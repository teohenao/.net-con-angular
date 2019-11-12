using System;
using System.Collections.Generic;
using System.Text;

namespace LabAbstraccion
{
    public  abstract class EquipoFutbol
    {
        public abstract string nombreEquipo();
        public abstract string colorEquipo();

        public  abstract void formacion();

        public void calentamiento()
        {
            Console.WriteLine("calentamiento del equipo");
        }
    }
}
