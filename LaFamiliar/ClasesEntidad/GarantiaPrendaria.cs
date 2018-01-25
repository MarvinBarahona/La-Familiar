using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class GarantiaPrendaria
    {
        private string _bien;
        private string _descripcion;
        private GarantiaFiador _fiador; 

        public string bien { get { return _bien; } set { _bien = value; } }
        public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public GarantiaFiador fiador { get { return _fiador; } set { _fiador = value; } }

        public GarantiaPrendaria(String bien, String descripcion) {
            this.bien = bien;
            this.descripcion = descripcion;
        }

        public GarantiaPrendaria() { }
    }
}
