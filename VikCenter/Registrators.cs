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
    public partial class RegistratorsForm : Form
    {
        private db1DataSet dataSet = new db1DataSet();
        VikCenter.db1DataSetTableAdapters.РегистраторыTableAdapter adapter = new db1DataSetTableAdapters.РегистраторыTableAdapter();

        public RegistratorsForm()
        {
            InitializeComponent();
            MyInit();
        }

        private void MyInit()
        {

            
            adapter.Fill(dataSet.Регистраторы);

      //      dataGridView.DataSource = dataSet.Регистраторы;
            dataGridView.DataSource = bindingSource;
            bindingSource.DataSource = dataSet.Регистраторы;

            SetColumnsOfGrid();
        }

        private void SetColumnsOfGrid()
        {
            //убираем служебные колонки
            dataGridView.Columns["Id"].Visible = false;
            //dataGridView.Columns["Активность"].Visible = false;
            //настраиваем хедеры
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSize = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns["Конт_лица"].HeaderText = "Контактные лица";
            //dataGridView.Columns["№соглашения"].HeaderText = "№ Соглашения";

            //dataGridView.Columns["Наименование"].DefaultCellStyle.BackColor = Color.Indigo;
          /*  DataGridViewButtonColumn registrator = new DataGridViewButtonColumn();
            registrator.DataPropertyName = "Наименование";
            registrator.HeaderText = "Найименование";
            dataGridView.Columns.Remove("Наименование");
            dataGridView.Columns.Insert(1, registrator);*/

            //создаем комбобоксы с выбором значений
            DataGridViewComboBoxColumn metro = new DataGridViewComboBoxColumn();
            metro.Items.AddRange("Аэропорт", "Сокол", "Войковская", "Динамо", "Беларусская");
           // metro.MaxDropDownItems = 200;
         //   metro.Items.AddRange("Авиамоторная", "Автозаводская", "Академическая", "Александровский сад", "Алексеевская", "Алтуфьево", "Аннино", "Арбатская", "Аэропорт", "Бабушкинская", "Багратионовская", "Баррикадная", "Бауманская", "Беговая", "Белорусская", "Беляево", "Бибирево", "Библиотека имени Ленина", "Битцевский парк", "Боровицкая", "Ботанический сад", "Братиславская", "Бульвар адмирала Ушакова", "Бульвар Дмитрия Донского", "Бунинская аллея", "Варшавская", "ВДНХ", "Владыкино", "Водный стадион", "Войковская", "Волгоградский проспект", "Волжская", "Воробьёвы горы", "Выставочный центр", "Выхино", "Деловой центр", "Динамо", "Дмитровская", "Добрынинская", "Домодедовская", "Дубровка", "Измайловская", "Калужская", "Кантемировская", "Каховская", "Каширская", "Киевская", "Китай-город", "Кожуховская", "Коломенская", "Комсомольская", "Коньково", "Красногвардейская", "Краснопресненская", "Красносельская", "Красные ворота", "Крестьянская застава", "Кропоткинская", "Крылатское", "Кузнецкий мост", "Кузьминки", "Кунцевская", "Курская", "Кутузовская", "Ленинский проспект", "Лубянка", "Люблино", "Марксистская", "Марьино", "Маяковская", "Медведково", "Международная", "Менделеевская", "Молодёжная", "Нагатинская", "Нагорная", "Нахимовский проспект", "Новогиреево", "Новокузнецкая", "Новослободская", "Новые Черёмушки", "Октябрьская", "Октябрьское поле", "Орехово", "Отрадное", "Охотный ряд", "Павелецкая", "Парк культуры", "Парк Победы", "Партизанская", "Первомайская", "Перово", "Петровско-Разумовская", "Печатники", "Пионерская", "Планерная", "Площадь Ильича", "Площадь Революции", "Полежаевская", "Полянка", "Пражская", "Преображенская площадь", "Пролетарская", "Проспект Вернадского", "Проспект Мира", "Пушкинская", "Речной вокзал", "Рижская", "Римская", "Рязанский проспект", "Савёловская", "Свиблово", "Севастопольская", "Семёновская", "Серпуховская", "Смоленская", "Сокол", "Сокольники", "Спортивная", "Сретенский бульвар", "Строгино", "Студенческая", "Сухаревская", "Сходненская", "Таганская", "Тверская", "Театральная", "Текстильщики", "Телецентр", "Тёплый Стан", "Тимирязевская", "Третьяковская", "Трубная", "Тульская", "Тургеневская", "Тушинская", "Улица 1905 года", "Улица Академика Королёва", "Улица Академика Янгеля", "Улица Горчакова", "Улица Милашенкова", "Улица Подбельского", "Улица Сергея Эйзенштейна", "Улица Скобелевская", "Улица Старокачаловская", "Университет", "Филёвский парк", "Фили", "Фрунзенская", "Царицыно", "Цветной бульвар", "Черкизовская", "Чертановская", "Чеховская", "Чистые пруды", "Чкаловская", "Шаболовская", "Шоссе Энтузиастов", "Щёлковская", "Щукинская", "Электрозаводская", "Юго-Западная", "Южная", "Ясенево");
            
            string[] strings = System.IO.File.ReadAllLines("Метро.txt");
            metro.DataSource = strings;
            

            metro.HeaderText = "Метро";
            dataGridView.Columns.Remove("Метро");
            dataGridView.Columns.Insert(5, metro);
            metro.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;

            DataGridViewLinkColumn email = new DataGridViewLinkColumn();
            email.DataPropertyName = "Email";
            email.HeaderText = "Email";
            dataGridView.Columns.Remove("Email");
            dataGridView.Columns.Insert(3, email);

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.DataPropertyName = "Сайт";
            link.HeaderText = "Сайт";
            dataGridView.Columns.Remove("Сайт");
            dataGridView.Columns.Insert(7, link);

            DataGridViewComboBoxColumn manager = new DataGridViewComboBoxColumn();
            manager.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            manager.Items.AddRange("Иванов А.С.", "Петров П.С.", "Сидоров И.Д.");
            manager.DataPropertyName = "Менеджер";
            manager.HeaderText = "Менеджер";
            dataGridView.Columns.RemoveAt(12);
            dataGridView.Columns.Insert(12, manager);
            
            
        }
        private void RegistratorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db1DataSet.Регистраторы". При необходимости она может быть перемещена или удалена.
          //  this.регистраторыTableAdapter.Fill(this.db1DataSet.Регистраторы);

            
        }

        //фильтр по менеджерам
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem.ToString() != "" &&
                toolStripComboBox1.SelectedItem.ToString() != "Без фильтра")
                bindingSource.Filter = "Менеджер ='" + toolStripComboBox1.SelectedItem.ToString() + "'";
            else bindingSource.RemoveFilter();
            /*if (toolStripComboBox1.SelectedItem.ToString() == "Иванов А.С.")
            {
                bindingSource.Filter = "Менеджер = 'Иванов А.С.'";
            }
            else if (toolStripComboBox1.SelectedItem.ToString() == "Петров П.С.")
            {
                bindingSource.Filter = "Менеджер = 'Петров П.С.'";
            }
            else if (toolStripComboBox1.SelectedItem.ToString() == "Сидоров И.Д.")
            {
                bindingSource.Filter = "Менеджер =  'Сидоров И.Д.'";
            }
            else if (toolStripComboBox1.SelectedItem.ToString() == "Без фильтра")
            {
                bindingSource.RemoveFilter();
            }*/
        }

        private void RegistratorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //по закрытию формы обновляем БД
            adapter.Update(dataSet.Регистраторы);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //фильтрация по наименованиям
            int position = bindingSource.Find("Наименование", toolStripTextBox1.Text);
            bindingSource.Position = position;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //фильтрация по №соглашения
            int position = bindingSource.Find("№соглашения", toolStripTextBox2.Text);
            bindingSource.Position = position;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            /*int position = bindingSource.Position;

            arenda arendaForm = new arenda();
            arendaForm.MdiParent = this.MdiParent;

            arendaForm.Show();*/
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int position = bindingSource.Position;
            DataRow row = dataSet.Регистраторы[position];
            string registrator = (string)row["Наименование"];

            arenda arendaForm = new arenda();
            arendaForm.MdiParent = this.MdiParent;
            arendaForm.setDataGrid(registrator, false);
            arendaForm.Show();
        }



    }
}
