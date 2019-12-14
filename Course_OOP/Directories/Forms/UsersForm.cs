using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Course_OOP
{
    [Serializable]
    public partial class UsersForm : Form
    {        
        
        List<User> users = new List<User>();
        BindingSource UsersBindingSource = new BindingSource();
        public UsersForm()
        {
            InitializeComponent();
        }


        private void UsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            
        private void UsersForm_Load(object sender, EventArgs e)
        {
         //   Program.DataWorkerXML(users,"Load");
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            Program.users = (List<User>)ConcreteFactoryXML.CreateReadData().GetObject(users);
            if (Program.users != null)
            {
                users = Program.users;
            }
            
            UsersBindingSource.DataSource = users;
            UsersDataGridView.DataSource = UsersBindingSource;
            UsersBindingNavigator.BindingSource = UsersBindingSource;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            
            switch(UserComboBox.SelectedItem)
            {
                case "Admin": user.AccessModifier = User.Access.Admin; break;
                case "Registered": user.AccessModifier = User.Access.Registered; break;
                default: user.AccessModifier = User.Access.Guest; break;

            }
            user.Login = LoginTextBox.Text;
            user.Password = PasswordTextBox.Text;
            bool UserExist = false;
            foreach(User user1 in Program.users)
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
                UsersBindingSource.ResetBindings(true);
            }
        }

        private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.users=users;
            //Program.DataWorkerXML(users, "Save");
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            users = (List<User>)ConcreteFactoryXML.CreateWriteData().SetObject(users);
           // users = Program.users;

        }


        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
