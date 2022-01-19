/*
 * Escribe un programa que muestre el número entero positivo que el usuario introduzca pero al revés 
 * (si introduce 1478 que muestre 8741), hasta que el usuario introduzca 0. 
 * Si introduce 0 la primera vez, debería mostrarlo al revés (es decir, mostrar 0) y acabar el programa.
 * Pistas:
 * Podemos utilizar el bucle para recorrer cada uno de los caracteres de un string. 
 * Si declaramos la variable ‘i’ a la cual asignamos un valor inicial de 0 y en la condición, 
 * indicamos que el bucle se va a repetir siempre que el valor de ‘i’ sea menor que la longitud del string
 * ( utilizando la propiedad .Lenght), podemos recuperar cada carácter del string utilizando el método Substring. 
 */
using System;

namespace _24_Ejercicio_Repaso_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            int numero;
            do
            {
                Console.WriteLine("Introduce un número");
                string txtnumero = Console.ReadLine();
                numero = Convert.ToInt32(txtnumero);
                int longitud = txtnumero.Length;
                for (int i =longitud-1; i>=0; i=i-1)
                {
                    Console.Write(txtnumero.Substring(i, 1));
                }
                Console.WriteLine();
                 

            } while (numero != 0);
           
        }
    }
}
