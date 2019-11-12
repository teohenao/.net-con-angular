using System;
using System.Collections.Generic;
using System.Text;

namespace LabEncapsulamiento
{
    class Division
    {
        public static double dividir(int num1, int num2)
        {
            if (num2 != 0) {
                double r = num1 / num2;
                Console.WriteLine("el resultado de la division es : " + r);
                return r;
            }
            else {
                Console.WriteLine("la division se indetermina, escriba un numero distinto de 0");
                int num3 = int.Parse(Console.ReadLine());
                return dividir(num1, num3); 
            }
            

        }
    }
}
