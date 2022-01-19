/*
 * Se desea conocer el lucky  number (número de la suerte) de cualquier persona. El número de la suerte se consigue reduciendo 
 * la fecha de nacimiento a un número de un solo dígito. Por ejemplo, la fecha de nacimiento de Emma es la siguiente: 
 * 16-08-1973 16+8+1973=1997 	1+9+9+7=26 	2+6=8. El número de la suerte de Emma será el 8.
 */
using System;

namespace _26_Ejercicio_Repaso_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            Console.WriteLine("Introduce tu fecha de nacimiento con el siguiente formato dd-mm-aaaa");
            string txtfecha = Console.ReadLine();
            int suma = Convert.ToInt32(txtfecha.Substring(0, 2)) + Convert.ToInt32(txtfecha.Substring(3, 2)) + Convert.ToInt32(txtfecha.Substring(6));
            string txtsuma = Convert.ToString(suma);
            
            while (txtsuma.Length != 1)
            {
                suma = 0;
                for (int i = 0; i <= txtsuma.Length-1; i++)
                {
                    suma = suma + Convert.ToInt32(txtsuma.Substring(i, 1));
                }
                txtsuma = Convert.ToString(suma);
            }
            Console.WriteLine("Tu número de la suerte es " + txtsuma);
        }
    }
}
