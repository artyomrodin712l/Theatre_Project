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
    public partial class PerfomanceForm : Form
    {        
        
        List<Perfomance> perfomances = new List<Perfomance>();
        BindingSource PerfomanceBindingSource = new BindingSource();
        Perfomance perfomance = new Perfomance();
        public PerfomanceForm()
        {
            InitializeComponent();
        }
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            perfomance = new Perfomance();
            perfomance.Name = PerfomanceTextBox.Text;
            perfomance.Author = AuthorComboBox.Text;
            perfomance.Genre = GenreComboBox.Text;
            perfomance.Path = PerfomancePictureBox.ImageLocation;
            perfomance.Picture = PerfomancePictureBox.Image;
            perfomances.Add(perfomance);
            PerfomanceBindingSource.ResetBindings(true);
        }

        private void PerfomanceForm_Load(object sender, EventArgs e)
        {
            
                Program.LoadAllData();
                if (Program.perfomances != null)
                {
                    perfomances = Program.perfomances;
                }
                BindingSource AuthorBS = new BindingSource();
                AuthorBS.DataSource = Program.authors;
                AuthorComboBox.DataSource = AuthorBS;
                AuthorComboBox.ValueMember = "Name";
                AuthorComboBox.DisplayMember = "Name";
                BindingSource GenreBs = new BindingSource();
                GenreBs.DataSource = Program.genres;
                GenreComboBox.DataSource = GenreBs;
                GenreComboBox.ValueMember = "Name";
                GenreComboBox.DisplayMember = "Name";
                PerfomanceBindingSource.DataSource = perfomances;
                PerfomanceDataGridView.DataSource = PerfomanceBindingSource;
                DataGridViewImageColumn column1 = (DataGridViewImageColumn)PerfomanceDataGridView.Columns["Picture"];
                column1.ImageLayout = DataGridViewImageCellLayout.Zoom;
                column1.Description = "Zoomed";
                PerfomanceBindingNavigator.BindingSource = PerfomanceBindingSource;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AuthorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PerfomancePictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void PerfomanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PerfomanceBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.perfomances = perfomances;
            //Program.DataWorkerXML(perfomances, "Save");
            //perfomances = Program.perfomances;
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            perfomances = (List<Perfomance>)ConcreteFactoryXML.CreateWriteData().SetObject(perfomances);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            Bitmap photo; //Bitmap для открываемого изображения
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    FileInfo fs = new FileInfo(open_dialog.FileName);
                    string Destination = Program.XMLfolderImage + fs.Name;
                    System.IO.File.Copy(open_dialog.FileName, Destination, true);
                    photo = new Bitmap(Destination);
                    PerfomancePictureBox.Image = photo;
                    PerfomancePictureBox.ImageLocation = Destination;
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
