namespace MetodosBusqueda.Experimentos;

// Generador SplitMix64. Se usa uno propio (en vez de System.Random) para que una misma semilla
// produzca exactamente los mismos datos en cualquier equipo y se pueda repetir el experimento.
public class GeneradorAleatorio
{
    private const ulong Incremento = 0x9E3779B97F4A7C15UL;
    private const ulong MultiplicadorA = 0xBF58476D1CE4E5B9UL;
    private const ulong MultiplicadorB = 0x94D049BB133111EBUL;
    private const int DesplazamientoA = 30;
    private const int DesplazamientoB = 27;
    private const int DesplazamientoC = 31;

    private ulong estado;

    public GeneradorAleatorio(ulong semilla)
    {
        estado = semilla;
    }

    public ulong SiguienteValor()
    {
        estado += Incremento;
        ulong z = estado;
        z = (z ^ (z >> DesplazamientoA)) * MultiplicadorA;
        z = (z ^ (z >> DesplazamientoB)) * MultiplicadorB;
        return z ^ (z >> DesplazamientoC);
    }

    // Entero en el intervalo [0, limiteExclusivo)
    public int SiguienteEntero(int limiteExclusivo)
    {
        return (int)(SiguienteValor() % (ulong)limiteExclusivo);
    }
}
