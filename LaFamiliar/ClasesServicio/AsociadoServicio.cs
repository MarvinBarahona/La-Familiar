using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using La_Familiar.ClasesEntidad;
using La_Familiar.Clases;

namespace La_Familiar.ClasesServicio
{
    class AsociadoServicio
    {

// ########################################################################################
// ###################    Llenar un comboBox con los asociados    #########################
// ########################################################################################

        public static void fillComboBox(ComboBox cmb)
        {
            string query = "select id, nombres, apellidos, aportacion from asociados.asociado";
            SqlDataReader dataReader = Queries.getDataReader(query);

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                String nombre = dataReader.GetString(1);
                String apellido = dataReader.GetString(2);
                decimal aportacion = dataReader.GetDecimal(3);

                Asociado asociado = new Asociado();
                asociado.id = id;
                asociado.nombre = nombre;
                asociado.apellido = apellido;
                asociado.aportacion = aportacion;

                ComboBoxItem item = new ComboBoxItem();
                item.Value = asociado;
                item.Text = nombre + " " + apellido;
              
                cmb.Items.Add(item);                
                coleccion.Add(item.Text);                
            }

            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.Append;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dataReader.Close();
        }


// ########################################################################################
// ###################     Llenar una tabla con los asociados     #########################
// ######################################################################################## 

        public static void fillTable(DataGridView tblAsociado)
        {
            String query = "select id as 'id', dui as 'DUI', nombres as 'Nombres', apellidos as 'Apellidos', " +
                "aportacion as 'Aportación', fecha as 'Fecha Ingreso' from asociados.asociado";
            DataTable dataTable = Queries.getDataTable(query);
            tblAsociado.DataSource = dataTable;

            tblAsociado.Columns["id"].Visible = false;

            if (!tblAsociado.Columns.Contains("idString"))
            {
                tblAsociado.Columns.Add("idString", "Número");
                tblAsociado.Columns["idString"].DisplayIndex = 0;
            }

            foreach (DataGridViewRow row in tblAsociado.Rows)
            {
                int num = (int)row.Cells["id"].Value;
                string codigo = Provider.numToFilledZeroString(num, 6);
                row.Cells["idString"].Value = codigo;
            }

            int ancho = tblAsociado.Width;
            tblAsociado.Columns["idString"].Width = ancho * 10 / 100;
            tblAsociado.Columns["DUI"].Width = ancho * 14 / 100;
            tblAsociado.Columns["Nombres"].Width = ancho * 25 / 100;
            tblAsociado.Columns["Apellidos"].Width = ancho * 25 / 100;
            tblAsociado.Columns["Aportación"].Width = ancho * 10 / 100;
            tblAsociado.Columns["Fecha Ingreso"].Width = ancho * 10 / 100;

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "btnEliminar";
            deleteButton.HeaderText = "";
            deleteButton.Text = "x";
            deleteButton.UseColumnTextForButtonValue = true;
            tblAsociado.Columns.Add(deleteButton);

            tblAsociado.Columns["btnEliminar"].Width = ancho * 6 / 100;

            tblAsociado.DoubleBuffered(true);
        }

// ########################################################################################
// ##################    Recuperar un asociado a partir de su id   ########################
// ########################################################################################

        public static Asociado select(int idAsociado)
        {
            // #### Crear el objeto ####

            Asociado asociado = new Asociado();
            asociado.id = idAsociado;

            string query;
            List<SqlParameter> parameters;


            // #### Recuperar la información de objeto asociado ####

            string duiNum = "";
            query = "select dui, nombres, apellidos, fecha, aportacion, activo from asociados.asociado where id = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
            SqlDataReader dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                duiNum = dataReader.GetString(0);
                asociado.nombre = dataReader.GetString(1);
                asociado.apellido = dataReader.GetString(2);
                asociado.fechaIngreso = dataReader.GetDateTime(3);
                asociado.aportacion = dataReader.GetDecimal(4);
                asociado.activo = dataReader.GetBoolean(5);
            }
            dataReader.Close();


            // #### Crear y obtener objeto InfoPersonal  #####

            asociado.infoPersonal = new AsociadoInfoPersonal();
            query = "select estadocivil, direccion, telefono, nacimiento_fecha, nacimiento_lugar, dui_fecha, "
                + "dui_lugar, nit, ingresos, otrosingresos, departamento, municipio from asociados.asociadodetalle "
                + "where id_asociado = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                asociado.infoPersonal.estadoCivil = dataReader.GetString(0);
                asociado.infoPersonal.direccion = dataReader.GetString(1);
                asociado.infoPersonal.telefono = dataReader.GetString(2);
                asociado.nacimiento = new AsociadoNacimiento(dataReader.GetDateTime(3), dataReader.GetString(4));
                asociado.dui = new Dui(duiNum, dataReader.GetString(6), dataReader.GetDateTime(5));
                asociado.infoPersonal.nit = dataReader.GetString(7);
                asociado.infoPersonal.ingresos = dataReader.GetDecimal(8);
                asociado.infoPersonal.ingresosOtros = dataReader.GetDecimal(9);
                asociado.infoPersonal.departamento = dataReader.GetString(10);
                asociado.infoPersonal.municipio = dataReader.GetString(11);
            }
            dataReader.Close();


            // #### Crear la lista de beneficiarios ####

            asociado.beneficiarios = new List<Beneficiario>();
            query = "select nombre, direccion, parentesco, edad, porcentaje from asociados.beneficiario where id_asociado=@id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                Beneficiario beneficiario = new Beneficiario();

                beneficiario.nombre = dataReader.GetString(0);
                beneficiario.direccion = dataReader.GetString(1);
                beneficiario.parentesco = dataReader.GetString(2);
                beneficiario.edad = dataReader.GetByte(3);
                beneficiario.porcentaje = dataReader.GetByte(4);

                asociado.beneficiarios.Add(beneficiario);
            }
            dataReader.Close();


            // #### Retornar el objeto de dependencias ####

            query = "select total, parcial from asociados.dependencia where id_asociado = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                asociado.dependencias = new AsociadoDependencia();
                asociado.dependencias.total = dataReader.GetByte(0);
                asociado.dependencias.parcial = dataReader.GetByte(1);
            }
            dataReader.Close();


            // #### Para el trabajo ####

            int idT = 0;
            string cargo = "";
            string tiempo = "";

            query = "select id_lugartrabajo, cargo, tiempo from asociados.trabajo where id_asociado = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                idT = dataReader.GetInt32(0);
                cargo = dataReader.GetString(1);
                tiempo = dataReader.GetString(2);
            }
            dataReader.Close();


            // #### Para el lugar de trabajo ####

            query = "select nombre, direccion, telefono from asociados.lugartrabajo where id = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idT) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                LugarTrabajo lugar = new LugarTrabajo(idT, dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2));
                asociado.trabajo = new AsociadoTrabajo(lugar, cargo, tiempo);
            }
            dataReader.Close();


            // #### Para el conyuge #####

            if (asociado.infoPersonal.estadoCivil == "Casado")
            {
                query = "select nombre, lugar_trabajo from asociados.conyuge where id_asociado = @id";
                parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
                dataReader = Queries.getDataReader(query, parameters);
                while (dataReader.Read())
                {
                    asociado.conyuge = new AsociadoConyuge(dataReader.GetString(0), dataReader.GetString(1));
                }
                dataReader.Close();
            }

            return asociado;
        }

        public static Asociado selectParcial(int idAsociado)
        {
            Asociado asociado = new Asociado();
            string duiNum = "";

            string query = "select nombres, apellidos, dui, aportacion from asociados.asociado where id = @id";
            List<SqlParameter> parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
            SqlDataReader dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                asociado.id = idAsociado;
                asociado.nombre = dataReader.GetString(0);
                asociado.apellido = dataReader.GetString(1);
                duiNum = dataReader.GetString(2);
                asociado.aportacion = dataReader.GetDecimal(3);
            }
            dataReader.Close();

            // #### Crear y obtener objeto InfoPersonal  #####

            asociado.infoPersonal = new AsociadoInfoPersonal();
            query = "select estadocivil, direccion, telefono, nacimiento_fecha, nacimiento_lugar, dui_fecha, "
                + "dui_lugar, nit, ingresos, otrosingresos, municipio, departamento from asociados.asociadodetalle where id_asociado = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                asociado.infoPersonal.estadoCivil = dataReader.GetString(0);
                asociado.infoPersonal.direccion = dataReader.GetString(1);
                asociado.infoPersonal.telefono = dataReader.GetString(2);
                asociado.nacimiento = new AsociadoNacimiento(dataReader.GetDateTime(3), dataReader.GetString(4));
                asociado.dui = new Dui(duiNum, dataReader.GetString(6), dataReader.GetDateTime(5));
                asociado.infoPersonal.nit = dataReader.GetString(7);
                asociado.infoPersonal.ingresos = dataReader.GetDecimal(8);
                asociado.infoPersonal.ingresosOtros = dataReader.GetDecimal(9);
                asociado.infoPersonal.municipio = dataReader.GetString(10);
                asociado.infoPersonal.departamento = dataReader.GetString(11);
            }
            dataReader.Close();

            // #### Para el trabajo ####

            int idT = 0;
            string cargo = "";
            string tiempo = "";

            query = "select id_lugartrabajo, cargo, tiempo from asociados.trabajo where id_asociado = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idAsociado) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                idT = dataReader.GetInt32(0);
                cargo = dataReader.GetString(1);
                tiempo = dataReader.GetString(2);
            }
            dataReader.Close();


            // #### Para el lugar de trabajo ####

            query = "select nombre, direccion, telefono from asociados.lugartrabajo where id = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", idT) };
            dataReader = Queries.getDataReader(query, parameters);
            while (dataReader.Read())
            {
                LugarTrabajo lugar = new LugarTrabajo(idT, dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2));
                asociado.trabajo = new AsociadoTrabajo(lugar, cargo, tiempo);
            }
            dataReader.Close();

            return asociado;
        }

        public static bool eliminar(int idAsociado)
        {
            bool resultado; 
            string query;
            List<SqlParameter> parameters;

            try
            {
                query = "delete from asociados.conyuge where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", idAsociado)
                };
                Queries.execute(query, parameters);

                query = "delete from asociados.beneficiario where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", idAsociado)
                };
                Queries.execute(query, parameters);

                query = "delete from asociados.dependencia where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", idAsociado)
                };
                Queries.execute(query, parameters);

                query = "delete from asociados.trabajo where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", idAsociado)
                };
                Queries.execute(query, parameters);

                query = "delete from asociados.asociadodetalle where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", idAsociado)
                };
                Queries.execute(query, parameters);

                query = "delete from asociados.ahorro where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", idAsociado)
                };
                Queries.execute(query, parameters);

                query = "delete from asociados.credito where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", idAsociado)
                };
                Queries.execute(query, parameters);

                query = "delete from asociados.asociado where id = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", idAsociado)
                };
                Queries.execute(query, parameters);

                resultado = true;
            }

            catch (SqlException ex)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
