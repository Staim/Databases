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
    public partial class RowInfoForm : Form
    {
        private DataGridViewCell cell;
        public RowInfoForm()
        {
            InitializeComponent();
        }
        public RowInfoForm(string s1, string s2, string s3, string s4, DataGridViewCell cell)
        {
            InitializeComponent();
            cLoginLabel.Text = s2;
            createTimeLabel.Text = s1;
            eLoginLabel.Text = s4;
            editTimeLabel.Text = s3;
            if (cell.Value != null) comment.Text = cell.Value.ToString();
            this.cell = cell;
        }

        private void RowInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comment.Text.Length > 0) this.cell.Value = comment.Text;
            this.Close();
        }
    }
}
