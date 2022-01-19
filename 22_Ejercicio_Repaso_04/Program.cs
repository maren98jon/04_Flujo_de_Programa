/*
 * Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 dependiendo de si el usuario introduce P o I . 
 * Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez. 
 */
using System;

namespace _22_Ejercicio_Repaso_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            bool correcto = true;
            while (correcto)
            {
                Console.WriteLine("Introduzca P para obtener los números pares del 1 al 100 e I para los impares");
                string letra = Console.ReadLine();
                if (letra.ToUpper() == "P")
                {
                    for (int i = 2; i <= 100; i = i + 2)
                    {
                        Console.WriteLine(i);
                        correcto = false;
                    }
                }
                else if (letra.ToUpper() == "I")
                {
                    for (int i = 1; i <= 100; i = i + 2)
                    {
                        Console.WriteLine(i);
                        correcto = false;
                    }
                }
                else { Console.WriteLine("Ese valor no es correcto.");
                }
                
            }

               

            
        }
    }
}
