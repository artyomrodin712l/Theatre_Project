using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Course_OOP
{
    public partial class RegistrForm : System.Windows.Forms.Form
    {
        List<User> users = new List<User>();
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccessButton_Click(object sender, EventArgs e)
        {

            if (LoginTextBox.Text == "")
            {
                MessageBox.Show("Вы не ввели логин");
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль");
            }
            else
            {

                //  Program.DataWorkerXML(users, "Load");
                ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
                users = (List<User>)ConcreteFactoryXML.CreateReadData().GetObject(users);
                if (Program.users != null)
                {
                    users = Program.users;
                }
                User user = new User();
                user.Id = 1;
                user.AccessModifier = User.Access.Registered;
                user.Login = LoginTextBox.Text;
                user.Password = PasswordTextBox.Text;
                bool UserExist = false;
                foreach (User user1 in Program.users)
                {
                    if (user1.Login == user.Login)
                    {
                        UserExist = true;
                    }
                }
                if (UserExist)
                {
                    MessageBox.Show("Данный пользоватеь уже существует");
                }
                else
                {
                    users.Add(user);
                    Program.users = users;

                    users = (List<User>)ConcreteFactoryXML.CreateWriteData().SetObject(users);
                    if (PasswordTextBox.Text != SecondPasswordTextBox.Text)
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                    else
                    {
                        Program.user = user;
                        MessageBox.Show("Регистрация прошла успешно.Теперь войдите в систему под своим логином и паролем");
                        this.Close();

                    }
                }
            }
        }
        private void SecondPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
