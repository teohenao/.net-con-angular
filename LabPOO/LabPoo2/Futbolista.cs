using System;
using System.Collections.Generic;
using System.Text;

namespace LabPoo2
{
    class Futbolista: SeleccionFutbol
    {
        public int dorsal;
        public string demarcacion;

        public void jugarPartido()
        {
            Console.WriteLine("jugando partido");
        }

        public void entrenar()
        {
            Console.WriteLine("entrenando");
        }
    }
}
