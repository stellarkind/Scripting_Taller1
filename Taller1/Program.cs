using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Taller1.Models;
using Taller1.Services;

namespace Taller1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Taller 1 – Scripting | Menú 20 funciones ===");
                Console.WriteLine(" 1) Saludar() [void, sin params]");
                Console.WriteLine(" 2) ImprimirMensaje(string) [void, con params]");
                Console.WriteLine(" 3) ObtenerNumeroFavorito() [retorno, sin params]");
                Console.WriteLine(" 4) Sumar(int,int) [retorno, con params]");
                Console.WriteLine(" 5) Potencia(double, exp=2) [opcional]");
                Console.WriteLine(" 6) SumarMuchos(params int[]) [params]");
                Console.WriteLine(" 7) TryParseEntero(string, out int) [out]");
                Console.WriteLine(" 8) Incrementar(ref int) [ref]");
                Console.WriteLine(" 9) InvertirArray(int[]) [array->array]");
                Console.WriteLine("10) ElegirPrimero<T>(T,T) [genérica]");
                Console.WriteLine("11) SumarMatrices(int[,],int[,]) [matriz->matriz]");
                Console.WriteLine("12) ImprimirOperacion(A,B,C) [void, matrices]");
                Console.WriteLine("13) SumarMatriz(int[,]) [matriz->int]");
                Console.WriteLine("14) ContarVocales(string) [string->int]");
                Console.WriteLine("15) Capitalizar(string) [string->string]");
                Console.WriteLine("16) EsPalindromo(string) [string->bool]");
                Console.WriteLine("17) DividirSeguro(double,double) [nullable]");
                Console.WriteLine("18) MinMax(int[]) [tupla]");
                Console.WriteLine("19) Crear Persona + ToString() [clase]");
                Console.WriteLine("20) SimularDescargaAsync(string) [async]");
                Console.WriteLine(" 0) Salir");
                Console.Write("Elige una opción: ");

                string? op = Console.ReadLine();
                Console.WriteLine();

                if (op == "0") break;

                try
                {
                    switch (op)
                    {
                        case "1":
                            MathService.Saludar();
                            break;

                        case "2":
                            {
                                string msg = ConsoleIO.LeerNoVacio("Mensaje: ");
                                MathService.ImprimirMensaje(msg);
                                break;
                            }

                        case "3":
                            Console.WriteLine("Número favorito => " + MathService.ObtenerNumeroFavorito());
                            break;

                        case "4":
                            {
                                int a = ConsoleIO.LeerEntero("a: ");
                                int b = ConsoleIO.LeerEntero("b: ");
                                Console.WriteLine($"Sumar({a},{b}) => {MathService.Sumar(a, b)}");
                                break;
                            }

                        case "5":
                            {
                                double baseNum = ConsoleIO.LeerDouble("Base (double): ");
                                Console.Write("Exponente (Enter para usar 2): ");
                                string? s = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(s))
                                    Console.WriteLine($"Potencia({baseNum}) => {MathService.Potencia(baseNum)}");
                                else
                                {
                                    if (!int.TryParse(s, out int exp))
                                        Console.WriteLine("Exponente inválido.");
                                    else
                                        Console.WriteLine($"Potencia({baseNum},{exp}) => {MathService.Potencia(baseNum, exp)}");
                                }
                                break;
                            }

                        case "6":
                            {
                                Console.WriteLine("Escribe enteros separados por espacio (ej: 1 2 3 4):");
                                string line = ConsoleIO.LeerNoVacio("> ");
                                int[] nums = ParseEnteros(line);
                                Console.WriteLine("SumarMuchos => " + MathService.SumarMuchos(nums));
                                break;
                            }

                        case "7":
                            {
                                string txt = ConsoleIO.LeerNoVacio("Texto: ");
                                bool ok = MathService.TryParseEntero(txt, out int val);
                                Console.WriteLine(ok
                                    ? $"TryParseEntero => true, valor={val}"
                                    : "TryParseEntero => false (no es entero)");
                                break;
                            }

                        case "8":
                            {
                                int x = ConsoleIO.LeerEntero("x inicial: ");
                                MathService.Incrementar(ref x);
                                Console.WriteLine("Después de Incrementar(ref x) => " + x);
                                break;
                            }

                        case "9":
                            {
                                Console.WriteLine("Escribe enteros separados por espacio (ej: 1 2 3 4):");
                                string line = ConsoleIO.LeerNoVacio("> ");
                                int[] nums = ParseEnteros(line);
                                int[] inv = ArrayService.InvertirArray(nums);
                                Console.WriteLine("InvertirArray => [" + string.Join(", ", inv) + "]");
                                break;
                            }

                        case "10":
                            {
                                // Para evidenciar genérica sin complicar: string
                                string a = ConsoleIO.LeerNoVacio("a (string): ");
                                string b = ConsoleIO.LeerNoVacio("b (string): ");
                                Console.WriteLine($"ElegirPrimero<string>(a,b) => {ArrayService.ElegirPrimero(a, b)}");
                                break;
                            }

                        case "11":
                            {
                                int n = ConsoleIO.LeerEntero("n (matriz nxn): ");
                                if (n <= 0) { Console.WriteLine("n debe ser > 0"); break; }

                                int[,] A = LeerMatriz(n, "A");
                                int[,] B = LeerMatriz(n, "B");
                                int[,] C = MatrixService.SumarMatrices(A, B);

                                Console.WriteLine("\nResultado C = A + B:");
                                MatrixService.ImprimirOperacion(A, B, C);
                                break;
                            }

                        case "12":
                            {
                                // demo rápida con 2x2 (como el ejemplo)
                                int[,] A = { { 3, 4 }, { 2, 1 } };
                                int[,] B = { { 5, -1 }, { 0, 3 } };
                                int[,] C = MatrixService.SumarMatrices(A, B);

                                Console.WriteLine("ImprimirOperacion (demo 2x2):");
                                MatrixService.ImprimirOperacion(A, B, C);
                                break;
                            }

                        case "13":
                            {
                                int n = ConsoleIO.LeerEntero("n (matriz nxn): ");
                                if (n <= 0) { Console.WriteLine("n debe ser > 0"); break; }

                                int[,] A = LeerMatriz(n, "A");
                                Console.WriteLine("SumarMatriz(A) => " + MatrixService.SumarMatriz(A));
                                break;
                            }

                        case "14":
                            {
                                string s = ConsoleIO.LeerNoVacio("Cadena: ");
                                Console.WriteLine("ContarVocales => " + StringService.ContarVocales(s));
                                break;
                            }

                        case "15":
                            {
                                string s = ConsoleIO.LeerNoVacio("Frase: ");
                                Console.WriteLine("Capitalizar => " + StringService.Capitalizar(s));
                                break;
                            }

                        case "16":
                            {
                                string s = ConsoleIO.LeerNoVacio("Cadena: ");
                                Console.WriteLine("EsPalindromo => " + StringService.EsPalindromo(s));
                                break;
                            }

                        case "17":
                            {
                                double a = ConsoleIO.LeerDouble("a: ");
                                double b = ConsoleIO.LeerDouble("b: ");
                                double? r = MathService.DividirSeguro(a, b);
                                Console.WriteLine(r is null ? "DividirSeguro => null (división inválida)" : $"DividirSeguro => {r}");
                                break;
                            }

                        case "18":
                            {
                                Console.WriteLine("Escribe enteros separados por espacio (ej: 9 -2 7 1 10):");
                                string line = ConsoleIO.LeerNoVacio("> ");
                                int[] nums = ParseEnteros(line);
                                var (min, max) = MathService.MinMax(nums);
                                Console.WriteLine($"MinMax => min={min}, max={max}");
                                break;
                            }

                        case "19":
                            {
                                string nombre = ConsoleIO.LeerNoVacio("Nombre: ");
                                int edad = ConsoleIO.LeerEntero("Edad: ");
                                Persona p = new Persona(nombre, edad);
                                Console.WriteLine("Persona creada => " + p);
                                break;
                            }

                        case "20":
                            {
                                string recurso = ConsoleIO.LeerNoVacio("Recurso: ");
                                string r = await AsyncService.SimularDescargaAsync(recurso);
                                Console.WriteLine(r);
                                break;
                            }

                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }

                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        // ===== Helpers locales para el menú =====

        private static int[] ParseEnteros(string line)
        {
            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<int> nums = new List<int>();

            foreach (var p in parts)
            {
                if (!int.TryParse(p, out int v))
                    throw new Exception($"No es entero válido: '{p}'");
                nums.Add(v);
            }

            if (nums.Count == 0) throw new Exception("No se ingresaron números.");
            return nums.ToArray();
        }

        private static int[,] LeerMatriz(int n, string nombre)
        {
            int[,] M = new int[n, n];
            Console.WriteLine($"\nIngrese matriz {nombre} ({n}x{n}):");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = ConsoleIO.LeerEntero($"{nombre}[{i},{j}]: ");
                }
            }

            return M;
        }
    }
}
