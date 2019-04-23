using System;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            int prestamo = 17000000;
            var interes = 0.02;
            int plazo = 12;
            var fecha = new DateTime();
            var dia="";
            var año="";
            var mes="";
            Console.WriteLine("Ingrese el dia: ");
            dia = Console.ReadLine();
            Console.WriteLine("Ingrese el mes: ");
            mes = Console.ReadLine();
            Console.WriteLine("ingrese el año: ");
            año = Console.ReadLine();
            Console.WriteLine($"La fecha ingresada es {fecha}");
            Console.ReadLine();
        }
    }
}
