# Taller 1 – Scripting  
## Funciones y variaciones en C#

**Asignatura:** Scripting  
**Taller:** 1 - Taller de repaso
**Lenguaje:** C#  
**Tipo de proyecto:** Aplicación de consola (.NET)  
**Autora:** Stella Pérez  

---

## Descripción

Este repositorio contiene el desarrollo del **Taller 1 de repaso de la asignatura Scripting**, cuyo objetivo es evidenciar el uso correcto del concepto de **función (método)** en C#, implementando **20 firmas diferentes** con distintas variaciones, tal como se solicita en el enunciado del reto.

El proyecto utiliza una **estructura básica de Programación Orientada a Objetos (POO)** y se apoya en un **menú interactivo en consola**, desde el cual es posible ejecutar cada función de manera individual, ingresar datos por teclado y observar sus resultados.

--- 
Lista de firmas (20) 
- public int Sumar(int a, int b);
- protected bool EsPar(int numero);
- public void ImprimirMensaje(string mensaje);
- protected byte ObtenerNivelAcceso(int usuarioId);
- internal long CalcularTotal(long a, long b);
- public float ConvertirTemperatura(float grados);
- private char ObtenerInicial(string nombre);
- protected short CalcularEdad(short anioNacimiento);
- private void ImprimirMensaje(string mensaje);
- public bool ValidarUsuario(string usuario, string password);
- public long CalcularPuntaje(long aciertos, long errores);
- protected byte CalcularPrioridad(int nivel);
- internal double CalcularDistancia(double x1, double y1);
- internal long GenerarCodigo(long semilla);
- protected short CalcularDiferencia(short a, short b);
- private bool ExisteArchivo(string ruta);
- protected double CalcularRaiz(double numero);
- protected byte ObtenerDiaSemana(DateTime fecha);
- public long ConvertirABinario(long decimalValor);
- private float CalcularVelocidad(float distancia, float tiempo); 

---

## Funciones implementadas en el repositorio (20)

Las siguientes funciones pueden ejecutarse desde el **menú interactivo** en consola:

1. **Saludar()**  
   Función sin parámetros y sin retorno (`void`).

2. **ImprimirMensaje(string mensaje)**  
   Función con parámetro y sin retorno.

3. **ObtenerNumeroFavorito() : int**  
   Función sin parámetros y con retorno.

4. **Sumar(int a, int b) : int**  
   Función con parámetros y con retorno.

5. **Potencia(double base, int exp = 2) : double**  
   Función con parámetro opcional.

6. **SumarMuchos(params int[] numeros) : int**  
   Función con número variable de parámetros (`params`).

7. **TryParseEntero(string texto, out int valor) : bool**  
   Función que utiliza el modificador `out`.

8. **Incrementar(ref int x) : void**  
   Función que utiliza el modificador `ref`.

9. **InvertirArray(int[] arr) : int[]**  
   Función que recibe un arreglo y retorna otro arreglo.

10. **ElegirPrimero<T>(T a, T b) : T**  
    Función genérica.

11. **SumarMatrices(int[,] A, int[,] B) : int[,]**  
    Función que opera con matrices bidimensionales y retorna una matriz.

12. **ImprimirOperacion(int[,] A, int[,] B, int[,] C) : void**  
    Función sin retorno que imprime matrices en formato:
    ```
    | A | + | B | = | C |
    ```

13. **SumarMatriz(int[,] m) : int**  
    Función que recibe una matriz y retorna la suma de sus elementos.

14. **ContarVocales(string texto) : int**  
    Función que procesa cadenas y retorna un valor numérico.

15. **Capitalizar(string frase) : string**  
    Función que recibe y retorna cadenas.

16. **EsPalindromo(string texto) : bool**  
    Función lógica aplicada a cadenas de texto.

17. **DividirSeguro(double a, double b) : double?**  
    Función que retorna un valor `nullable`.

18. **MinMax(int[] arr) : (int min, int max)**  
    Función que retorna una **tupla**.

19. **Persona (constructor + ToString)**  
    Uso de una **clase** como tipo de dato y representación en consola.

20. **SimularDescargaAsync(string recurso) : Task<string>**  
    Función **asíncrona** que simula un proceso no inmediato.

---

## Funcionamiento del programa

Al ejecutar el programa se presenta un **menú interactivo en consola** con las 20 opciones correspondientes a cada función.  
El usuario puede seleccionar una opción, ingresar los datos requeridos y observar el resultado de la ejecución.

---

## Cómo ejecutar el proyecto

1. Abrir la carpeta `Taller1` en Visual Studio Code.
2. Asegurarse de tener instalado el SDK de .NET.
3. Ejecutar en la terminal:

```bash
dotnet run
```
Usar el menú para probar cada función.

