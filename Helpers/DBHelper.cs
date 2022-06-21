using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagementSystem.Helpers
{
    class DBHelper
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=DB_TicketSales;trusted_connection=true;");
        public const string ConnectionString = @"server=(localdb)\MSSQLLocalDB;database= DB_TicketSales;trusted_connection=true;";
        public enum OperationTypes
        {
            Insert,
            Update,
            Delete
        }
        public static DataTable Search(string tableName, List<TableInfo> tableInfos)
        {
            DataTable dt = new DataTable();
            string command = "SELECT * FROM tbl_Customer WHERE ";
            for (int i = 0; i < tableInfos.Count; i++)
            {
                command = command + $"{tableInfos[i].ColumnName} Like '%{tableInfos[i].ParameterValue}%' ";
                command = command + "or ";

            }
            command = command.Remove(command.Length - 3);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader =  sqlCommand.ExecuteReader();
            dt.Load(reader);
            sqlConnection.Close();
            return dt;
        }
        public static DataTable ExecuteNonQuery(string query, CommandType commandType = CommandType.Text, string connectionString = ConnectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = commandType;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public static DataTable ExecuteNonQuery(string query, List<DBParameter> parameters, CommandType commandType = CommandType.Text, string connectionString = ConnectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.CommandType = commandType;
                foreach (var item in parameters)
                {
                    sqlCommand.Parameters.AddWithValue($"@{item.ParameterName}", item.ParameterValue);

                }
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                dt.Load(reader);
                connection.Close();
                return dt;
            }
        }
        public static int ExecuteNonQuery(OperationTypes operationTypes, string tableName, List<DBParameter> dBParameters, string columnName = null, int id = 0, string connStr = ConnectionString)
        {
            string query = "";
            int result = 0;
            StringBuilder columnStr = new StringBuilder();
            StringBuilder paramStr = new StringBuilder();
            switch (operationTypes)
            {
                case OperationTypes.Insert:
                    //INSERT INTO {Table}(FirstName,LastName,Year) VALUES (@FirstName,@LastName,@Year)
                    foreach (var item in dBParameters)
                    {
                        columnStr.Append($"{item.ParameterName},");
                        paramStr.Append($"@{item.ParameterName},");
                    }
                    columnStr.Remove(columnStr.Length - 1, 1);
                    paramStr.Remove(paramStr.Length - 1, 1);
                    query = $"INSERT INTO {tableName} ({columnStr}) VALUES ({paramStr})";
                    break;
                case OperationTypes.Update:
                    // UPDATE {table} SET FirstName = @FirstName, LastName = @LastName......  WHERE {columnId} = @id
                    foreach (var item in dBParameters)
                    {
                        columnStr.Append($"{item.ParameterName}=");
                        columnStr.Append($"@{item.ParameterName},");
                    }
                    columnStr.Remove(columnStr.Length - 1, 1);
                    query = $"UPDATE {tableName} SET {columnStr} WHERE {columnName}={id}";
                    break;
                case OperationTypes.Delete:
                    //Delete {table} WHERE {columnId} =@id
                    query = $"Delete {tableName} WHERE {columnName} = {id}";
                    break;
                default:
                    break;
            }
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            if (operationTypes != OperationTypes.Delete)
            {
                foreach (var item in dBParameters)
                {
                    sqlCommand.Parameters.AddWithValue($"@{item.ParameterName}", item.ParameterValue);
                }
            }

            sqlConnection.Open();
            result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
        public static double GetMovieIMDbAverage(string genre)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                double imdb = 0;
                //DataTable dt = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("SELECT AVG(IMDbScore) Average FROM tbl_Movie WHERE Genre = @genre ", connection);
                sqlCommand.Parameters.AddWithValue("@genre", genre);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    imdb = reader.GetDouble(reader.GetOrdinal("Average"));
                }
                //dt.Load(reader);
                connection.Close();
                return imdb;
                //return dt;
            }
        }
    }
        public class TableInfo
        {
            public string ColumnName { get; set; }
            public string ParameterValue { get; set; }
        }
    public class DBParameter
    {
        public string ParameterName { get; set; }
        public object ParameterValue { get; set; }
    }
}
