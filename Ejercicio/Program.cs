using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //double interes = 0.02;
            //double cuota = 340000;
            //double interes2 = 0.21;
            double interestotal = 1619047;
            double diasmora=0;
            double interesmora = 0;
            DateTime consignacion;
            Console.WriteLine("::::::::::: Mariana, Bienevenida al Banco BBVA :::::::::::");
            Console.WriteLine("Por favor ingresa la fecha para la consignacion en el formato (DD/MM/AAAA):");
            consignacion = Convert.ToDateTime(Console.ReadLine());
            int dia = consignacion.Day;
            int mes = consignacion.Month;
            int año = consignacion.Year;
            int diames = DateTime.DaysInMonth(año, mes);
            diasmora = dia - 5;
            interesmora = interestotal * 0.02*diasmora;
            Console.WriteLine($"La fecha ingresada es {dia}/{mes}/{año}");
            
            if (dia < 5)
            { 
                Console.WriteLine($"el valor a pagar a la fecha de hoy es de: {interestotal}");                        
            }
            else
            {
                Console.WriteLine($"la cantidad de dias en mora es de: {dia-5}");
                Console.WriteLine($"el total a pagar por los dias en mora es de: {interestotal + interesmora}");
            }
            Console.ReadLine();
            
        }
    }
}

