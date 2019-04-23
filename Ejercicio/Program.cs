using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double interes = 0.02;
            var dia = 10;
            double cuota = 340000;
            double interes2 = 0.21;
            double interestotal = 1619047;
            double diasmora = dia-5;
            double interesmora = interestotal*0.02*diasmora;
            
            Console.WriteLine("::::::::::: Mariana, Bienevenida al Banco BBVA :::::::::::");
            Console.WriteLine("Por favor ingresa la fecha:");
            Console.WriteLine("Ingrese el dia: ");
            dia = Console.ReadLine();
            Console.WriteLine("Ingrese el mes: ");
            Console.ReadLine();
            Console.WriteLine("ingrese el año: ");
            Console.ReadLine();
            Console.WriteLine($"La fecha ingresada es {dia}/{mes}/{año}");
            
            if (dia < 5)
            { 
                Console.WriteLine($"el valor a pagar a la fecha de hoy es de: {interestotal}");                        
            }
            else
            {
                Console.WriteLine($"la cantidad de dias en mora es de: {diasmora}");
                Console.WriteLine($"el total a pagar por los dias en mora es de: {interestotal + interesmora}");
            }
            Console.ReadLine();
            
        }
    }
}

