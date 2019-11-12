using System;

namespace LabEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer valor");
            String numero = Console.ReadLine();
            int n1 = int.Parse(numero);
            Console.WriteLine("ingrese el segundo valor");
            String numero2 = Console.ReadLine();
            int n2 = int.Parse(numero2);

            Suma.suma(n1, n2);
            Resta.resta(n1, n2);
            Multiplicacion.multiplicacion(n1, n2);
            Division.dividir(n1, n2);
            Console.WriteLine("PRESIONE ENTER PARA SALIR");
            Console.Read();
            Environment.Exit(1);

        }
    }
}
