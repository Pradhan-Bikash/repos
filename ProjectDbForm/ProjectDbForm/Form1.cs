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
using DatabaseLib3;

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
            try
            {
                DatabaseManager dm = new DatabaseManager();
                StudentDTO sd = new StudentDTO();
                sd.Id = Convert.ToInt32(textBox1.Text);
                sd.Name = textBox2.Text;
                sd.Age = Convert.ToInt32(textBox3.Text);
                int i = dm.updateStudent(sd);

                if (i > 0)
                {

                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            DatabaseManager dm = new DatabaseManager();
            StudentDTO sd = new StudentDTO();
            sd.Name=textBox2.Text;
         dataGridView1.DataSource = dm.searchStudent(sd);
        }
    }
}
