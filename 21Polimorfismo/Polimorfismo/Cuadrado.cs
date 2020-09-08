using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Cuadrado : Rectangulo//Se extiende o hereda de Rectangulo
    {
        public void CalcularArea(int Base)//Metodo Heredado aplicando el polimorfismo
        {
            Console.WriteLine("El area del cuadrado es: " + ((Base * Base) ));
        }
    }
}
