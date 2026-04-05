using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2_lecc7_inciso1_BuzonDeVoz
{
    internal class Act2_lecc7_inciso1
    {
        static void Main(string[] args)
        {
            int opción;
            Console.WriteLine("BUZÓN DE VOZ");
            Console.WriteLine("Escriba el número deseado");
            Console.WriteLine("1. Ventas");
            Console.WriteLine("2. Soporte técnico");
            Console.WriteLine("3. Atención al cliente");
            Console.WriteLine("4. Salir");
            opción = int.Parse(Console.ReadLine());

            if (opción == 1)
                Console.WriteLine("Has seleccionado Ventas");
            else if (opción == 2)
                Console.WriteLine("Has seleccionado Soporte técnico");
            else if (opción == 3)
                Console.WriteLine("Has seleccionado Atención al cliente");
            else if (opción == 4)
                Console.WriteLine("Gracias por llamar");
            else
                Console.WriteLine("Opción inválida");
        }
    }
}
