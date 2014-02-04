using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace VikCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            conn.ConnectionString = "server=localhost;user id=root;password=polta1712;persistsecurityinfo=True;database=database";
            conn.Open();
            DataSet dataset = new DataSet();
            adapter.SelectCommand = new MySqlCommand("select * from contracts", conn);
            
            adapter.Fill(dataset);
            this.dataGridView1.DataSource = dataset.Tables[0];
            MessageBox.Show("test");

        }
    }
}
