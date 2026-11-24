namespace MetodosBusqueda.Experimentos;

public static class Primos
{
    private const int PrimerPrimo = 2;

    // Se usa un tamaño primo para la tabla porque reparte mejor las claves con la función de división
    public static int SiguienteMayorOIgual(int minimo)
    {
        int candidato = Math.Max(minimo, PrimerPrimo);

        while (!EsPrimo(candidato))
        {
            candidato++;
        }

        return candidato;
    }

    private static bool EsPrimo(int numero)
    {
        if (numero < PrimerPrimo)
        {
            return false;
        }

        if (numero % PrimerPrimo == 0)
        {
            return numero == PrimerPrimo;
        }

        for (int divisor = 3; (long)divisor * divisor <= numero; divisor += 2)
        {
            if (numero % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
