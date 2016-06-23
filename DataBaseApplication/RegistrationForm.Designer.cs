namespace DataBaseApplication
{
    partial class RegistrationForm
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
            this.button_Reg = new System.Windows.Forms.Button();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.groupBox_Password = new System.Windows.Forms.GroupBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox_Secr = new System.Windows.Forms.GroupBox();
            this.textBox_Secr = new System.Windows.Forms.TextBox();
            this.groupBox_Reply = new System.Windows.Forms.GroupBox();
            this.textBox_Reply = new System.Windows.Forms.TextBox();
            this.groupBox_Login.SuspendLayout();
            this.groupBox_Password.SuspendLayout();
            this.groupBox_Secr.SuspendLayout();
            this.groupBox_Reply.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Reg
            // 
            this.button_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reg.Location = new System.Drawing.Point(107, 308);
            this.button_Reg.Name = "button_Reg";
            this.button_Reg.Size = new System.Drawing.Size(203, 42);
            this.button_Reg.TabIndex = 0;
            this.button_Reg.Text = "Регистрация";
            this.button_Reg.UseVisualStyleBackColor = true;
            this.button_Reg.Click += new System.EventHandler(this.button_Reg_Click);
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Controls.Add(this.textBox_Login);
            this.groupBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Login.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(377, 68);
            this.groupBox_Login.TabIndex = 1;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "Ваш логин";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(7, 30);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(345, 26);
            this.textBox_Login.TabIndex = 0;
            // 
            // groupBox_Password
            // 
            this.groupBox_Password.Controls.Add(this.textBox_Password);
            this.groupBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Password.Location = new System.Drawing.Point(12, 86);
            this.groupBox_Password.Name = "groupBox_Password";
            this.groupBox_Password.Size = new System.Drawing.Size(377, 68);
            this.groupBox_Password.TabIndex = 2;
            this.groupBox_Password.TabStop = false;
            this.groupBox_Password.Text = "Ваш пароль";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(7, 30);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(345, 26);
            this.textBox_Password.TabIndex = 0;
            // 
            // groupBox_Secr
            // 
            this.groupBox_Secr.Controls.Add(this.textBox_Secr);
            this.groupBox_Secr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Secr.Location = new System.Drawing.Point(12, 160);
            this.groupBox_Secr.Name = "groupBox_Secr";
            this.groupBox_Secr.Size = new System.Drawing.Size(377, 68);
            this.groupBox_Secr.TabIndex = 2;
            this.groupBox_Secr.TabStop = false;
            this.groupBox_Secr.Text = "Ваш секретный вопрос";
            // 
            // textBox_Secr
            // 
            this.textBox_Secr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Secr.Location = new System.Drawing.Point(7, 30);
            this.textBox_Secr.Name = "textBox_Secr";
            this.textBox_Secr.Size = new System.Drawing.Size(345, 26);
            this.textBox_Secr.TabIndex = 0;
            // 
            // groupBox_Reply
            // 
            this.groupBox_Reply.Controls.Add(this.textBox_Reply);
            this.groupBox_Reply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Reply.Location = new System.Drawing.Point(12, 234);
            this.groupBox_Reply.Name = "groupBox_Reply";
            this.groupBox_Reply.Size = new System.Drawing.Size(377, 68);
            this.groupBox_Reply.TabIndex = 3;
            this.groupBox_Reply.TabStop = false;
            this.groupBox_Reply.Text = "Ваш ответ на секретный вопрос";
            // 
            // textBox_Reply
            // 
            this.textBox_Reply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Reply.Location = new System.Drawing.Point(7, 30);
            this.textBox_Reply.Name = "textBox_Reply";
            this.textBox_Reply.Size = new System.Drawing.Size(345, 26);
            this.textBox_Reply.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 356);
            this.Controls.Add(this.groupBox_Reply);
            this.Controls.Add(this.groupBox_Secr);
            this.Controls.Add(this.groupBox_Password);
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.button_Reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.groupBox_Password.ResumeLayout(false);
            this.groupBox_Password.PerformLayout();
            this.groupBox_Secr.ResumeLayout(false);
            this.groupBox_Secr.PerformLayout();
            this.groupBox_Reply.ResumeLayout(false);
            this.groupBox_Reply.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Reg;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.GroupBox groupBox_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.GroupBox groupBox_Secr;
        private System.Windows.Forms.TextBox textBox_Secr;
        private System.Windows.Forms.GroupBox groupBox_Reply;
        private System.Windows.Forms.TextBox textBox_Reply;
    }
}