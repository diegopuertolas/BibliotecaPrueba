namespace Biblioteca.Utils;

public static class ConsoleUtils
{
    public static string LeerString(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) return input.Trim();
            Console.WriteLine("Error: El texto no puede estar vacío.");
        }
    }
    
    public static int LeerInt(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out var resultado) && resultado >= 0) return resultado;
            Console.WriteLine("Error: Debe introducir un número entero válido (mayor o igual a 0).");
        }
    }
}