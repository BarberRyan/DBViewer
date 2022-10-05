using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Forms;

namespace DBViewer
{
    public class DB
    {
        public string connectionString;
        public SqlConnection conn;

        public DB(string connection)
        {
            connectionString = connection;
        }

    }

    public static class DBExtensions
    {

        /// <summary>
        /// Sets the database's connection string to an empty string to prevent use
        /// </summary>
        /// <param name="database">Database to target</param>
        public static void CloseConnection(this DB database)
        {
            database.connectionString = "";
        }

        /// <summary>
        /// Tests database connection status
        /// </summary>
        /// <param name="database">Database to target</param>
        /// <returns>boolean value that reflects if a connection is possible</returns>
        public static bool TestConnection(this DB database)
        {
            try
            {
                using (database.conn = new SqlConnection(database.connectionString))
                {
                    database.conn.Open();
                    database.conn.Close();
                }

            }
            catch
            {
                return false;
            }
            database.conn.Dispose();
            return true;
        }

        /// <summary>
        /// Provides a list of accessible tables for the signed-in user
        /// </summary>
        /// <param name="database">Database to target</param>
        /// <returns>List of table names</returns>
        public static List<string> GetTableList(this DB database)
        {
            List<string> tables = new List<string>();
            tables.Add("");
            if(database.conn != null)
            {
                using (database.conn = new SqlConnection(database.connectionString))
                {
                    database.conn.Open();
                    DataTable dt = database.conn.GetSchema("Tables");
                    foreach (DataRow row in dt.Rows)
                    {
                        string tablename = (string)row[2];
                        tables.Add(tablename);
                    }
                }
                database.conn.Dispose();
                return tables;
            }
            return new List<string> { };
            
        }

        /// <summary>
        /// Provides a DataTable that reflects the contents of the specified database table
        /// </summary>
        /// <param name="database">Database to target</param>
        /// <param name="table">Name of table to retrieve</param>
        /// <param name="where">(Optional) "WHERE" clause</param>
        /// <returns>DataTable containing table data</returns>
        public static DataTable GetTable(this DB database, string table, string where = "")
        {

            using (database.conn = new SqlConnection(database.connectionString))
            {
                database.conn.Open();
                SqlDataAdapter SQLDa = new SqlDataAdapter($"SELECT * FROM {table} {where};", database.conn);
                DataTable dt = new DataTable();

                try
                {
                    SQLDa.Fill(dt);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "An error has occurred");
                }
                return dt;
            }
        }

        /// <summary>
        /// Gets record count of specified table
        /// </summary>
        /// <param name="database">Database to target</param>
        /// <param name="table">Table to target</param>
        /// <returns>String containing the number of records in the table</returns>
        public static string GetTableCount(this DB database, string table)
        {
            string RecordCount;
            try
            {
                using (database.conn = new SqlConnection(database.connectionString))
                {
                    database.conn.Open();

                    SqlCommand cmd = database.conn.CreateCommand();
                    cmd.CommandText = $"SELECT COUNT(*) FROM {table}";

                    RecordCount = cmd.ExecuteScalar().ToString();

                    database.conn.Dispose();
                }
            }
            catch (Exception e)
            {
                return $"ERROR: {e.Message}";
            }
            return RecordCount;
        }
    }
}