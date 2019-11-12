using System;
using System.Collections.Generic;
using System.Text;

namespace LabAbstraccion
{
    class Nacional : EquipoFutbol
    {
        public override string colorEquipo()
        {
            return "verde";
        }

        public override void formacion()
        {
            throw new NotImplementedException();
        }

        public override string nombreEquipo()
        {
            return "Nacional";
        }
    }
}
