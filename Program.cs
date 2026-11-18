using Biblioteca.Models;

var quijote = new Libro("Don Quijote de la Mancha", 1563, "Miguel de Cervantes");
var extranjero = new Libro("El Extranjero", 1956, "Albert Camus");
var hola = new Revista("HOLA", 2011, 1002);
var marca = new Revista("Marca", 2002, 12321);
var spiderman = new Comic("Spideman", 1999, "Miles Morales");

var publicaciones = new List<Publicacion>
{
    quijote,
    extranjero,
    hola,
    marca,
    spiderman
};


foreach (var publicacion in publicaciones)
{
    publicacion.ObtenerDescripcion();
}

BuscarPublicacionPorTitulo(publicaciones, "quijote");
BuscarPublicacionesPosteriores(publicaciones, 1500);

static void BuscarPublicacionPorTitulo(List<Publicacion> lista, string titulo)
{
    if (string.IsNullOrWhiteSpace(titulo))
    {
        Console.WriteLine("El título no tiene el formato adecuaco");
        return;
    }

    var found = false;
    
    foreach(var publicacion in lista)
    {
        if (publicacion.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase) == true)
        {
            publicacion.ObtenerDescripcion();
            found = true;
        }
    }

    if (!found) Console.WriteLine($"No se ha encontrado ninguna publicación con el título: {titulo}");
}

static void BuscarPublicacionesPosteriores(List<Publicacion> lista, int year)
{
    if (year <= 0)
    {
        Console.WriteLine("\nLa publicación no puede pertener a un año inferior o igual a 0.");
        return;
    }

    var found = false;

    foreach(var publicacion in lista)
    {
        if (year <= publicacion.Year)
        {
            publicacion.ObtenerDescripcion();
            found = true;
        }
    }

    if (!found) Console.WriteLine($"No se ha encontrado ninguna publicación posterior al año: {year}");
}