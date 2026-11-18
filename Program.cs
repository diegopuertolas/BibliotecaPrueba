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
