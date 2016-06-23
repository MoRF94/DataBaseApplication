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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button_Reg_Click(object sender, EventArgs e)
        {
            if (textBox_Login.TextLength < 10)
                if (textBox_Password.TextLength < 12)
                    if (textBox_Secr.TextLength < 20)
                        if (textBox_Reply.TextLength < 20)
                            CreateNewUser();
                        else MessageBox.Show("Число символов ответа на секретный вопрос не должно привышать 12");
                    else MessageBox.Show("Число символов секретного вопроса не должно привышать 12");
                else MessageBox.Show("Число символов пароля не должно привышать 12");
            else MessageBox.Show("Число символов логина не должно привышать 12");
        }

        private void CreateNewUser()
        {
            
        }
    }
}
