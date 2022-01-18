/*
 * Uso de booleanos con variables que da el usuario. Operaciones de relación en WriteLine
 */

using System;

namespace _03_Ejemplo_Relacionales_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad; // Creamos una variable
            Console.WriteLine("¿Cuantos años tienes? "); // Mostramos mensaje al usuario
            edad = Int32.Parse(Console.ReadLine()); // Parseamos lo que obtengamos del usuario y lo introducimos en la variable edad

            Console.WriteLine("Eres mayor de edad: " + (edad >= 18)); // Mostramos mensaje y true/false dependiendo de si edad es mayor o igual que 18
        }
    }
}
