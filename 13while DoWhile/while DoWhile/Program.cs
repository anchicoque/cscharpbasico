//date: 15-08-2020
//for: AAC
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_DoWhile
{
    class Program
    {
        static int cont = 1;       
       
        static void Main(string[] args)
        {

            while (cont < 5)
            {
                //Console.WriteLine("Hola a todos desde el While");  //Bucle infinito
                Console.WriteLine("contador =" + cont);
                cont++;
            }         

            do
            {
                Console.WriteLine("entre al DoWhile y el contador es mayor de 5");  //Bucle infinito
                cont++;
                Console.WriteLine("contador ="+cont);                    
            } while (cont < 2);
           

            Console.WriteLine("Presione enter para salir");
            Console.ReadLine();
        }
    }
}
