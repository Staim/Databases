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
            LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            loginLabel.Text = loginForm.loginInfo();

        }

        private void регистраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistratorsForm regForm = new RegistratorsForm();
            regForm.MdiParent = this;
            regForm.Show();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void своднаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arenda arendaForm = new arenda();
            arendaForm.MdiParent = this;
            arendaForm.setDataGrid("", true);
            arendaForm.Show();
        }

        private void арендаАдресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arenda arendaForm = new arenda();
            arendaForm.MdiParent = this;
            arendaForm.setDataGrid("", false);
            arendaForm.Show();
        }
    }
}
