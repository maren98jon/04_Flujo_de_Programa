/*
 * Escribe un programa que pida un número de 3 dígitos y muestre el resultado de sumar sus dígitos.
 */
using System;

namespace _25_Ejercicio_Repaso_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            Console.WriteLine("Introduzca un número de 3 dígitos:");
            string txtnumero = Console.ReadLine();
            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma =suma + Convert.ToInt32(txtnumero.Substring(i, 1));
            }
            Console.WriteLine(suma);
        } 
    }
}
