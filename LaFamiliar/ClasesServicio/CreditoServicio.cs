using La_Familiar.Clases;
using La_Familiar.ClasesEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Familiar.ClasesServicio
{
    class CreditoServicio
    {

// ##########################################################################################
// #################   Llenar una tabla con los créditos.   #################################
// ##########################################################################################


        public static void fillTable(DataGridView tblCredito, int idAsociado = -1)
        {
            String query = "select cre.id, cre.codigo as 'Código', concat(aso.nombres, ' ', aso.apellidos) as Asociado, " +
                "cre.monto as Monto, cre.forma_pago as 'Forma Pago', cre.fecha as Fecha " +
                "from asociados.asociado aso inner join asociados.credito cre on aso.id = cre.id_asociado";

            if (idAsociado != -1)
            {
                query += " and aso.id = " + idAsociado.ToString();
            }

            query += " order by cre.fecha desc";

            DataTable dataTable = Queries.getDataTable(query);
            tblCredito.DataSource = dataTable;

            tblCredito.Columns["id"].Visible = false;

            int ancho = tblCredito.Width;

            if (idAsociado == -1)
            {
                tblCredito.Columns["Código"].Width = ancho * 17 / 100;
                tblCredito.Columns["Asociado"].Width = ancho * 37 / 100;
                tblCredito.Columns["Monto"].Width = ancho * 10 / 100;
                tblCredito.Columns["Forma Pago"].Width = ancho * 18 / 100;
                tblCredito.Columns["Fecha"].Width = ancho * 18 / 100;
            }
            else
            {
                tblCredito.Columns["Asociado"].Visible = false;
                tblCredito.Columns["Código"].Width = ancho * 25 / 100;
                tblCredito.Columns["Monto"].Width = ancho * 20 / 100;
                tblCredito.Columns["Forma Pago"].Width = ancho * 35 / 100;
                tblCredito.Columns["Fecha"].Width = ancho * 20 / 100;
            }
            
            tblCredito.DoubleBuffered(true);
        }

// ##########################################################################################
// ###############   Recuperar un crédito a partir de su id   ###############################
// ##########################################################################################

        public static Credito select(int id)
        {
            Credito credito = new Credito();
            credito.id = id;

            string query;
            List<SqlParameter> parameters; 


            // ####  Recuperar la información del crédito   #####

            query = "select codigo, id_asociado, tipo, monto, interes, cuota, " +
                "plazo, forma_pago, fecha, aportacion, cuota_social, garantia_aportacion, activo " +
                "from asociados.credito where id = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", credito.id) };
            SqlDataReader dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                credito.codigo = dataReader.GetString(0);
                credito.idAsociado = dataReader.GetInt32(1);
                credito.tipo = dataReader.GetString(2);
                credito.monto = dataReader.GetDecimal(3);
                credito.interes = dataReader.GetByte(4);
                credito.cuota = dataReader.GetDecimal(5);
                credito.plazo = dataReader.GetByte(6);
                credito.forma_pago = dataReader.GetString(7);
                credito.fecha = dataReader.GetDateTime(8);
                credito.aportacion = dataReader.GetDecimal(9);
                credito.cuota_social = dataReader.GetDecimal(10);
                credito.garantia_aportacion = dataReader.GetBoolean(11);
                credito.activo = dataReader.GetBoolean(12);
            }
            dataReader.Close();


            // ####   Recuperar los pagos de este crédito   #####

            credito.detallesPago = new List<CreditoDetalle>();

            query = "select monto_pagado, aportacion, cuota_social, capital, interes, fecha, saldoParcial from asociados.creditodetalle " + 
                "where id_credito = @id order by fecha";
            parameters = new List<SqlParameter>() { new SqlParameter("id", credito.id) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                CreditoDetalle detalle = new CreditoDetalle(dataReader.GetDecimal(0), dataReader.GetDecimal(1),
                    dataReader.GetDecimal(2), dataReader.GetDateTime(5));
                detalle.capital = dataReader.GetDecimal(3);
                detalle.interes = dataReader.GetDecimal(4);
                detalle.saldoParcial = dataReader.GetDecimal(6);
                credito.detallesPago.Add(detalle);
            }
            dataReader.Close();

            // ##### Recupera la información del asociado (parcialmente, solo la que se usa)  ####

            credito.asociado = AsociadoServicio.selectParcial(credito.idAsociado);


            // #### Recupera el objeto CreditoDescuento  #####

            credito.creditoDescuento = new CreditoDescuento();

            query = "select cuota_ingreso, escrituracion, seguro, papeleria from asociados.creditodescuento where id_credito = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", credito.id) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                credito.creditoDescuento.cuota_ingreso = dataReader.GetDecimal(0);
                credito.creditoDescuento.escrituracion = dataReader.GetDecimal(1);
                credito.creditoDescuento.seguro = dataReader.GetDecimal(2);
                credito.creditoDescuento.papeleria = dataReader.GetDecimal(3);
            }
            dataReader.Close();

            return credito;
        }


        public static DataTable obtenerDetalles(DateTime fecha)
        {
            DataTable dataTable;

            string query = "select cre.codigo, det.monto_pagado, det.aportacion, det.cuota_social, det.interes, det.capital "
                + "from asociados.credito cre inner join asociados.creditodetalle det "
                + "on cre.id = det.id_credito and det.fecha = @fecha";
            List<SqlParameter> parameters = new List<SqlParameter>() { new SqlParameter("fecha", fecha) };
            dataTable = Queries.getDataTable(query, parameters);

            return dataTable;
        }
    }
}
