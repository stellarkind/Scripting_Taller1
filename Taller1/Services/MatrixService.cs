using System;

namespace Taller1.Services
{
    public static class MatrixService
    {
        public static int[,] SumarMatrices(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] C = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    C[i, j] = A[i, j] + B[i, j];

            return C;
        }

        public static int SumarMatriz(int[,] m)
        {
            int suma = 0;
            foreach (int v in m) suma += v;
            return suma;
        }

        // Imprime: | A | + | B | = | C |
        public static void ImprimirOperacion(int[,] A, int[,] B, int[,] C)
        {
            int n = A.GetLength(0);
            int w = CalcularAnchoCelda(A, B, C);

            for (int i = 0; i < n; i++)
            {
                ImprimirFila(A, i, w);
                Console.Write(i == n / 2 ? " + " : "   ");
                ImprimirFila(B, i, w);
                Console.Write(i == n / 2 ? " = " : "   ");
                ImprimirFila(C, i, w);
                Console.WriteLine();
            }
        }

        private static void ImprimirFila(int[,] M, int fila, int w)
        {
            int n = M.GetLength(1);
            Console.Write("|");
            for (int j = 0; j < n; j++)
                Console.Write(M[fila, j].ToString().PadLeft(w));
            Console.Write(" |");
        }

        private static int CalcularAnchoCelda(int[,] A, int[,] B, int[,] C)
        {
            int maxLen = 1;

            void Revisar(int[,] M)
            {
                foreach (int v in M)
                    maxLen = Math.Max(maxLen, v.ToString().Length);
            }

            Revisar(A); Revisar(B); Revisar(C);
            return maxLen + 1;
        }
    }
}
