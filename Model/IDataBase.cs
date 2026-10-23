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
        // IMPORTANT CHANGE FOR PORTABILITY:
        // Changed "Server=DESKTOP-..." to "Server=.\\SQLEXPRESS".
        // The "." (dot) represents "Localhost", meaning it will look for SQL Express on whichever computer runs this app.
        public static string connectionString = "Server=.\\SQLEXPRESS; Database=KOSDb; Integrated Security=True; TrustServerCertificate=True;";

        // METHOD 1: DatatoDataTable
        // Purpose: Executes a SELECT query and returns the results as a DataTable.
        // It uses SqlDataAdapter which automatically handles opening/closing connections.
        // SqlException is not caught here: it reaches the UI layer (and the global handler in Program.cs) with its stack trace intact.
        public static DataTable DatatoDataTable(string query, List<SqlParameter> parameters)
        {
            // "using" disposes the connection, command and adapter even if an error occurs
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Add parameters to the command to prevent SQL Injection
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                // Use SqlDataAdapter to fetch data (Disconnected Architecture)
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();

                    // Fill the DataTable with the result set from the database
                    da.Fill(dt);

                    return dt;
                }
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
        public static void executeNonQuery(string query, List<SqlParameter> parameters)
        {
            // "using" closes the connection even if an error occurs, preventing leaks
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                // We must open the connection manually for ExecuteNonQuery
                con.Open();

                // Execute the command (returns the number of affected rows)
                cmd.ExecuteNonQuery();
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
        public static object? executeScalar(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                con.Open();

                // ExecuteScalar returns the first column of the first row (as an object, needs casting later)
                return cmd.ExecuteScalar();
            }
        }
    }
}
