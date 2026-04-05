using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act3_Lecc7_Inciso2_TipoDeTriangulo 
{
    internal class Act3_Lecc7_Inciso2 
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Ingrese los tres ángulos:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Triángulo Equilátero");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Triángulo Isósceles");
            else
                Console.WriteLine("Triángulo Escaleno");
        }
    }
}
