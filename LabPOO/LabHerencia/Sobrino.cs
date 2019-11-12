using System;
using System.Collections.Generic;
using System.Text;

namespace LabHerencia
{
    class Sobrino: Padre
    {

        public void ponerQueja()
        {
            Console.WriteLine("estoy colocando una queja de mi tio");
        }

        public void esconderse()
        {
            Console.WriteLine("me estoy escondiendo");
        }

    }
}
