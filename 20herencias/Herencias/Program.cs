//Date: 23-10-2018 -> 15-08-2020
//for: AAC
//Description: Herencia de clases
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Herencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseHija miClaseHija = new ClaseHija();  //Crea un objeto de la ClaseHija que hereda de la ClasePadre.
            miClaseHija.saludardelaclasehija();       //Metodo no heredado corresponde a la clase hija
            miClaseHija.Saludar();                    //Se puede utilizar los metodos heredados.
            miClaseHija.Despedirse();                 //Se puede utilizar los metodos heredados.            
            Console.WriteLine(miClaseHija.miVariablePublicaPadre);//Llamo a la una variable publica de la clase padre.
            //Console.WriteLine(miClaseHija.miVariablePrivadaPadre);
            Console.WriteLine("Fin desde main");
            Console.ReadKey();
        }
    }
}
