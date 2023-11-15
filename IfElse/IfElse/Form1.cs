using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 20, b = 30;
            string name = "bikash";
            bool control = true;
            if (a == 20)
            {
                label1.Text = "if block 1 was executed";
            }
            if (!control)
            {
                textBox1.Text = "if block 2 was executed";
            }
            if (a <= b)
            {
                MessageBox.Show("if block 3 was executed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
