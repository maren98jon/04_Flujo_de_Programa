/*
 * Ejemplo del uso de las variables booleanas (bool)
 */

using System;

namespace _01_Ejemplo_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos una vaiable tipo bool llamada test
            bool test;
            // Ponemos el valor false en la variable test
            test = false;
            // mostramos en pantalla el valor dentro de la variable test
            Console.WriteLine(test);
            // creamos una variable de tipo cadena de caracteres llamado mensaje
            string mensaje;
            // Unimos un texto al valor de la variable test y lo asignamos a mensaje
            mensaje = "La variable test contiene el valor " + test;
            // Mostramos mensaje en pantalla
            Console.WriteLine(mensaje);
        }
    }
}
