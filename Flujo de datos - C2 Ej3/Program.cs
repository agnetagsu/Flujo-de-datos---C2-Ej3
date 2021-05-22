using System;

namespace Flujo_de_datos___C2_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            string edad = Console.ReadLine();
            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años");
        }
    }
}
