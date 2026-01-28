using System;

namespace Taller1.Services
{
    public static class StringService
    {
        public static int ContarVocales(string s)
        {
            if (s == null) return 0;

            int count = 0;
            foreach (char c in s.ToLower())
                if ("aeiou".Contains(c)) count++;

            return count;
        }

        public static string Capitalizar(string frase)
        {
            string[] palabras = frase.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < palabras.Length; i++)
            {
                string p = palabras[i].ToLower();
                palabras[i] = p.Length == 1
                    ? p.ToUpper()
                    : char.ToUpper(p[0]) + p.Substring(1);
            }

            return string.Join(" ", palabras);
        }

        // Palíndromo ignorando espacios y signos; no distingue mayúsculas/minúsculas
        public static bool EsPalindromo(string texto)
        {
            if (texto == null) return false;

            texto = texto.ToLower().Trim();

            char[] filtrado = new char[texto.Length];
            int k = 0;

            foreach (char c in texto)
            {
                if (char.IsLetterOrDigit(c))
                {
                    filtrado[k] = c;
                    k++;
                }
            }

            int i = 0, j = k - 1;
            while (i < j)
            {
                if (filtrado[i] != filtrado[j]) return false;
                i++; j--;
            }

            return true;
        }
    }
}
