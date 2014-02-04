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
    public partial class MainForm : Form
    {
    //перенес в Global        public db1DataSet dataSet = new db1DataSet();
        public Global global = new Global();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            //loginLabel.Text = loginForm.loginInfo(); !!! не забыть
            //получение логина времени входа
            global.LoginInfo = loginForm.loginInfo;
            this.Text = this.Text + " - Логин: " + global.LoginInfo.Login + " время входа: " + global.LoginInfo.LoginTime;
            
        }

        private void регистраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //удалить в дизайнере
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void своднаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  arenda arendaForm = new arenda();
            arendaForm.MdiParent = this;
            arendaForm.setDataGrid("", true);
            arendaForm.Show();*/
        }

        private void арендаАдресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* arenda arendaForm = new arenda();
            arendaForm.MdiParent = this;
            arendaForm.setDataGrid("", false);
            arendaForm.Show();*/
        }

        private void регистраторыСДоговорамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((global.Windows & Global.WindowsOpen.RegistratorsMod) != Global.WindowsOpen.RegistratorsMod)
            {
                Regmod form = new Regmod();
                form.MdiParent = this;
                
                form.Show();
                global.Windows = global.Windows | Global.WindowsOpen.RegistratorsMod;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip.Items[0].Text = "test";
        }

        private void сводныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((global.Windows & Global.WindowsOpen.Report) != Global.WindowsOpen.Report)
            {
                Report reportForm = new Report();
                reportForm.MdiParent = this;

                reportForm.Show();
                global.Windows = global.Windows | Global.WindowsOpen.Report;
            }
        }
    }

    public class Global
    {

        public LoginInfo loginInfo;
        public DataSet1 dataSet;
        public WindowsOpen Windows;
        public DataSet1TableAdapters.registratorsTableAdapter regAdapter = new DataSet1TableAdapters.registratorsTableAdapter();
        public DataSet1TableAdapters.contractsTableAdapter arendaAdapter = new DataSet1TableAdapters.contractsTableAdapter();
        public DataSet1TableAdapters.stationsTableAdapter stationAdapter = new DataSet1TableAdapters.stationsTableAdapter();


        [Flags]
        public enum WindowsOpen
        {
            None = 0x00,
            Registrators,
            RegistratorsMod,
            Report
        }



        public Global()
        {
            dataSet = new DataSet1();
            regAdapter.Fill(dataSet.registrators);
            arendaAdapter.Fill(dataSet.contracts);
            stationAdapter.Fill(dataSet.stations);
            Windows = WindowsOpen.None;
        }

        public LoginInfo LoginInfo
        {
            get { return loginInfo; }
            set { loginInfo = value; }
        }



        internal void renewRegsTable()
        {

                regAdapter.Update(dataSet.registrators);

        }

        internal void renewArendaTable()
        {

                arendaAdapter.Update(dataSet.contracts);    
        }
    }
}
