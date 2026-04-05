using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inciso2_Act1_Lecc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad en números");
            edad = int.Parse(Console.ReadLine());

            if (edad>= 18) {
                Console.WriteLine("Es mayor de edad");
            }
            else{
                Console.WriteLine("Es menor de edad");
            }
        }
    }
}
