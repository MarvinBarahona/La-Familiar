using La_Familiar.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class Asociado
    {
        // Datos del asociado. 
        private int _id;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaIngreso;
        private decimal _aportacion;
        private bool _activo;

        private AsociadoInfoPersonal _infoPersonal;
        private Dui _dui;


        //Otras clases que contienen información del asociado. 
        private AsociadoDependencia _dependencias;
        private AsociadoNacimiento _nacimiento;
        private AsociadoTrabajo _trabajo;
        private List<Beneficiario> _beneficiarios;
        private AsociadoConyuge _conyuge;


        //Getters y setters. 
        public int id { get { return _id; } set { _id = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellido { get { return _apellido; } set { _apellido = value; } }
        public DateTime fechaIngreso { get { return _fechaIngreso; } set { _fechaIngreso = value; } }
        public decimal aportacion { get { return _aportacion; } set { _aportacion = value; } }
        public bool activo { get { return _activo; } set { _activo = value; } }

        public AsociadoInfoPersonal infoPersonal { get { return _infoPersonal; } set { _infoPersonal = value; } }
        public Dui dui { get { return _dui; } set { _dui = value; } }

        public AsociadoDependencia dependencias { get { return _dependencias; } set { _dependencias = value; } }
        public AsociadoNacimiento nacimiento { get { return _nacimiento; } set { _nacimiento = value; } }
        public AsociadoTrabajo trabajo { get { return _trabajo; } set { _trabajo = value; } }
        public AsociadoConyuge conyuge { get { return _conyuge; } set { _conyuge = value; } }

        public List<Beneficiario> beneficiarios { get { return _beneficiarios; } set { _beneficiarios = value; } }

        public bool abonoInicial {
            get{
                bool resp = false;
                string query = "select tipo from asociados.aportaciondetalle where id=@id and tipo='Abono inicial'";
                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                     new SqlParameter("id", id)
                };
                SqlDataReader dataReader = Queries.getDataReader(query, parameters);
                
                while (dataReader.Read())
                {
                    resp = true;
                }

                dataReader.Close();
                return resp;
            }
        }

        //Constructores. 
        public Asociado()
        {
            aportacion = 0;
            activo = true;
        }

        
        //Método para guardar el asociado en la base. 
        public void insert()
        {
            string query;
            List<SqlParameter> parameters;

            try
            {
                //Guardar en la tabla asociado
                query = "insert into asociados.asociado(id, dui, nombres, apellidos, fecha, aportacion, activo) "
                + "values (@id, @dui, @nombres, @apellidos, @fecha, @aportacion, @activo)";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", id),
                    new SqlParameter("dui", dui.numero),
                    new SqlParameter("nombres", nombre),
                    new SqlParameter("apellidos", apellido),
                    new SqlParameter("fecha", fechaIngreso),
                    new SqlParameter("aportacion", aportacion),
                    new SqlParameter("activo", activo)
                };
                Queries.execute(query, parameters);


                //Guardar en la tabla asociadodetalle
                query = "insert into asociados.asociadodetalle(id_asociado, estadocivil, direccion, municipio, departamento, "
                    + "telefono, nacimiento_fecha, nacimiento_lugar, dui_fecha, dui_lugar, nit, ingresos, otrosingresos) "
                    + "values (@id, @estadocivil, @direccion, @municipio, @departamento, @telefono, @nacimiento_fecha, " +
                    "@nacimiento_lugar, @dui_fecha, @dui_lugar, @nit, @ingresos, @otrosingresos)";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", id),
                    new SqlParameter("estadocivil", infoPersonal.estadoCivil),
                    new SqlParameter("direccion", infoPersonal.direccion),
                    new SqlParameter("municipio", infoPersonal.municipio),
                    new SqlParameter("departamento", infoPersonal.departamento),
                    new SqlParameter("telefono", infoPersonal.telefono),
                    new SqlParameter("nacimiento_fecha", nacimiento.fecha),
                    new SqlParameter("nacimiento_lugar", nacimiento.lugar),
                    new SqlParameter("dui_fecha", dui.fechaEmision),
                    new SqlParameter("dui_lugar", dui.lugarEmision),
                    new SqlParameter("nit", infoPersonal.nit),
                    new SqlParameter("ingresos", infoPersonal.ingresos),
                    new SqlParameter("otrosingresos", infoPersonal.ingresosOtros)
                };
                Queries.execute(query, parameters);


                //Guardar en la tabla trabajo
                query = "insert into asociados.trabajo(id_asociado, id_lugartrabajo, cargo, tiempo) values (@id_a, @id_t, @cargo, @tiempo)";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id_a", id),
                    new SqlParameter("id_t", trabajo.lugar.id),
                    new SqlParameter("cargo", trabajo.cargo),
                    new SqlParameter("tiempo", trabajo.tiempoServicio)
                };
                Queries.execute(query, parameters);


                //Guardar en la tabla dependencia
                query = "insert into asociados.dependencia(id_asociado, total, parcial) values (@id, @total, @parcial)";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", id),
                    new SqlParameter("total", dependencias.total),
                    new SqlParameter("parcial", dependencias.parcial)
                };
                Queries.execute(query, parameters);


                //Guardar en la tabla beneficiarios. 
                query = "insert into asociados.beneficiario(id_asociado, nombre, direccion, parentesco, edad, porcentaje) "
                    + "values (@id, @nombre, @direccion, @parentesco, @edad, @porcentaje)";
                foreach(Beneficiario beneficiario in beneficiarios)
                {
                    parameters = new List<SqlParameter>()
                    {
                        new SqlParameter("id", id),
                        new SqlParameter("nombre", beneficiario.nombre), 
                        new SqlParameter("direccion", beneficiario.direccion), 
                        new SqlParameter("parentesco", beneficiario.parentesco),
                        new SqlParameter("edad", beneficiario.edad),
                        new SqlParameter("porcentaje", beneficiario.porcentaje)
                    };
                    Queries.execute(query, parameters);
                }


                //Quizas guardar en la tabla conyuge
                if (infoPersonal.estadoCivil == "Casado")
                {
                    query = "insert into asociados.conyuge(id_asociado, nombre, lugar_trabajo) values (@id, @nombre, @trabajo)";
                    parameters = new List<SqlParameter>()
                    {
                        new SqlParameter("id", id),
                        new SqlParameter("nombre", conyuge.nombre),
                        new SqlParameter("trabajo", conyuge.lugarTrabajo)
                    };
                    Queries.execute(query, parameters);
                }

            }
            catch(SqlException ex)
            {
                throw new Exception("Error en consulta SQL", ex);                
            }
        }

        public bool exist(int id)
        {
            string query;
            int ida = 0;
            List<SqlParameter> parameters;
            bool flag = true;
            try
            {
                Queries.transactionBegin();
                query = "select id from asociados.asociado where id = @ida";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("ida", id)
                };

                SqlDataReader dataReader = Queries.getDataReader(query, parameters);

                while (dataReader.Read())
                {
                    ida = dataReader.GetInt32(0);
                }
                dataReader.Close();

                if (ida != 0)
                {
                    flag = false;
                }
                Queries.transactionCommit();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la consula SQL", ex);
            }
            return flag;
        }

        //update
        public void update()
        {
            string query;
            List<SqlParameter> parameters;

            Queries.transactionBegin();         //Inicio de la transacción.

            try
            {
                //Actualizar la tabla asociado
                query = "update asociados.asociado set dui=@dui, nombres = @nombres, apellidos = @apellidos, fecha = @fecha, "
                    + "aportacion = @aportacion, activo = @activo where id = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", id),
                    new SqlParameter("dui", dui.numero),
                    new SqlParameter("nombres", nombre),
                    new SqlParameter("apellidos", apellido),
                    new SqlParameter("fecha", fechaIngreso),
                    new SqlParameter("aportacion", aportacion),
                    new SqlParameter("activo", activo)
                };
                Queries.execute(query, parameters);


                //Actualizar la tabla asociadodetalle
                query = "update asociados.asociadodetalle set estadocivil = @estadocivil, direccion = @direccion, municipio = @municipio, "
                    + "departamento = @departamento, telefono = @telefono, nacimiento_fecha = @nacimiento_fecha, nacimiento_lugar = @nacimiento_lugar, "
                    + "dui_fecha = @dui_fecha, dui_lugar = @dui_lugar, nit = @nit, ingresos = @ingresos, otrosingresos = @otrosingresos "
                    + "where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", id),
                    new SqlParameter("estadocivil", infoPersonal.estadoCivil),
                    new SqlParameter("direccion", infoPersonal.direccion),
                    new SqlParameter("municipio", infoPersonal.municipio),
                    new SqlParameter("departamento", infoPersonal.departamento),
                    new SqlParameter("telefono", infoPersonal.telefono),
                    new SqlParameter("nacimiento_fecha", nacimiento.fecha),
                    new SqlParameter("nacimiento_lugar", nacimiento.lugar),
                    new SqlParameter("dui_fecha", dui.fechaEmision),
                    new SqlParameter("dui_lugar", dui.lugarEmision),
                    new SqlParameter("nit", infoPersonal.nit),
                    new SqlParameter("ingresos", infoPersonal.ingresos),
                    new SqlParameter("otrosingresos", infoPersonal.ingresos)
                };
                Queries.execute(query, parameters);


                //Actualizar la tabla trabajo
                query = "update asociados.trabajo set id_lugartrabajo = @id_t, cargo = @cargo, tiempo = @tiempo where id_asociado = @id_a";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id_a", id),
                    new SqlParameter("id_t", trabajo.lugar.id),
                    new SqlParameter("cargo", trabajo.cargo),
                    new SqlParameter("tiempo", trabajo.tiempoServicio)
                };
                Queries.execute(query, parameters);


                //Actualizar la tabla dependencia
                query = "update asociados.dependencia set total = @total, parcial = @parcial where id_asociado = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", id),
                    new SqlParameter("total", dependencias.total),
                    new SqlParameter("parcial", dependencias.parcial)
                };
                Queries.execute(query, parameters);


                //Actualizar la tabla beneficiario
                query = "delete from asociados.beneficiario where id_asociado = @id";
                parameters = new List<SqlParameter>() {new SqlParameter("id", id) };
                Queries.execute(query, parameters);

                query = "insert into asociados.beneficiario(id_asociado, nombre, direccion, parentesco, edad, porcentaje) "
                    + "values (@id, @nombre, @direccion, @parentesco, @edad, @porcentaje)";
                foreach (Beneficiario beneficiario in beneficiarios)
                {
                    parameters = new List<SqlParameter>()
                    {
                        new SqlParameter("id", id),
                        new SqlParameter("nombre", beneficiario.nombre), 
                        new SqlParameter("direccion", beneficiario.direccion), 
                        new SqlParameter("parentesco", beneficiario.parentesco),
                        new SqlParameter("edad", beneficiario.edad),
                        new SqlParameter("porcentaje", beneficiario.porcentaje)
                    };
                    Queries.execute(query, parameters);
                }


                //Actualizar la tabla conyuga
                if (infoPersonal.estadoCivil == "Casado")
                {
                    query = "if exists (select * from asociados.conyuge where id_asociado = @id) "
                        + "update asociados.conyuge set nombre = @nombreConyuge, lugar_trabajo = @lugarConyuge where id_asociado = @id "
                        + "else insert into asociados.conyuge(id_asociado, nombre, lugar_trabajo) values (@id, @nombreConyuge, @lugarConyuge)";
                    parameters = new List<SqlParameter>()
                    {
                        new SqlParameter("id", id),
                        new SqlParameter("nombreConyuge", conyuge.nombre),
                        new SqlParameter("lugarConyuge", conyuge.lugarTrabajo)
                    };
                    Queries.execute(query, parameters);
                }

                Queries.transactionCommit();        //COmmit de la transacción
            }
            catch (SqlException ex)
            {
                Queries.transactionRollback();      //Rollback de la transacción.
                throw new Exception("Error en consulta SQL", ex);
            }
        }


        //ToString
        public override string ToString()
        {
            return Provider.numToFilledZeroString(id, 6);
        }
    }
}
