using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AsociadoConyuge
    {
        private string _nombre;
        private string _lugarTrabajo;

        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string lugarTrabajo { get { return _lugarTrabajo; } set { _lugarTrabajo = value; } }

        public AsociadoConyuge(string nombre, string lugar)
        {
            this.nombre = nombre;
            this.lugarTrabajo = lugar;
        }
    }
}
