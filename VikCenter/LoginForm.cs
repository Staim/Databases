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
    public partial class LoginForm : Form
    {
        private bool verify = false;
        private bool verify_change = false;

        public LoginForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowIcon = false;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //убирает рамку с кнопками и иконками вообще
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximumSize = new Size(229, 160);
            this.MinimumSize = new Size(229, 160);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           if(!verify) Application.Exit();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //можно добавить транзакцию
            db1DataSetTableAdapters.ЛогиныTableAdapter loginTableAdapter = new db1DataSetTableAdapters.ЛогиныTableAdapter();
            using (db1DataSet.ЛогиныDataTable loginsDataTable = new db1DataSet.ЛогиныDataTable())
            {
                loginTableAdapter.Fill(loginsDataTable);

                for (int i = 0; i < loginsDataTable.Rows.Count; i++)
                {
                    DataRow row = loginsDataTable.Rows[i];
                    string login = (string) row["Логин"];
                    string pass = (string) row["Пароль"];
                    if (login == loginTextBox.Text && pass == passwordTextBox.Text)
                        verify = true;
                }
                if (!verify) MessageBox.Show("Введен неверный логин или пароль. Повторите снова", "Ошибка при вводе", MessageBoxButtons.OK); else this.Close();

            }

            loginTableAdapter.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сhangeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //textBox ы для изменения пароля, запись в БД измененного паса
            DisplayChangePassControls();
        }

        private void DisplayChangePassControls()
        {
       //     panel1.Visible = false;
            this.Text = "Изменение пароля";
            panel2.Visible = true;

        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            //можно добавить транзакцию
            db1DataSetTableAdapters.ЛогиныTableAdapter loginTableAdapter = new db1DataSetTableAdapters.ЛогиныTableAdapter();
            using (db1DataSet.ЛогиныDataTable loginsDataTable = new db1DataSet.ЛогиныDataTable())
            {
                loginTableAdapter.Fill(loginsDataTable);

                for (int i = 0; i < loginsDataTable.Rows.Count; i++)
                {
                    DataRow row = loginsDataTable.Rows[i];
                    string login = (string)row["Логин"];
                    string pass = (string)row["Пароль"];
                    if (login == changeLoginTextBox.Text && pass == changePassTextBox.Text)
                    {
                        verify_change = true;
                        verify = true;
                        loginsDataTable.Rows[i]["Пароль"] = repeatePassTextBox.Text;
                        loginTableAdapter.Update(loginsDataTable);
                        this.Text = "Cоединение с БД";
                        panel2.Visible = false;
                        panel1.Visible = true;
                    }
                }
                if (!verify_change) MessageBox.Show("Введен неверный логин или пароль. Повторите снова", "Ошибка при вводе", MessageBoxButtons.OK); else this.Close();
            }

            loginTableAdapter.Dispose();
        }

        private void cancelChangeButton_Click(object sender, EventArgs e)
        {
            this.Text = "Cоединение с БД";
            panel2.Visible = false;
            panel1.Visible = true;
            
        }
    }
}
