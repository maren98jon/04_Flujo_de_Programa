/*
 * Programa que da al usuario varios opciones que elegir (como  si fuera un menú)
 * y después muestra en pantalla la opción elegida y acaba el programa (no
 * se hace nada más que mostrar la selección)
 * 
 * A diferencia del programa anterior, utilizamos un switch en vez de los if ... else if ... else
 */
using System;

namespace _09_Ejemplo_Switch
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

            switch (opcion) // Vamos a hacer un switch basándonos en el valor de la variable opcion
            {
                case 1: // En el caso de que el valor de la variable opcion sea 1
                    Console.WriteLine("Elegiste insertar dato"); // Mostrar en pantalla un mensaje indicando que se eligió la primera opción
                    break; // Si llegamos a esta instrucción (por estar dentro del case 1) esto hace que salgamos del switch (pasamos a la línea 41)

                case 2: // En el caso de que el valor de la variable opcion sea 2
                    Console.WriteLine("Elegiste editar dato"); // Mostrar en pantalla un mensaje indicando que se eligió la segunda opción
                    break; // Si llegamos a esta instrucción (por estar dentro del case 2) esto hace que salgamos del switch (pasamos a la línea 41)

                case 3: // En el caso de que el valor de la variable opcion sea 3
                    Console.WriteLine("Elegiste eliminar dato"); // Mostrar en pantalla un mensaje indicando que se eligió la segunda opción
                    break; // Si llegamos a esta instrucción (por estar dentro del case 3) esto hace que salgamos del switch (pasamos a la línea 41)

                case 4: // En el caso de que el valor de la variable opcion sea 4
                    Console.WriteLine("Elegiste salir del programa"); // Mostrar en pantalla un mensaje indicando que se eligió la tercera opción
                    break; // Si llegamos a esta instrucción (por estar dentro del case 4) esto hace que salgamos del switch (pasamos a la línea 41)

                default: // En el caso de que el valor de la variable opcion no sea ninguno de los que aparece en los case
                    Console.WriteLine("Opción erronea"); // Mostrar en pantalla un mensaje indicando que se eligió la cuarta opción
                    break; // Si llegamos a esta instrucción (por estar dentro del default) esto hace que salgamos del switch (pasamos a la línea 41)
            }
        }
    }
}
