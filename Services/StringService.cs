using System;

    public static class StringService
    {
        // 17) Contar vocales (retorna int)
        public static int ContarVocales(string s)
        {
            if (s == null) return 0;

            int count = 0;
            foreach (char ch in s.ToLower())
                if ("aeiou".Contains(ch)) count++;
            return count;
        }

        // 18) Capitalizar frase (retorna string)
        public static string Capitalizar(string frase)
        {
            var palabras = frase.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < palabras.Length; i++)
            {
                string p = palabras[i].ToLower();
                palabras[i] = p.Length == 0 ? p : char.ToUpper(p[0]) + p.Substring(1);
            }
            return string.Join(" ", palabras);
        }

        // 19) Palíndromo (retorna bool) - ignora espacios/puntuación, no distingue mayúsculas
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