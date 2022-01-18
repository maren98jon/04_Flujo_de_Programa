/*
 * Programa que muestra el número introducido por el usuario hasta que introduzca un 0.
 * 
 * El programa repite el proceso 2 veces, ya que en el primero se hace utilizando
 * código repetido en un while, y la segunda sin código repetido en un do while.
 */

using System;

namespace _12_Ejemplo_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; // Crea una variable de número entero en la que guardaremos el valor introducido por el usuario

            Console.WriteLine("Introduce un número: "); // Pide un número al usuario
            numero = Int32.Parse(Console.ReadLine()); // Convierte lo que el usuario introduce a un número entero y lo guarda en la variable numero

            while (numero != 0) // Mientras el valor de la variable numero no sea igual a 0, repetir el código entre { y }
            {
                Console.WriteLine("Introduce un número: "); // Pide un número al usuario
                numero = Int32.Parse(Console.ReadLine()); // Convierte lo que el usuario introduce a un número entero y lo guarda en la variable numero
                Console.WriteLine(numero); // Muestra el valor de la variable numero en pantalla
            }

            do // Marca el inicio del código que se repetirá, pero al pasar por primera vez empieza a ejecutarlo sin ninguna condición
            {
                Console.WriteLine("Introduce un número: "); // Pide un número al usuario
                numero = Int32.Parse(Console.ReadLine()); // Convierte lo que el usuario introduce a un número entero y lo guarda en la variable numero
                Console.WriteLine(numero); // Muestra el valor de la variable numero en pantalla
            } while (numero != 0); // Mientras la variable no sea 0, hace que el código se repita desde después del do hasta aquí
        }
    }
}
