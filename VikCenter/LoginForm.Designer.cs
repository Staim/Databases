namespace VikCenter
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveCheckBox = new System.Windows.Forms.CheckBox();
            this.сhangeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeLoginTextBox = new System.Windows.Forms.TextBox();
            this.changePassTextBox = new System.Windows.Forms.TextBox();
            this.repeatePassTextBox = new System.Windows.Forms.TextBox();
            this.changeLoginLabel = new System.Windows.Forms.Label();
            this.changePassLabel = new System.Windows.Forms.Label();
            this.repeatePassLabel = new System.Windows.Forms.Label();
            this.changePassButton = new System.Windows.Forms.Button();
            this.cancelChangeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.saveCheckBox);
            this.panel1.Controls.Add(this.сhangeLinkLabel);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.loginTextBox);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 122);
            this.panel1.TabIndex = 9;
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Location = new System.Drawing.Point(17, 64);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(82, 17);
            this.saveCheckBox.TabIndex = 7;
            this.saveCheckBox.Text = "Запомнить";
            this.saveCheckBox.UseVisualStyleBackColor = true;
            // 
            // сhangeLinkLabel
            // 
            this.сhangeLinkLabel.AutoSize = true;
            this.сhangeLinkLabel.Location = new System.Drawing.Point(105, 65);
            this.сhangeLinkLabel.Name = "сhangeLinkLabel";
            this.сhangeLinkLabel.Size = new System.Drawing.Size(97, 13);
            this.сhangeLinkLabel.TabIndex = 6;
            this.сhangeLinkLabel.TabStop = true;
            this.сhangeLinkLabel.Text = "Изменить пароль";
            this.сhangeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.сhangeLinkLabel_LinkClicked);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(157, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(157, 15);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 38);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(139, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 12);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(139, 20);
            this.loginTextBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(110, 87);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(12, 87);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(92, 23);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelChangeButton);
            this.panel2.Controls.Add(this.changePassButton);
            this.panel2.Controls.Add(this.repeatePassLabel);
            this.panel2.Controls.Add(this.changePassLabel);
            this.panel2.Controls.Add(this.changeLoginLabel);
            this.panel2.Controls.Add(this.repeatePassTextBox);
            this.panel2.Controls.Add(this.changePassTextBox);
            this.panel2.Controls.Add(this.changeLoginTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 122);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // changeLoginTextBox
            // 
            this.changeLoginTextBox.Location = new System.Drawing.Point(12, 12);
            this.changeLoginTextBox.Name = "changeLoginTextBox";
            this.changeLoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.changeLoginTextBox.TabIndex = 0;
            // 
            // changePassTextBox
            // 
            this.changePassTextBox.Location = new System.Drawing.Point(12, 38);
            this.changePassTextBox.Name = "changePassTextBox";
            this.changePassTextBox.Size = new System.Drawing.Size(100, 20);
            this.changePassTextBox.TabIndex = 1;
            // 
            // repeatePassTextBox
            // 
            this.repeatePassTextBox.Location = new System.Drawing.Point(12, 64);
            this.repeatePassTextBox.Name = "repeatePassTextBox";
            this.repeatePassTextBox.Size = new System.Drawing.Size(100, 20);
            this.repeatePassTextBox.TabIndex = 2;
            // 
            // changeLoginLabel
            // 
            this.changeLoginLabel.AutoSize = true;
            this.changeLoginLabel.Location = new System.Drawing.Point(116, 15);
            this.changeLoginLabel.Name = "changeLoginLabel";
            this.changeLoginLabel.Size = new System.Drawing.Size(38, 13);
            this.changeLoginLabel.TabIndex = 3;
            this.changeLoginLabel.Text = "Логин";
            // 
            // changePassLabel
            // 
            this.changePassLabel.AutoSize = true;
            this.changePassLabel.Location = new System.Drawing.Point(116, 41);
            this.changePassLabel.Name = "changePassLabel";
            this.changePassLabel.Size = new System.Drawing.Size(45, 13);
            this.changePassLabel.TabIndex = 4;
            this.changePassLabel.Text = "Пароль";
            // 
            // repeatePassLabel
            // 
            this.repeatePassLabel.AutoSize = true;
            this.repeatePassLabel.Location = new System.Drawing.Point(116, 67);
            this.repeatePassLabel.Name = "repeatePassLabel";
            this.repeatePassLabel.Size = new System.Drawing.Size(80, 13);
            this.repeatePassLabel.TabIndex = 5;
            this.repeatePassLabel.Text = "Новый пароль";
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(24, 90);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(75, 23);
            this.changePassButton.TabIndex = 6;
            this.changePassButton.Text = "Изменить";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // cancelChangeButton
            // 
            this.cancelChangeButton.Location = new System.Drawing.Point(110, 90);
            this.cancelChangeButton.Name = "cancelChangeButton";
            this.cancelChangeButton.Size = new System.Drawing.Size(75, 23);
            this.cancelChangeButton.TabIndex = 7;
            this.cancelChangeButton.Text = "Отмена";
            this.cancelChangeButton.UseVisualStyleBackColor = true;
            this.cancelChangeButton.Click += new System.EventHandler(this.cancelChangeButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 122);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Соединение с БД";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox saveCheckBox;
        private System.Windows.Forms.LinkLabel сhangeLinkLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelChangeButton;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Label repeatePassLabel;
        private System.Windows.Forms.Label changePassLabel;
        private System.Windows.Forms.Label changeLoginLabel;
        private System.Windows.Forms.TextBox repeatePassTextBox;
        private System.Windows.Forms.TextBox changePassTextBox;
        private System.Windows.Forms.TextBox changeLoginTextBox;

    }
}