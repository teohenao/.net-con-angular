using System;
using System.Collections.Generic;
using System.Text;

namespace LabHerencia
{
    class Padre
    {
        public string nombre;
        public string primerApellido = "henao";
        public string segundoApellido;

        public void bailar()
        {
            Console.WriteLine("bailando");
        }

        public void cantar()
        {
            Console.WriteLine("cantando");
        }

    }
}
