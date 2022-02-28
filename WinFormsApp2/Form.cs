using Microsoft.EntityFrameworkCore.Storage;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
   
{
    public partial class Form : System.Windows.Forms.Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=promtfinalapp");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        public Form()
        {
            InitializeComponent();
            showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   int firstTextBox = int.Parse(textBox1.Text);

            MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=promtfinalapp");

            string InsertQuey = $"INSERT INTO promtfinalapp( promtfinalappcol, promtfinalappcol1, promtfinalappcol2) VALUES ('{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')";
            //using var con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(InsertQuey, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data has saved in database");
            con.Close();
            showdata();




        }
        public void showdata()
        {
            adpt = new MySqlDataAdapter("select * from promtfinalapp",con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource=dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    MySqlCommand cmd;
        //    MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=promtfinalapp");
        //    con.Open();
        //    cmd=new MySqlCommand($"INSERT INTO promtfinalapp( promtfinalappcol, promtfinalappcol1, promtfinalappcol2) VALUES ('{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')");
        //    cmd.ExecuteNonQuery();
        //    MessageBox.Show("data has saved in database");
        //    con.Close();
        }
    }
}