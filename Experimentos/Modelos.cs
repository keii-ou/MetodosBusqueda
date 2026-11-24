using MetodosBusqueda.Algoritmos;

namespace MetodosBusqueda.Experimentos;

public static class NombresTecnicas
{
    public const string Secuencial = "Secuencial";
    public const string Binaria = "Binaria";
    public const string Hash = "Hash (encadenamiento)";
}

public record ParametrosExperimento(
    int CantidadDatos,
    int CantidadConsultas,
    int PorcentajeExito,
    int FactorRango,
    double FactorCarga,
    ulong Semilla);

public class ConjuntoDatos
{
    public required int[] SinOrdenar { get; init; }
    public required int[] Ordenado { get; init; }
    public required TablaHash Tabla { get; init; }

    // Los valores generados caen en [0, LimiteSuperior)
    public required int LimiteSuperior { get; init; }
    public required double MsOrdenar { get; init; }
    public required double MsConstruirHash { get; init; }
}

public class EstadisticasTecnica
{
    public required string Nombre { get; init; }
    public required int Consultas { get; init; }
    public required int Encontradas { get; init; }
    public required double PromedioComparacionesExito { get; init; }
    public required double PromedioComparacionesFallo { get; init; }
    public required double PromedioComparaciones { get; init; }
    public required int MaxComparaciones { get; init; }
    public required double PromedioIteraciones { get; init; }
    public required int MaxIteraciones { get; init; }
    public required double MsPreparacion { get; init; }
    public required double MsBusqueda { get; init; }
}

public record ResultadoExperimento(
    ParametrosExperimento Parametros,
    ConjuntoDatos Datos,
    int ConsultasExitosas,
    IReadOnlyList<EstadisticasTecnica> Tecnicas,
    double MsTotales)
{
    public EstadisticasTecnica ObtenerTecnica(string nombre)
    {
        return Tecnicas.Single(t => t.Nombre == nombre);
    }
}
