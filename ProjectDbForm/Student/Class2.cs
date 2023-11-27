using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class DatabaseManager
    {
        public void insertStudent(StudentDTO student)
        {
           // SqlConnection con = null;
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTab values(@ID,@Name,@age)", con);
                cmd.Parameters.AddWithValue("@ID", student.Id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.ExecuteNonQuery();
                con.Close();
            
        }
    }
}
