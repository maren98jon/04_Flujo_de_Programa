/*
 * Programa que pide un número al usuario e indica si es par o impar
 */

using System;

namespace _16_Operador_De_Resto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; // Crea una variable tipo entero
            Console.WriteLine("Introduce un número: "); // Pide al usuario un número
            numero = Int32.Parse(Console.ReadLine()); // Obtiene lo introducido por el usuario, lo convierte en valor de número entero y lo asigna a la variable numero

            if (numero % 2 == 0) // Si el resto del valor de la variable numero divido por dos es cero
            {
                Console.WriteLine("El número es par"); // Mostrar en pantalla que el número es par
            }
            else // En el caso de que el resto del valor de la variable numero divido por dos no es cero
            {
                Console.WriteLine("El número es impar"); // Mostrar en pantalla que el número no es par
            }
        }
    }
}
