using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.Clases
{
    static class Queries
    {
        
        static SqlTransaction transaction;

// ############################################################################
// ##################               getCommand         ########################
// ############################################################################

        public static void transactionBegin()
        {
            transaction = Provider.connection.BeginTransaction();
        }

        public static void transactionCommit()
        {
            transaction.Commit();
            transaction = null;
        }

        public static void transactionRollback()
        {
            transaction.Rollback();
            transaction = null;
        }
// ############################################################################
// ##################               getCommand         ########################
// ############################################################################

        public static SqlCommand getCommand(string query)
        {
            SqlCommand command;
            if (transaction == null)
            {
                command = new SqlCommand(query, Provider.connection);
            }
            else
            {
                command = new SqlCommand(query, transaction.Connection, transaction);
            }

            return command;
        }

        public static SqlCommand getCommand(string query, List<SqlParameter> parameters)
        {
            SqlCommand command = getCommand(query);
            command.Parameters.AddRange(parameters.ToArray());

            return command;
        }

// ############################################################################
// #################               getDataTable         #######################
// ############################################################################

        private static DataTable getDataTable(SqlCommand command)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            
            return dataTable;
        }

        public static DataTable getDataTable(string query)
        {
            return getDataTable(getCommand(query));
        }

        public static DataTable getDataTable(string query, List<SqlParameter> parameters)
        {
            return getDataTable(getCommand(query, parameters));
        }

// ############################################################################
// #################               getDataReader         ######################
// ############################################################################

        private static SqlDataReader getDataReader(SqlCommand command)
        {
            return command.ExecuteReader();
        }

        public static SqlDataReader getDataReader(string query)
        {
            return getDataReader(getCommand(query));
        }

        public static SqlDataReader getDataReader(string query, List<SqlParameter> parameters)
        {
            return getDataReader(getCommand(query, parameters));
        }

// ############################################################################
// #################             executeScalar           ######################
// ############################################################################

        //Ejecutar Scalar significa que devuelve la primera fila de la primera columna afectada por la consulta.
        //Usar este método para retornar el id de la nueva fila agregada luego de un Insert. 
        
        private static int executeScalar(SqlCommand command)
        {
            return (int)command.ExecuteScalar();
        }

        public static int executeScalar(string query)
        {
            return executeScalar(getCommand(query));
        }

        public static int executeScalar(string query, List<SqlParameter> parameters)
        {
            return executeScalar(getCommand(query, parameters));
        }

// ############################################################################
// #####################             execute           ########################
// ############################################################################

        private static void execute(SqlCommand command)
        {
            command.ExecuteNonQuery();
        }

        public static void execute(string query)
        {
            execute(getCommand(query));
        }

        public static void execute(string query, List<SqlParameter> parameters)
        {
            execute(getCommand(query, parameters));
        }
    }
}
