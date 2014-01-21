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
            SetupGridView();
        }

        private void SetupGridView()
        {
            регистраторыTableAdapter1.Fill(db1DataSet1.Регистраторы);
            dataGridView1.DataSource = db1DataSet1.Регистраторы;

        }
    }
}
