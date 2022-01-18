/*
 * Valores booleanos que son resultado de distintas operaciones de igualdad o relación
 */

using System;

namespace _02_Ejemplo_Relacionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 < 5 es " + (3 < 5)); // 3 < 5 es True
            Console.WriteLine("3 > 5 es " + (3 > 5)); // 3 > 5 es False

            Console.WriteLine("4 < 4 es " + (4 < 4)); // 4 < 4 es False
            Console.WriteLine("4 <= 4 es " + (4 <= 4)); // 4 <= 4 es True
            Console.WriteLine("4 <= 5 es " + (4 <= 5)); // 4 <= 5 es True
            Console.WriteLine("4 >= 4 es " + (4 >= 4)); // 4 >= 4 es True
            Console.WriteLine("5 >= 4 es " + (5 >= 4)); // 5 >= 4 es True

            Console.WriteLine("4 == 3 es " + (4 == 3)); // 4 == 3 es False
            Console.WriteLine("4 == 4 es " + (4 == 4)); // 4 == 4 es True
            Console.WriteLine("4 != 3 es " + (4 != 3)); // 4 != 3 es True
            Console.WriteLine("4 != 4 es " + (4 != 4)); // 4 != 4 es False
        }
    }
}
