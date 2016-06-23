using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApplication
{
    public partial class AuthorizationForm : Form
    {
        static public string Status;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (Verification(textBox_Login.Text, textBox1.Text))
            {
                Status = "Run";
                Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность ввода логина или пароля", "Ошибка авторизации");
            }
        }

        private bool Verification(string login, string password)
        {
            string _login = "admin";
            string _password = "12345";

            if (login == _login)
                if (password == _password)
                    return true;

            return false;
        }

        private void linkLabel_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPassword sPass = new ShowPassword();
            sPass.Show();
        }

        private void linkLabel_Reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
        }
    }
}
