using System;
// Espacio de nombres
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesión 12: Instrucción while 30092026

            /* Sintaxis:
            inicializacion;
            while (expresión)
            {
                // Bloque de instrucciones
                iterador;
            }
            Iterar: Repetir o terminar el ciclo.
            */

            //Ejemplo 1: Ciclo ascendente (rango; 1-3)
            // m: variable de control
            int m = 1; // Inicialización
            while (m <= 3) // Expresión: True
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }
            // Ejercitación
            // 1. Definir un ciclo para imprimri tu nombre 5 veces.
            // Nota: Para la expresión, utilizar el operador <.
            // a. Ciclo asendente
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine($"Impresion {n + 1}: Tu nombre es: Oscar Fuentes");
                n += 1; // Iterador
            }
            // b. Ciclo descedente
            int d = 3;
            while (d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1; // Iterador
            }
            // c. Incrementos
            // Secuancia: 3 6 9 12 15 18
            int i = 3;
            while ( i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3; // Iterador
            }
            // d. Decrementos
            // Ejercitación
            // 1. Definit un ciclo para imprimir "331" 8 veces.
            // Nota: Para la solucióm, definir un ciclo descendente con decrementos de 2 unidades.
            int j = 15;
            while (j >= 1)
            {
                Console.WriteLine($"El salon es: 331");
                j -= 2; // Iterador
            }
            // Actividad 1: Ciclo Infinito
            // 1. Definir un ciclo infinito ascendente.
            // 2. Definir un ciclo infinito descendente.
            // Nota: Para la solución, utilizar el operador de diferencia.
            int a = 1;
            while (a != 0)
            {
                Console.WriteLine("Ciclo infinito ascendente");
                a += 1; // Iterador
            }

            int b = -1;
            while ( b != 0)
            {
                Console.WriteLine("Ciclo infinito descendente");
                b -= 1; // Iterador
            }

        }
    }
}