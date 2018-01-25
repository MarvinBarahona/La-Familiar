using La_Familiar.Clases;
using La_Familiar.ClasesEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesServicio
{
    class GarantiasServicios
    {
        public static void selectGarantias(Credito credito)
        {
            string query;
            SqlDataReader dataReader;

            query = "select dui, nombres, apellidos, direccion, telefono, nit, id from asociados.fiador where id_credito = "
                + credito.id.ToString();
            dataReader = Queries.getDataReader(query);

            credito.fiadores = new List<GarantiaFiador>();
            while (dataReader.Read())
            {
                GarantiaFiador fiador = new GarantiaFiador();
                fiador.dui = dataReader.GetString(0);
                fiador.nombres = dataReader.GetString(1);
                fiador.apellidos = dataReader.GetString(2);
                fiador.direccion = dataReader.GetString(3);
                fiador.telefono = dataReader.GetString(4);
                fiador.nit = dataReader.GetString(5);
                fiador.id = dataReader.GetInt32(6);

                credito.fiadores.Add(fiador);
            }
            dataReader.Close();


            query = "select bien, descripcion, id_fiador from asociados.prendaria where id_credito = "
                + credito.id.ToString();
            dataReader = Queries.getDataReader(query);

            credito.prendarias = new List<GarantiaPrendaria>();
            while (dataReader.Read())
            {
                GarantiaPrendaria prendaria = new GarantiaPrendaria();
                prendaria.bien = dataReader.GetString(0);
                prendaria.descripcion = dataReader.GetString(1);

                int id;
                Int32.TryParse(dataReader.GetValue(2).ToString(), out id);
                if (id != 0)
                    foreach (GarantiaFiador fiador in credito.fiadores)
                        if (fiador.id == id)
                            prendaria.fiador = fiador;

                credito.prendarias.Add(prendaria);
            }
            dataReader.Close();


            query = "select direccion, matricula, medidas, id_fiador from asociados.hipotecaria where id_credito = "
                + credito.id.ToString();
            dataReader = Queries.getDataReader(query);

            credito.hipotecarias = new List<GarantiaHipotecaria>();
            while (dataReader.Read())
            {
                GarantiaHipotecaria hipotecaria = new GarantiaHipotecaria();
                hipotecaria.direccion = dataReader.GetString(0);
                hipotecaria.matricula = dataReader.GetString(1);
                hipotecaria.medidas = dataReader.GetString(2);

                int id;
                Int32.TryParse(dataReader.GetValue(3).ToString(), out id);
                if (id != 0)
                    foreach (GarantiaFiador fiador in credito.fiadores)
                        if (fiador.id == id)
                            hipotecaria.fiador = fiador;

                credito.hipotecarias.Add(hipotecaria);
            }
            dataReader.Close();

            query = "select gar.id_ahorro, aho.codigo from asociados.ahorro aho inner join asociados.garantiadeposito gar on "
                + "aho.id = gar.id_ahorro and gar.id_credito = " + credito.id.ToString();
            dataReader = Queries.getDataReader(query);

            credito.depositos = new List<int>();
            credito.codDepositos = new List<string>();
            while (dataReader.Read())
            {
                credito.depositos.Add(dataReader.GetInt32(0));
                credito.codDepositos.Add(dataReader.GetString(1));
            }
            dataReader.Close();
        }
    }
}
