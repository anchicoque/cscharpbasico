using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IFacturas
    {

        decimal CalculaIgv(decimal monto);
        int redondeaMonto(decimal monto);

    }
}
