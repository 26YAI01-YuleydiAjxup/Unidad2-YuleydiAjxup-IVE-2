using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2_Lecc7_Inciso2_Calificaciones
{
    internal class Act2_Lecc7_Inciso2
    {
        static void Main(string[] args)
        {
            double nota;
            Console.WriteLine("Ingrese la calificación");
            nota = double.Parse(Console.ReadLine());

            if (nota < 60)
                Console.WriteLine("Deficiente");
            else if (nota < 70)
                Console.WriteLine("Regular");
            else if (nota < 80)
                Console.WriteLine("Bien");
            else if (nota < 90)
                Console.WriteLine("Muy bien");
            else
                Console.WriteLine("Excelente");
        }
    }
}
