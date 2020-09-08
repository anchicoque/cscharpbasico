using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacesejemplo
{
    interface IFacturas
    {
        //int monto;
        double RalculaIva(double monto);        
        int RedondeaMonto(double monto);       
    }
}
