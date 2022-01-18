/*
 * Programa que da al usuario 3 intentos para adivinar un número entre
 * el 1 y el 10 (el número que tiene que adivinar es el 5). Dentro
 * de cada uno de los else en los if ... else ... estamos introduciendo
 * otro if ... else ...
 */

using System;

namespace _07_Ejemplo_If_Else_Anidado
{
    class Program
    {
        static void Main(string[] args)
        {
            int correcta; // Creamos una variable de tipo número entero
            correcta = 5; // Le asignamos el valor 5 (el número que tiene que acertar el usuario)

            int respuesta; // Variable en la que guardaremos la respuesta del usuario

            Console.WriteLine("Adivina el número entre 1 y 10"); // Mostramos en pantalla instrucciones para el usuario
            respuesta = Int32.Parse(Console.ReadLine()); // Obtenemos el número del usuario, lo convertimos en valor numérico y lo guardamos en la variable respuesta
            if (respuesta == correcta) // Si ha acertado el número
            {
                Console.WriteLine("Has adivinado el número en el intento 1"); // Le felicitamos
            }
            else // Si no acerto el número
            {
                Console.WriteLine("Número incorrecto."); // Le informamos de que no acertó
                Console.WriteLine("Adivina el número entre 1 y 10"); // Mostramos en pantalla instrucciones para el usuario
                respuesta = Int32.Parse(Console.ReadLine()); // Obtenemos el número del usuario, lo convertimos en valor numérico y lo guardamos en la variable respuesta
                if (respuesta == correcta) // Si ha acertado el número
                {
                    Console.WriteLine("Has adivinado el número en el intento 2"); // Le felicitamos
                }
                else // Si no acerto el número
                {
                    Console.WriteLine("Número incorrecto."); // Le informamos de que no acertó
                    Console.WriteLine("Adivina el número entre 1 y 10"); // Mostramos en pantalla instrucciones para el usuario
                    respuesta = Int32.Parse(Console.ReadLine()); // Obtenemos el número del usuario, lo convertimos en valor numérico y lo guardamos en la variable respuesta
                    if (respuesta == correcta) // Si ha acertado el número
                    {
                        Console.WriteLine("Has adivinado el número en el intento 3"); // Le felicitamos
                    }
                    else // // Si no acerto el número
                    {
                        Console.WriteLine("No te quedan más intentos"); // Le informamos de que no acertó y no quedan más intentos
                    }
                }
            }
        }
    }
}
