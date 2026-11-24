using System.Diagnostics;
using MetodosBusqueda.Algoritmos;

namespace MetodosBusqueda.Experimentos;

public static class Experimento
{
    private const double CienPorCiento = 100.0;

    public static ResultadoExperimento Ejecutar(ParametrosExperimento parametros)
    {
        var reloj = Stopwatch.StartNew();
        var azar = new GeneradorAleatorio(parametros.Semilla);

        ConjuntoDatos datos = GenerarDatos(parametros, azar);
        int exitosas = CalcularConsultasExitosas(parametros);
        int[] consultas = GenerarConsultas(parametros, datos, exitosas, azar);

        // las tres técnicas reciben exactamente las mismas consultas para que la comparación sea justa
        var tecnicas = new List<EstadisticasTecnica>
        {
            Medir(NombresTecnicas.Secuencial, consultas, clave => BusquedaSecuencial.Buscar(datos.SinOrdenar, clave), 0),
            Medir(NombresTecnicas.Binaria, consultas, clave => BusquedaBinaria.Buscar(datos.Ordenado, clave), datos.MsOrdenar),
            Medir(NombresTecnicas.Hash, consultas, datos.Tabla.Buscar, datos.MsConstruirHash)
        };

        reloj.Stop();
        return new ResultadoExperimento(parametros, datos, exitosas, tecnicas, reloj.Elapsed.TotalMilliseconds);
    }

    private static ConjuntoDatos GenerarDatos(ParametrosExperimento parametros, GeneradorAleatorio azar)
    {
        int limite = checked(parametros.CantidadDatos * parametros.FactorRango);
        var datos = new int[parametros.CantidadDatos];
        var usados = new HashSet<int>(parametros.CantidadDatos);
        int cantidad = 0;

        // se descartan los repetidos para que todas las claves sean únicas
        while (cantidad < datos.Length)
        {
            int valor = azar.SiguienteEntero(limite);
            if (usados.Add(valor))
            {
                datos[cantidad] = valor;
                cantidad++;
            }
        }

        // costo de preparar la búsqueda binaria: copiar y ordenar
        var relojOrdenar = Stopwatch.StartNew();
        int[] ordenado = (int[])datos.Clone();
        Array.Sort(ordenado);
        relojOrdenar.Stop();

        // costo de preparar la tabla hash: calcular su tamaño e insertar todas las claves
        var relojHash = Stopwatch.StartNew();
        int capacidad = Primos.SiguienteMayorOIgual((int)Math.Ceiling(parametros.CantidadDatos / parametros.FactorCarga));
        var tabla = new TablaHash(capacidad);
        foreach (int clave in datos)
        {
            tabla.Insertar(clave);
        }
        relojHash.Stop();

        return new ConjuntoDatos
        {
            SinOrdenar = datos,
            Ordenado = ordenado,
            Tabla = tabla,
            LimiteSuperior = limite,
            MsOrdenar = relojOrdenar.Elapsed.TotalMilliseconds,
            MsConstruirHash = relojHash.Elapsed.TotalMilliseconds
        };
    }

    public static int CalcularConsultasExitosas(ParametrosExperimento parametros)
    {
        double exactas = parametros.CantidadConsultas * parametros.PorcentajeExito / CienPorCiento;
        return (int)Math.Round(exactas, MidpointRounding.AwayFromZero);
    }

    private static int[] GenerarConsultas(ParametrosExperimento parametros, ConjuntoDatos datos, int exitosas, GeneradorAleatorio azar)
    {
        var consultas = new int[parametros.CantidadConsultas];

        // las exitosas son claves tomadas al azar del propio conjunto
        for (int i = 0; i < exitosas; i++)
        {
            consultas[i] = datos.SinOrdenar[azar.SiguienteEntero(datos.SinOrdenar.Length)];
        }

        // las fallidas se toman de un rango que queda fuera de los valores generados, así nunca existen
        for (int i = exitosas; i < consultas.Length; i++)
        {
            consultas[i] = datos.LimiteSuperior + azar.SiguienteEntero(datos.LimiteSuperior);
        }

        return consultas;
    }

    private static EstadisticasTecnica Medir(string nombre, int[] consultas, Func<int, ResultadoBusqueda> buscar, double msPreparacion)
    {
        var resultados = new ResultadoBusqueda[consultas.Length];

        // el cronómetro solo rodea las búsquedas; el resumen estadístico se hace después
        var reloj = Stopwatch.StartNew();
        for (int i = 0; i < consultas.Length; i++)
        {
            resultados[i] = buscar(consultas[i]);
        }
        reloj.Stop();

        return Resumir(nombre, resultados, msPreparacion, reloj.Elapsed.TotalMilliseconds);
    }

    private static EstadisticasTecnica Resumir(string nombre, ResultadoBusqueda[] resultados, double msPreparacion, double msBusqueda)
    {
        long sumaExito = 0;
        long sumaFallo = 0;
        long sumaIteraciones = 0;
        int encontradas = 0;
        int maxComparaciones = 0;
        int maxIteraciones = 0;

        foreach (ResultadoBusqueda r in resultados)
        {
            sumaIteraciones += r.Iteraciones;
            maxComparaciones = Math.Max(maxComparaciones, r.Comparaciones);
            maxIteraciones = Math.Max(maxIteraciones, r.Iteraciones);

            if (r.Encontrado)
            {
                encontradas++;
                sumaExito += r.Comparaciones;
            }
            else
            {
                sumaFallo += r.Comparaciones;
            }
        }

        int fallidas = resultados.Length - encontradas;

        return new EstadisticasTecnica
        {
            Nombre = nombre,
            Consultas = resultados.Length,
            Encontradas = encontradas,
            PromedioComparacionesExito = Promedio(sumaExito, encontradas),
            PromedioComparacionesFallo = Promedio(sumaFallo, fallidas),
            PromedioComparaciones = Promedio(sumaExito + sumaFallo, resultados.Length),
            MaxComparaciones = maxComparaciones,
            PromedioIteraciones = Promedio(sumaIteraciones, resultados.Length),
            MaxIteraciones = maxIteraciones,
            MsPreparacion = msPreparacion,
            MsBusqueda = msBusqueda
        };
    }

    private static double Promedio(long suma, int cantidad)
    {
        return cantidad == 0 ? 0 : (double)suma / cantidad;
    }
}
