using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectDbForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
           con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTab values(@ID,@Name,@age)", con);
            cmd.Parameters.AddWithValue("@ID",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name",(textBox2.Text));
            cmd.Parameters.AddWithValue("@Age",int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserTab set Name = @Name,Age=@Age where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", (textBox2.Text));
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "") { 
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserTab where Name=@Name", con);
            cmd.Parameters.AddWithValue("@Name", (textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
            }
            else
            {
                MessageBox.Show("Please enter  name only you want to Delete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                if (textBox2.Text != "")
                {
                     con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from UserTab where Name=@Name", con);
                    cmd.Parameters.AddWithValue("@Name", (textBox2.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else
                {

                   con = new SqlConnection("Data Source=.;Initial Catalog=MyTestDB;Integrated Security=True;Pooling=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from UserTab ", con);
                    //cmd.Parameters.AddWithValue("@Name", (textBox2.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
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
