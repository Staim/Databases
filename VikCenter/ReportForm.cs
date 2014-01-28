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
    public partial class Report : Form
    {
        MainForm all;
        db1DataSetTableAdapters.JoinTableTableAdapter joinAdapter = new db1DataSetTableAdapters.JoinTableTableAdapter();

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
                if (comboBox2.Text == "Все") men1 = ""; else men1 = comboBox2.Text;
            }


            bindingSource1.Filter = "[Дата_платежа] >= '" + date + "'AND [Дата_платежа] <= '" + date2 + "'" +
                "AND [Регистратор] LIKE '%" + registrator + "%'" +
                "AND [Менеджер_хол_звонок] LIKE '%" + men1 + "%'" +
                "AND [Менеджер_встреча] LIKE '%" + men2 + "%'";

            /*if(dateTimePicker1.Enabled)
            {
                bindingSource1.Filter = "[Дата_платежа] >= '" + dateTimePicker1.Value.ToShortDateString() + "'AND [Дата_платежа] <= '" + dateTimePicker2.Value.ToShortDateString() + "'";
                    
            }
            if (textBox1.Enabled)
            {
                bindingSource1.Filter = "[Регистратор] LIKE '%" + textBox1.Text + "%'";
            }
            if (dateTimePicker1.Enabled && textBox1.Enabled)
                bindingSource1.Filter = "[Дата_платежа] >= '" + dateTimePicker1.Value.ToShortDateString() + "'AND [Дата_платежа] <= '" + dateTimePicker2.Value.ToShortDateString() + "'" +
                    "AND [Регистратор] LIKE '%" + textBox1.Text + "%'";
            if (comboBox1.Enabled)
            {
                bindingSource1.Filter = "[Менеджер_хол_звонок] LIKE '%" + comboBox1.Text + "%'";
            }
            if (comboBox2.Enabled)
            {
                bindingSource1.Filter = "[Менеджер_встреча] LIKE '%" + comboBox2.Text + "%'";
            }
            
            */

        }

        private void SetUpDataGrid2()
        {
            datagridview1.Columns["Наименование"].HeaderText = "Организация";
            datagridview1.Columns["Дата_платежа"].HeaderText = "Дата платежа";
            datagridview1.Columns["Менеджер_хол_звонок"].HeaderText = "Холодный звонок";
            datagridview1.Columns["Менеджер_встреча"].HeaderText = "Встреча";
            datagridview1.Columns["%Мен_встреча"].HeaderText = "% мен. встреча";
            datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
            datagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview1.ReadOnly = true;
            datagridview1.Columns["Сумма"].DefaultCellStyle.Format = "C";
            datagridview1.Columns["%Мен_встреча"].DefaultCellStyle.Format = "C";
            datagridview1.Columns["Сумма"].DisplayIndex = 6;
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
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
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
