namespace Biblioteca.Models;

public class Comics : Publicaciones
{
    public string Dibujante { get; set; }

    public Comics(string titulo, int year, string dibujante)
        : base(titulo, year)
    {
        Dibujante = dibujante;
    }
}