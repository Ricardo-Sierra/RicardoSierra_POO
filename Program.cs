using System;


namespace Boletos_Avion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tipoboleto;
            double precio;
            double tua;
            double subtotal;
            double iva;
            double preciofinal;
            double descuento;
            double preciodescuento;
            Console.WriteLine("===== VENTA DE BOLETOS PARA CIUDAD DE MEXICO =====");
            Console.WriteLine("¿Cuántos boletos va a comprar?");
            int boleto = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("¿Qué tipo de viaje va a realizar");
                Console.WriteLine("1.Normal \n2.Redondo");
                tipoboleto = Convert.ToInt32(Console.ReadLine());
            } while (tipoboleto != 1 && tipoboleto != 2);
            switch (tipoboleto)
            {
                case 1:
                    precio = 1100 * boleto;
                    tua = precio * 0.12;
                    subtotal = precio + tua;
                    iva = subtotal * 0.16;
                    preciofinal = subtotal + iva;
                    Console.WriteLine("====VIAJE SENCILLO====");
                    Console.WriteLine($"Número de boletos a adquirir: {boleto}\nImporte unitario de boleto: $1100\nImporte por boletos adquiridos: ${precio}");
                    Console.WriteLine($"Importe del descuento: $0 \nImporte de boletos aplicando el descuento: ${precio}\n Importe del TUA: ${tua}");
                    Console.WriteLine($"Subtotal: ${subtotal}\n Importe del IVA: ${iva}\nIMPORTE TOTAL: ${preciofinal}");
                    break;

                case 2:
                    precio = 2000 * boleto;
                    Console.WriteLine("====VIAJE REDONDO====");
                    Console.WriteLine($"Número dde boletos a adquirir: {boleto}\nImporte unitario de boleto: $2000\nImporte por boletos adquiridos: ${precio}");
                    if (tipoboleto == 2 && boleto >= 3)
                    {
                        descuento = precio * 0.2;
                    }
                    else
                    {
                        descuento = 0;
                    }
                    preciodescuento = precio - descuento;
                    tua = preciodescuento * 0.12;
                    subtotal = preciodescuento + tua;
                    iva = subtotal * 0.16;
                    preciofinal = subtotal + iva;
                    Console.WriteLine($" Importe del descuento: ${descuento}\nImporte de boletos aplicando el descuento: ${preciodescuento}\n Importe del TUA ${tua}");
                    Console.WriteLine($"Subtotal: ${subtotal}\n Importe del IVA:${iva}\nIMPORTE TOTAL: ${preciofinal}");
                    break;
            }
          Console.ReadLine();
        }
        
    }
}
