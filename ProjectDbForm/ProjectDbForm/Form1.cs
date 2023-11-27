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
using DatabaseLib2;

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
           DatabaseManager dm=new DatabaseManager();
            StudentDTO sd = new StudentDTO();
            sd.Id = Convert.ToInt32(textBox1.Text);
            sd.Name =textBox2.Text;
            sd.Age =Convert.ToInt32( textBox3.Text);
            dm.insertStudent(sd);
            MessageBox.Show("Successfully Stored");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseManager dm = new DatabaseManager();
            StudentDTO sd = new StudentDTO();
            sd.Id = Convert.ToInt32(textBox1.Text);
            sd.Name = textBox2.Text;
            sd.Age = Convert.ToInt32(textBox3.Text);
            dm.updateStudent(sd);
            MessageBox.Show("Successfully Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseManager dm = new DatabaseManager();
            StudentDTO sd = new StudentDTO();
            sd.Id = Convert.ToInt32(textBox1.Text);
            
            dm.deleteStudent(sd);
           
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
