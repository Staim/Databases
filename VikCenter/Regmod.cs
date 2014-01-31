using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;
using VikCenter.db1DataSetTableAdapters;

namespace VikCenter
{
    public partial class Regmod : Form
    {
        private MainForm main;
        private BindingSource bindingSource3;

        public Regmod()
        {
            InitializeComponent();
        }

        private void Regmod_Load(object sender, EventArgs e)
        {
            //get data
            main = this.MdiParent as MainForm;

            bindingSource1 = new BindingSource(main.global.dataSet, "Регистраторы");

            bindingSource3 = new BindingSource(bindingSource1, "РегистраторыАренда_адресов");

            dataGridView1.DataSource = bindingSource1;
            dataGridView3.DataSource = bindingSource3;
            
            bindingNavigator1.BindingSource = bindingSource1;
            bindingNavigator2.BindingSource = bindingSource3;

            dataGridView1.AutoResizeColumns();
            dataGridView3.AutoResizeColumns();

            SetUpDataGrid(main);

            dataGridView3.Columns["Id"].Visible = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);

            dataGridView3.Columns["Сумма"].DefaultCellStyle.Format = "C";
            dataGridView3.Columns["Создание_строки"].Visible = false;
            dataGridView3.Columns["Редактирование_строки"].Visible = false;
            dataGridView3.Columns["Создание_логин"].Visible = false;
            dataGridView3.Columns["Редактирование_логин"].Visible = false;
            dataGridView3.Columns["Статус_строки"].Visible = false;
            dataGridView3.Columns["Процент"].Visible = false;
            dataGridView3.Columns["Наименование"].HeaderText = "Организация";
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
           //combo2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns.RemoveAt(3);
            dataGridView3.Columns.Insert(3, combo2);
            DataGridViewComboBoxColumn convension = new DataGridViewComboBoxColumn();
            convension.Items.AddRange("С платежом", "Без платежа");
            convension.HeaderText = "Вид договора";
            convension.DataPropertyName = "Вид_договора";
            dataGridView3.Columns.RemoveAt(2);
            dataGridView3.Columns.Insert(2, convension);
            SetUpDataGrid_new(main);
            DataGridViewCalendarColumn payDate = new DataGridViewCalendarColumn();
            payDate.DataPropertyName = "Дата_платежа";
            payDate.HeaderText = "Дата платежа";
            dataGridView3.Columns.RemoveAt(7);
            dataGridView3.Columns.Insert(7, payDate);
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetUpDataGrid_new(MainForm main)
        {
            /*dataGridView3.Columns["Id"].Visible = false;
            dataGridView3.Columns["Создание_строки"].Visible = false;
            dataGridView3.Columns["Редактирование_строки"].Visible = false;
            dataGridView3.Columns["Создание_логин"].Visible = false;
            dataGridView3.Columns["Редактирование_логин"].Visible = false;
            dataGridView3.Columns["Статус_строки"].Visible = false;
            dataGridView3.Columns["Процент"].Visible = false;
            dataGridView3.Columns["Наименование"].HeaderText = "Организация";

            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView3.Columns["Сумма"].DefaultCellStyle.Format = "C";
            dataGridView3.Columns["Вид_договора"].HeaderText = "Вид договора";

            DataGridViewComboBoxColumn convension = new DataGridViewComboBoxColumn();
            convension.Items.AddRange("С платежом", "Без платежа");
            convension.DataPropertyName = "Вид_договора";
            dataGridView3.Columns.RemoveAt(2);
            dataGridView3.Columns.Insert(2, convension);


            DataGridViewCalendarColumn payDate = new DataGridViewCalendarColumn();
            payDate.DataPropertyName = "Дата_платежа";
            payDate.HeaderText = "Дата платежа";
            dataGridView3.Columns.RemoveAt(7);
            dataGridView3.Columns.Insert(7, payDate);*/
        }

        private void SetUpDataGrid(MainForm main)
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Создание_строки"].Visible = false;
            dataGridView1.Columns["Редактирование_строки"].Visible = false;
            dataGridView1.Columns["Создание_логин"].Visible = false;
            dataGridView1.Columns["Редактирование_логин"].Visible = false;
            dataGridView1.Columns["Статус_строки"].Visible = false;
            dataGridView1.Columns["Наименование"].HeaderText = "Регистратор";

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["Конт_лица"].HeaderText = "Контактные лица";
            dataGridView1.Columns["Наименование"].HeaderText = "Регистратор";

            DataGridViewComboBoxColumn metroComboBox = new DataGridViewComboBoxColumn();
            metroComboBox.DataPropertyName = "Метро";
            metroComboBox.HeaderText = "Метро";
            metroComboBox.DataSource = main.global.dataSet.Станции_метро;
            metroComboBox.ValueMember = "Id";
            metroComboBox.DisplayMember = "Станция";
            dataGridView1.Columns.RemoveAt(5);
            dataGridView1.Columns.Insert(5, metroComboBox);

            DataGridViewComboBoxColumn manager1 = new DataGridViewComboBoxColumn();
            //manager1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            manager1.Items.AddRange("Алиева Е.И","Баркевич В.В.","Белова Ю.А.","Денисова Н.С.","Завгородная Е.В.","Мишин.В.И.","Пашина А.Е.","Самарская Ю.А.","Соколова Ю.В.","Черняева М.Н.");
            manager1.DataPropertyName = "Менеджер_хол_звонок";
            manager1.HeaderText = "Менеджер \n(холодный звонок)";
            dataGridView1.Columns.RemoveAt(9);
            dataGridView1.Columns.Insert(9, manager1);

            DataGridViewComboBoxColumn manager2 = new DataGridViewComboBoxColumn();
            //manager1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            manager2.Items.AddRange("Алиева Е.И", "Баркевич В.В.", "Белова Ю.А.", "Денисова Н.С.", "Завгородная Е.В.", "Мишин.В.И.", "Пашина А.Е.", "Самарская Ю.А.", "Соколова Ю.В.", "Черняева М.Н.");
            manager2.DataPropertyName = "Менеджер_встреча";
            manager2.HeaderText = "Менеджер \n(встреча)";
            dataGridView1.Columns.RemoveAt(10);
            dataGridView1.Columns.Insert(10, manager2);
        }


        //Принять изменения
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;
            main.global.renewRegsTable();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;
            main.global.renewArendaTable();

        }

        private void Regmod_ResizeEnd(object sender, EventArgs e)
        {

        }

        //установка фильтра наименования регистратора
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
            setFilter();
        }

        //отмена установка фильтра наименования регистратора
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
            bindingSource1.RemoveFilter();
            setFilter();
        }

        //установка фильтра менеджера хол звонка
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
            setFilter();
        }

        private void setFilter()
        {
            if (toolStripComboBox1.Text == "Все" && toolStripComboBox2.Text == "Все")
                bindingSource1.Filter = "[Наименование] LIKE '" + toolStripTextBox1.Text + "%'" +
                    "and [Менеджер_хол_звонок] LIKE '%'" +
                    "and [Менеджер_встреча] LIKE '%'";
            else if (toolStripComboBox1.Text == "Все")
                bindingSource1.Filter = "[Наименование] LIKE '" + toolStripTextBox1.Text + "%'" +
                "and [Менеджер_хол_звонок] LIKE '%'" +
                "and [Менеджер_встреча] LIKE '" + toolStripComboBox2.Text + "%'";
            else if (toolStripComboBox2.Text == "Все")
                bindingSource1.Filter = "[Наименование] LIKE '" + toolStripTextBox1.Text + "%'" +
                "and [Менеджер_хол_звонок] LIKE '" + toolStripComboBox1.Text + "%'" +
                "and [Менеджер_встреча] LIKE '%'";
            else
                bindingSource1.Filter = "[Наименование] LIKE '" + toolStripTextBox1.Text + "%'" +
                "and [Менеджер_хол_звонок] LIKE '" + toolStripComboBox1.Text + "%'" +
                "and [Менеджер_встреча] LIKE '" + toolStripComboBox2.Text + "%'";

        }

        private void toolStripComboBox2_TextChanged(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
            setFilter();
        }
        //установка нижних фильтров
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingSource3.RemoveFilter();
            setFilterBottom();
        }

        private void setFilterBottom()
        {
            bindingSource3.Filter = "[Наименование] LIKE '" + toolStripTextBox2.Text + "%'" +
                "and [№Договора] LIKE '" + toolStripTextBox3.Text + "%'";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            bindingSource3.RemoveFilter();
            setFilterBottom();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            toolStripTextBox2.Text = "";
            bindingSource3.RemoveFilter();
            setFilterBottom();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
            bindingSource3.RemoveFilter();
            setFilterBottom();
        }


        //удалить верхнего грида
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //int i = bindingSource1.Position;
            //dataGridView1.CurrentRow.Cells["
            //MainForm main = this.MdiParent as MainForm;
            //main.global.dataSet.Регистраторы.GetChanges();

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

            //ЛогиныTableAdapter adapter = new ЛогиныTableAdapter();
           // MainForm data = this.MdiParent as MainForm;
            //adapter.UpdateRow("root", "test","C",1);
           
            
            int rowIndex =  dataGridView1.CurrentCell.RowIndex;
            int currntValue = byte.Parse(dataGridView1.Rows[rowIndex].Cells["Статус_строки"].Value.ToString());
            
            РегистраторыTableAdapter adapter = new РегистраторыTableAdapter();
            if  (currntValue == 0)
            {
                DialogResult result = MessageBox.Show("Удаление", "Пометить запись на удаление?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes) 
                {

                    int curvalue = (int)(dataGridView1.Rows[rowIndex].Cells["Id"].Value);
                    //dataGridView1.Rows[rowIndex].Cells["Статус_строки"].Value = 1;
                    adapter.DelById(1, curvalue);
                    MainForm main = this.MdiParent as MainForm;
                    main.global.renewRegsTable();
                    //new code
                    adapter.Fill(main.global.dataSet.Регистраторы);
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Gray;
                    dataGridView1.CurrentRow.ReadOnly = true;
                }
            }
            else
            {
                
                DialogResult result = MessageBox.Show("Отменить удаление", "Отменить пометку записи?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int curvalue = (int)(dataGridView1.Rows[rowIndex].Cells["Id"].Value);
                    //dataGridView1.Rows[rowIndex].Cells["Статус_строки"].Value = 0;
                    adapter.DelById(0, curvalue);
                    main.global.renewRegsTable();
                    adapter.Fill(main.global.dataSet.Регистраторы);
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.CurrentRow.ReadOnly = false;
                }
            }
            

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
                
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
          /* if (dataGridView1.Rows[e.RowIndex].Cells["Статус_строки"].Value.ToString() == "0")
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;**/
            
        }

        private void Regmod_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;
            main.global.renewRegsTable();
            main.global.renewArendaTable();
            main.global.Windows = main.global.Windows ^ Global.WindowsOpen.RegistratorsMod;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        //пометка на удаление аренды 
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView3.CurrentCell.RowIndex;
            int currntValue = byte.Parse(dataGridView3.Rows[rowIndex].Cells["Статус_строки"].Value.ToString());

            //РегистраторыTableAdapter adapter = new РегистраторыTableAdapter();
            Аренда_адресовTableAdapter adapter = new Аренда_адресовTableAdapter();
            if (currntValue == 0)
            {
                DialogResult result = MessageBox.Show("Удаление", "Пометить запись на удаление?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes) 
                {

                    int curvalue = (int)(dataGridView3.Rows[rowIndex].Cells["Id"].Value);
                    dataGridView3.Rows[rowIndex].Cells["Статус_строки"].Value = 1;
                    adapter.DelById(1, curvalue);
                    MainForm main = this.MdiParent as MainForm;
                    main.global.renewArendaTable();
                    adapter.Fill(main.global.dataSet.Аренда_адресов);
                    dataGridView3.CurrentRow.DefaultCellStyle.BackColor = Color.Gray;
                    dataGridView3.CurrentRow.ReadOnly = true;
                }
            }
            else
            {

                DialogResult result = MessageBox.Show("Отменить удаление", "Отменить пометку записи?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int curvalue = (int)(dataGridView3.Rows[rowIndex].Cells["Id"].Value);
                    dataGridView3.Rows[rowIndex].Cells["Статус_строки"].Value = 0;
                    adapter.DelById(0, curvalue);
                    main.global.renewArendaTable();
                    adapter.Fill(main.global.dataSet.Аренда_адресов);
                    dataGridView3.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    dataGridView3.CurrentRow.ReadOnly = false;
                }
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int status = 0;
            try
            {
                status = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Статус_строки"].Value.ToString());
            }
            catch (Exception)
            {
                
            }

            if (status == 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //dataGridView1.Rows[e.RowIndex].ReadOnly = true;
            }
            if (status == 1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                //dataGridView1.Rows[e.RowIndex].ReadOnly = false;
            }
        }

        private void dataGridView3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int status = 0;
            try
            {
                status = int.Parse(dataGridView3.Rows[e.RowIndex].Cells["Статус_строки"].Value.ToString());
            }
            catch (Exception)
            {

            }

            if (status == 0)
            {
                dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //dataGridView3.Rows[e.RowIndex].ReadOnly = true;
            }
            if (status == 1)
            {
                dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
               // dataGridView3.Rows[e.RowIndex].ReadOnly = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Point p = Cursor.Position;
                contextMenuStrip1.Show(p);
            }
        }

        private void информацияОИзмененииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells["Создание_строки"].Value.ToString();
            string s2 = dataGridView1.CurrentRow.Cells["Создание_логин"].Value.ToString();
            string s3 = dataGridView1.CurrentRow.Cells["Редактирование_строки"].Value.ToString();
            string s4 = dataGridView1.CurrentRow.Cells["Редактирование_логин"].Value.ToString();
            RowInfoForm info = new RowInfoForm(s,s2,s3,s4);
            info.ShowDialog();
        }

    }
}
