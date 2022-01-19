/*
 * Escribe un programa que muestre  en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.
 */
using System;

namespace _19_Ejercicio_Repaso_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tu código aquí
            Console.WriteLine("Cuántos años tienes?");
            int edad = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= edad; i++)
            {
                Console.WriteLine("Feliz cumpleaños!");
            }
        }
    }
}
