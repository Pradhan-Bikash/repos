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
            String messagetext = "Do you want to close window";
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
