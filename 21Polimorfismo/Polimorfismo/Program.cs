using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo myRectangulo = new Rectangulo();
            myRectangulo.CalcularArea(2,3);

            Cuadrado myCruadrado = new Cuadrado();
            myCruadrado.CalcularArea(2);

            Console.WriteLine("El perimettro es:"+myCruadrado.CalcularPerimetro(2, 3));

            Console.WriteLine("Presione enter para salir");
            Console.ReadKey();
        }
    }
}
