using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Submit.Text = "Login";
            //combo box
           /* comboBox1.Items.Add("bikash");
            comboBox1.Items.Add("biku");
            comboBox1.Items.Add("bi");
            comboBox1.Items.Add("Pradhan");
            comboBox1.SelectedIndex = 1;*/
           //message box
           /* String messagetext = "Do you want to close window";
            String messagetitle = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //MessageBox.Show("simple message text");
            //MessageBox.Show(messagetext,messagetitle);
            DialogResult result= MessageBox.Show(messagetext, messagetitle, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                // DO nothing
            }
           */
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            Submit.Text = "Clicked";
        }

        private void Submit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Submit.Text = "Enter";
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "First Label"; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
