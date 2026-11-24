using System.Globalization;
using System.Text;
using MetodosBusqueda.Algoritmos;
using MetodosBusqueda.Experimentos;

namespace MetodosBusqueda;

public partial class Form1 : Form
{
    private const long LimiteOperacionesSinConfirmar = 2_000_000_000L;
    private const char SeparadorCsv = ',';

    // guarda la última corrida para poder hacer búsquedas individuales sobre sus datos
    private ResultadoExperimento? ultimoResultado;

    public Form1()
    {
        InitializeComponent();
        lblRangoClave.Text = Textos.RangoSinDatos;
        lblEstado.Text = Textos.EstadoListo;
    }

    private void chkSemillaAleatoria_CheckedChanged(object? sender, EventArgs e)
    {
        nudSemilla.Enabled = !chkSemillaAleatoria.Checked;
    }

    private async void btnEjecutar_Click(object? sender, EventArgs e)
    {
        ParametrosExperimento parametros = LeerParametros();

        // con N y consultas muy grandes la secuencial puede tardar bastante, mejor avisar
        long peorCaso = (long)parametros.CantidadDatos * parametros.CantidadConsultas;
        if (peorCaso > LimiteOperacionesSinConfirmar)
        {
            DialogResult respuesta = MessageBox.Show(
                string.Format(Textos.ConfirmarExperimentoGrande, peorCaso),
                Textos.TituloConfirmacion,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }
        }

        AlternarEjecucion(true);

        try
        {
            // el experimento corre en otro hilo para que la ventana no se congele
            ResultadoExperimento resultado = await Task.Run(() => Experimento.Ejecutar(parametros));
            ultimoResultado = resultado;
            MostrarResultado(resultado);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, Textos.TituloError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblEstado.Text = Textos.EstadoListo;
        }
        finally
        {
            AlternarEjecucion(false);
        }
    }

    private void btnLimpiar_Click(object? sender, EventArgs e)
    {
        dgvResultados.Rows.Clear();
        txtDetalle.Clear();
        txtConclusiones.Clear();
        txtResultadoClave.Clear();
        ultimoResultado = null;
        lblRangoClave.Text = Textos.RangoSinDatos;
        lblEstado.Text = Textos.EstadoLimpio;
    }

    private void btnExportar_Click(object? sender, EventArgs e)
    {
        if (dgvResultados.Rows.Count == 0)
        {
            MessageBox.Show(Textos.AvisoSinResultados, Textos.TituloAviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        sfdCsv.Filter = Textos.FiltroCsv;
        sfdCsv.FileName = Textos.NombreArchivoCsv;

        if (sfdCsv.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var contenido = new StringBuilder();
        IEnumerable<string> encabezados = dgvResultados.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText);
        contenido.AppendLine(string.Join(SeparadorCsv, encabezados));

        foreach (DataGridViewRow fila in dgvResultados.Rows)
        {
            // se usa la cultura invariante para que los decimales siempre lleven punto
            IEnumerable<string?> celdas = fila.Cells.Cast<DataGridViewCell>()
                .Select(c => Convert.ToString(c.Value, CultureInfo.InvariantCulture));
            contenido.AppendLine(string.Join(SeparadorCsv, celdas));
        }

        File.WriteAllText(sfdCsv.FileName, contenido.ToString(), Encoding.UTF8);
        lblEstado.Text = string.Format(Textos.EstadoExportado, sfdCsv.FileName);
    }

    private void btnClaveExistente_Click(object? sender, EventArgs e)
    {
        if (ultimoResultado is null)
        {
            MostrarAvisoSinExperimento();
            return;
        }

        int[] datos = ultimoResultado.Datos.SinOrdenar;
        nudClave.Value = datos[Random.Shared.Next(datos.Length)];
    }

    private void btnBuscarClave_Click(object? sender, EventArgs e)
    {
        if (ultimoResultado is null)
        {
            MostrarAvisoSinExperimento();
            return;
        }

        int clave = (int)nudClave.Value;
        ConjuntoDatos datos = ultimoResultado.Datos;
        var salida = new StringBuilder();

        salida.AppendLine(string.Format(Textos.BusquedaClave, clave));
        salida.AppendLine();

        AgregarResultado(salida, NombresTecnicas.Secuencial,
            BusquedaSecuencial.Buscar(datos.SinOrdenar, clave), Textos.UbicacionArreglo);

        AgregarResultado(salida, NombresTecnicas.Binaria,
            BusquedaBinaria.Buscar(datos.Ordenado, clave), Textos.UbicacionOrdenado);

        AgregarResultado(salida, NombresTecnicas.Hash,
            datos.Tabla.Buscar(clave), Textos.UbicacionCubo);

        salida.AppendLine(string.Format(Textos.LineaIndiceHash, datos.Tabla.CalcularIndice(clave)));

        txtResultadoClave.Text = salida.ToString();
    }

    private ParametrosExperimento LeerParametros()
    {
        // si piden semilla aleatoria se toma el reloj; si no, la que escribieron
        ulong semilla = chkSemillaAleatoria.Checked
            ? (ulong)DateTime.Now.Ticks
            : (ulong)nudSemilla.Value;

        return new ParametrosExperimento(
            (int)nudCantidadDatos.Value,
            (int)nudConsultas.Value,
            (int)nudPorcentajeExito.Value,
            (int)nudFactorRango.Value,
            (double)nudFactorCarga.Value,
            semilla);
    }

    private void AlternarEjecucion(bool ejecutando)
    {
        gbParametros.Enabled = !ejecutando;
        barraProgreso.Visible = ejecutando;

        if (ejecutando)
        {
            lblEstado.Text = Textos.EstadoEjecutando;
        }
    }

    private void MostrarResultado(ResultadoExperimento resultado)
    {
        foreach (EstadisticasTecnica t in resultado.Tecnicas)
        {
            dgvResultados.Rows.Add(
                resultado.Parametros.CantidadDatos,
                t.Nombre,
                t.Consultas,
                t.Encontradas,
                t.PromedioComparacionesExito,
                t.PromedioComparacionesFallo,
                t.PromedioComparaciones,
                t.MaxComparaciones,
                t.PromedioIteraciones,
                t.MaxIteraciones,
                t.MsPreparacion,
                t.MsBusqueda);
        }

        txtDetalle.Text = ConstruirDetalle(resultado);
        txtConclusiones.Text = ConstruirConclusiones(resultado);
        lblRangoClave.Text = string.Format(Textos.RangoClaves, resultado.Datos.LimiteSuperior);
        nudClave.Value = 0;
        txtResultadoClave.Clear();

        lblEstado.Text = string.Format(Textos.EstadoTerminado, resultado.MsTotales, resultado.Parametros.Semilla);
    }

    private static string ConstruirDetalle(ResultadoExperimento resultado)
    {
        ParametrosExperimento p = resultado.Parametros;
        ConjuntoDatos datos = resultado.Datos;
        TablaHash tabla = datos.Tabla;

        var texto = new StringBuilder();
        texto.AppendLine(string.Format(Textos.DetalleSemilla, p.Semilla));
        texto.AppendLine(string.Format(Textos.DetalleDatos, p.CantidadDatos));
        texto.AppendLine(string.Format(Textos.DetalleRango, datos.LimiteSuperior));
        texto.AppendLine(string.Format(Textos.DetalleConsultas,
            p.CantidadConsultas, resultado.ConsultasExitosas, p.CantidadConsultas - resultado.ConsultasExitosas));
        texto.AppendLine();
        texto.AppendLine(string.Format(Textos.DetalleTabla, tabla.Capacidad, tabla.FactorCarga));
        texto.AppendLine(string.Format(Textos.DetalleColisiones, tabla.Colisiones));
        texto.AppendLine(string.Format(Textos.DetalleCubos, tabla.CubosOcupados, tabla.Capacidad - tabla.CubosOcupados));
        texto.AppendLine(string.Format(Textos.DetalleCadena, tabla.CadenaMasLarga));
        texto.AppendLine();
        texto.AppendLine(string.Format(Textos.DetallePreparacion, datos.MsOrdenar, datos.MsConstruirHash));
        return texto.ToString();
    }

    private static string ConstruirConclusiones(ResultadoExperimento resultado)
    {
        int n = resultado.Parametros.CantidadDatos;
        TablaHash tabla = resultado.Datos.Tabla;

        EstadisticasTecnica secuencial = resultado.ObtenerTecnica(NombresTecnicas.Secuencial);
        EstadisticasTecnica binaria = resultado.ObtenerTecnica(NombresTecnicas.Binaria);
        EstadisticasTecnica hash = resultado.ObtenerTecnica(NombresTecnicas.Hash);

        List<EstadisticasTecnica> porCosto = resultado.Tecnicas.OrderBy(t => t.PromedioComparaciones).ToList();
        EstadisticasTecnica masBarata = porCosto.First();
        EstadisticasTecnica masCara = porCosto.Last();

        // valores que predice la teoría, para ponerlos junto a lo medido
        double secuencialTeorico = (n + 1) / 2.0;
        int binariaTeorica = (int)Math.Floor(Math.Log2(n)) + 1;
        double hashExitoTeorico = 1 + tabla.FactorCarga / 2;

        var texto = new StringBuilder();
        texto.AppendLine(string.Format(Textos.ConclusionComparaciones,
            masBarata.Nombre, masBarata.PromedioComparaciones, masCara.Nombre, masCara.PromedioComparaciones));
        texto.AppendLine(string.Format(Textos.ConclusionSecuencial,
            secuencial.PromedioComparacionesExito, secuencialTeorico, secuencial.PromedioComparacionesFallo, n));
        texto.AppendLine(string.Format(Textos.ConclusionBinaria,
            binaria.MaxIteraciones, binariaTeorica, resultado.Datos.MsOrdenar));
        texto.AppendLine(string.Format(Textos.ConclusionHash,
            hash.PromedioComparacionesExito, hashExitoTeorico, hash.PromedioComparacionesFallo,
            tabla.FactorCarga, tabla.Colisiones, tabla.CadenaMasLarga));
        texto.AppendLine(Textos.ConclusionPreparacion);
        return texto.ToString();
    }

    private static void AgregarResultado(StringBuilder salida, string tecnica, ResultadoBusqueda r, string formatoUbicacion)
    {
        string descripcion = r.Encontrado
            ? string.Format(Textos.Encontrada, string.Format(formatoUbicacion, r.Posicion))
            : Textos.NoEncontrada;

        salida.AppendLine(string.Format(Textos.LineaTecnica, tecnica));
        salida.AppendLine(string.Format(Textos.LineaResultado, descripcion));
        salida.AppendLine(string.Format(Textos.LineaCostos, r.Comparaciones, r.Iteraciones));
        salida.AppendLine();
    }

    private static void MostrarAvisoSinExperimento()
    {
        MessageBox.Show(Textos.AvisoSinExperimento, Textos.TituloAviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
