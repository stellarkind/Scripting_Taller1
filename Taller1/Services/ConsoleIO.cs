using System;

namespace Taller1.Services
{
    public static class ConsoleIO
    {
        public static int LeerEntero(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out int n))
                    return n;

                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }

        public static double LeerDouble(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out double n))
                    return n;

                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }

        public static string LeerNoVacio(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string? s = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(s))
                    return s.Trim();

                Console.WriteLine("Entrada vacía. Intente de nuevo.");
            }
        }
    }
}
