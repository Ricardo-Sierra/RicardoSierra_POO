using System;

namespace Examen2
{
    public abstract class Empleado
    {
        //ATRIBUTOS
        public string Nombre {  get; set; }
        public string Puesto { get; set; }
        public double Sueldo { get; set; }

        //CONSTRUCTOR
        public Empleado(string nombre, string puesto, double sueldo) 
        { 
            Nombre = nombre;
            Puesto = puesto;
            Sueldo = sueldo;
        }

        //METODOS
        public abstract void CalcularSueldo();
        public void MostrarDatos()
        {
            Console.WriteLine($"INFORMACIÓN DEL EMPLEADO\nNombre:{Nombre}\nPuesto que ocupa:{Puesto}");
        }
    }
    //La Herencia se aplica en estos momentos, cuando las siguientes clases derivan de la clase empleado con todos sus atributos y métodos
    //El polimorfismo se aplica cuando un método o una clase se puede comportar de manera distinta, como lo es el metodo CalcularSueldo()
    //Este diseño es bastante últil cuando se quiere trabajar con elementos que tienen características en común, pero igual tienen otras que varían
    //así como el uso de un mismo método para cada tipo de caso que se necesite
    public class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(string nombre, string puesto, double sueldo) : base(nombre, puesto, sueldo) { }
        public override void CalcularSueldo()
        {
            double sueldomensual = Sueldo;
            Console.WriteLine($"El Sueldo calculado es ${sueldomensual}");
            
        }
    }
    public class EmpleadoPorHoras : Empleado
    { 
        public int Horas { get; set; }
        public EmpleadoPorHoras(string nombre, string puesto, double sueldo, int horas) : base(nombre, puesto, sueldo)
        {
            Horas = horas;
        }
        public override void CalcularSueldo()
        {
            double sueldohoras = Sueldo * Horas;
            Console.WriteLine($"El sueldo calculado es ${sueldohoras}");
        }
    }
    public class EmpleadoPorComision : Empleado
    {
        public double PorcentajeComision { get; set; }
        public EmpleadoPorComision(string nombre, string puesto, double sueldo, double porcentajeComision) : base(nombre, puesto, sueldo)
        {
            PorcentajeComision = porcentajeComision;
        }
        public override void CalcularSueldo()
        {
            double sueldocomision = Sueldo * (PorcentajeComision/100);
            Console.WriteLine($"El sueldo calculado es: ${sueldocomision}");
        }
    }
    public class EmpleadoMixto : Empleado
    { 
        public double TotalVentas { get; set; }
        public double PorcentajeComision { get; set; }
        public EmpleadoMixto(string nombre, string puesto, double sueldo, double porcentajeComision, double totalventas) : base(nombre,puesto,sueldo)
        {
            TotalVentas = totalventas;
            PorcentajeComision = porcentajeComision;
        }
        public override void CalcularSueldo()
        {
            double sueldomixto = Sueldo +(TotalVentas * (PorcentajeComision/100));
            Console.WriteLine($"El sueldo calculado es ${sueldomixto}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            string nombre;
            string puesto;
            double sueldo;
            int horas;
            double porcentajeComision;
            double totalventas;
            do
            {
                Console.WriteLine("============REGISTRO DE EMPLEADOS============");
                Console.WriteLine("Selecciona el tipo de empleado\n1.Empleado por tiempo completo\n2.Empleado por Horas\n3.Empleado por Comisión\n4.Empleado Mixto");
                respuesta = Convert.ToInt32(Console.ReadLine());
            } while (respuesta < 1 || respuesta > 4);
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu puesto");
            puesto = Console.ReadLine();
            switch (respuesta)
            {
                case 1: 
                    Console.WriteLine("Ingresa tu sueldo por mes");
                    sueldo = Convert.ToDouble(Console.ReadLine());
                    EmpleadoTiempoCompleto empleadotiempocompleto = new EmpleadoTiempoCompleto(nombre,puesto,sueldo);
                    empleadotiempocompleto.MostrarDatos();
                    empleadotiempocompleto.CalcularSueldo();
                    break;
                case 2:
                    Console.WriteLine("Ingresa tu sueldo por hora");
                    sueldo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa las horas trabajadas");
                    horas = Convert.ToInt32(Console.ReadLine());
                    EmpleadoPorHoras empleadoporhoras = new EmpleadoPorHoras(nombre,puesto,sueldo,horas);
                    empleadoporhoras.MostrarDatos();
                    empleadoporhoras.CalcularSueldo();
                    break;
                case 3:
                    Console.WriteLine("Ingresa el total de ventas");
                    sueldo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el porcentaje de comisión");
                    porcentajeComision = Convert.ToDouble(Console.ReadLine());
                    EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision(nombre,puesto,sueldo,porcentajeComision);
                    empleadoPorComision.MostrarDatos();
                    empleadoPorComision.CalcularSueldo();
                    break;
                case 4:
                    Console.WriteLine("Ingresa el sueldo base");
                    sueldo= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el total de ventas");
                    totalventas = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el porcentaje de comisión");
                    porcentajeComision = Convert.ToDouble(Console.ReadLine());
                    EmpleadoMixto empleadomixto = new EmpleadoMixto(nombre,puesto,sueldo,porcentajeComision,totalventas);
                    empleadomixto.MostrarDatos();
                    empleadomixto.CalcularSueldo();
                    break;
            }
            Console.ReadKey();
        }
    }
}
