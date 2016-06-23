namespace DataBaseApplication
{
    partial class AuthorizationForm
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
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel_Password = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Reg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(14, 24);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(47, 17);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Логин";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(12, 54);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(57, 17);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Пароль";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(17, 86);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(267, 36);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Войти";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(84, 23);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(200, 22);
            this.textBox_Login.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // linkLabel_Password
            // 
            this.linkLabel_Password.AutoSize = true;
            this.linkLabel_Password.Location = new System.Drawing.Point(17, 136);
            this.linkLabel_Password.Name = "linkLabel_Password";
            this.linkLabel_Password.Size = new System.Drawing.Size(120, 17);
            this.linkLabel_Password.TabIndex = 5;
            this.linkLabel_Password.TabStop = true;
            this.linkLabel_Password.Text = "Забыл пароль :-(";
            this.linkLabel_Password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Password_LinkClicked);
            // 
            // linkLabel_Reg
            // 
            this.linkLabel_Reg.AutoSize = true;
            this.linkLabel_Reg.Location = new System.Drawing.Point(192, 136);
            this.linkLabel_Reg.Name = "linkLabel_Reg";
            this.linkLabel_Reg.Size = new System.Drawing.Size(92, 17);
            this.linkLabel_Reg.TabIndex = 6;
            this.linkLabel_Reg.TabStop = true;
            this.linkLabel_Reg.Text = "Регистрация";
            this.linkLabel_Reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Reg_LinkClicked);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 165);
            this.Controls.Add(this.linkLabel_Reg);
            this.Controls.Add(this.linkLabel_Password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel_Password;
        private System.Windows.Forms.LinkLabel linkLabel_Reg;
    }
}