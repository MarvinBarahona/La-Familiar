using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class Dui
    {
        private string _numero;
        private DateTime _fechaEmision;
        private string _lugarEmision;

        public string numero { get { return _numero; } set { _numero = value; } }
        public DateTime fechaEmision { get { return _fechaEmision; } set { _fechaEmision = value; } }
        public string lugarEmision { get { return _lugarEmision; } set { _lugarEmision = value; } }

        public Dui(string numDui, string lugar, DateTime fecha)
        {
            this.numero = numDui;
            this.lugarEmision = lugar;
            this.fechaEmision = fecha;
        }
    }
}
