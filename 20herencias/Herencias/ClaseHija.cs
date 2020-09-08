using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{    
    class ClaseHija : ClasePadre//Clase hija hereda todo de la clase padre.
    {
        public void saludardelaclasehija()
        {
            Console.WriteLine("Hola soy la clase hija");
        }
    }
}
