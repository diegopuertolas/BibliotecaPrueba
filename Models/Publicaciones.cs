namespace Biblioteca.Models;

public abstract class Publicaciones
{
    public string Titulo { get; set; }
    public int Year { get; set; }

    public Publicaciones(string titulo, int year)
    {
        Titulo = titulo;
        Year = year;
    }
}