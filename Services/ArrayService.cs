    public static class ArrayService
    {
        // 11) Array -> Array
        public static int[] InvertirArray(int[] arr)
        {
            int[] inv = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                inv[i] = arr[arr.Length - 1 - i];
            return inv;
        }

        // 12) Genérica
        public static T ElegirPrimero<T>(T a, T b) => a;
    }