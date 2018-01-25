using La_Familiar.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using La_Familiar.ClasesEntidad;

namespace La_Familiar.ClasesServicio
{
    class LugarTrabajoServicio
    {
        public static void fillComboBox(ComboBox cmbLugares)
        {
            string query = "select id, nombre, telefono, direccion from asociados.lugartrabajo";

            SqlDataReader dataReader = Queries.getDataReader(query);

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                string nombre = dataReader.GetString(1);
                string telefono = dataReader.GetString(2);
                string direccion = dataReader.GetString(3);

                ComboBoxItem item = new ComboBoxItem();
                item.Value = new LugarTrabajo(id, nombre, direccion, telefono);
                item.Text = nombre;

                cmbLugares.Items.Add(item);
            }

            dataReader.Close();
        }

        internal static int insert(string nombre, string direccion, string telefono)
        {
            string query = "insert into asociados.lugartrabajo(nombre, direccion, telefono) output inserted.id values (@n, @d, @t)";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("n", nombre),
                new SqlParameter("d", direccion),
                new SqlParameter("t", telefono)
            };

            return Queries.executeScalar(query, parameters);
        }
    }
}
