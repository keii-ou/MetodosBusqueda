namespace MetodosBusqueda.Algoritmos;

public static class BusquedaSecuencial
{
    // Recorre el arreglo de izquierda a derecha; no necesita que los datos estén ordenados
    public static ResultadoBusqueda Buscar(int[] datos, int clave)
    {
        int comparaciones = 0;
        int iteraciones = 0;

        for (int i = 0; i < datos.Length; i++)
        {
            iteraciones++;
            comparaciones++;

            if (datos[i] == clave)
            {
                return new ResultadoBusqueda(true, i, comparaciones, iteraciones);
            }
        }

        return new ResultadoBusqueda(false, ResultadoBusqueda.SinPosicion, comparaciones, iteraciones);
    }
}
