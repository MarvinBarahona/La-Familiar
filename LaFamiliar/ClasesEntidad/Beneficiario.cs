using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class Beneficiario
    {
        private string _nombre;
        private string _direccion;
        private string _parentesco;
        private int _edad;
        private int _porcentaje;

        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string direccion { get { return _direccion; } set { _direccion = value; } }
        public string parentesco { get { return _parentesco; } set { _parentesco = value; } }
        public int edad { get { return _edad; } set { _edad = value; } }
        public int porcentaje { get { return _porcentaje; } set { _porcentaje = value; } }

        public Beneficiario(String nombre, String parentesco, int edad, int porcentaje, String direccion)
        {
            this.nombre = nombre;
            this.parentesco = parentesco;
            this.edad = edad;
            this.porcentaje = porcentaje;
            this.direccion = direccion;
        }

        public Beneficiario() { }
    }
}
