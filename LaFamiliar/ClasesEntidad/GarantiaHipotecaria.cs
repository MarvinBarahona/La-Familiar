using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class GarantiaHipotecaria
    {
        private string _direccion;
        private string _matricula;
        private string _medidas;
        private GarantiaFiador _fiador;

        public string direccion { get { return _direccion; } set { _direccion = value; } }
        public string matricula { get { return _matricula; } set { _matricula = value; } }
        public string medidas { get { return _medidas; } set { _medidas = value; } }
        public GarantiaFiador fiador { get { return _fiador; } set { _fiador = value; } }

        public GarantiaHipotecaria(String direccion, String matricula, String medidas) {
            this.direccion = direccion;
            this.matricula = matricula;
            this.medidas = medidas;
        }

        public GarantiaHipotecaria() { }
    }
}
