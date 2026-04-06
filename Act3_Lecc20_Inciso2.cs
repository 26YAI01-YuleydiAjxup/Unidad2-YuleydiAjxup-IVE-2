using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act3_Lecc20_Inciso2_Aprobado_Reprobado 
{
    internal class Act3_Lecc20_Inciso2 
    {
        static void Main(string[] args)
        {
            double nota;

            Console.WriteLine("Ingrese la calificación:");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 70) {
                Console.WriteLine("Aprobado");
            }
            else {
                Console.WriteLine("Reprobado");
            }
        }
    }
}
