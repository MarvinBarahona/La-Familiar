using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.Clases
{
    static class Provider
    {
        private static FormMain f;
        private static SqlConnection c;


        // Guarda el FormMain para poder mostrarlo y cerrarlo desde cualquier ventana. 
        public static FormMain formMain
        {
            get
            {
                return f;
            }
            set
            {
                f = value;
            }
        }

        // Crea, abre y retorna una conexión para todos los procesos. 
        public static SqlConnection connection
        {
            get
            {
                if (c == null)
                {
                    c = new SqlConnection(La_Familiar.Properties.Settings.Default.La_FamiliarConnectionString);
                }
                if (c.State == System.Data.ConnectionState.Closed)
                {
                    c.Open();
                }

                return c;
            }
        }

        public static string numToFilledZeroString(int num, int cantZeros)
        {
            string numero = "";
            int count = num.ToString().Length;
            for (int i = 0; i < (cantZeros - count); i++)
            {
                numero += "0";
            }
            numero += num.ToString();
            return numero;
        }
    }
}
