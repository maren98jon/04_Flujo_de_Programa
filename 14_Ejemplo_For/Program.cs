/*
 * Programa que muestra en pantalla una cuenta de 1 a 5 dos veces, la primera
 * con código que utiliza un while y la segunda utilizando un for
 */

using System;

namespace _14_Ejemplo_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; // Creamos una variable de tipo entero
            numero = 1; // Asignamos 1 a la variable

            while (numero <= 5) // Mientras la variable numero tenga un valor igual o menor que 5, repetiremos el código entre { y }
            {
                Console.WriteLine("El número es " + numero); // Mostrar en pantalla el valor de la variable numero
                numero = numero + 1; // Añadir 1 al valor de la variable número
            }
            Console.WriteLine("Después del bucle, numero es : " + numero); // Mostrar en pantalla el valor de la variable número después de el bucle while

            // Bucle for que se va a repetir mientras la variable i (iniciada con un valor de 1) sea menor o igual a 5.
            // Cada vez que el bucle acaba, añadimos 1 al valor de la variable i
            for (int i = 1; i <= 5; i = i + 1) 
            {
                Console.WriteLine("El valor de i es " + i); // Mostrar en pantalla el valor de la variable i
            }

            Console.WriteLine("Después del bucle, i deja de existir"); // Tras el bucle, la variable i no existe por lo que no podemos mostrar su valor.
            // Console.WriteLine(i); // Si intentamos utilizar esta variable, es un error
        }
    }
}
