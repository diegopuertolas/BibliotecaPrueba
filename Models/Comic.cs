namespace Biblioteca.Models;

public class Comic : Publicacion
{
    public string Dibujante { get; set; }

    public Comic(string titulo, int year, string dibujante)
        : base(titulo, year)
    {
        Dibujante = dibujante;
    }
}