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
        public RowInfoForm()
        {
            InitializeComponent();
        }
        public RowInfoForm(string s1, string s2, string s3, string s4)
        {
            InitializeComponent();
            label1.Text = label1.Text + s1;
            label2.Text = label2.Text + s2;
            label3.Text = label3.Text + s3;
            label4.Text = label4.Text + s4;
        }
    }
}
