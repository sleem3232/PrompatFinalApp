namespace WinFormsApp7;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

    public partial class Form1 : Form
    {
    MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=promtfinalapp");
    MySqlCommand cmd;
    MySqlDataAdapter adpt;
    DataTable dt;


    public Form1()
        {
            InitializeComponent();
        showdata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_b_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    public void showdata()
    {
        adpt = new MySqlDataAdapter("select * from promtfinalapp", con);
        dt = new DataTable();
        adpt.Fill(dt);
        dataGridView_b.DataSource = dt;
    }

    private void button9_Click(object sender, EventArgs e)
    {

    }
}
