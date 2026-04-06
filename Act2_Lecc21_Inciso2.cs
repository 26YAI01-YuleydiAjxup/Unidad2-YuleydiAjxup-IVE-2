using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2_Lecc21_Inciso2_BuzónDeVoz 
{
    internal class Act2_Lecc21_Inciso2 
    {
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("*Buzón de Voz*");
            Console.WriteLine("1. Ventas");
            Console.WriteLine("2. Recepción");
            Console.WriteLine("3. Dirección");
            Console.WriteLine("4. Compras");
            op = int.Parse(Console.ReadLine());

            if (op == 1) {
                Console.WriteLine("Bienvenido a Ventas");
                Console.WriteLine("Encargado: José - ventas@empresa.com");
            }
            else if (op == 2){
                Console.WriteLine("Bienvenido a Recepción");
                Console.WriteLine("Encargado: María - recepcion@empresa.com");
            }
            else if (op == 3){
                Console.WriteLine("Bienvenido a Dirección");
                Console.WriteLine("Encargado: Luis - direccion@empresa.com");
            }
            else if (op == 4){
                Console.WriteLine("Bienvenido a Compras");
                Console.WriteLine("Encargado: Miguel - compras@empresa.com");
            }
            else{
                Console.WriteLine("Opción inválida");
            }
        }
    }
}
