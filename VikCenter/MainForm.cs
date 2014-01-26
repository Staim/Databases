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
            if((global.Windows & Global.WindowsOpen.Registrators) != Global.WindowsOpen.Registrators )
            {
                RegistratorsForm regForm = new RegistratorsForm();
                regForm.MdiParent = this;
                regForm.Show();
                global.Windows = global.Windows | Global.WindowsOpen.Registrators;
            }
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
            arenda arendaForm = new arenda();
            arendaForm.MdiParent = this;
            arendaForm.setDataGrid("", true);
            arendaForm.Show();
        }

        private void арендаАдресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arenda arendaForm = new arenda();
            arendaForm.MdiParent = this;
            arendaForm.setDataGrid("", false);
            arendaForm.Show();
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

        private LoginInfo loginInfo;
        public db1DataSet dataSet;
        public WindowsOpen Windows;
        public db1DataSetTableAdapters.РегистраторыTableAdapter regAdapter = new db1DataSetTableAdapters.РегистраторыTableAdapter();
        public db1DataSetTableAdapters.Аренда_адресовTableAdapter arendaAdapter = new db1DataSetTableAdapters.Аренда_адресовTableAdapter();
        public db1DataSetTableAdapters.Станции_метроTableAdapter stationAdapter = new db1DataSetTableAdapters.Станции_метроTableAdapter();


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
            dataSet = new db1DataSet();
            regAdapter.Fill(dataSet.Регистраторы);
            arendaAdapter.Fill(dataSet.Аренда_адресов);
            stationAdapter.Fill(dataSet.Станции_метро);
            Windows = WindowsOpen.None;
        }

        public LoginInfo LoginInfo
        {
            get { return loginInfo; }
            set { loginInfo = value; }
        }



        internal void renewRegsTable()
        {
            regAdapter.Update(dataSet.Регистраторы);
        }

        internal void renewArendaTable()
        {
            arendaAdapter.Update(dataSet.Аренда_адресов);
        }
    }
}
