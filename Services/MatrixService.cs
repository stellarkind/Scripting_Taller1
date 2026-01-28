using System;
namespace Taller1.Services
{
    public static class MatrixService
    {
        // 13) Leer matriz cuadrada (retorna matriz)
        public static int[,] LeerMatrizCuadrada(int n, string nombre, Func<string, int> leerEntero)
        {
            int[,] m = new int[n, n];
            Console.WriteLine($"\nIngrese los valores de la matriz {nombre} ({n}x{n}):");

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    m[i, j] = leerEntero($"{nombre}[{i},{j}]: ");

            return m;
        }

        // 14) Sumar matrices (retorna matriz)
        public static int[,] SumarMatrices(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] C = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    C[i, j] = A[i, j] + B[i, j];

            return C;
        }

        // 15) Imprimir matriz simple (void)
        public static void ImprimirMatriz(int[,] m)
        {
            int f = m.GetLength(0);
            int c = m.GetLength(1);

            for (int i = 0; i < f; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < c; j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine("|");
            }
        }

        // 16) Sumar todos los elementos (retorna int)
        public static int SumarMatriz(int[,] m)
        {
            int suma = 0;
            foreach (int v in m) suma += v;
            return suma;
        }

        // EXTRA: Impresión tipo ejemplo: |A| + |B| = |C|
        public static void ImprimirOperacion(int[,] A, int[,] B, int[,] C)
        {
            int n = A.GetLength(0);
            int w = CalcularAnchoCelda(A, B, C);

            for (int i = 0; i < n; i++)
            {
                ImprimirFila(A, i, n, w);
                Console.Write(" ");
                Console.Write(i == n / 2 ? "+ " : "  ");
                ImprimirFila(B, i, n, w);
                Console.Write(" ");
                Console.Write(i == n / 2 ? "= " : "  ");
                ImprimirFila(C, i, n, w);
                Console.WriteLine();
            }
        }

        private static void ImprimirFila(int[,] M, int fila, int n, int w)
        {
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
                    if (v.ToString().Length > maxLen) maxLen = v.ToString().Length;
            }

            Revisar(A); Revisar(B); Revisar(C);
            return maxLen + 1;
        }
    }
}