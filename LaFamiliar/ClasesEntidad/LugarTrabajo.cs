using La_Familiar.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class LugarTrabajo
    {
        private int _id;
        private string _nombre;
        private string _direccion;
        private string _telefono;

        public int id { get { return _id; } set { _id = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string direccion { get { return _direccion; } set { _direccion = value; } }
        public string telefono { get { return _telefono; } set { _telefono = value; } }

        public LugarTrabajo(int id, string nombre, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public void update()
        {
            string query = "update asociados.lugartrabajo set nombre = @n, telefono = @t, direccion = @d where id = @id";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("id", id),
                new SqlParameter("n", nombre),
                new SqlParameter("d", direccion),
                new SqlParameter("t", telefono)
            };
            Queries.execute(query, parameters);
        }
    }
}
