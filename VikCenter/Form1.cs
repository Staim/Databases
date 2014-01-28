using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            db1DataSetTableAdapters.JoinTableTableAdapter joinAdapter = new db1DataSetTableAdapters.JoinTableTableAdapter();
            db1DataSet dataset = new db1DataSet();
            joinAdapter.Fill(dataset.JoinTable);
            BindingSource bs = new BindingSource(dataset, "JoinTable");
            dataGridView1.DataSource = bs;
        }
    }
}
