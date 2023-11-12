namespace FormGetData
{
    public partial class GetData : Form
    {
        public GetData()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string surname = textSurName.Text;
            string NameSurname = name + " " + surname;
            ShowData showData = new ShowData();
            showData.lblNameSurname.Text = NameSurname;
            showData.Show();
            
        }
    }
}