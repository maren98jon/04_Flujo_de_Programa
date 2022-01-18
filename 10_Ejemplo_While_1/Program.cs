/*
 * Programa que muestra el funcionamiento básico de while.
 */

using System;

namespace _10_Ejemplo_While_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // Creamos una variable de número entero
            x = 1; // Le asignamos el valor 1

            while (x <= 3) // Mientras el valor de x sea menor o igual que 3, repetir las instrucciones entre { y }
            {
                Console.WriteLine(x); // Mostrar el valor de x en pantalla
                x = x + 1; // Añadir 1 a x
            }

            x = 1; // Volver a poner el valor de x a 1
            while (x <= 3) // Mientras el valor de x sea menor o igual a 3, repetir las instrucciones entre { y }
            {
                if (x == 2) // Si x es igual a 2
                {
                    break; // Salir del while (continuar el programa en la línea 33
                }
                Console.WriteLine(x); // Mostrar el valor de x en pantalla
                x = x + 1; // Añadir 1 a x
            }
        }
    }
}
