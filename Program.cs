using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inciso1_Actividad1_Leccion_7_Promedio 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, promedio;
            Console.WriteLine("Ingrese 5 notas");
            n1 = double.Parse(Console.ReadLine());
            n2= double.Parse(Console.ReadLine());
            n3= double.Parse(Console.ReadLine());
            n4= double.Parse(Console.ReadLine());
            n5 = double.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3 + n4 + n5) / 5;

            if (promedio >= 70){
                Console.WriteLine("Aprobado");
            }
            else{
                Console.WriteLine("Reprobado");
            }
        }
    }
}
