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
    public partial class ShowPassword : Form
    {
        public ShowPassword()
        {
            InitializeComponent();
        }

        private void button_GetSecr_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button1.Enabled = false;

            if (textBox1.Text == "admin")
            {
                textBox2.Text = "Домашнее животное";
                textBox3.Enabled = true;
                button1.Enabled = true;
            }
            else
                MessageBox.Show("Не можем найти такой логин", "Ошибка");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Varifications(textBox3.Text))
            {
                Close();
            }
            else MessageBox.Show("Ответ не верный!");
        }

        private bool Varifications(string p)
        {
            string str = "Кот";
            if (p == str)
            {
                MessageBox.Show("12345", "Ваш пароль");
                return true;
            }

            return false;            
        }
    }
}
