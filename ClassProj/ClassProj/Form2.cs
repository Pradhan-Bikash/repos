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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
          Employee personalDetails = new Employee();
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text=personalDetails.EmployeeId.ToString();
            textBox2.Text=personalDetails.Name.ToString();
            textBox3.Text=personalDetails.Age.ToString();

        }
    }
}
