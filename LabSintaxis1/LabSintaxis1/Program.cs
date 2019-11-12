using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis1
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1 = "Este es el valor 1";
            int valor2 = 5;
            string valor3 = valor1;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine("presione una tecla para ver el ultimo valor ");
            Console.ReadKey();
            Console.WriteLine(valor3);
        }
    }
}
