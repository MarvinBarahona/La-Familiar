using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AsociadoInfoPersonal
    {
        private string _nit;
        private string _direccion;
        private string _municipio;
        private string _departamento;
        private string _telefono;
        private string _estadoCivil;
        private decimal _ingresos;
        private decimal _ingresosOtros;

        public string nit { get { return _nit; } set { _nit = value; } }
        public string direccion { get { return _direccion; } set { _direccion = value; } }
        public string municipio { get { return _municipio; } set { _municipio = value; } }
        public string departamento { get { return _departamento; } set { _departamento = value; } }
        public string telefono { get { return _telefono; } set { _telefono = value; } }
        public string estadoCivil { get { return _estadoCivil; } set { _estadoCivil = value; } }
        public decimal ingresos { get { return _ingresos; } set { _ingresos = value; } }
        public decimal ingresosOtros { get { return _ingresosOtros; } set { _ingresosOtros = value; } }
    }
}
