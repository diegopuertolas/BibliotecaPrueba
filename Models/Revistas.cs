namespace Biblioteca.Models;

public class Revistas : Publicaciones
{
    public int NumeroEdicion { get; set; }

    public Revistas(string titulo, int year, int numeroEdicion)
        : base(titulo, year)
    {
        NumeroEdicion = numeroEdicion;
    }
}