using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AsociadoNacimiento
    {
        private DateTime _fecha;
        private string _lugar;
        private byte _edad;

        public DateTime fecha { 
            get { return _fecha; }
            set
            {
                _fecha = value;

                _edad = (byte)(DateTime.Today.Year - _fecha.Year);

                if (DateTime.Today.Month < _fecha.Month ||
                    DateTime.Today.Month == _fecha.Month && DateTime.Today.Day < _fecha.Day) _edad--;
            }
        }
        public string lugar { get { return _lugar; } set { _lugar = value; } }
        public byte edad { get { return _edad; } }

        public AsociadoNacimiento(DateTime fecha, string lugar)
        {
            this.fecha = fecha;
            this.lugar = lugar; 
        }
    }
}
