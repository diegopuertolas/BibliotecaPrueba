namespace Biblioteca.Models;

public class Libros : Publicaciones
{
    public string Autor { get; set; }

    public Libros(string titulo, int year, string autor)
        : base(titulo, year)
    {
        Autor = autor;
    }
}