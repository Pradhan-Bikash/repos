using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;

namespace ProjectDb
{
    public  class Program
    {
        private string connectionString = "your_connection_string_here";

        public void CreateTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "CREATE TABLE ExampleTable (ID INT PRIMARY KEY, Name NVARCHAR(50))";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertData(int id, string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO ExampleTable (ID, Name) VALUES (@ID, @Name)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable RetrieveData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM ExampleTable";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public void DeleteData(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM ExampleTable WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    command.ExecuteNonQuery();
                }
            }
        }
        static void Main(string[] args)
        {
            Program sqlOperations = new Program();

            // Create table
            sqlOperations.CreateTable();

            // Insert data
            sqlOperations.InsertData(1, "John Doe");

            // Retrieve data
            DataTable data = sqlOperations.RetrieveData();
            Console.WriteLine("Data Retrieved:");
            foreach (DataRow row in data.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}");
            }

            // Delete data
            sqlOperations.DeleteData(1);

            // Retrieve data after deletion
            data = sqlOperations.RetrieveData();
            Console.WriteLine("Data After Deletion:");
            foreach (DataRow row in data.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}");
            }
        }
       
    }
}
