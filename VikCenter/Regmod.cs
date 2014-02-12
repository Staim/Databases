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
using VikCenter.DataSet1TableAdapters;

namespace VikCenter
{
    public partial class Regmod : Form
    {
        private MainForm main;
        private BindingSource bindingSource3;
        private int registratorRowPosition = 0;
        private int contractRowPostion = 0;

        public Regmod()
        {
            InitializeComponent();
            MyInit();
        }

        private void MyInit()
        {
            this.dataGridView1.DataError += dataGridView1_DataError;
            this.dataGridView3.DataError += dataGridView3_DataError;
        }

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = e.Exception is System.Data.ConstraintException;
            MessageBox.Show("Вы ввели некорректное значение", "Ошибка", MessageBoxButtons.OK);
        }

        void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = e.Exception is System.Data.ConstraintException;
            MessageBox.Show("Вы ввели некорректное значение", "Ошибка", MessageBoxButtons.OK);
        }

        private void Regmod_Load(object sender, EventArgs e)
        {
            //get data
            main = this.MdiParent as MainForm;
            
            main.global.regAdapter.Fill(main.global.dataSet.registrators);
            main.global.arendaAdapter.Fill(main.global.dataSet.contracts);

            bindingSource1 = new BindingSource(main.global.dataSet, "registrators");

            bindingSource3 = new BindingSource(bindingSource1, "registrators_contracts");

            dataGridView1.DataSource = bindingSource1;
            dataGridView3.DataSource = bindingSource3;
            
            bindingNavigator1.BindingSource = bindingSource1;
            bindingNavigator2.BindingSource = bindingSource3;

           // dataGridView1.AutoResizeColumns();
           // dataGridView3.AutoResizeColumns();
           // dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
           // dataGridView3.EditMode = DataGridViewEditMode.EditOnEnter;
            SetUpDataGrid(main);
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.Columns["id"].Visible = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);

            dataGridView3.Columns["sum"].DefaultCellStyle.Format = "C";
            dataGridView3.Columns["create_time"].Visible = false;
            dataGridView3.Columns["edit_time"].Visible = false;
            dataGridView3.Columns["create_login"].Visible = false;
            dataGridView3.Columns["edit_login"].Visible = false;
            dataGridView3.Columns["status"].Visible = false;
            //dataGridView3.Columns["man1_proc"].Visible = false;
            dataGridView3.Columns["comment"].Visible = false;
            dataGridView3.Columns["man_v_proc"].Visible = false;
            dataGridView3.Columns["name"].HeaderText = "Организация";
            dataGridView3.Columns["contr_number"].HeaderText = "№ Договора";
            dataGridView3.Columns["sum"].HeaderText = "Сумма";
            dataGridView3.Columns["registrator"].Visible = false;
            dataGridView3.Columns["contr_number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["sum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns["pay_date"].Width = 100;
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
            combo2.DataPropertyName = "adress";
            combo2.HeaderText = "Адрес";
           //combo2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns.RemoveAt(3);
            dataGridView3.Columns.Insert(3, combo2);
            DataGridViewComboBoxColumn convension = new DataGridViewComboBoxColumn();
            convension.Items.AddRange("С платежами", "Без платежей");
            convension.HeaderText = "Вид договора";
            convension.DataPropertyName = "type";
            dataGridView3.Columns.RemoveAt(2);
            dataGridView3.Columns.Insert(2, convension);
            SetUpDataGrid_new(main);
            DataGridViewCalendarColumn payDate = new DataGridViewCalendarColumn();
            payDate.DataPropertyName = "pay_date";
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["create_login"].Visible = false;
            dataGridView1.Columns["create_time"].Visible = false;
            dataGridView1.Columns["edit_login"].Visible = false;
            dataGridView1.Columns["edit_time"].Visible = false;
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["comment"].Visible = false;

            dataGridView1.Columns["name"].HeaderText = "Регистратор";

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["contacts"].HeaderText = "Контактные лица";
            dataGridView1.Columns["name"].HeaderText = "Регистратор";
            dataGridView1.Columns["phone"].HeaderText = "Телефон";
            dataGridView1.Columns["email"].HeaderText = "E-mail";
            dataGridView1.Columns["adress"].HeaderText = "Адрес";
            dataGridView1.Columns["site"].HeaderText = "Сайт";
            dataGridView1.Columns["terms"].HeaderText = "Условия работы";

            DataGridViewComboBoxColumn metroComboBox = new DataGridViewComboBoxColumn();
            metroComboBox.DataPropertyName = "metro";
            metroComboBox.HeaderText = "Метро";
            metroComboBox.DataSource = main.global.dataSet.stations;
            metroComboBox.ValueMember = "id";
            metroComboBox.DisplayMember = "name";
            dataGridView1.Columns.RemoveAt(5);
            dataGridView1.Columns.Insert(5, metroComboBox);
            
            DataGridViewComboBoxColumn manager1 = new DataGridViewComboBoxColumn();
            //manager1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            manager1.Items.AddRange("Алиева Е.И","Баркевич В.В.","Белова Ю.А.","Денисова Н.С.","Завгородная Е.В.","Мишин.В.И.","Пашина А.Е.","Самарская Ю.А.","Соколова Ю.В.","Черняева М.Н.");
            manager1.DataPropertyName = "man1";
            manager1.HeaderText = "Менеджер \n(холодный звонок)";
            dataGridView1.Columns.RemoveAt(9);
            dataGridView1.Columns.Insert(9, manager1);

            DataGridViewComboBoxColumn manager2 = new DataGridViewComboBoxColumn();
            //manager1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            manager2.Items.AddRange("Алиева Е.И", "Баркевич В.В.", "Белова Ю.А.", "Денисова Н.С.", "Завгородная Е.В.", "Мишин.В.И.", "Пашина А.Е.", "Самарская Ю.А.", "Соколова Ю.В.", "Черняева М.Н.");
            manager2.DataPropertyName = "man2";
            manager2.HeaderText = "Менеджер \n(встреча)";
            dataGridView1.Columns.RemoveAt(10);
            dataGridView1.Columns.Insert(10, manager2);
        }


        //Принять изменения
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;
            registratorRowPosition = bindingSource1.Position;
            contractRowPostion = bindingSource3.Position;
            main.global.regAdapter.Update(main.global.dataSet.registrators);
            main.global.regAdapter.Fill(main.global.dataSet.registrators);
            bindingSource1.Position = registratorRowPosition;
            bindingSource3.Position = contractRowPostion;

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;
            contractRowPostion = bindingSource3.Position;
            registratorRowPosition = bindingSource1.Position;
            main.global.arendaAdapter.Update(main.global.dataSet.contracts);
            main.global.regAdapter.Fill(main.global.dataSet.registrators);
            bindingSource3.Position = contractRowPostion;
            bindingSource1.Position = registratorRowPosition;
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
                bindingSource1.Filter = "[name] LIKE '" + toolStripTextBox1.Text + "%'" +
                    "and [man1] LIKE '%'" +
                    "and [man2] LIKE '%'";
            else if (toolStripComboBox1.Text == "Все")
                bindingSource1.Filter = "[name] LIKE '" + toolStripTextBox1.Text + "%'" +
                "and [man1] LIKE '%'" +
                "and [man2] LIKE '" + toolStripComboBox2.Text + "%'";
            else if (toolStripComboBox2.Text == "Все")
                bindingSource1.Filter = "[name] LIKE '" + toolStripTextBox1.Text + "%'" +
                "and [man1] LIKE '" + toolStripComboBox1.Text + "%'" +
                "and [man2] LIKE '%'";
            else
                bindingSource1.Filter = "[name] LIKE '" + toolStripTextBox1.Text + "%'" +
                "and [man1] LIKE '" + toolStripComboBox1.Text + "%'" +
                "and [man2] LIKE '" + toolStripComboBox2.Text + "%'";

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
            bindingSource3.Filter = "[name] LIKE '" + toolStripTextBox2.Text + "%'" +
                "and [contr_number] LIKE '" + toolStripTextBox3.Text + "%'";
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


        private void Regmod_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;

            if (MessageBox.Show("Сохранить в базу текущие данные?", "Закрытие окна...", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                
                main.global.renewRegsTable();
                main.global.renewArendaTable();
               
            }
            main.global.Windows = main.global.Windows ^ Global.WindowsOpen.RegistratorsMod;
        }

/*================================================================================================================
 * ==========================DATAGRIDVIEW3 ENENT HANDLERS========================================================
 * ==============================================================================================================*/
        //пометка на удаление аренды 
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView3.CurrentCell.RowIndex;
            int currntValue = byte.Parse(dataGridView3.Rows[rowIndex].Cells["Статус_строки"].Value.ToString());

            //РегистраторыTableAdapter adapter = new РегистраторыTableAdapter();
            contractsTableAdapter adapter = new contractsTableAdapter();
            if (currntValue == 0)
            {
                DialogResult result = MessageBox.Show("Удаление", "Пометить запись на удаление?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes) 
                {

                    int curvalue = (int)(dataGridView3.Rows[rowIndex].Cells["Id"].Value);
                    dataGridView3.Rows[rowIndex].Cells["Статус_строки"].Value = 1;
                    adapter.DelByID(1, curvalue);
                    MainForm main = this.MdiParent as MainForm;
                    main.global.renewArendaTable();
                    adapter.Fill(main.global.dataSet.contracts);
                    dataGridView3.CurrentRow.DefaultCellStyle.BackColor = Color.Gray;
                    dataGridView3.CurrentRow.ReadOnly = true;
                }
            }
            else
            {

                DialogResult result = MessageBox.Show("Отменить удаление", "Отменить пометку записи?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int curvalue = (int)(dataGridView3.Rows[rowIndex].Cells["id"].Value);
                    dataGridView3.Rows[rowIndex].Cells["status"].Value = 0;
                    adapter.DelByID(0, curvalue);
                    main.global.renewArendaTable();
                    adapter.Fill(main.global.dataSet.contracts);
                    dataGridView3.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    dataGridView3.CurrentRow.ReadOnly = false;
                }
            }
        }



        private void dataGridView3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int status = 0;
            try
            {
                status = int.Parse(dataGridView3.Rows[e.RowIndex].Cells["status"].Value.ToString());
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
        private void информацияОбИзмененииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView3.CurrentRow.Cells["create_time"].Value.ToString();
            string s2 = dataGridView3.CurrentRow.Cells["create_login"].Value.ToString();
            string s3 = dataGridView3.CurrentRow.Cells["edit_time"].Value.ToString();
            string s4 = dataGridView3.CurrentRow.Cells["edit_login"].Value.ToString();
            RowInfoForm info = new RowInfoForm(s, s2, s3, s4, dataGridView3.CurrentRow.Cells["comment"]);
            info.ShowDialog();
        }
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Point p = Cursor.Position;
                contextMenuStrip2.Show(p);
            }
        }
        //кнопка обновление нижняя
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            main.global.regAdapter.Fill(main.global.dataSet.registrators);
        }

        private void dataGridView3_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            Font currentFont = dataGridView1.DefaultCellStyle.Font;
            dataGridView3.CurrentCell.Style.Font = new Font(currentFont, FontStyle.Bold);
            dataGridView3.Rows[e.RowIndex].Cells["edit_login"].Value = main.global.LoginInfo.Login;
            dataGridView3.Rows[e.RowIndex].Cells["edit_time"].Value = DateTime.Now;
        }
        private void dataGridView3_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["create_login"].Value = main.global.LoginInfo.Login;
            e.Row.Cells["create_time"].Value = DateTime.Now;
        }

        //===========================DATAGRIDVIEW 1 EVENTS HANDLERS==================================================
        //===========================================================================================================
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["create_login"].Value = main.global.LoginInfo.Login;
            e.Row.Cells["create_time"].Value = DateTime.Now;
        }
        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            //MessageBox.Show("test");
            dataGridView1.Rows[e.RowIndex].Cells["edit_login"].Value = main.global.LoginInfo.Login;
            dataGridView1.Rows[e.RowIndex].Cells["edit_time"].Value = DateTime.Now;
            Font currentFont = dataGridView1.DefaultCellStyle.Font;
            dataGridView1.CurrentCell.Style.Font = new Font(currentFont, FontStyle.Bold);
        }
        //кнопка обновление верхняя
        private void toolStripButton11_Click(object sender, EventArgs e)
        {

            main.global.regAdapter.Fill(main.global.dataSet.registrators);

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
            string s = dataGridView1.CurrentRow.Cells["create_time"].Value.ToString();
            string s2 = dataGridView1.CurrentRow.Cells["create_login"].Value.ToString();
            string s3 = dataGridView1.CurrentRow.Cells["edit_time"].Value.ToString();
            string s4 = dataGridView1.CurrentRow.Cells["edit_login"].Value.ToString();
            RowInfoForm info = new RowInfoForm(s, s2, s3, s4, dataGridView1.CurrentRow.Cells["comment"]);
            info.ShowDialog();
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int status = 0;
            try
            {
                status = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString());
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
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int currntValue = byte.Parse(dataGridView1.Rows[rowIndex].Cells["status"].Value.ToString());

            registratorsTableAdapter adapter = new registratorsTableAdapter();
            if (currntValue == 0)
            {
                DialogResult result = MessageBox.Show("Удаление", "Пометить запись на удаление?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int curvalue = (int)(dataGridView1.Rows[rowIndex].Cells["id"].Value);
                    //dataGridView1.Rows[rowIndex].Cells["Статус_строки"].Value = 1;
                    adapter.DelByID(1, curvalue);
                    MainForm main = this.MdiParent as MainForm;
                    main.global.renewRegsTable();
                    //new code
                    adapter.Fill(main.global.dataSet.registrators);
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Gray;
                    dataGridView1.CurrentRow.ReadOnly = true;
                }
            }
            else
            {

                DialogResult result = MessageBox.Show("Отменить удаление", "Отменить пометку записи?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int curvalue = (int)(dataGridView1.Rows[rowIndex].Cells["id"].Value);
                    //dataGridView1.Rows[rowIndex].Cells["Статус_строки"].Value = 0;
                    adapter.DelByID(0, curvalue);
                    main.global.renewRegsTable();
                    adapter.Fill(main.global.dataSet.registrators);
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.CurrentRow.ReadOnly = false;
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            if (bindingSource3.Position == 0)
            {
                dataGridView3.Rows[bindingSource3.Position].Cells["man_v_proc"].Value = 500;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.Cancel == true) MessageBox.Show("test");
            try
            {
               // dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("Введите уникальное значение!");
                
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

           /* if (e.Value != null && dataGridView1.Columns[e.ColumnIndex].Name == "contr_number")
            {
                System.Text.StringBuilder str = new StringBuilder();
                str.Append(e.Value.ToString()[0] + e.Value.ToString()[1]);
                str.Append('-');
                str.Append(e.Value.ToString()[2] + e.Value.ToString()[3]);
                str.Append('-');
                str.Append(e.Value.ToString()[4] + e.Value.ToString()[5]);
                str.Append('-');
            }*/
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*if (dataGridView3.Columns[e.ColumnIndex].Name == "contr_number")
            {
                System.Text.StringBuilder str = new StringBuilder();
                str.Append(e.Value.ToString()[0] + e.Value.ToString()[1]);
                str.Append('-');
                str.Append(e.Value.ToString()[2] + e.Value.ToString()[3]);
                str.Append('-');
                str.Append(e.Value.ToString()[4] + e.Value.ToString()[5]);
                str.Append('-');
                e.Value = str.ToString();
                e.FormattingApplied = true;
            }*/
        }







    }
}
