using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    class Program
    {
        static string miColor;        
        static void Main(string[] args)
        {
            Console.WriteLine("digiyte el color de la ventana");
            miColor = Console.ReadLine();
            //Ventana miVentana = new Ventana();//Se crea un objeto.
            Ventana miVentana = new Ventana(miColor);        //Se crea un objeto.
            miVentana.Mostrar();//Se llama un metodo del objeto creado.
            Console.WriteLine(miVentana.miMensaje);

            Console.WriteLine("Preione una tecla para salir del metodo Main");
            Console.ReadKey();
        }
    }
        
    class Ventana
    {
        //Atributos.
        private int ancho, altura;
        private string color;
        public string miMensaje = "mi mensaje";
                
        /*
        //Constructor.
        public Ventana()
        {
            ancho = 15;
            altura = 20;
            color = "Rojo";
        }
        */
        
        //Constructor
        public Ventana(string miColor)
        {
            ancho = 15;
            altura = 20;
            color = miColor;
        }
        

        //Metodos.
        public void Mostrar()
        {
            Console.WriteLine("La dimencion de la ventana es: {0} x {1} y su color es: {2}", ancho, altura, color);
        }

        ~Ventana()      //Metodo destructor, no es necesario.
        {
            //System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos");
            Console.WriteLine("Entra al metodo destructor");
            Console.ReadKey();
        }
    }
}
