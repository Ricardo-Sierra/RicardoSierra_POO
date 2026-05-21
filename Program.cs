using System;

namespace Clases_ejemplo
{
    public class Persona
    {
        public int Id { get; set; } //Get es para dar y el set es para poder modificar el valor D:
        public string Name { get; set; }
        public string Apellidos { get; set; }
        public string Sex { get; set; } = string.Empty;
        public string Curp { get; set; }
        public int Edad {  get; set; }

        //constructor

        public Persona(string nombre, string apellidos)
        {
          Name = nombre;
            Apellidos = apellidos;
        }
        public Persona()
        {

        }
        public Persona(string nombre)
        {
            Name = nombre;
        }
        public Persona(int id, string nombre, string apellidos, string sex, string curp)
        {
            Id = id;
            Name = nombre;
            Apellidos = apellidos;
            Sex = sex;
            Curp = curp;
        }   
     }


    internal class Program
    {
        static string MayorEdad(int edad)
        {
            if (edad >= 18)
            {
                return "Eres mayor de edad";
            }
            else
            {
                return "No eres mayor de edad";
            }
        }
        static void Main(string[] args)
        {
            //Instanciar la clase

            Persona persona2 = new Persona(1, "juan", "Sanchez", "H", "juanprogamer");
            Console.WriteLine($"{persona2.Name} {persona2.Apellidos}");
            
            Persona persona1 = new Persona("Mariana", "Perez");
            persona1.Name = "Alicia";
            persona1.Curp = "PADFTHQSH2466704";
            Console.WriteLine($"{persona1.Name} {persona1.Apellidos}\n{persona1.Curp}");

            Persona persona3 = new Persona();
            persona3.Name = "Jorge";
            Console.WriteLine($"{persona3.Name}");
            persona3.Curp = "DJROWHRAJAFH405865";


            Persona persona4 = new Persona("Samuel", "M");

            Persona persona5 = new Persona();
            Console.WriteLine("Ingresa tu edad");
            persona5.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tu edad es {persona5.Edad} y {MayorEdad(persona5.Edad)}");
            Console.ReadKey();
        }
    }
}
