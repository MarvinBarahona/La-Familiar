using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AhorroProgramado
    {
        decimal _cuota;
        string _formaPago;
        byte _plazo;
        byte _extendido;

        public decimal cuota { get { return _cuota; } set { _cuota = value; } }
        public string formaPago { get { return _formaPago; } set { _formaPago = value; } }
        public byte plazo { set { _plazo = value; } }
        public byte extendido { get { return _extendido; } set { _extendido = value; } }
        public int duracion { get { return _plazo * this.extendido; } }
    }
}
