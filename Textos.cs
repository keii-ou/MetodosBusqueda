namespace MetodosBusqueda;

// Mensajes y plantillas de texto que usa la ventana, concentrados aquí para no regarlos por el código
internal static class Textos
{
    // títulos y avisos
    public const string TituloError = "Error en el experimento";
    public const string TituloAviso = "Aviso";
    public const string TituloConfirmacion = "Confirmar ejecución";
    public const string AvisoSinExperimento = "Primero ejecute el experimento para generar el conjunto de datos.";
    public const string AvisoSinResultados = "No hay resultados para exportar.";
    public const string ConfirmarExperimentoGrande =
        "En el peor caso la búsqueda secuencial haría unas {0:N0} comparaciones y la ejecución puede tardar. ¿Desea continuar?";

    // barra de estado
    public const string EstadoListo = "Listo.";
    public const string EstadoEjecutando = "Ejecutando experimento...";
    public const string EstadoTerminado = "Experimento terminado en {0:N0} ms (semilla {1}).";
    public const string EstadoExportado = "Resultados exportados a {0}";
    public const string EstadoLimpio = "Resultados borrados.";

    // exportación
    public const string FiltroCsv = "Archivo CSV (*.csv)|*.csv";
    public const string NombreArchivoCsv = "resultados_busquedas";

    // pestaña de detalle
    public const string DetalleSemilla = "Semilla utilizada: {0}";
    public const string DetalleDatos = "Cantidad de datos (N): {0:N0}";
    public const string DetalleRango = "Valores generados en el rango [0, {0:N0})";
    public const string DetalleConsultas = "Consultas por técnica: {0:N0} ({1:N0} con clave existente y {2:N0} con clave ausente)";
    public const string DetalleTabla = "Tabla hash: {0:N0} cubos (tamaño primo), factor de carga real {1:F3}";
    public const string DetalleColisiones = "Colisiones al insertar: {0:N0}";
    public const string DetalleCubos = "Cubos ocupados: {0:N0} | cubos vacíos: {1:N0}";
    public const string DetalleCadena = "Cadena más larga en un cubo: {0}";
    public const string DetallePreparacion = "Preparación: ordenar el arreglo {0:F3} ms | construir la tabla {1:F3} ms";

    // conclusiones generadas con los datos de la corrida
    public const string ConclusionComparaciones =
        "• Menos comparaciones en promedio: {0} ({1:F2}). Más comparaciones: {2} ({3:F2}).";
    public const string ConclusionSecuencial =
        "• Secuencial: {0:F1} comparaciones al encontrar (teoría (N+1)/2 = {1:F1}) y {2:F1} al no encontrar, porque recorre los {3:N0} elementos.";
    public const string ConclusionBinaria =
        "• Binaria: como máximo {0} iteraciones; el límite teórico es floor(log2 N) + 1 = {1}. Exige ordenar antes ({2:F3} ms).";
    public const string ConclusionHash =
        "• Hash: {0:F2} comparaciones al encontrar (teoría 1 + α/2 = {1:F2}) y {2:F2} al no encontrar (teoría α = {3:F2}); {4:N0} colisiones y cadena máxima de {5}.";
    public const string ConclusionPreparacion =
        "• Costo previo: la secuencial no prepara nada, la binaria ordena (O(n log n)) y la hash construye la tabla (O(n)).";

    // búsqueda individual
    public const string RangoSinDatos = "Aún no hay un conjunto de datos generado.";
    public const string RangoClaves = "Las claves del conjunto están en el rango [0, {0:N0}).";
    public const string BusquedaClave = "Búsqueda de la clave {0}";
    public const string LineaTecnica = "--- {0} ---";
    public const string LineaResultado = "  Resultado: {0}";
    public const string LineaCostos = "  Comparaciones: {0} | Iteraciones: {1}";
    public const string LineaIndiceHash = "  Cubo calculado por la función hash: {0}";
    public const string Encontrada = "encontrada, {0}";
    public const string NoEncontrada = "no encontrada";
    public const string UbicacionArreglo = "posición {0} del arreglo original";
    public const string UbicacionOrdenado = "posición {0} del arreglo ordenado";
    public const string UbicacionCubo = "dentro del cubo {0}";
}
