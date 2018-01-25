using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class CreditoDetalle
    {
        private decimal _monto_pagado;
        private decimal _aportacion;
        private decimal _cuota_social;
        private decimal _interes;
        private decimal _capital;
        private DateTime _fecha;
        private decimal _saldoParcial;
        int _n;

        public decimal monto_pagado { get { return _monto_pagado; } set { _monto_pagado = value; } }
        public decimal aportacion { get { return _aportacion; } set { _aportacion = value; } }
        public decimal cuota_social { get { return _cuota_social; } set { _cuota_social = value; } }
        public decimal interes { get { return _interes; } set { _interes = value; } }
        public decimal capital { get { return _capital; } set { _capital = value; } }
        public DateTime fecha { get { return _fecha; } set { _fecha = value; } }
        public decimal saldoParcial { get { return _saldoParcial; } set { _saldoParcial = value; } }
        public int correlativo { get { return _n; } set { _n = value; } }

        public CreditoDetalle(decimal montoPagado, decimal aportacion, decimal cuotaSocial, DateTime fecha) {
            this.monto_pagado = montoPagado;
            this.aportacion = aportacion;
            this.cuota_social = cuotaSocial;
            this.fecha = fecha;
        }

        public CreditoDetalle() { }
    }
}
