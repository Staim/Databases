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
        private Global global = new Global();
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
            string[] combobox1_items = new string[] {
                "Алиева Е.И","Баркевич В.В.","Белова Ю.А.","Денисова Н.С.","Завгородная Е.В.","Мишин.В.И.","Пашина А.Е.","Самарская Ю.А.","Соколова Ю.В.","Черняева М.Н."
            };
            comboBox1.Items.AddRange(combobox1_items);
            comboBox2.Items.AddRange(combobox1_items);

            MainForm all = (this.MdiParent as MainForm);


            this.bindingSource1 = new BindingSource(global.dataSet, "Аренда_адресов");
            this.datagridview1.DataSource = this.bindingSource1;
            SetUpDataGrid2();
        }

        //установка фильтров
        private void button1_Click(object sender, EventArgs e)
        {
            setFilters();
        }

        private void setFilters()
        {
            if(dateTimePicker1.Enabled)
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
           
        }

        private void SetUpDataGrid2()
        {
            datagridview1.Columns["Id"].Visible = false;
            datagridview1.Columns["Вид_договора"].Visible = false;
            datagridview1.Columns["Адрес"].Visible = true ;

            datagridview1.Columns["Создание_строки"].Visible = false;
            datagridview1.Columns["Редактирование_строки"].Visible = false;
            datagridview1.Columns["Создание_логин"].Visible = false;
            datagridview1.Columns["Редактирование_логин"].Visible = false;
            datagridview1.Columns["Статус_строки"].Visible = false;
            datagridview1.Columns["Наименование"].HeaderText = "Организация";

            datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
            datagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview1.ReadOnly = true;
            datagridview1.Columns["Сумма"].DefaultCellStyle.Format = "C";
            datagridview1.Columns["Процент"].DefaultCellStyle.Format = "C";
            //datagridview1.Columns["Вид_договора"].HeaderText = "Вид договора";

           /* DataGridViewComboBoxColumn convension = new DataGridViewComboBoxColumn();
            convension.Items.AddRange("С платежом", "Без платежа");
            convension.DataPropertyName = "Вид_договора";
            datagridview1.Columns.RemoveAt(2);
            datagridview1.Columns.Insert(2, convension);*/


            /*DataGridViewCalendarColumn payDate = new DataGridViewCalendarColumn();
            payDate.DataPropertyName = "Дата_платежа";
            payDate.HeaderText = "Дата платежа";
            datagridview1.Columns.RemoveAt(7);
            datagridview1.Columns.Insert(7, payDate);*/
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
