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
    public partial class arenda : Form
    {
        public string reg;
        private db1DataSet dataset = new db1DataSet();
        private VikCenter.db1DataSetTableAdapters.Аренда_адресовTableAdapter adapter = new db1DataSetTableAdapters.Аренда_адресовTableAdapter();

        public arenda()
        {
            InitializeComponent();
        }

        internal void setDataGrid(string registrator, bool mode)
        {
            if (mode == false)
            {
                adapter.Fill(dataset.Аренда_адресов);
                bindingSource.DataSource = dataset.Аренда_адресов;
                dataGridView.DataSource = bindingSource;
                bindingNavigator.BindingSource = bindingSource;

                //фильтр по регистратору 
                if (registrator.Length > 0)
                {
                    this.Text = "Договора аренды у регистратора \"" + registrator + "\"";
                    bindingSource.Filter = "Регистратор = '" + registrator + "'";
                    this.reg = registrator;
                    this.SetColumnsOfGrid();
                }
                else
                {
                    this.Text = "Все договора аренды";
                    this.reg = registrator;
                    this.SetColumnsOfGrid();
                }
            }
            else
            {
                adapter.Fill(dataset.Аренда_адресов);
                bindingSource.DataSource = dataset.Аренда_адресов;
                dataGridView.DataSource = bindingSource;
                bindingNavigator.Visible = false;

                this.Text = "Сводная таблица за месяц";

                this.SetColumnsOfGrid_All();
            }

        }

        private void SetColumnsOfGrid_All()
        {
            //throw new NotImplementedException();
            //убираем служебные колонки
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Вид_договора"].Visible = false;
            dataGridView.Columns["Адрес"].Visible = false;
            dataGridView.Columns["Дата_заключения"].Visible = false;
            dataGridView.Columns["Срок_договора"].Visible = false;
            dataGridView.Columns["Дата_окончания"].Visible = false;
            dataGridView.Columns[9].DefaultCellStyle.Format = "C";
            dataGridView.Columns[10].DefaultCellStyle.Format = "C";
            dataGridView.Columns[10].HeaderText = "% Менеджера";
            dataGridView.Columns[11].DefaultCellStyle.Format = "C";
            dataGridView.Columns[11].HeaderText = "% Начальника";

            //настраиваем хедеры
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSize = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;

            double sumOfmanagers = 0, sumOfBoss = 0;



            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataRow row = dataset.Аренда_адресов[i];
                sumOfmanagers += (double)row["Мен_проц"];
                sumOfBoss += (double)row["Нач_проц"];
            }

            Label totalLbl = new Label();
            totalLbl.Text = "Всего договоров аренды: " + dataGridView.Rows.Count + ". " +
                "Сумма % менеджеров: " + sumOfmanagers + " руб. " +
                "Сумма % начальства: " + sumOfBoss + " Руб.";
            MessageBox.Show(totalLbl.Text);
           /* splitContainer1.Panel2.Controls.Add(totalLbl);
            totalLbl.Top = 10;
            totalLbl.Left = 10;*/
        }

        private void SetColumnsOfGrid()
        {
            //убираем служебные колонки
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Дата_заключения"].Visible = false;
            dataGridView.Columns["Срок_договора"].Visible = false;
            dataGridView.Columns["Дата_окончания"].Visible = false;
            dataGridView.Columns[9].DefaultCellStyle.Format = "C";
            dataGridView.Columns[10].Visible = false;
            dataGridView.Columns[11].Visible = false;
        //    dataGridView.Columns[10].DefaultCellStyle.Format = "C";
        //    dataGridView.Columns[11].DefaultCellStyle.Format = "C";

            //настраиваем хедеры
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSize = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataGridViewComboBoxColumn combo1 = new DataGridViewComboBoxColumn();
            combo1.Items.AddRange("С платежом", "Без платежа");
            combo1.DataPropertyName = "Вид_договора";
            combo1.HeaderText = "Вид договора";
            dataGridView.Columns.RemoveAt(2);
            dataGridView.Columns.Insert(2, combo1);

            DataGridViewComboBoxColumn combo2 = new DataGridViewComboBoxColumn();
            combo2.Items.AddRange("105066, ул. Спартаковская",
                "129110, Банный пер.", "123557, Большой Тишинский пер.",
                "123104, Спиридоньевский переулок",
                "119048, ул. Усачёва",
                "115054, ул. Большая Пионерская",
                "119049, 4-й Добрынинский пер.",
                "127473, ул. Самотёчная",
                "129090, ул. Большая Спасская",
                "105120, 2-ой Сыромятнический пер.",
                "127247, Дмитровское шоссе",
                "107113, ул. Сокольнический вал",
                "109451, ул. Братиславская",
                "117556, Чонгарский бульвар",
                "121087, ул. Новозаводская",
                "121596, ул. Толбухина",
                "119311, ул. Крупской");
            combo2.DataPropertyName = "Адрес";
            combo2.HeaderText = "Адрес";
            //combo2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns.RemoveAt(3);
            dataGridView.Columns.Insert(3, combo2);
            dataGridView.Columns[10].HeaderText = "% Менеджера";
            dataGridView.Columns[11].HeaderText = "% Начальника";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //по наименованию
            if (toolStripTextBox1.Text.Length > 0) bindingSource.Filter = "Наименование = '" + toolStripTextBox1.Text + "'";
            else if (this.reg.Length > 0) bindingSource.Filter = "Регистратор = '" + this.reg + "'";
            else bindingSource.RemoveFilter();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //по договору
            if (toolStripTextBox2.Text.Length > 0) bindingSource.Filter = "№Договора = '" + toolStripTextBox2.Text + "'";
            else if (this.reg.Length > 0) bindingSource.Filter = "Регистратор = '" + this.reg + "'"; 
            else bindingSource.RemoveFilter();
        }

        private void arenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            adapter.Update(dataset.Аренда_адресов);
        }
    }
}
