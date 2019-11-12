using System;
using System.Collections.Generic;
using System.Text;

namespace LabAbstraccion
{
    class Quindio : EquipoFutbol
    {
        public override string colorEquipo()
        {
            return "blanco";
        }

        public override void formacion()
        {
            throw new NotImplementedException();
        }

        public override string nombreEquipo()
        {
            return "Quindio";
        }
    }
}
