using System;


namespace Promedio_Arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[5];
            double suma = 0;
            for (double i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingresa un número");
                numeros[(int)i] = double.Parse(Console.ReadLine());
            }
            foreach (double i in numeros)
            {
                suma += i;
            }
            double promedio = suma/numeros.Length;
            Console.WriteLine($"El promedio es {promedio}");
            Console.ReadKey();
        }
    }
}
