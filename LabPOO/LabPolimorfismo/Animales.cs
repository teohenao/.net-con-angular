using System;
using System.Collections.Generic;
using System.Text;

namespace LabPolimorfismo
{
    class Animales
    {
        public string nombre;
        public string color;
        public string tamanio;

        public void comer()
        {
            Console.WriteLine("comiendo");
        }

        public void dormir()
        {
            Console.WriteLine("durmiendo");
        }

        public void morir()
        {
            Console.WriteLine("muriendo");
        }

        public void saltar()
        {
            Console.WriteLine("saltando");
        }
    }
}
