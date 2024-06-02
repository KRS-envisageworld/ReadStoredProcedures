using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ReadStoredProceduers
{
    public class SQLOperation_Repo
    {
        private string _connectionString;
        public SQLOperation_Repo(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException();
            _connectionString = connectionString;
        }

        public string GetStoredProcedureText(string spName)
        {
            string returnValue = string.Empty;

            try
            {
                var sb = new StringBuilder();
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"sp_helptext '{spName}'", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        sb.AppendLine(reader["Text"].ToString().Trim());
                    }
                }
                returnValue = sb.ToString();
            }
            catch
            {
                throw;
            }
            return returnValue;
        }

        public List<string> GetStoredProcedureNameList() {
            List<string> spName = new List<string>();
            try
            {
                var sb = new StringBuilder();
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"SELECT spName = OBJECT_SCHEMA_NAME([object_id])+'.'+name FROM sys.procedures;", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        spName.Add(item: reader["spName"].ToString().Trim());
                    }
                }
            }
            catch
            {
                throw;
            }
            return spName;
        }

        public static bool TestConnection(string connectionString)
        {
            bool conncetionSuccess = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        conncetionSuccess = true;
                    }
                }
            }
            catch { }
            return conncetionSuccess;
        }
    }
}
