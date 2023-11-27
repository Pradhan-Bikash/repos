using System.Data.SqlClient;
namespace Database
{
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
                //MessageBox.Show("Successfully Saved");
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