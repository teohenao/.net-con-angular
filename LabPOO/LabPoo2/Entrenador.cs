using System;
using System.Collections.Generic;
using System.Text;

namespace LabPoo2
{
    class Entrenador: SeleccionFutbol
    {
        public string idFederacion;

        public void dirigirPartido()
        {
            Console.WriteLine("dirigiendo partido");
        }

        public void dirigirEntrenamiento()
        {
            Console.WriteLine("dirigiendo entrenamiento");
        }
    }
}
