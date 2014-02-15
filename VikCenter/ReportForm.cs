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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;


namespace VikCenter
{
    public partial class Report : Form
    {
        MainForm all;
        DataSet1TableAdapters.JoinTableAdapter joinAdapter = new DataSet1TableAdapters.JoinTableAdapter();
       
        private Word._Application _application;
        private Word._Document _document;
        // фиксированные параметры для передачи приложению Word
        private Object _missingObj = System.Reflection.Missing.Value;
        private Object _trueObj = true;
        private Object _falseObj = false;
        private decimal sum = 0;
        private decimal sum2 = 0;
        private decimal sum_contracts = 0;


        private void button3_Click(object sender, EventArgs e)
        {
            //создаем обьект приложения word
            _application = new Word.Application();
            // создаем путь к файлу
            Object templatePathObj = Application.StartupPath + "\\" + "VikCentr.dot";
            
            try
            {
                _document = _application.Documents.Add(ref  templatePathObj, ref _missingObj, ref _missingObj, ref _missingObj);
            }
            catch (Exception error)
            {
                _document.Close(ref _falseObj, ref  _missingObj, ref _missingObj);
                _application.Quit(ref _missingObj, ref  _missingObj, ref _missingObj);
                _document = null;
                _application = null;
                throw error;
            }
            _application.Visible = true;
            Object bookmark = "date1";
            Word.Range bookmarkRange = _document.Bookmarks.get_Item(ref bookmark).Range;
            bookmarkRange.Font.Bold = 1;
            bookmarkRange.Bold = 1;
            bookmarkRange.Font.Size = 14;

            bookmarkRange.Font.Underline = Word.WdUnderline.wdUnderlineDash;
            Object bookmark2 = "date2";
            Word.Range bookmarkRange2 = _document.Bookmarks.get_Item(ref bookmark2).Range;
            bookmarkRange2.Font.Bold = 1;
            bookmarkRange2.Font.Size = 14;

            string firstDate;
            string secondDate;
            if (dateTimePicker1.Enabled && dateTimePicker2.Enabled)
            {
                firstDate = dateTimePicker1.Value.ToShortDateString();
                secondDate = dateTimePicker2.Value.ToShortDateString();
                bookmarkRange.Text = firstDate;
                bookmarkRange2.Text = secondDate;
            }

            Object registrator = "registrator";
            Word.Range registratorRange = _document.Bookmarks.get_Item(ref registrator).Range;
            registratorRange.Font.Size = 14;
            registratorRange.Font.Bold = 1;
            registratorRange.Text = datagridview1["registrator", 0].Value.ToString();
            
            
            
            Object manager1 = "man1";
            Object manager2 = "man2";
            Word.Range manager1range = _document.Bookmarks.get_Item(ref manager1).Range;
            Word.Range manager2range = _document.Bookmarks.get_Item(ref manager2).Range;
            manager1range.Bold = 1;
            manager2range.Bold = 1;
            manager1range.Text = datagridview1.Rows[0].Cells["man1"].Value.ToString();
            manager2range.Text = datagridview1.Rows[0].Cells["man2"].Value.ToString();
            
            /*Object sum_man1 = "manager1_bottom";
            Object sum_man2 = "manager2_bottom";
            Word.Range sum_man1Range = _document.Bookmarks.get_Item(ref sum_man1).Range;
            Word.Range sum_man2Range = _document.Bookmarks.get_Item(ref sum_man2).Range;
            sum_man1Range.Bold = 1;
            sum_man2Range.Bold = 1;
            sum_man1Range.Text = sum.ToString("C");
            sum_man2Range.Text = sum2.ToString("C");*/

            /********************************************************
             * ************ТАБЛИЦА***********************************
             * *****************************************************/
            Word.Range currange;
            Word.Table _table = _document.Tables[1];
            _table.Rows.First.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray20;
            for (int i = 0; i < datagridview1.RowCount; i++)
            {

                _table.Rows.Add(ref _missingObj).Shading.BackgroundPatternColor = Word.WdColor.wdColorWhite;
                _table.Cell(i + 2, 1).Shading.BackgroundPatternColor = Word.WdColor.wdColorWhite;
                currange = _table.Cell(i + 2, 1).Range;
                currange.Bold = 0;
                currange.Text = datagridview1.Rows[i].Cells["registrator"].Value.ToString();
                currange = _table.Cell(i + 2, 2).Range;
                currange.Bold = 0;
                currange.Text = datagridview1.Rows[i].Cells["contr_number"].Value.ToString();
                currange = _table.Cell(i + 2, 3).Range;
                currange.Bold = 0;
                decimal s;
                s = decimal.Parse(datagridview1.Rows[i].Cells["sum"].Value.ToString());
                currange.Text = s.ToString("C");
                currange = _table.Cell(i + 2, 4).Range;
                currange.Bold = 0;
                s = decimal.Parse(datagridview1.Rows[i].Cells["man2_proc"].Value.ToString());
                currange.Text = s.ToString("C");
                currange = _table.Cell(i + 2, 5).Range;
                currange.Bold = 0;
                s = decimal.Parse(datagridview1.Rows[i].Cells["man_v_proc"].Value.ToString());
                currange.Text = s.ToString("C");
            }

            _table.Rows.Add(ref _missingObj).Shading.BackgroundPatternColor = Word.WdColor.wdColorGray20;
            _table.Rows[datagridview1.RowCount+2].Cells[1].Merge(_table.Rows[datagridview1.RowCount+2].Cells[2]);
            currange = _table.Cell(datagridview1.RowCount + 2, 1).Range;
            currange.Font.Bold = 1;
            currange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            currange.Text = "Итого:";
            currange = _table.Cell(datagridview1.RowCount + 2, 2).Range;
            currange.Font.Bold = 1;
            currange.Text = sum_contracts.ToString("C");
            
            //currange.Font.Shading.BackgroundPatternColor = Word.WdColor.wdColorBlack;
            currange = _table.Cell(datagridview1.RowCount + 2, 3).Range;
            currange.Font.Bold = 1;
            currange.Text = sum.ToString("C");
            currange = _table.Cell(datagridview1.RowCount + 2, 4).Range;
            currange.Font.Bold = 1;
            currange.Text = sum2.ToString("C");

            /********************************************************
            * ************ТАБЛИЦА***********************************
            * *****************************************************/
        }








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

            sum = sum2 = sum_contracts = 0;
            bindingSource1.RemoveFilter();
            setFilters();
            if(comboBox1.Text != "Все" || comboBox2.Text != "Все")
            if (datagridview1.RowCount > 0)
            {
                for (int i = 0; i < (datagridview1.RowCount-1); i++)
                {
                    if (datagridview1.Rows[i].Cells["man2_proc"].Value.ToString().Length > 0)
                    {
                        sum += decimal.Parse(datagridview1.Rows[i].Cells["man2_proc"].Value.ToString());
                    }
                    if (datagridview1.Rows[i].Cells["man_v_proc"].Value.ToString().Length > 0)
                    {
                        sum2 += decimal.Parse(datagridview1.Rows[i].Cells["man_v_proc"].Value.ToString());
                    }
                    if (datagridview1["sum", i].Value.ToString().Length > 0)
                    {
                        sum_contracts += decimal.Parse(datagridview1["sum", i].Value.ToString());
                    }
                }
                label1.Text = "Итоговая сумма менеджера \"хол. звонок\" = " + sum.ToString("C") +
                    "\nИтоговая сумма менеджера \"встреча\" = " + sum2.ToString("C");
            }

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
            datagridview1.Columns["man2_proc"].HeaderText = "% мен. звонок";
            datagridview1.Columns["man_v_proc"].HeaderText = "% мен. встреча";
            datagridview1.Columns["man2_proc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Bold);
            datagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview1.ReadOnly = true;
            datagridview1.Columns["sum"].DefaultCellStyle.Format = "C";
            datagridview1.Columns["man2_proc"].DefaultCellStyle.Format = "C";
            datagridview1.Columns["sum"].DisplayIndex = 6;
            datagridview1.Columns["man_v_proc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview1.Columns["man_v_proc"].DefaultCellStyle.Format = "C";
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
