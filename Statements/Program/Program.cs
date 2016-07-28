using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            while (proceed)
            {
                char selection = printmenu();
                switch (selection)
                {
                    case 'a':
                        addValues();
                        break;
                    case 'b':
                        concatenateStrings();
                        break;
                    case 'c':
                        break;
                        loopNumber();
                    case 'd':
                        proceed = false;
                        Console.WriteLine("Adios");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
                
            }
        }

        private static void loopNumber()
        {
            throw new NotImplementedException();
        }

        private static void concatenateStrings()
        {
            throw new NotImplementedException();
        }

        private static void addValues()
        {
            throw new NotImplementedException();
        }

        static char printmenu()
        {
            Console.WriteLine("seleccione una option");
            Console.WriteLine("a sumar dos valores");
            Console.WriteLine("b concatenar dos textos");
            Console.WriteLine("c Iterar un numero \n");
            Console.WriteLine("d salir");
            char option = (char)Console.Read();
            return option;

        }
    }
}
