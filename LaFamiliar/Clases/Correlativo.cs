using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.Clases
{
    public enum TiposCorrelativo
    {
        Asociado = 0,
        AhorroCorriente = 2, 
        AhorroProgramado = 3, 
        AhorroPlazo = 4,
        CreditoConsumo = 51, 
        CreditoComercio = 52, 
        CreditoServicio = 53, 
        CreditoVivienda = 54, 
        CreditoDeposito = 55, 
        CreditoRotativo = 56, 
        CreditoAportacion = 57
    }

    static class Correlativo
    {
        public static void update(this TiposCorrelativo tipo)
        {
            int nuevoCorrelativo = tipo.getCorrelativo() + 1;

            string query = "update dbo.correlativo set correlativo = @c where nombre = @n";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("c", nuevoCorrelativo),
                new SqlParameter("n", tipo.getCorrelativoString())
            };
            Queries.execute(query, parameters);
        }

        public static string generarCodigo(this TiposCorrelativo tipo)
        {
            int correlativo = tipo.getCorrelativo();

            string codigo = La_Familiar.Properties.Settings.Default.Sucursal + "-" + tipo.getCorrelativoString()
                + "-" + Provider.numToFilledZeroString(correlativo, 6);
            return codigo;
        }

        public static string generarCodigo(this TiposCorrelativo tipo, int correlativo)
        {
            string codigo = La_Familiar.Properties.Settings.Default.Sucursal + "-" + tipo.getCorrelativoString()
                + "-" + Provider.numToFilledZeroString(correlativo, 6);
            return codigo;
        }

        public static int getCorrelativo(this TiposCorrelativo tipo)
        {
            string query = "select correlativo from dbo.correlativo where nombre = @tipo";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("tipo", tipo.getCorrelativoString())
            };

            SqlDataReader dataReader = Queries.getDataReader(query, parameters);

            int correlativo = 0;
            while(dataReader.Read())
            {
                correlativo = dataReader.GetInt32(0);
            }
            dataReader.Close();
            
            return correlativo;
        }

        public static string getCorrelativoString(this TiposCorrelativo tipo)
        {
            return Provider.numToFilledZeroString((int) tipo, 2);
        }
    }
}
