/*
 * Programa que muestra los múltiplos de 6 que existen entre el número 1 y 100.
 * Los muestra dos veces, en la primera vez muestra cada número en una línea
 * y en la segunda los muestra todos en la misma línea, separados por un espacio.
 */

using System;

namespace _17_Operador_De_Resto_For
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bucle que se repite mientras la variable i (que empieza con un valor de 1) sea menor o igual que 100.
            // Cada vez que el código se repite, se le añade 1 a i
            for (int i = 1; i <= 100; i = i + 1)
            {
                if (i % 6 == 0) // Si el valor actual de i en la repetición del bucle es múltiplo de 6
                {
                    Console.WriteLine(i); // Mostrar el valor en pantalla en su propia línea
                }
            }

            // Bucle que se repite mientras la variable i (que empieza con un valor de 1) sea menor o igual que 100.
            // Cada vez que el código se repite, se le añade 1 a i
            for (int i = 1; i <= 100; i++)
            {
                if (i % 6 == 0) // Si el valor actual de i en la repetición del bucle es múltiplo de 6
                {
                    Console.Write(i + " "); // Mostrar el valor en pantalla seguido de un espacio, sin salto de línea
                }
            }
        }
    }
}
