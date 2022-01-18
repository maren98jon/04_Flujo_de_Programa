using System;

namespace _18_Ejemplo_For_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int palo = 1; palo <= 4; palo = palo + 1)
            {
                for (int valor = 1; valor <= 10; valor = valor + 1)
                {
                    if (valor == 1)
                    {
                        Console.Write("As");
                    }
                    else if (valor == 8)
                    {
                        Console.Write("Sota");
                    }
                    else if (valor == 9)
                    {
                        Console.Write("Caballo");
                    }
                    else if (valor == 10)
                    {
                        Console.Write("Rey");
                    }
                    else
                    {
                        Console.Write(valor);
                    }

                    Console.Write(" de ");

                    if (palo == 1)
                    {
                        Console.WriteLine("Oros");
                    }
                    else if (palo == 2)
                    {
                        Console.WriteLine("Copas");
                    }
                    else if (palo == 3)
                    {
                        Console.WriteLine("Espadas");
                    }
                    else if (palo == 4)
                    {
                        Console.WriteLine("Bastos");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
