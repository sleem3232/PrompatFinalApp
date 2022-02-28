using MySqlConnector;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// login to app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BRegister_Click(object sender, EventArgs e)
        {



            //MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=regester");

            //string InsertQuey = $"INSERT INTO regester( username, busines, password) VALUES ('{username.Text}','{BName.Text}','{BPassword.Text}')";

            //con.Open();
            //MySqlCommand cmd = new MySqlCommand(InsertQuey, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            MessageBox.Show("busnies account accesed");


        }

   

        private void NRegister_Click(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=nonprofit");

            //string InsertQuey = $"INSERT INTO nonprofit( username, name, Email,website,password) VALUES ('{NUsername.Text}','{NName.Text}','{NEmail.Text},{NWebsite.Text},{NPassword.Text}')";

            //con.Open();
            //MySqlCommand cmd = new MySqlCommand(InsertQuey, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            MessageBox.Show("non profit account accesed");

        }

        private void NPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ARegister_Click(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=activites-account");

            //string InsertQuey = $"INSERT INTO activites-account(usename,email,adress,phone,twitter,password) VALUES ('{AUsername.Text}','{AEmail.Text}','{Adress.Text},{APhone.Text},{ATwitter.Text},{APassword.Text}')";

            //con.Open();
            //MySqlCommand cmd = new MySqlCommand(InsertQuey, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            MessageBox.Show("activites account accesed");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}