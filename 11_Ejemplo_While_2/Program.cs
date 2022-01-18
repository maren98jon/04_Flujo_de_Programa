/* Programa que da al usuario 3 intentos para adivinar un número entre
 * el 1 y el 10 (el número que tiene que adivinar es el 5).
 */

using System;

namespace _11_Ejemplo_While_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int correcta; // Creamos una variable de número entero
            correcta = 5; // Le asignamos el valor 5

            int max_intentos; // Creamos una variable de número entero
            max_intentos = 3; // Le asignamos el valor 3

            int intento; // Creamos una variable de número entero
            intento = 1; // Le asignamos el valor 1

            int respuesta; // Creamos una variable de número entero, donde guardaremos el valor introducido por el usuario

            while (intento <= max_intentos) // Mientras el intento sea igual o menor que el número máximo de intentos
            {
                Console.WriteLine("Adivina el número entre 1 y 10"); // Mostar al usuario la instrucción
                respuesta = Int32.Parse(Console.ReadLine()); // Obtener el valor del usuario, convertirlo en número entero y guardarlo en la variable respuesta
                if (respuesta == correcta) // Si la respuesta es el número a adivinar (el 5)
                {
                    Console.WriteLine("Has adivinado el número en el intento " + intento); // Felicitar al usuario
                    break; // break hace que el código salga del bucle while (el código continua en la línea 39)
                }
                else // Si la respuesta no es el número a adivinar
                {
                    Console.WriteLine("Número incorrecto"); // Decir al usuario que no adivinó el número
                }
                intento = intento + 1; // Añadir 1 al intento
            }
        }
    }
}
