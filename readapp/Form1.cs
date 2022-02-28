

using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
namespace readapp
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=promtfinalapp");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        private DataGridView dgv1;
        DataTable dt;
        // MySqlConnection con = new MySqlConnection(@"server=localhost;user=root;password=admin;database=promtfinalapp");
        public Form1()
        {
            InitializeComponent();
            showdata();

        }
        public void showdata()
        {
            adpt = new MySqlDataAdapter("select * from promtfinalapp", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv1.DataSource = dt;
        }

        private void InitializeComponent()
        {
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(72, 53);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(398, 176);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(602, 292);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}