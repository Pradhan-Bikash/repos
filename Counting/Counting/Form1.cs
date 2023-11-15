using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int firstNumber = 0, lastNumber = 0;
        int divisibleTerm = 1;

        private void DivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm=Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add(2);
            cmbDivisibleTerm.Items.Add(3);
            cmbDivisibleTerm.Items.Add(4);
            cmbDivisibleTerm.Items.Add(5);
            cmbDivisibleTerm.Items.Add(6);
            cmbDivisibleTerm.Items.Add(7);
            cmbDivisibleTerm.Items.Add(8);
            cmbDivisibleTerm.Items.Add(10);
        }
        int controlNumber = 1;

        private void txtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void rgbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbBlack.Checked)
            {
                rgbRed.Checked = false;
                rgbGreen.Checked = false;
                rgbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rgbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbBlue.Checked)
            {
                rgbRed.Checked = false;
                rgbGreen.Checked = false;
                rgbBlack.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;
            }
        }

        private void rgbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbGreen.Checked)
            {
                rgbRed.Checked = false;
                rgbBlack.Checked = false;
                rgbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Green;
            }
        }

        private void rgbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbRed.Checked)
            {
                rgbBlack.Checked = false;
                rgbGreen.Checked = false;
                rgbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Bold);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Italic);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void btnCount_Click(object sender, EventArgs e) 
        {
            string divisibleNumber = "";
            if (txtStartFrom.Text.Trim() == "" || txtTo.Text.Trim() == "")
            {
                MessageBox.Show("please fill the neccesary field");
            }
            else if (cmbDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter the divisible value");
            }
            else
            {
                firstNumber = Convert.ToInt32(txtStartFrom.Text);
                lastNumber = Convert.ToInt32(txtTo.Text);
                //MessageBox.Show("Divisible " + divisibleTerm + " From "+ firstNumber + " To " + lastNumber);
                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                            divisibleNumber += Environment.NewLine;
                        controlNumber++;
                    }
                    txtDivisibleNumbers.Text = divisibleNumber;
                }
            }
        }
    }
}
