using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int interes = 2 / 100;
            int plazo = 12;
            int dia = 1;
            int cuota = (interes * 17000000);
            double interes2 = (1 - (1 + interes));
                double interestotal= Math.Pow(interes2,-12);
            double cuota2 = (interestotal / cuota);
            //DateTime consignacion;
            //Console.WriteLine("::::::::::: Mariana, Bienevenida al Banco BBVA :::::::::::");
            //Console.WriteLine("Por favor ingresa la fecha:");
            //Console.WriteLine("Ingrese el dia: ");
            //Console.ReadLine();
            //Console.WriteLine("Ingrese el mes: ");
            //Console.ReadLine();
            //Console.WriteLine("ingrese el año: ");
            //Console.ReadLine();
            //consignacion = Convert.ToDateTime(Console.ReadLine());
            //int dia = consignacion.Day;
            //int mes = consignacion.Month;
            //int año = consignacion.Year;
            //Console.WriteLine($"La fecha ingresada es {dia}/{mes}/{año}");
            //
            if (dia < 5)
            { 
                Console.WriteLine($"el valor a pagar a la fecha de hoy es de: {cuota2},{cuota},{interes2}");
            
            }
            Console.ReadLine();
        }
    }
}

