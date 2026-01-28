namespace Taller1.Services
{
    public static class ArrayService
    {

        public static int[] InvertirArray(int[] arr)
        {
            int[] inv = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                inv[i] = arr[arr.Length - 1 - i];

            return inv;
        }

        // Firma extra (genérica) si tu profe pide más variedad:
        public static T ElegirPrimero<T>(T a, T b) => a;
    }
}
