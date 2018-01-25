using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AsociadoTrabajo
    {
        private LugarTrabajo _lugar;
        private string _cargo;
        private string _tiempoServicio;

        public LugarTrabajo lugar { get { return _lugar; } set { _lugar = value; } }
        public string cargo { get { return _cargo; } set { _cargo = value; } }
        public string tiempoServicio { get { return _tiempoServicio; } set { _tiempoServicio = value; } }

        public AsociadoTrabajo(LugarTrabajo lugar, string cargo, string tiempoServicio)
        {
            this.lugar = lugar;
            this.cargo = cargo;
            this.tiempoServicio = tiempoServicio;
        }
    }
}
