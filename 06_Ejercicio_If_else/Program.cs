/*
 * En este ejercicio, debes pedirle al usuario que introduzca su edad. Si es igual o mayor a 18, 
 * mostrarás en pantalla "Eres mayor de edad" y en caso contrario "Eres menor".
 */
using System;

namespace _06_Ejercicio_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tu código aquí
            Console.WriteLine("Introduzca su edad:");
            string txtedad = Console.ReadLine();
            int edad = Convert.ToInt32(txtedad);
            if (edad>=18) {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor");
            }
        }
    }
}
