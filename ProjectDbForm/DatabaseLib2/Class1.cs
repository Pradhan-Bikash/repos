
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
                con = new SqlConnection("Data Source=.;Initial Catalog=Student;Integrated Security=True;Pooling=False");
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
        public int updateStudent(StudentDTO student) 
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=Student;Integrated Security=True;Pooling=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update UserTab set Name = @Name,Age=@Age where ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID",student.Id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
                
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
                    con = new SqlConnection("Data Source=.;Initial Catalog=Student;Integrated Security=True;Pooling=False");
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

        /*1. first check the text box empty or fill if filled than the control goes to if block
         * in if block
         *    1.first establish a connection with database
         *    2.open the database to inrect searching data from student table with the help of select query.
         *    3.sqlcommand for do operation with the data table
         *    4.addwith value set the value in name 
         *    5.sql adapter represent a set of data command use to fill dataset 
         *    6.when call fill data data store from datatable
         *    7.then we  need to close the connection other wise it will take more unnecessary memory
         * 
         * else part
         * 2.in else part when if part is false then control goes to else block
         *      1.in else block we are retrive all data from student table 
         *      
         *   if try block throw any erron then catch block executed the error
        */
        public DataTable searchStudent(StudentDTO studen)
        {
            SqlConnection con = null;
            try
            {
                if (!string.IsNullOrEmpty(studen.Name))
                {
                     con = new SqlConnection("Data Source=.;Initial Catalog=Student;Integrated Security=True;Pooling=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from UserTab where Name=@Name", con);
                    cmd.Parameters.AddWithValue("@Name", studen.Name);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
                else
                {
                    con = new SqlConnection("Data Source=.;Initial Catalog=Student;Integrated Security=True;Pooling=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from UserTab ", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
            finally
            {
                if(con != null)
                {
                    con.Dispose();
                }
            }
        }

    }
}
