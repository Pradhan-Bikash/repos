using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Employee personalDetails = new Employee();
        private void setValue_Click(object sender, EventArgs e)
        {
           
            personalDetails.EmployeeId = Convert.ToInt32(txtEmployeeid.Text);
            personalDetails.Name = txtName.Text;
            personalDetails.Age= Convert.ToInt32(txtAge.Text);
            MessageBox.Show("All data received");

        }

        private void txtSend_Click(object sender, EventArgs e)
        {
            personalDetails.EmployeeId = Convert.ToInt32(txtEmployeeid.Text);
            personalDetails.Name = txtName.Text;
            personalDetails.Age = Convert.ToInt32(txtAge.Text);
            Form2 frm =new Form2();
            frm.personalDetails = personalDetails;
            frm.ShowDialog();
        }
    }
}
