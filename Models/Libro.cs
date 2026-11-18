namespace Biblioteca.Models;

public class Libro : Publicacion
{
    public string Autor { get; set; }

    public Libro(string titulo, int year, string autor)
        : base(titulo, year)
    {
        Autor = autor;
    }

    public override void ObtenerDescripcion()
    {
        Console.WriteLine($"{Titulo} · {Year} · {Autor}");
    }
}