using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int loopWorkAmount = 0, loopControlValue = 10;
            while (loopControlValue < 20)
            {
                textBox1.Text += loopWorkAmount.ToString() + Environment.NewLine;
                loopControlValue++;
                loopWorkAmount++;
            }
            MessageBox.Show(loopWorkAmount.ToString());
        }
    }
}
