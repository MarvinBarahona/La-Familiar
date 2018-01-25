using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class CreditoDescuento
    {
        #region Datos de descuento de credito
        private decimal _cuota_ingreso;
        private decimal _escrituracion;
        private decimal _seguro;
        private decimal _papeleria;
        #endregion

        #region Getters y setters
        public decimal cuota_ingreso { get { return _cuota_ingreso; } set { _cuota_ingreso = value; } }
        public decimal escrituracion { get { return _escrituracion; } set { _escrituracion = value; } }
        public decimal seguro { get { return _seguro; } set { _seguro = value; } }
        public decimal papeleria { get { return _papeleria; } set { _papeleria = value; } }
        #endregion
    }
}
