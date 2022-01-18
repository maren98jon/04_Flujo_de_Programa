/*
 * Programa que muestra distintos bucles for
 */

using System;

namespace _15_Ejemplo_For_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int i = 1; i < 10; i = i + 1"); // Muestra en pantalla el bucle que crea los valores que se muestran
            // Bucle que se repite mientras el valor i (que se inicia con 1) es menor que 10 y en cada vuelta se le añade 1 al valor de i
            for (int i = 1; i < 10; i = i + 1)
            {
                Console.WriteLine("El número es " + i); // Muestra el valor actual en la vuelta del bucle a pantalla
            }
            Console.WriteLine(); // Dibuja una línea vacía para separar los bucles

            Console.WriteLine("int i = 1; i <= 10; i = i + 1"); // Muestra en pantalla el bucle que crea los valores que se muestran
            // Bucle que se repite mientras el valor i (que se inicia con 1) es menor o igual que 10 y en cada vuelta se le añade 1 al valor de i
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine("El número es " + i); // Muestra el valor actual en la vuelta del bucle a pantalla
            }
            Console.WriteLine(); // Dibuja una línea vacía para separar los bucles

            Console.WriteLine("int i = 1; i <= 10; i = i + 2"); // Muestra en pantalla el bucle que crea los valores que se muestran
            // Bucle que se repite mientras el valor i (que se inicia con 1) es menor o igual que 10 y en cada vuelta se le añade 2 al valor de i
            for (int i = 1; i <= 10; i = i + 2)
            {
                Console.WriteLine("El número es " + i); // Muestra el valor actual en la vuelta del bucle a pantalla
            }
            Console.WriteLine(); // Dibuja una línea vacía para separar los bucles

            Console.WriteLine("int i = 10; i > 0; i = i - 1"); // Muestra en pantalla el bucle que crea los valores que se muestran
            // Bucle que se repite mientras el valor i (que se inicia con 10) es mayor que 0 y en cada vuelta se le resta 1 al valor de i
            for (int i = 10; i > 0; i = i - 1)
            {
                Console.WriteLine("El número es " + i); // Muestra el valor actual en la vuelta del bucle a pantalla
            }
            Console.WriteLine(); // Dibuja una línea vacía para separar los bucles

            Console.WriteLine("int i = 10; i > 0; i = i - 2"); // Muestra en pantalla el bucle que crea los valores que se muestran
            // Bucle que se repite mientras el valor i (que se inicia con 10) es mayor que 0 y en cada vuelta se le resta 2 al valor de i
            for (int i = 10; i > 0; i = i - 2)
            {
                Console.WriteLine("El número es " + i); // Muestra el valor actual en la vuelta del bucle a pantalla
            }
        }
    }
}
