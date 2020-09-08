using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacesejemplo
{
    class Program
    {
        static void Main(string[] args)
        {   
            double monto = 100.5;

            Facturas facturas = new Facturas();                       

            Console.WriteLine("El IVA es : " + facturas.RalculaIva(monto));
            Console.WriteLine("El monto redondeado es : " + facturas.RedondeaMonto(monto).ToString());
            Console.ReadLine();
        }
    }
}
