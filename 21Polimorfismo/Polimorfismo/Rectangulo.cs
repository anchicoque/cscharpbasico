using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo{
    
    class Rectangulo
    {
        public static int perimetroRectangulo = 0;
        public void CalcularArea(int Base, int Altura)//Metodo Original en la clase padre
        {
            Console.WriteLine("El area del rectangulo es: " + (Base * Altura));
        }

        public int CalcularPerimetro(int Base, int Altura)
        {
            perimetroRectangulo = Base * Altura;
            Console.WriteLine("");
            return perimetroRectangulo;
        }
    }
}
