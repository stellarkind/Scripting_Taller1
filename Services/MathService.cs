using System;
namespace Taller1.Services
{
    public static class MathService
    {
        // 1) Sin parámetros, sin retorno
        public static void Saludar() => Console.WriteLine("Hola 👋");

        // 2) Con parámetros, sin retorno
        public static void ImprimirMensaje(string mensaje) => Console.WriteLine(mensaje);

        // 3) Sin parámetros, con retorno
        public static int ObtenerNumeroFavorito() => 7;

        // 4) Con parámetros, con retorno
        public static int Sumar(int a, int b) => a + b;

        // 5) Parámetro opcional, con retorno
        public static double Potencia(double baseNum, int exp = 2)
        {
            double r = 1;
            for (int i = 0; i < exp; i++) r *= baseNum;
            return r;
        }

        // 6) params
        public static int SumarMuchos(params int[] numeros)
        {
            int s = 0;
            foreach (var n in numeros) s += n;
            return s;
        }

        // 7) out
        public static bool TryParseEntero(string texto, out int valor)
            => int.TryParse(texto, out valor);

        // 8) ref
        public static void Incrementar(ref int x) => x++;

        // 9) Nullable + validación
        public static double? DividirSeguro(double a, double b)
            => (b == 0) ? null : a / b;

        // 10) Retorno múltiple (tupla)
        public static (int min, int max) MinMax(int[] arr)
        {
            int min = arr[0], max = arr[0];
            foreach (var v in arr)
            {
                if (v < min) min = v;
                if (v > max) max = v;
            }
            return (min, max);
        }
    }
}