using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AhorroDetalle
    {
        string _tipo;
        decimal _monto;
        DateTime _fecha;
        decimal _saldoParcial;
        int _n;

        public string tipo { get { return _tipo; } set { _tipo = value; } }
        public decimal monto { get { return _monto; } set { _monto = value; } }
        public DateTime fecha { get { return _fecha; } set { _fecha = value; } }
        public decimal saldoParcial { get { return _saldoParcial; } set { _saldoParcial = value; } }
        public int correlativo { get { return _n; } set { _n = value; } }

        public decimal saldoAnterior 
        {
            get
            {
                decimal result = 0;
                if (this.tipo.StartsWith("Abono"))
                {
                    result = saldoParcial - monto;
                }
                else if (this.tipo.StartsWith("Retiro"))
                {
                    result = saldoParcial + monto;
                }
                return result;
            }
        }

        public AhorroDetalle(){}

        public AhorroDetalle(string tipo, decimal monto, DateTime fecha, decimal saldo)
        {
            this.tipo = tipo;
            this.monto = monto;
            this.fecha = fecha;
            this.saldoParcial = saldo;
        }
    }
}
