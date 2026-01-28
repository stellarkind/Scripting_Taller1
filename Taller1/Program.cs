using System;
using System.Threading.Tasks;
using Taller1.Models;
using Taller1.Services;

namespace Taller1
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("=== Taller 1 – Scripting ===\n");

            MathService.Saludar();
            MathService.ImprimirMensaje("Probando servicios...");

            Persona p = new Persona("Stella", 20);
            Console.WriteLine("Persona => " + p);

            int[] inv = ArrayService.InvertirArray(new[] { 1, 2, 3, 4 });
            Console.WriteLine("InvertirArray => [" + string.Join(", ", inv) + "]");

            int[,] A = { { 3, 4 }, { 2, 1 } };
            int[,] B = { { 5, -1 }, { 0, 3 } };
            int[,] C = MatrixService.SumarMatrices(A, B);

            Console.WriteLine("\nA + B = C:");
            MatrixService.ImprimirOperacion(A, B, C);

            Console.WriteLine("\nEsPalindromo(\"Anita lava la tina\") => " +
                              StringService.EsPalindromo("Anita lava la tina"));

            string r = await AsyncService.SimularDescargaAsync("recurso.json");
            Console.WriteLine("\n" + r);
        }
    }
}
