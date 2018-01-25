using La_Familiar.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class AportacionDetalle
    {
        int _idAsociado;
        decimal _monto;
        DateTime _fecha;
        decimal _saldoParcial;
        string _tipo;

        public int idAsociado { get { return _idAsociado; } set { _idAsociado = value; } }
        public decimal monto { get { return _monto; } set { _monto = value; } }
        public DateTime fecha { get { return _fecha; } set { _fecha = value; } }
        public decimal saldoParcial { get { return _saldoParcial; } set { _saldoParcial = value; } }
        public string tipo { get { return _tipo; } set { _tipo = value; } }

        public decimal saldoAnterior { get { return saldoParcial - monto; } }

        public AportacionDetalle(Asociado asociado, string tipo, DateTime fecha, decimal monto = 0)
        {
            this.idAsociado = asociado.id;            
            this.fecha = fecha;
            this.tipo = tipo;

            if (tipo.StartsWith("Abono"))
            {
                this.monto = monto;
                this.saldoParcial = asociado.aportacion + monto;
            }

            else
            {
                this.saldoParcial = 0;
                this.monto = asociado.aportacion;
            } 
        }

        public void insert()
        {
            try
            {
                string query = "insert into asociados.aportaciondetalle (id_asociado, monto, fecha, tipo) values (@id, @monto, @fecha, @tipo)";
                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", this.idAsociado),
                    new SqlParameter("monto", this.monto),
                    new SqlParameter("fecha", this.fecha),
                    new SqlParameter("tipo", this.tipo)
                };
                Queries.execute(query, parameters);

                query = "update asociados.asociado set aportacion = @aportacion where id = @id";
                parameters = new List<SqlParameter>() 
                {
                    new SqlParameter("id", this.idAsociado),
                    new SqlParameter("aportacion", this.saldoParcial)
                };
                Queries.execute(query, parameters);
            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
