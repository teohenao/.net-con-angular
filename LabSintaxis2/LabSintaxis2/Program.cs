using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto = Console.ReadLine();
            validarMensaje(inputTexto);
            void validarMensaje(String t)
            {
                if (t == "")
                {
                    Console.WriteLine("no ingreso nada");
                    Environment.Exit(1);
                }
            }
            Console.WriteLine("Seleccione una opcion por favor \n" +
                "1- mostrar palabra en mayuscula \n" +
                "2- mostrar flase en minuscula \n" +
                "3- mostrar cantidad de caracteres");
            ConsoleKeyInfo opcion = Console.ReadKey();
            opcionElegida();
            void opcionElegida()
            {
                if (opcion.Key == ConsoleKey.D1)
                {
                    String salida = inputTexto.ToUpper();
                    Console.WriteLine(salida);
                }
            }

            Console.WriteLine(opcion.Key);

            Console.ReadLine();
        }
    }
}            