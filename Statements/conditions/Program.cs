using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un caracter:  ");
            char c = (char)Console.Read(); /*el console.read espera un string, hay que hacer la conversion con (char) casting para que acepte un solo caracter */

            if (Char.IsLetter(c)) {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("el caracter es minuscula");
                }

                else
                {
                    Console.WriteLine("el caracter es mayuscula");
           
                }
                }


            else
            {
                Console.WriteLine("el caracter no es una letra");

            }

            Console.ReadKey();
        }
    }
}
