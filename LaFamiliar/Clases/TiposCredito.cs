using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Familiar.Clases;

namespace La_Familiar.Clases
{
    public enum TiposCredito
    {
        Consumo = 51,
        Comercio = 52,
        Servicio = 53,
        Vivienda = 54,
        Deposito = 55,
        Rotativo = 56,
        Aportacion = 57
    }

    static class TiposCreditoM
    {
        public static TiposCorrelativo correlativo(this TiposAhorro tipoAhorro)
        {
            return (TiposCorrelativo)tipoAhorro;
        }
    }
}
