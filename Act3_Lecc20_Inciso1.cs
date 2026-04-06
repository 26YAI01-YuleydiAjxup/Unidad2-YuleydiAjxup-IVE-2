using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act3_Lecc20_Inciso1_DíaDeLaSemana 
{
    internal class Act3_Lecc20_Inciso1 
    {
        static void Main(string[] args)
        {
            int dia;

            Console.WriteLine("Ingrese un número del 1 al 7:");
            dia = int.Parse(Console.ReadLine());

            if (dia == 1 || dia == 7)
                Console.WriteLine("Fin de semana");
            else if (dia >= 2 && dia <= 6)
                Console.WriteLine("Entre semana");
            else
                Console.WriteLine("Número inválido");
        }
    }
}
