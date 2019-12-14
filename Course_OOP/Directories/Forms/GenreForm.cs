using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Course_OOP
{
    [Serializable]
    public partial class GenreForm : Form
    {
        public GenreForm()
        {
            InitializeComponent();
        }
        List<Genre> genres = new List<Genre>();
        BindingSource GenreBindingSource = new BindingSource();
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            // Program.DataWorkerXML(genres,"Load");
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            Program.genres = (List<Genre>)ConcreteFactoryXML.CreateReadData().GetObject(genres);
            if (Program.genres != null)
            {
                genres = Program.genres;
            }
            GenreBindingSource.DataSource = genres;
            GenreDataGridView.DataSource = GenreBindingSource;
            GenreBindingNavigator.BindingSource = GenreBindingSource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.Name = GenreTextBox.Text;
            genres.Add(genre);
            GenreBindingSource.ResetBindings(true);
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            // Program.DataWorkerXML(genres, "Save");
            // genres = Program.genres;
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            genres = (List<Genre>)ConcreteFactoryXML.CreateWriteData().SetObject(genres);
          
        }
    }
}
