namespace MetodosBusqueda.Algoritmos;

// Lo que devuelve cada búsqueda: si encontró la clave, dónde, y cuánto trabajo costó
public readonly record struct ResultadoBusqueda(bool Encontrado, int Posicion, int Comparaciones, int Iteraciones)
{
    public const int SinPosicion = -1;
}
