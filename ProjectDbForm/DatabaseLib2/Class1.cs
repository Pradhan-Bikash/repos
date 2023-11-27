using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseLib2
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class DatabaseManager
    {
        public void insertStudent(StudentDTO student)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTab values(@ID,@Name,@age)", con);
                cmd.Parameters.AddWithValue("@ID", student.Id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
            }
        }
        public void updateStudent(StudentDTO student) 
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update UserTab set Name = @Name,Age=@Age where ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID",student.Id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
            }
        }
        public void deleteStudent(StudentDTO student)
        {
            SqlConnection con = null;
            try
            {   
                    con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete UserTab where ID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID",student.Id );
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
            }
        }

    }
}
