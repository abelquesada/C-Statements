using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Por favor ingrese un numero");
            value = Convert.ToInt32(Console.Read());

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("el valor i es " + i);  
            }
            int u = value;
            while(u > 0)
            {
                Console.WriteLine("el valor de u es" + u);
                u--;
            }

            bool active = true;
            while (active)
            {
                Console.WriteLine("el estado es " + active);
                active = false;

            }
            Console.WriteLine(value);


            Console.ReadKey();


        }
        
    }
}
