using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AhorroPlazo
    {
        decimal _montoInicial;
        byte _plazo;
        byte _extendido;
        string _codigoCuenta;

        public decimal montoInicial { get { return _montoInicial; } set { _montoInicial = value; } }
        public byte plazo { set { _plazo = value; } }
        public byte extendido { get { return _extendido; } set { _extendido = value; } }
        public int duracion { get { return _plazo * this.extendido; } }
        public string codigoCuenta { get { return _codigoCuenta; } set { _codigoCuenta = value; } }
    }
}
