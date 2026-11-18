namespace Biblioteca.Models;

public class Revista : Publicacion
{
    public int NumeroEdicion { get; set; }

    public Revista(string titulo, int year, int numeroEdicion)
        : base(titulo, year)
    {
        NumeroEdicion = numeroEdicion;
    }
}