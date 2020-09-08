using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _12InstruccionesBreakContinueGoto
{
    class Program
    {
        static void Main(string[] args)
        {                       
            for (int id = 0; id <= 20; id++)
            {
                Thread.Sleep(600);//Volver lento los mensajes
                if (id == 4)
                {
                    Console.WriteLine();
                    //goto liquidacion;//Goto o ir a:
                    //continue;//Se utiliza para realizar un salto en la estructura repetitiva.
                    if (id <= 2)
                    {
                        Console.WriteLine("va salir");
                        break;//Se utiliza para salir de la estructura repetitiva.
                    }
                }
                Console.WriteLine(id);                
            }
            
        //liquidacion:
            Console.WriteLine("Salto desde el goto");
            Console.WriteLine("enter para salir");
            Console.ReadLine();
        }        
    }
}
