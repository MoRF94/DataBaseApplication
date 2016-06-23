namespace DataBaseApplication
{
    partial class ShowPassword
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
            this.label_login = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_SecretIssue = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_GetSecr = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Reply = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(12, 16);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(81, 17);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Ваш логин:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label_SecretIssue
            // 
            this.label_SecretIssue.AutoSize = true;
            this.label_SecretIssue.Location = new System.Drawing.Point(12, 78);
            this.label_SecretIssue.Name = "label_SecretIssue";
            this.label_SecretIssue.Size = new System.Drawing.Size(135, 17);
            this.label_SecretIssue.TabIndex = 2;
            this.label_SecretIssue.Text = "Секретный вопрос:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button_GetSecr
            // 
            this.button_GetSecr.Location = new System.Drawing.Point(17, 42);
            this.button_GetSecr.Name = "button_GetSecr";
            this.button_GetSecr.Size = new System.Drawing.Size(296, 33);
            this.button_GetSecr.TabIndex = 4;
            this.button_GetSecr.Text = "Получить секретный вопрос";
            this.button_GetSecr.UseVisualStyleBackColor = true;
            this.button_GetSecr.Click += new System.EventHandler(this.button_GetSecr_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(12, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 22);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Получить пароль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Reply
            // 
            this.label_Reply.AutoSize = true;
            this.label_Reply.Location = new System.Drawing.Point(11, 132);
            this.label_Reply.Name = "label_Reply";
            this.label_Reply.Size = new System.Drawing.Size(81, 17);
            this.label_Reply.TabIndex = 7;
            this.label_Reply.Text = "Ваш ответ:";
            // 
            // ShowPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 231);
            this.Controls.Add(this.label_Reply);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_GetSecr);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_SecretIssue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Забыл пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_SecretIssue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_GetSecr;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Reply;
    }
}