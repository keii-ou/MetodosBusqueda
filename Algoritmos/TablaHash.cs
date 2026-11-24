namespace MetodosBusqueda.Algoritmos;

// Tabla hash con encadenamiento: cada cubo guarda una lista con las claves que caen en él
public class TablaHash
{
    private readonly List<int>?[] cubos;

    public TablaHash(int capacidad)
    {
        if (capacidad < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(capacidad));
        }

        cubos = new List<int>?[capacidad];
    }

    public int Capacidad => cubos.Length;
    public int Elementos { get; private set; }
    public int Colisiones { get; private set; }
    public int CubosOcupados { get; private set; }
    public int CadenaMasLarga { get; private set; }
    public double FactorCarga => (double)Elementos / Capacidad;

    // Función de dispersión por división: clave mod capacidad (con ajuste por si la clave fuera negativa)
    public int CalcularIndice(int clave)
    {
        long residuo = clave % (long)Capacidad;
        return (int)((residuo + Capacidad) % Capacidad);
    }

    public void Insertar(int clave)
    {
        int indice = CalcularIndice(clave);
        List<int>? cubo = cubos[indice];

        if (cubo is null)
        {
            cubo = new List<int>();
            cubos[indice] = cubo;
            CubosOcupados++;
        }
        else
        {
            // el cubo ya tenía al menos una clave, entonces hubo colisión
            Colisiones++;
        }

        cubo.Add(clave);
        Elementos++;

        if (cubo.Count > CadenaMasLarga)
        {
            CadenaMasLarga = cubo.Count;
        }
    }

    public ResultadoBusqueda Buscar(int clave)
    {
        int indice = CalcularIndice(clave);
        List<int>? cubo = cubos[indice];
        int comparaciones = 0;
        int iteraciones = 0;

        if (cubo is not null)
        {
            for (int i = 0; i < cubo.Count; i++)
            {
                iteraciones++;
                comparaciones++;

                if (cubo[i] == clave)
                {
                    return new ResultadoBusqueda(true, indice, comparaciones, iteraciones);
                }
            }
        }

        return new ResultadoBusqueda(false, ResultadoBusqueda.SinPosicion, comparaciones, iteraciones);
    }
}
