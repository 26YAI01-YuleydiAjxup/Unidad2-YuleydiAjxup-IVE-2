using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeLaPágina86
{
    internal class EjemploDeLaPágina86 
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Introduzca un número:");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("El número es menor a cero");
            }
            else{
                Console.WriteLine("El número es igual o mayor a cero");
            }
        }
    }
}
