/*
 * Ejemplos de uso de If, con valores fijos, operaciones relaciones y variables.
 * Uso de ! para obtener el valor booleano contrario.
 */

using System;

namespace _04_Ejemplo_If
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true) // Siempre se ejecuta
            {
                Console.WriteLine("Siempre se ejecuta esto");
            }
            if (false) // Nunca se ejecuta (fijate como Visual Studio marca la instrucción advirtiéndonos de que nunca se ejecuta
            {
                Console.WriteLine("Nunca se ejecutará");
            }

            if (3 < 5) // Siempre se ejecutará ya que el resultado siempre será true
            {
                Console.WriteLine("3 es menor que 5.");
            }

            Console.WriteLine("¿Cuantos años tienes?"); // Mostramos mensaje en pantalla
            int edad; // Creamos variable
            edad = Int32.Parse(Console.ReadLine()); // Cogemos datos del teclado, los convertimos en un int, los introducimos en la variable edad

            Console.WriteLine("Tienes " + edad + " años."); // Mostramos la edad introducida en pantalla
            if (edad >= 18) // Si la edad es mayor o igual a 18 mostramos un mensaje
            {
                Console.WriteLine("Eres mayor de edad.");
            }

            bool vip;
            vip = true; // Creamos variable VIP y le asignamos el valor true
            if (vip == true) // Aunque este modo funcione, es redundante
            {
                Console.WriteLine("Cliente VIP.");
            }
            if (vip) // Funciona igual que el if anterior, mostrando que igualarlo a true es redundante
            {
                Console.WriteLine("Cliente VIP.");
            }

            vip = false; // Pongamos ahora el valor false en vip
            if (!vip) // Este es el modo de comprobar si la variable tiene un valor false
            {
                Console.WriteLine("Cliente no VIP.");
            }
        }
    }
}
