using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using La_Familiar.Clases;
using La_Familiar.ClasesServicio;

namespace La_Familiar.ClasesEntidad
{
    public class Ahorro
    {
        int _id;
        string _codigo;
        int _idAsociado;
        string _tipo;
        DateTime _fecha;
        int _interes;
        bool _activo;

        List<Beneficiario> _beneficiarios;
        AhorroPlazo _ahorroPlazo;
        AhorroProgramado _ahorroProgramado;
        List<AhorroDetalle> _detalles;
        Asociado _asociado;        

        public int id { get { return _id; } set { _id = value; } }
        public string codigo { get { return _codigo; } set { _codigo = value; } }
        public int idAsociado { get { return _idAsociado; } set { _idAsociado = value; } }
        public string tipo { get { return _tipo; } set { _tipo = value; } }
        public DateTime fecha { get { return _fecha; } set { _fecha = value; } }
        
        public int interes { get { return _interes; } set { _interes = value; } }
        public bool activo { get { return _activo; } set { _activo = value; } }

        public List<Beneficiario> beneficiarios { get { return _beneficiarios; } set { _beneficiarios = value; } }
        public AhorroPlazo ahorroPlazo { get { return _ahorroPlazo; } set { _ahorroPlazo = value; } }
        public AhorroProgramado ahorroProgramado { get { return _ahorroProgramado; } set { _ahorroProgramado = value; } }

        public List<AhorroDetalle> detalles { get { return _detalles; } set { _detalles = value; } }
        public Asociado asociado { get { return _asociado; } set { _asociado = value; } }

        public decimal saldo { 
            get
            {
                decimal saldo;
                if (detalles != null && detalles.Count > 0)
                    saldo =  detalles.Last().saldoParcial;
                else
                    saldo = 0;
                return saldo;
            } 
        }

        public DateTime ultimoMovimiento
        {
            get
            {
                DateTime fecha;
                if (detalles != null && detalles.Count > 0)
                    fecha = detalles.Last().fecha;
                else
                    fecha = this.fecha;
                return fecha;
            }
        }

        public DateTime ultimaCapitalizacion
        {
            get
            {
                DateTime fecha = this.fecha;
                if (detalles != null && detalles.Count > 0)
                    foreach (AhorroDetalle detalle in detalles)
                    {
                        if (detalle.tipo == "Abono intereses") fecha = detalle.fecha;
                    }

                return fecha;
            }
        }

        public bool caducado
        {
            get
            {
                return DateTime.Today > this.fechaVencimiento;
            }
        }

        public DateTime fechaVencimiento
        {
            get
            {
                DateTime fecha;
                if (this.tipo == "Depósito a plazo")
                    fecha = this.fecha.AddMonths(this.ahorroPlazo.duracion);
                else if (this.tipo == "Programado")
                    fecha = this.fecha.AddMonths(this.ahorroProgramado.duracion);
                else fecha = this.fecha.AddMonths(6);
                return fecha;
            }
        }

        public Ahorro()
        {
            activo = true;
        }

        public void insert()
        {
            List<SqlParameter> parameters;
            string query;

            query = "insert into asociados.ahorro(codigo, id_asociado, tipo, interes, fecha, activo) "
                + "output inserted.id values (@codigo, @idAsociado, @tipo, @tasa, @fecha, @activo)";
            parameters = new List<SqlParameter>()
                {
                    new SqlParameter("@codigo", this.codigo),
                    new SqlParameter("@idAsociado", this.idAsociado),
                    new SqlParameter("@tipo", this.tipo),
                    new SqlParameter("@tasa", this.interes),
                    new SqlParameter("@fecha", this.fecha),
                    new SqlParameter("@activo", this.activo)
                };

            this.id = Queries.executeScalar(query, parameters);

            query = "insert into asociados.beneficiarioahorro(id_ahorro, nombre, parentesco, edad, porcentaje) "
                    + "values (@id, @nombre, @parentesco, @edad, @porcentaje)";
            foreach (Beneficiario beneficiario in beneficiarios)
            {
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", this.id),
                    new SqlParameter("nombre", beneficiario.nombre),
                    new SqlParameter("parentesco", beneficiario.parentesco),
                    new SqlParameter("edad", beneficiario.edad),
                    new SqlParameter("porcentaje", beneficiario.porcentaje)
                };
                Queries.execute(query, parameters);
            }

            if (this.tipo == "Depósito a plazo")
            {
                query = "insert into asociados.ahorroplazo(id_ahorro, monto_inicial, plazo, extendido, codigo_cuenta) "
                    + "values(@id, @monto, @plazo, @ext, @cuenta)";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", this.id),
                    new SqlParameter("monto", this.ahorroPlazo.montoInicial),
                    new SqlParameter("plazo", this.ahorroPlazo.duracion),
                    new SqlParameter("ext", this.ahorroPlazo.extendido),
                    new SqlParameter("cuenta", this.ahorroPlazo.codigoCuenta)
                };
                Queries.execute(query, parameters);

                insertDetalle("Abono", this.ahorroPlazo.montoInicial, this.fecha);
            }

            if (this.tipo == "Programado")
            {
                query = "insert into asociados.ahorroprogramado(id_ahorro, cuota, forma_pago, plazo, extendido) "
                    + "values(@id, @cuota, @forma, @plazo, @ext)";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", this.id),
                    new SqlParameter("cuota", this.ahorroProgramado.cuota),
                    new SqlParameter("forma", this.ahorroProgramado.formaPago),
                    new SqlParameter("plazo", this.ahorroProgramado.duracion),
                    new SqlParameter("ext", this.ahorroProgramado.extendido)
                };
                Queries.execute(query, parameters);
            }
        }

        public AhorroDetalle insertDetalle(string tipo, decimal monto, DateTime fecha)
        {
            capitalizar(fecha);

            AhorroDetalle detalle = new AhorroDetalle();
            detalle.fecha = fecha;
            detalle.monto = Math.Round(monto, 2);
            detalle.tipo = tipo;

            if (tipo == "Abono") detalle.saldoParcial = Math.Round(this.saldo + detalle.monto, 2);
            else if (tipo == "Retiro") detalle.saldoParcial = Math.Round(this.saldo - detalle.monto, 2);

            guardarDetalle(detalle);

            detalle.correlativo = this.detalles.Count;

            //Reportes.comprobanteMovimiento(this.asociado, this, detalle);
            return detalle;
        }

        public void capitalizar(DateTime fechaHasta)
        {
            List<DateTime> fechas = AhorroServicio.fechasCapitalizables(this.ultimaCapitalizacion, fechaHasta);

            if (fechas.Count > 0)
            {
                decimal tasa, monto, saldoParcial;

                //Para la primera capitalización (que no aplica 3 meses, si no por días)
                if (this.ultimaCapitalizacion == this.fecha)
                {
                    int dias = (fechas.First() - this.fecha).Days;
                    tasa = (decimal)((double)this.interes / (100 * 12 * 30));

                    monto = Math.Round(this.saldo * dias * tasa, 2);
                    saldoParcial = Math.Round(this.saldo + monto, 2);

                    AhorroDetalle detalle = new AhorroDetalle("Abono intereses", monto, fechas.First(), saldo);
                    guardarDetalle(detalle);

                    fechas.RemoveAt(0);
                }


                //Para las capizalizaciones trimestrales pendientes. 
                tasa = (decimal)((double)this.interes / (100 * 4));

                foreach (DateTime fechaC in fechas)
                {
                    monto = Math.Round(this.saldo * tasa, 2);
                    saldoParcial = Math.Round(this.saldo + monto, 2);

                    AhorroDetalle detalle = new AhorroDetalle("Abono intereses", monto, fechaC, saldoParcial);
                    guardarDetalle(detalle);
                }
            }            
        }

        public void guardarDetalle(AhorroDetalle detalle)
        {
            if (detalles == null) detalles = new List<AhorroDetalle>();
            detalles.Add(detalle);

            string query = "insert into asociados.ahorrodetalle(id_ahorro, tipo, monto, saldo_parcial, fecha) "
                + "values(@id, @tipo, @monto, @saldo, @fecha)";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("id", this.id), 
                new SqlParameter("tipo", detalle.tipo),
                new SqlParameter("monto", detalle.monto),
                new SqlParameter("saldo", detalle.saldoParcial), 
                new SqlParameter("fecha", detalle.fecha)
            };

            Queries.execute(query, parameters);
        }

        public void extenderPlazo()
        {
            capitalizar(this.fechaVencimiento);

            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("id", this.id)
            };

            switch (this.tipo)
            {
                case "Depósito a plazo":
                    query = "update asociados.ahorroplazo set extendido = @ext where id_ahorro = @id";
                    parameters.Add(new SqlParameter("ext", ++this.ahorroPlazo.extendido));
                    break;
                case "Programado":                    
                    query = "update asociados.ahorroprogramado set extendido = @ext where id_ahorro = @id";
                    parameters.Add(new SqlParameter("ext", ++this.ahorroProgramado.extendido));
                    break;
            }

            Queries.execute(query, parameters);
        }

        public void finalizar()
        {
            capitalizar(this.fechaVencimiento);

            string query = "update asociados.ahorro set activo = @activo where id = @id";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("activo", false),
                new SqlParameter("id", this.id)
            };

            Queries.execute(query, parameters);
        }
    }
}
