using MySqlConnector;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=promtfinalapp");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
      //  MySqlCommand cmd;
        //MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=promtfinalapp");

        public Form1()
        {
            InitializeComponent();
            showdata();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
           
            con.Open();
            string InsertQuey = $"INSERT INTO promtfinalapp( campin-name, campin-url, hastag) VALUES ('{CampaignName.Text}','{url.Text}','{hashtag.Text}')";
           MySqlCommand cmd = new MySqlCommand(InsertQuey, con);
           // cmd.ExecuteNonQuery();
            MessageBox.Show("data has saved in database");
            con.Close();
            showdata();
        }
        public void showdata()
        {
            adpt = new MySqlDataAdapter("select * from promtfinalapp", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView_c.DataSource = dt;
        }
    }
}