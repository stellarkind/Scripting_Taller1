using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TuProyecto.Models;
using TuProyecto.Services;

    static async Task Main()
    {
        Console.WriteLine("=== POO Estricto: 20 Firmas + Invocaciones ===\n");

        // 1
        MathService.Saludar();

        // 2
        MathService.ImprimirMensaje("Mensaje desde un método con parámetro.");

        // 3
        Console.WriteLine("Número favorito: " + MathService.ObtenerNumeroFavorito());

        // 4
        Console.WriteLine("Sumar(5, 6) = " + MathService.Sumar(5, 6));

        // 5
        Console.WriteLine("Potencia(3) = " + MathService.Potencia(3));
        Console.WriteLine("Potencia(2, 5) = " + MathService.Potencia(2, 5));

        // 6
        Console.WriteLine("SumarMuchos(1,2,3,4) = " + MathService.SumarMuchos(1, 2, 3, 4));

        // 7
        if (MathService.TryParseEntero("123", out int valor))
            Console.WriteLine("TryParseEntero(\"123\") => " + valor);

        // 8
        int x = 10;
        MathService.Incrementar(ref x);
        Console.WriteLine("Incrementar(ref x) => " + x);

        // 9
        int[] arr = { 1, 2, 3, 4 };
        int[] inv = ArrayService.InvertirArray(arr);
        Console.WriteLine("InvertirArray => [" + string.Join(", ", inv) + "]");

        // 10
        int[,] matriz = { { 3, 4 }, { 2, 1 } };
        Console.WriteLine("\nImprimirMatriz:");
        MatrixService.ImprimirMatriz(matriz);

        // 11
        Console.WriteLine("SumarMatriz => " + MatrixService.SumarMatriz(matriz));

        // 12
        Console.WriteLine("ElegirPrimero<string>(\"A\",\"B\") => " + ArrayService.ElegirPrimero("A", "B"));

        // 13-14-15-16 (matrices completas)
        int n = 2;
        int[,] A = { { 3, 4 }, { 2, 1 } };
        int[,] B = { { 5, -1 }, { 0, 3 } };
        int[,] C = MatrixService.SumarMatrices(A, B);

        Console.WriteLine("\nFormato A + B = C:");
        MatrixService.ImprimirOperacion(A, B, C);

        // 17
        Console.WriteLine("\nContarVocales(\"Hola Mundo\") => " + StringService.ContarVocales("Hola Mundo"));

        // 18
        Console.WriteLine("Capitalizar(\"el examen mas facil del mundo\") => " +
                          StringService.Capitalizar("el examen mas facil del mundo"));

        // 19
        Console.WriteLine("EsPalindromo(\"Anita lava la tina\") => " +
                          StringService.EsPalindromo("Anita lava la tina"));

        // 9 (nullable)
        double? div = MathService.DividirSeguro(10, 0);
        Console.WriteLine("DividirSeguro(10, 0) => " + (div is null ? "null" : div.ToString()));

        // 10 (tupla)
        var (min, max) = MathService.MinMax(new[] { 9, -2, 7, 1, 10 });
        Console.WriteLine($"MinMax => min={min}, max={max}");

        // Clase Persona (POO)
        Persona p = new Persona("Stella", 20);
        Console.WriteLine("\nPersona => " + p);

        // Modificación de objeto (método void)
        // (Si quieres, lo ponemos como PersonaService, pero aquí lo dejo simple)
        p.Edad += 1;
        Console.WriteLine("Persona tras cambio => " + p);

        // 20 (async)
        string r = await AsyncService.SimularDescargaAsync("recurso.json");
        Console.WriteLine("\n" + r);

        Console.WriteLine("\n=== Fin ===");
    }