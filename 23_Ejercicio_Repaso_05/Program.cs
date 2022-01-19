/*
 * Escribe un programa que muestre los números de 1 a 12 en una columna. En la columna de al lado de los números 
 * impares mostrar el cuadrado de ese valor y en la de los pares mostrar el cubo.
 * Pistas:
 * Podemos concatenar la cadena "\t" para insertar una tabulación dentro de una cadena. 
 * Por ejemplo,  Console.WriteLine(“Nombre” + "\t" + “Apellido” ); 
 * Mostrará por consola: Nombre	        Apellido . Incluyendo una tabulación dentro del mensaje.
 */
using System;

namespace _23_Ejercicio_Repaso_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            int operacion;
            for (int i = 1; i <= 12; i++)
            {
                if (i % 2 == 0)
                {
                    operacion = i * i * i;
                } else { operacion = i * i; }
                Console.WriteLine(i + "\t" + operacion);
            }
        }
    }
}
