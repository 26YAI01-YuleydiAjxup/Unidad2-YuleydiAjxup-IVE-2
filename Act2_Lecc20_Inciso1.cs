using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2_Lecc20_Inciso1_Contraseña 
{
    internal class Act2_Lecc20_Inciso1 
    {
        static void Main(string[] args)
        {
            string clave;

            Console.WriteLine("Ingrese la contraseña");
            clave = Console.ReadLine();

            if (clave == "Password123") {
                Console.WriteLine("Bienvenido");
            }
            else{
                Console.WriteLine("Acceso Prohibido");
            }

        }
    }
}
