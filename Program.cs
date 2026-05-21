using System;

namespace RicardoSierra_Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            do
            {
                Console.WriteLine("Introduce un número entero");
                int num_1 = Convert.ToInt32(Console.ReadLine());
                if (num_1 == 0)
                {
                    Console.WriteLine("El número es cero y es par");
                }
                else if (num_1 % 2 != 0)
                {
                    Console.WriteLine($"El número es {num_1} y es IMPAR");
                }
                else
                {
                    Console.WriteLine($"El número es {num_1} y es PAR");
                }
                Console.WriteLine("¿Quieres analizar otro número? (si/no)");
                respuesta = Console.ReadLine().ToLower();
            } while(respuesta == "si");
            Console.WriteLine("Ha finalizado el programa :)");
            Console.ReadKey();
        }
    }
}
