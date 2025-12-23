using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutupoto.Model
{
    // This class acts as a central helper for all Database operations.
    // It prevents code duplication by handling connections and commands in one place.
    internal class IDataBase
    {
        public static string connectionString = "Server=DESKTOP-NP5RE6D\\SQLEXPRESS; Database=KOSDb; Integrated Security=True; TrustServerCertificate=True;";

        // METHOD 1: DatatoDataTable
        // Purpose: Executes a SELECT query and returns the results as a DataTable.
        // It uses SqlDataAdapter which automatically handles opening/closing connections.
        public static DataTable DatatoDataTable(string query, List<SqlParameter> parameters)
        {
            try
            {
                // Create a new connection
                SqlConnection con = new SqlConnection(connectionString);
                
                // Prepare the command with the query and connection
                SqlCommand cmd = new SqlCommand(query, con);
                
                // Add parameters to the command to prevent SQL Injection
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                // Use SqlDataAdapter to fetch data (Disconnected Architecture)
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                
                // Fill the DataTable with the result set from the database
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                // Re-throw the exception to be handled by the UI layer
                throw ex;
            }
        }

        // Overload 1: For queries with a single parameter
        public static DataTable DatatoDataTable(string query, SqlParameter parameter)
        {
            return DatatoDataTable(query, new List<SqlParameter>() { parameter });
        }

        // Overload 2: For queries with NO parameters (e.g., "SELECT * FROM users")
        public static DataTable DatatoDataTable(string query)
        {
            return DatatoDataTable(query, new List<SqlParameter>() { });
        }

        // METHOD 2: executeNonQuery
        // Purpose: Executes commands that DO NOT return data (INSERT, UPDATE, DELETE).
        // It manages the connection state (Open/Close) manually.
        public static void executeNonQuery(string query, List<SqlParameter> parameters)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            
            // We must open the connection manually for ExecuteNonQuery
            con.Open();
            try
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                
                // Execute the command (returns the number of affected rows, though ignored here)
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally 
            { 
                // CRITICAL: Always close the connection in the 'finally' block
                // ensures the connection closes even if an error occurs.
                con.Close(); 
            }
        }

        // Overload: For executeNonQuery with a single parameter
        public static void executeNonQuery(string query, SqlParameter parameter)
        {
            executeNonQuery(query, new List<SqlParameter>() { parameter });
        }

        // METHOD 3: executeScalar
        // Purpose: Executes a query that returns a SINGLE value (e.g., Count, ID, Sum).
        // Used often for "SELECT @@IDENTITY" or "SELECT COUNT(*)".
        public static object executeScalar(string query, List<SqlParameter> parameters)
        {
            object value = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            
            con.Open();
            try
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                
                // ExecuteScalar returns the first column of the first row
                value = cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally 
            { 
                con.Close(); 
            }
            
            // Return the single value (as an object, needs casting later)
            return value;
        }
    }
}