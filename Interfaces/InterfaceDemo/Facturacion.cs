using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Facturacion : IFacturas
    {

        public decimal CalculaIgv(decimal monto)
        {
            decimal IGV = 0.18M;

            return monto * IGV;
        }

        public int redondeaMonto(decimal monto)
        {
            return (int) Math.Round(monto);
        }
    }
}
