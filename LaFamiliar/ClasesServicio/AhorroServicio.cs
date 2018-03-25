using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using La_Familiar.ClasesEntidad;
using La_Familiar.Clases;

namespace La_Familiar.ClasesServicio
{
    class AhorroServicio
    {        
        public static void fillTable(DataGridView tblAhorro, int idAsociado = -1)
        {
            String query = "select aho.id, aho.codigo as 'Código', concat(aso.nombres, ' ', aso.apellidos) as Asociado, " 
                + "aho.fecha as Fecha, aho.tipo as Tipo " 
                + "from asociados.asociado aso inner join asociados.ahorro aho on aso.id = aho.id_asociado";

            if (idAsociado != -1)
            {
                query += " and aso.id = " + idAsociado.ToString();
            }

            query += " order by aho.fecha desc";

            DataTable dataTable = Queries.getDataTable(query);
           
            foreach(DataRow r in dataTable.Rows)
            {
                int codigo = Int32.Parse(r["Código"].ToString());
                switch(r["Tipo"].ToString())
                {
                    case ("Corriente"):
                        r["Código"] = TiposCorrelativo.AhorroCorriente.generarCodigo(codigo);
                        break;
                    case ("Depósito a plazo"):
                        r["Código"] = TiposCorrelativo.AhorroPlazo.generarCodigo(codigo);
                        break;
                    case ("Programado"):
                        r["Código"] = TiposCorrelativo.AhorroProgramado.generarCodigo(codigo);
                        break;
                }
            }

            tblAhorro.DataSource = dataTable;

            tblAhorro.Columns["id"].Visible = false;
            
            int ancho = tblAhorro.Width;

            if (idAsociado == -1)
            {
                tblAhorro.Columns["Código"].Width = ancho * 17 / 100;
                tblAhorro.Columns["Asociado"].Width = ancho * 45 / 100;
                tblAhorro.Columns["Tipo"].Width = ancho * 20 / 100;
                tblAhorro.Columns["Fecha"].Width = ancho * 18 / 100;
            }
            else
            {
                tblAhorro.Columns["Asociado"].Visible = false;

                tblAhorro.Columns["Código"].Width = ancho * 30 / 100;
                tblAhorro.Columns["Tipo"].Width = ancho * 40 / 100;
                tblAhorro.Columns["Fecha"].Width = ancho * 30 / 100;
            }

            tblAhorro.DoubleBuffered(true);
        }

        public static void fillComboBoxDepositos(ComboBox cmb, int idAsociado)
        {
            String query = "select id, codigo from asociados.ahorro where id_asociado = @idAsociado and tipo = 'Depósito a plazo' and activo = 1";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("idAsociado", idAsociado)
            };
            SqlDataReader dataReader = Queries.getDataReader(query, parameters);

            while (dataReader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Value = dataReader.GetInt32(0);
                item.Text = dataReader.GetString(1);
                cmb.Items.Add(item);
            }
            dataReader.Close();
        }

        public static void fillComboBoxCuentasAhorro(ComboBox cmb, int idAsociado)
        {
            cmb.Items.Clear();
            String query = "select id, codigo from asociados.ahorro where id_asociado = @idAsociado and tipo = 'Corriente'";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("idAsociado", idAsociado)
            };
            SqlDataReader dataReader = Queries.getDataReader(query, parameters);

            while (dataReader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Value = dataReader.GetInt32(0);
                item.Text = dataReader.GetString(1);
                cmb.Items.Add(item);
            }
            dataReader.Close();
        }

        public static Ahorro select(int id)
        {
            Ahorro ahorro = new Ahorro();
            ahorro.id = id;

            string query;
            List<SqlParameter> parameters;

            query = "select codigo, id_asociado, tipo, interes, fecha, activo from asociados.ahorro where id = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", id) };
            SqlDataReader dataReader = Queries.getDataReader(query, parameters);

            while (dataReader.Read())
            {
                ahorro.codigo = dataReader.GetString(0);
                ahorro.idAsociado = dataReader.GetInt32(1);
                ahorro.tipo = dataReader.GetString(2);
                ahorro.interes = dataReader.GetByte(3);
                ahorro.fecha = dataReader.GetDateTime(4);
                ahorro.activo = dataReader.GetBoolean(5);
            }
            dataReader.Close();

            if (ahorro.tipo == "Depósito a plazo")
            {
                AhorroPlazo ahorroPlazo = new AhorroPlazo();

                query = "select monto_inicial, plazo, extendido from asociados.ahorroplazo where id_ahorro = @id";
                parameters = new List<SqlParameter>() { new SqlParameter("id", id) };
                dataReader = Queries.getDataReader(query, parameters);

                while (dataReader.Read())
                {
                    ahorroPlazo.montoInicial = dataReader.GetDecimal(0);
                    ahorroPlazo.plazo = dataReader.GetByte(1);
                    ahorroPlazo.extendido = dataReader.GetByte(2);
                }
                dataReader.Close();

                ahorro.ahorroPlazo = ahorroPlazo;
            }

            if (ahorro.tipo == "Programado")
            {
                AhorroProgramado ahorroProgramado = new AhorroProgramado();

                query = "select cuota, forma_pago, plazo, extendido from asociados.ahorroprogramado where id_ahorro = @id";
                parameters = new List<SqlParameter>() { new SqlParameter("id", id) };
                dataReader = Queries.getDataReader(query, parameters);

                while (dataReader.Read())
                {
                    ahorroProgramado.cuota = dataReader.GetDecimal(0);
                    ahorroProgramado.formaPago = dataReader.GetString(1);
                    ahorroProgramado.plazo = dataReader.GetByte(2);
                    ahorroProgramado.extendido = dataReader.GetByte(3);
                }
                dataReader.Close();

                ahorro.ahorroProgramado = ahorroProgramado;
            }

            query = "select tipo, monto, fecha, saldo_parcial from asociados.ahorrodetalle where id_ahorro = @id order by fecha";
            parameters = new List<SqlParameter>() { new SqlParameter("id", id) };
            dataReader = Queries.getDataReader(query, parameters);

            ahorro.detalles = new List<AhorroDetalle>();
            AhorroDetalle detalle;
            while (dataReader.Read())
            {
                detalle = new AhorroDetalle();
                detalle.tipo = dataReader.GetString(0);
                detalle.monto = dataReader.GetDecimal(1);
                detalle.fecha = dataReader.GetDateTime(2);
                detalle.saldoParcial = dataReader.GetDecimal(3);

                ahorro.detalles.Add(detalle);
            }
            dataReader.Close();

            query = "select nombre, edad, porcentaje, parentesco from asociados.beneficiarioahorro where id_ahorro = @id";
            parameters = new List<SqlParameter>() { new SqlParameter("id", id) };
            dataReader = Queries.getDataReader(query, parameters);

            ahorro.beneficiarios = new List<Beneficiario>();
            Beneficiario beneficiario;
            while (dataReader.Read())
            {
                beneficiario = new Beneficiario();
                beneficiario.nombre = dataReader.GetString(0);
                beneficiario.edad = dataReader.GetByte(1);
                beneficiario.porcentaje = dataReader.GetByte(2);
                beneficiario.parentesco = dataReader.GetString(3);

                ahorro.beneficiarios.Add(beneficiario);
            }
            dataReader.Close();

            ahorro.asociado = AsociadoServicio.selectParcial(ahorro.idAsociado);

            return ahorro;
        }

        public static List<DateTime> fechasCapitalizables(DateTime ultimaCapitalizacion, DateTime fechaHasta)
        {
            List<DateTime> result = new List<DateTime>();

            for (int y = ultimaCapitalizacion.Year; y <= fechaHasta.Year; y++)
            {
                FechasCapitalizables fechasCapitalizables = new FechasCapitalizables(y);

                foreach (DateTime fecha in fechasCapitalizables.fechas)
                {
                    if (fecha > ultimaCapitalizacion && fecha < fechaHasta) result.Add(fecha);
                }
            }

            return result;
        }

        public static void extenderPlazo(int plazo, int id)
        {
            try
            {
                Queries.transactionBegin();
                string query = "update asociados.ahorroplan set plazo = @plazo, extendido = @valor where id_ahorro = @id";
                List<SqlParameter> parameters = new List<SqlParameter>() { 
                    new SqlParameter("@plazo",plazo*2),
                    new SqlParameter("@valor",true),
                    new SqlParameter("@id",id)
                };
                Queries.execute(query,parameters);
                Queries.transactionCommit();
            }
            catch(Exception ex)
            {
                Queries.transactionRollback();
                MessageBox.Show(ex.Message);
            }
        }

        public static void finalizarPlan(int id)
        {
            try
            {
                Queries.transactionBegin();
                string query = "update asociados.ahorro set activo = @valor where id = @id";
                List<SqlParameter> parameters = new List<SqlParameter>() { 
                    new SqlParameter("@valor",false),
                    new SqlParameter("@id",id)
                };
                Queries.execute(query, parameters);
                Queries.transactionCommit();
            }
            catch(Exception ex)
            {
                Queries.transactionRollback();
            }
        }

    }
}
