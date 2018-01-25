using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AsociadoDependencia
    {
        private byte _total;
        private byte _parcial;

        public byte total { get { return _total; } set { _total = value; } }
        public byte parcial { get { return _parcial; } set { _parcial = value; } }
    }
}
