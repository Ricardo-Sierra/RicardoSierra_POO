using System;

namespace Arreglos_Bidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int columna;
            int fila;
            double suma = 0;
            double promedio;
            Console.WriteLine("Recorrer tipos de arreglos bidimensionales (matrices)");
            Console.WriteLine("=====================================================================");

            do
            {
                Console.WriteLine("¿Cuántas filas tendrá la matriz?");
                fila = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Cuántas columnas tendrá la matriz?");
                columna = Convert.ToInt32(Console.ReadLine());
            } while (columna == 0 || fila == 0);
            
            int[,] matriz = new int[fila, columna];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el número para {i},{j}");
                    matriz[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++) 
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    suma += matriz[i, j];
                    Console.WriteLine($"Matriz[{i}, {j}] = {matriz[i,j]}");
                }
            }
            promedio = suma/matriz.Length;
            Console.WriteLine($"La suma de los elementos de la matriz es {suma} :)");
            Console.WriteLine($"El promedio de los elementos de la matriz es {promedio} :)");
            Console.ReadLine();

        }
    }
}
