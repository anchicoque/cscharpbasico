using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Facturacion facturas = new Facturacion();

            decimal monto = 100.15M;

            Console.WriteLine("El IGV es : " + facturas.CalculaIgv(monto).ToString());
            Console.WriteLine("El monto redondeado es : " + facturas.redondeaMonto(monto).ToString());
            Console.ReadLine();
        }
    }
}
