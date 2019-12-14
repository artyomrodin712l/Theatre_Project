using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_OOP
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        List<User> users = new List<User>();
        User user = new User();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            bool loginPassed = false;
            bool passwordPassed = false;

            foreach (User user in users)
            {            
                if (user.Login == LoginTextBox.Text)
                {
                    loginPassed = true;

                    if (user.Password == PasswordTextBox.Text)
                    {
                        
                        passwordPassed = true;
                        Program.user = user;
                        this.Close();
 //                       MainForm Form = new MainForm();
 //                       Form.Show();
                        break;
                        
                    }
               
                }
            }
            if (!loginPassed)
            {
                MessageBox.Show("Неверный логин");
            }
            else if (!passwordPassed)
            {
                MessageBox.Show("Неверный пароль");
            }     
            
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void RegistrLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm regForm = new RegistrForm();
            regForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Program.users != null)
            {
                users = Program.users;
            }
            User user = new User();
            user.Id = 1;
            user.AccessModifier = User.Access.Admin;
            user.Login = "admin";
            user.Password = "admin";
            users.Add(user);
        }
    }
}
