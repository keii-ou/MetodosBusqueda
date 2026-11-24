namespace MetodosBusqueda.Algoritmos;

public static class BusquedaBinaria
{
    // El arreglo tiene que venir ordenado de menor a mayor, si no el resultado no es confiable
    public static ResultadoBusqueda Buscar(int[] ordenado, int clave)
    {
        int comparaciones = 0;
        int iteraciones = 0;
        int inicio = 0;
        int fin = ordenado.Length - 1;

        while (inicio <= fin)
        {
            iteraciones++;

            // así se evita el desbordamiento que podría dar (inicio + fin) con arreglos enormes
            int medio = inicio + (fin - inicio) / 2;

            comparaciones++;
            if (ordenado[medio] == clave)
            {
                return new ResultadoBusqueda(true, medio, comparaciones, iteraciones);
            }

            comparaciones++;
            if (ordenado[medio] < clave)
            {
                inicio = medio + 1;
            }
            else
            {
                fin = medio - 1;
            }
        }

        return new ResultadoBusqueda(false, ResultadoBusqueda.SinPosicion, comparaciones, iteraciones);
    }
}
