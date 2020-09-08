using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holamundo3
{
    class Program
    {
        private static string miNombre = "";
        static void Main(string[] args)
        {
            Console.WriteLine("digite su nombre");
            miNombre = Console.ReadLine();
            Console.WriteLine("hola "+miNombre);
            Console.WriteLine("Digite una tecla para salir");
            Console.ReadLine();
        }
    }
}
