using System;

namespace Examen1
{
    class MascotaVirtual
    {
        private string Nombre { get; set; }
        private int Hambre { get; set;}
        private int Felicidad { get; set; }

        //Constructor
        public void RegistroMascota()
        {
            string nombre = "";
            do
            {
                Console.WriteLine("Esta es tu nueva mascota :) ¿Cuál es su nombre?");
                nombre = Console.ReadLine();
            } while (nombre == null);
            Nombre = nombre;
            Hambre = 50;
            Felicidad = 50;
        }
        //Métodos Públicos
        public void Alimentar()
        {
            Hambre -= 20;
            ValidarRango();
            Console.WriteLine($"{Nombre} está comiendo. Su nivel de hambre ahora es de {Hambre}");
        }

        public void Jugar()
        {
            Felicidad += 15;
            Hambre += 5;
            ValidarRango();
            Console.WriteLine($"Jugaste con {Nombre}. Su nivel de Felicidad es de {Felicidad} y su nivel de hambre es de {Hambre}");
        }
        public void EstaSaludable ()
        {
            if ( Hambre < 70 && Felicidad > 30)
            {
                Console.WriteLine("Tu mascota está saludable :)");
            } else
            { Console.WriteLine("Tu mascota no está sana. Tienes que cuidarla más :(");}
        }
         private void ValidarRango()
        {
            if(Hambre <= 0)
            { Hambre = 0;}
            if(Hambre >= 100)
            { Hambre = 100;}
            if(Felicidad <= 0)
            {  Felicidad = 0;}
            if (Felicidad >= 100)
            { Felicidad = 100;}
        }
        public void MostrarEstado()
        {
            Console.WriteLine($"El nombre de tu mascota es {Nombre}\nSu nivel de felicidad es de {Felicidad}\nSu nivel de hambre es de {Hambre} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            string respuesta2;
            MascotaVirtual mascota = new MascotaVirtual();
            mascota.RegistroMascota();
            Console.WriteLine("============= INFORMACION DE LA MASCOTA =====================");
            mascota.MostrarEstado();
            Console.WriteLine("=============================================================");
            do
            {
                Console.WriteLine("¿Qué quieres hacer?\n1.Alimentar mascota\n2.Jugar con la mascota\n3.Ver salud de la mascota\n4.Mostrar información de la mascota");
                respuesta = Convert.ToInt32(Console.ReadLine());
                switch (respuesta)
                {
                    case 1:
                        mascota.Alimentar();
                        break;
                    case 2:
                        mascota.Jugar();
                        break;
                    case 3:
                        mascota.EstaSaludable();
                        break;
                    case 4:
                        mascota.MostrarEstado();
                        break;
                }
                Console.WriteLine("¿Quieres hacer otra acción?");
                respuesta2 = Console.ReadLine().ToLower();
            } while (respuesta2 == "si");
            Console.WriteLine("El estado de tu mascota quedó así:");
            mascota.MostrarEstado();
            Console.ReadKey();
        }
    }
}
