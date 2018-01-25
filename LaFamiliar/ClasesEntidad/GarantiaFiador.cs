using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class GarantiaFiador
    {
        int _id;
        private string _dui;
        private string _apellidos;
        private string _nombres;
        private string _direccion;
        private string _telefono;
        private string _nit;

        public int id { get { return _id; } set { _id = value; } }
        public string dui { get { return _dui; } set { _dui = value; } }
        public string apellidos { get { return _apellidos; } set { _apellidos = value; } }
        public string nombres { get { return _nombres; } set { _nombres = value; } }
        public string direccion { get { return _direccion; } set { _direccion = value; } }
        public string telefono { get { return _telefono; } set { _telefono = value; } }
        public string nit { get { return _nit; } set { _nit = value; } }

        public GarantiaFiador(String dui, String apellidos, String nombres, String direccion, string telefono, String nit) {
            this.dui = dui;
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.direccion = direccion;
            this.telefono = telefono;
            this.nit = nit;
        }

        public GarantiaFiador() { }
    }
}
