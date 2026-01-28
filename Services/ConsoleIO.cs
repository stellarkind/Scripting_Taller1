using System;    
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
    }
