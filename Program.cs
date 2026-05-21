using System;


namespace Uso_Funciones
{
    internal class Program
    {
        static void header()
        {
            Console.WriteLine("Bienvenido al curso programación orientada a objetos");
            Console.WriteLine("------------------------------------------------------");
        }
        static double Sumar(double numero1, double numero2)
        {
            return (numero1 + numero2);
        }
        static double Resta(double numero1, double numero2)
        {
            return (numero1 - numero2); 
        }
        static double Multiplicacion(double numero1, double numero2)
        {
            return (numero1 * numero2);
        }
        static double Division(double numero1, double numero2)
        {
            return (numero1 / numero2);
        }
        static void Nombre(string mensaje)
        {
            Console.WriteLine($"Nombre del programa:{mensaje}");
        }
        static void Main(string[] args)
        {
            string programa = "Aprendiendo funciones";
            string respuesta;
            header();
            Nombre(programa);
            do
            {


                Console.WriteLine("¿Qué función quieres hacer? \n1.Suma \n2.Resta\n3.Multiplicación\n4.División");
                int variable = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el primer número");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo número");
                double numero2 = Convert.ToDouble(Console.ReadLine());
                switch (variable)
                {
                    case 1:
                        Console.WriteLine($"El resultado de la función es:{Sumar(numero1, numero2)}");
                        break;
                    case 2:
                        Console.WriteLine($"El resultado de la función es: {Resta(numero1, numero2)}");
                        break;
                    case 3:
                        Console.WriteLine($"El resultado de la función es: {Multiplicacion(numero1, numero2)}");
                        break;
                    case 4:
                        Console.WriteLine($"El resultado de la función es: {Division(numero1, numero2)}");
                        break;
                }
                Console.WriteLine("¿Quieres hacer otra operación? sí/no");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta == "si");
            Console.WriteLine("Ha finalizado el programa");
            Console.ReadKey();
        }
    }
}
