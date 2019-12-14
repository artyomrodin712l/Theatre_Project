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
    public partial class AuthorForm : Form
    {
        List<Author> authors = new List<Author>();
        BindingSource AuthorBindingSource = new BindingSource();
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Name = AuthorTextBox.Text;
            
            authors.Add(author);
            AuthorBindingSource.ResetBindings(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           // Program.DataWorkerXML(authors, "Save");
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            authors = (List<Author>)ConcreteFactoryXML.CreateWriteData().SetObject(authors);
          //  authors = Program.authors;
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
          
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            Program.authors = (List<Author>)ConcreteFactoryXML.CreateReadData().GetObject(authors);
            if (Program.authors != null)
            {
                authors = Program.authors;
            }
            AuthorBindingSource.DataSource = authors;
            AuthorDataGridView.DataSource = AuthorBindingSource;
            AuthorBindingNavigator.BindingSource = AuthorBindingSource;
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void AuthorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
