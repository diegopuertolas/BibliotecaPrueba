using Biblioteca.Models;

namespace Biblioteca.UI;

public static class AppMenu
{
    public static void DisplayMenu(List<Publicacion> lista)
    {
        var option = -1;

        do
        {
            MostrarMenu();
            option = ElegirOpcion();

            switch (option)
            {
                case 1:
                    Console.WriteLine();
                    MostrarPublicaciones(lista);
                    break;
                case 2:
                    Console.WriteLine();
                    BuscarPublicacionPorTitulo(lista);
                    break;
                case 3:
                    Console.WriteLine();
                     BuscarPublicacionesPosteriores(lista);
                    break;
                case 4:
                    Console.WriteLine();
                    FiltrarPorLibros(lista);
                    break;
                case 5:
                    Console.WriteLine();
                    EstadisticasPublicaciones(lista);
                    break;
                case 0:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Introduzca un número del 1 al 5");
                    break;
            }
        } while (option != 0);
    }

    public static void MostrarMenu()
    {
        Console.WriteLine("\n=== BIBLIOTECA ===");
        Console.WriteLine("1. Ver todas las publicaciones");
        Console.WriteLine("2. Buscar publicación");
        Console.WriteLine("3. Filtrar por año");
        Console.WriteLine("4. Mostrar libros");
        Console.WriteLine("5. Ver estadísticas");
        Console.WriteLine("0. Salir");
    }

    public static int ElegirOpcion()
    {
        Console.Write("Elija una opción: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var decision))
        {
            Console.WriteLine("\nOpción incorrecta");
            return -1;
        }

        return decision;
    }

    public static void MostrarPublicaciones(List<Publicacion> lista)
    {
        foreach (var publicacion in lista)
        {
            publicacion.ObtenerDescripcion();
        }
    }

    public static void BuscarPublicacionPorTitulo(List<Publicacion> lista)
    {   
        Console.Write("Introduzca el título de la publicación: ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("El formato del título no es el adecuado");
            return;
        }

        var found = false;

        foreach (var publicacion in lista)
        {
            if (publicacion.Titulo.Contains(input, StringComparison.OrdinalIgnoreCase) == true)
            {
                publicacion.ObtenerDescripcion();
                found = true;
            }
        }

        if (!found) Console.WriteLine($"No se ha encontrado ninguna publicación con el título: {input}");
    }

    public static void BuscarPublicacionesPosteriores(List<Publicacion> lista)
    {   
        Console.Write("Introduzca el año: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var decision))
        {
            Console.WriteLine("El formato del año no es el adecuado");
            return;
        }

        if (decision <= 0)
        {
            Console.WriteLine("\nLa publicación no puede pertener a un año inferior o igual a 0.");
            return;
        }

        var found = false;

        foreach (var publicacion in lista)
        {
            if (decision <= publicacion.Year)
            {
                publicacion.ObtenerDescripcion();
                found = true;
            }
        }

        if (!found) Console.WriteLine($"No se ha encontrado ninguna publicación posterior al año: {decision}");
    }

    public static void FiltrarPorLibros(List<Publicacion> lista)
    {
        var found = false;

        foreach (var publicacion in lista)
        {
            if (publicacion is Libro)
            {
                publicacion.ObtenerDescripcion();
                found = true;
            }
        }

        if (!found) Console.WriteLine($"No se ha encontrado ningun libro.");
    }

    public static void EstadisticasPublicaciones(List<Publicacion> lista)
    {
        int numLibros = 0;
        int numRevistas = 0;
        int numComis = 0;

        foreach (var publicacion in lista)
        {
            if (publicacion is Libro) numLibros++;
            else if (publicacion is Revista) numRevistas++;
            else numComis++;
        }

        Console.WriteLine("=== ESTADÍSTICAS ===");
        Console.WriteLine($"Total publicaciones: {lista.Count}");
        Console.WriteLine($"Comics: {numLibros}");
        Console.WriteLine($"Revistas: {numRevistas}");
        Console.WriteLine($"Cómics: {numComis}");
    }
}