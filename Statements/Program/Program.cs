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
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 'b':
                        concatenateStrings();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 'c':
                        loopNumber();
                        Console.ReadLine();
                        Console.Clear();
                        break;
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
            int valor;
            Console.WriteLine("Por favor ingrese un numero");
            Console.ReadLine();
            valor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine("el valor i es " + i);
            }
            int u = valor;
            while (u > 0)
            {
                Console.WriteLine("el valor de u es" + u);
                u--;
            }
            Console.ReadKey();
            bool active = true;
            while (active)
            {
                Console.WriteLine("el estado es " + active);
                active = false;
                Console.ReadLine();
            }
        }

        private static void concatenateStrings()
        {
            Console.WriteLine("\n Por favor ingrese una palabra");
            Console.ReadLine();
            string palabradigitada1 = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("\n Por favor ingrese otra palabra");
            string palabradigitada2 = Console.ReadLine();
            Console.WriteLine("las palabra unidas son:   " + palabradigitada1 + palabradigitada2);
        }

        private static void addValues()
        {
            /*int numero1 = 0;
            Console.WriteLine("Por favor ingrese un numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero1);
            Console.ReadKey();
            int numero2 = 0;
            Console.WriteLine("Por favor ingrese otro numero");
            numero2 = Convert.ToInt32(Console.Read());
            Console.WriteLine(numero2);
            Console.ReadKey();
            int sumatoria= numero1 + numero2;
            Console.WriteLine("la suma de los valores es: ");
            Console.WriteLine(sumatoria);
            return;*/

      
            Console.WriteLine("\n Por favor ingrese un numero");
            Console.ReadLine();
            string numerodigitado1 = Console.ReadLine();
            int numero1;
            int.TryParse(numerodigitado1, out numero1);
            Console.WriteLine("el numero digitado fue" + numero1);

            Console.WriteLine("\n Por favor ingrese otro numero");
            string numerodigitado2 = Console.ReadLine();
            int numero2;
            int.TryParse(numerodigitado2, out numero2);
            Console.WriteLine("el numero digitado fue" + numero2);

            int sumatoria;
            sumatoria = numero1 + numero2;
            Console.WriteLine("\n La suma de los numeros es:" + sumatoria);
            return;

                      
        }

        static char printmenu()
        {
            Console.WriteLine("\n seleccione una opcion");
            Console.WriteLine("\n A sumar dos valores");
            Console.WriteLine("\n B concatenar dos textos");
            Console.WriteLine("\n C Iterar un numero \n");
            Console.WriteLine("\n D salir");
            char option = (char)Console.Read();
            return option;

        }
    }
}
