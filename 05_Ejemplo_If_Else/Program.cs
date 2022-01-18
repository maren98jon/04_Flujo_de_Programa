/*
 * Uso del if...else...
 */

using System;

namespace _05_Ejemplo_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vip; // Creamos una variable booleana
            vip = true; // Le asignamos valor true
            if (vip) // Si vip tiene valor true...
            {
                Console.WriteLine("Cliente VIP."); // Mostrar mensaje en pantalla
            }
            // Ahora comprobaremos si vip tiene valor falso.
            // Si vip tenía valor verdadero, no debería hacer falta comprobarlo
            if (!vip)
            {
                Console.WriteLine("Cliente no VIP.");
            }

            
            if (vip)
            {
                Console.WriteLine("Cliente VIP.");
            }
            else // Con if ... else... no tenemos que comprobar lo contrario de lo anterior, si el anterior es falso este se ejecuta
            {
                Console.WriteLine("Cliente no VIP.");
            }
        }
    }
}
