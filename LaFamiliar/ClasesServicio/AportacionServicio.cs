using La_Familiar.Clases;
using La_Familiar.ClasesEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace La_Familiar.ClasesServicio
{
    class AportacionServicio
    {
        public static decimal fillTable(DataGridView tblAportaciones, int id)
        {
            string query = "select fecha as Fecha, monto as 'Monto ($)', tipo as 'Tipo' from asociados.aportaciondetalle" +
                " where id_asociado = @id order by fecha";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("id", id)
            };

            DataTable dataTable = Queries.getDataTable(query, parameters);
            tblAportaciones.DataSource = dataTable;

            decimal totalAportado = 0;
            foreach (DataGridViewRow row in tblAportaciones.Rows)
            {
                totalAportado += (decimal)row.Cells["Monto ($)"].Value;
            }

            tblAportaciones.DoubleBuffered(true);

            return totalAportado;
        }
    }
}
