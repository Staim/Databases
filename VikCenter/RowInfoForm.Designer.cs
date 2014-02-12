namespace VikCenter
{
    partial class RowInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eLoginLabel = new System.Windows.Forms.Label();
            this.editTimeLabel = new System.Windows.Forms.Label();
            this.createTimeLabel = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.cLoginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата и время создания записи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата и время последнего редактирования:";
            // 
            // eLoginLabel
            // 
            this.eLoginLabel.AutoSize = true;
            this.eLoginLabel.Location = new System.Drawing.Point(13, 57);
            this.eLoginLabel.Name = "eLoginLabel";
            this.eLoginLabel.Size = new System.Drawing.Size(0, 13);
            this.eLoginLabel.TabIndex = 2;
            // 
            // editTimeLabel
            // 
            this.editTimeLabel.AutoSize = true;
            this.editTimeLabel.Location = new System.Drawing.Point(314, 44);
            this.editTimeLabel.Name = "editTimeLabel";
            this.editTimeLabel.Size = new System.Drawing.Size(107, 13);
            this.editTimeLabel.TabIndex = 3;
            this.editTimeLabel.Text = "не было изменений";
            // 
            // createTimeLabel
            // 
            this.createTimeLabel.AutoSize = true;
            this.createTimeLabel.Location = new System.Drawing.Point(314, 9);
            this.createTimeLabel.Name = "createTimeLabel";
            this.createTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.createTimeLabel.TabIndex = 4;
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(15, 101);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(406, 55);
            this.comment.TabIndex = 5;
            this.comment.Text = "Оставленный комментарий:";
            // 
            // cLoginLabel
            // 
            this.cLoginLabel.AutoSize = true;
            this.cLoginLabel.Location = new System.Drawing.Point(12, 22);
            this.cLoginLabel.Name = "cLoginLabel";
            this.cLoginLabel.Size = new System.Drawing.Size(0, 13);
            this.cLoginLabel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(172, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Комментарий:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RowInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cLoginLabel);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.createTimeLabel);
            this.Controls.Add(this.editTimeLabel);
            this.Controls.Add(this.eLoginLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RowInfoForm";
            this.Text = "Информация о записи";
            this.Load += new System.EventHandler(this.RowInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label eLoginLabel;
        private System.Windows.Forms.Label editTimeLabel;
        private System.Windows.Forms.Label createTimeLabel;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.Label cLoginLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}