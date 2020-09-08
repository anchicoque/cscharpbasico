using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class ClasePadre
    {
        private String miVariablePrivadaPadre = "Variable privada, no se puede llamar desde la instancia";
        public String miVariablePublicaPadre = "Variable publica desde la clase padre";
        
        //Metodos
        public void Saludar()
        {
            Console.WriteLine("Hola soy la clase padre");
        }

        public void Despedirse()
        {
            Console.WriteLine("Recuerdamo soy tu padre. Adios...");
        }

        private void clasePrivada()
        //public void clasePrivada()
        {
            Console.WriteLine("Esta clase es privada, no se puede llamar desde la instancia");
        }
    }
}
