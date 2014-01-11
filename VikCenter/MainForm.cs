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
    public partial class MainForm : Form
    {
        public db1DataSet dataSet = new db1DataSet();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           // LoginForm loginForm = new LoginForm();
           // loginForm.ShowDialog();
        }

        private void регистраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistratorsForm regForm = new RegistratorsForm();
            regForm.MdiParent = this;
            regForm.Show();

        }
    }
}
