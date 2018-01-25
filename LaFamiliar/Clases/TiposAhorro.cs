using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.Clases
{
    public enum TiposAhorro
    {
        AhorroCorriente = 2, 
        AhorroProgramado = 3, 
        AhorroPlazo = 4,
    }

    static class TiposAhorroM
    {
        public static TiposCorrelativo correlativo(this TiposAhorro tipoAhorro)
        {
            return (TiposCorrelativo)tipoAhorro;
        }
    }
}
