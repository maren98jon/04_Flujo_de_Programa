/*
 * Programa que da al usuario varios opciones que elegir (como  si fuera un menú)
 * y después muestra en pantalla la opción elegida y acaba el programa (no
 * se hace nada más que mostrar la selección)
 */

using System;

namespace _08_Ejemplo_Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizamos estas cinco WriteLines para mostrar las opciones al usuario
            Console.WriteLine("Elige la opción:");
            Console.WriteLine("1- Insertar dato");
            Console.WriteLine("2- Editar dato");
            Console.WriteLine("3- Eliminar dato");
            Console.WriteLine("4- Salir");

            int opcion; // Creamos una variable de tipo entero
            opcion = Int32.Parse(Console.ReadLine()); // Obtenemos un valor del usuario y lo convertimos en número entero para asignarlo a la variable opcion

            if (opcion == 1) // Si opcion es igual a uno
            {
                Console.WriteLine("Elegiste insertar dato"); // Mostrar mensaje que indica que se eligió la primera opción
            }
            else if (opcion == 2) // Si opcion es igual a dos
            {
                Console.WriteLine("Elegiste editar dato"); // Mostrar mensaje que indica que se eligió la segunda opción
            }
            else if (opcion == 3) // Si opcion es igual a tres
            {
                Console.WriteLine("Elegiste eliminar dato"); // Mostrar mensaje que indica que se eligió la tercera opción
            }
            else if (opcion == 4) // Si opcion es igual a cuatro
            {
                Console.WriteLine("Elegiste salir del programa"); // Mostrar mensaje que indica que se eligió la cuarta opción
            }
            else // Si opcion no es igual a ninguna de los valores anteriores (ni 1, 2, 3 ni 4)
            {
                Console.WriteLine("Opción erronea"); // Indicar que no se ha elegido una opcion posible
            }
        }
    }
}
