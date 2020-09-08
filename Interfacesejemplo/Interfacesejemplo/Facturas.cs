using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacesejemplo
{
    class Facturas : IFacturas
    {
        public double RalculaIva(double monto)
        {
            double IVA = 0.19;
            return monto * IVA;
        }

        public int RedondeaMonto(double monto)
        {
            return (int)Math.Round(monto);
        }
    }
}
