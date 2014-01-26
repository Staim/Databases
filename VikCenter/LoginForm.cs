using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VikCenter
{
    public partial class LoginForm : Form
    {
        private bool verify = false;
        private bool verify_change = false;
        private string _loginIfo = "";
        public LoginInfo loginInfo;
        private BinaryFormatter binaryFormatter;
        private string filePath;

        public string FilePath
        {
            get {
                if (File.Exists(@"login.ini"))
                {
                    filePath = @"login.ini";
                    return filePath;
                }
                else { return ""; }
            }
            set { filePath = value; }
        }

   /*     public string loginInfo()
        {

            return _loginIfo;
        }*/

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

            if (this.FilePath != "")
            {
                using (FileStream fs = new FileStream(this.FilePath, FileMode.Open))
                {
                    binaryFormatter = new BinaryFormatter();
                    loginInfo = (LoginInfo)binaryFormatter.Deserialize(fs);
                }
            }
            else loginInfo = new LoginInfo();
            this.loginTextBox.Text = loginInfo.Login;
            this.passwordTextBox.Text = loginInfo.Password;
            if (loginInfo.State == true) this.saveCheckBox.CheckState = CheckState.Checked;
            else this.saveCheckBox.CheckState = CheckState.Unchecked;
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
                        {
                            //_loginIfo = "Вы зашли под именем: " + login + ". Время подключения: " + DateTime.Now.ToShortTimeString();
                            verify = true;
                            loginInfo.Login = login;
                            loginInfo.Password = pass;
                            loginInfo.Role = row["Правило"].ToString()[0];
                            if (saveCheckBox.Checked)
                            // ceриализуем
                            {
                                FileMode fileMode;
                                if (this.FilePath.Length > 0)
                                {
                                     fileMode = FileMode.Open;
                                }
                                else
                                {
                                    fileMode = FileMode.Create;
                                }
                                using (FileStream fs = new FileStream(@"login.ini", fileMode))
                                {
                                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                                    binaryFormatter.Serialize(fs, loginInfo);
                                }
                            }

                        }
 
                }
                if (!verify) MessageBox.Show("Введен неверный логин или пароль. Повторите снова", "Ошибка при вводе", MessageBoxButtons.OK);
                else
                {
                    loginInfo.LoginTime = DateTime.Now;
                    this.Close();
                }

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

    [Serializable]
    public class LoginInfo
    {
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private bool state;

        public bool State
        {
            get { return state; }
            set { state = value; }
        }

        private DateTime loginTime;

        public DateTime LoginTime
        {
            get { return loginTime; }
            set { loginTime = value; }
        }

        private char role = 'A';

        public char Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
