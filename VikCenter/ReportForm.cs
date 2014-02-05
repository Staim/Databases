using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VikCenter
{
    public partial class Report : Form
    {
        MainForm all;
        DataSet1TableAdapters.JoinTableAdapter joinAdapter = new DataSet1TableAdapters.JoinTableAdapter();

        public Report()
        {
            InitializeComponent();
        }

        private void MyInit()
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox1.Enabled = false;
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            string[] combobox1_items = new string[] {"Все",
                "Алиева Е.И","Баркевич В.В.","Белова Ю.А.","Денисова Н.С.","Завгородная Е.В.","Мишин.В.И.","Пашина А.Е.","Самарская Ю.А.","Соколова Ю.В.","Черняева М.Н."
            };
            comboBox1.Items.AddRange(combobox1_items);
            comboBox1.Text = "Все";
            comboBox2.Items.AddRange(combobox1_items);
            comboBox2.Text = "Все";

            all = (this.MdiParent as MainForm);
            
            joinAdapter.Fill(all.global.dataSet.JoinTable);
            //BindingSource bs = new BindingSource(all.global.dataSet, "JoinTable");
            
            this.bindingSource1 = new BindingSource(all.global.dataSet, "JoinTable");
            this.datagridview1.DataSource = this.bindingSource1;
            
            SetUpDataGrid2();
        }

        //установка фильтров
        private void button1_Click(object sender, EventArgs e)
        {
       //     Form1 frm = new Form1();
       //     frm.ShowDialog();
            bindingSource1.RemoveFilter();
            setFilters();
        }

        private void setFilters()
        {
            string date = DateTime.Parse("01.01.2000").ToShortDateString();
            string date2 = DateTime.Parse("01.01.2020").ToShortDateString();
            if (dateTimePicker1.Enabled) { date = dateTimePicker1.Value.ToShortDateString(); date2 = dateTimePicker2.Value.ToShortDateString(); }
            
            string registrator = "";
            if (textBox1.Enabled)
            {
                registrator = textBox1.Text;
            }

            string men1 = "";
            string men2 = "";
            if (comboBox1.Enabled)
            {
                if (comboBox1.Text == "Все") men1 = ""; else men1 = comboBox1.Text;
            }

            if (comboBox2.Enabled)
            {
                if (comboBox2.Text == "Все") men2 = ""; else men2 = comboBox2.Text;
            }


            bindingSource1.Filter = "[pay_date] >= '" + date + "'AND [pay_date] <= '" + date2 + "'" +
                "AND [registrator] LIKE '%" + registrator + "%'" +
                "AND [man1] LIKE '%" + men1 + "%'" +
                "AND [man2] LIKE '%" + men2 + "%'";

        }

        private void SetUpDataGrid2()
        {
            datagridview1.Columns["name"].HeaderText = "Организация";
            datagridview1.Columns["sum"].HeaderText = "Сумма";
            datagridview1.Columns["sum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.Columns["contr_number"].HeaderText = "№ Договора";
            datagridview1.Columns["contr_number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.Columns["registrator"].HeaderText = "Регистратор";

            datagridview1.Columns["pay_date"].HeaderText = "Дата платежа";
            datagridview1.Columns["pay_date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.Columns["man1"].HeaderText = "Холодный звонок";
            datagridview1.Columns["man2"].HeaderText = "Встреча";
            datagridview1.Columns["man2_proc"].HeaderText = "% мен. встреча";
            datagridview1.Columns["man2_proc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
            datagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview1.ReadOnly = true;
            datagridview1.Columns["sum"].DefaultCellStyle.Format = "C";
            datagridview1.Columns["man2_proc"].DefaultCellStyle.Format = "C";
            datagridview1.Columns["sum"].DisplayIndex = 6;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }

        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.CheckState == CheckState.Checked)
            {
                comboBox2.Enabled = true;
            } else
            {
                comboBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            MyInit();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;
            main.global.Windows = main.global.Windows ^ Global.WindowsOpen.Report;
        }
    }
}
