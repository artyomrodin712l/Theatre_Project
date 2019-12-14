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
    [Serializable]
    public partial class PosterForm : Form
    {
        List<Poster> posters = new List<Poster>();
        BindingSource PosterBindingSource = new BindingSource();

        public PosterForm()
        {
            InitializeComponent();
        }

        private void PosterForm_Load(object sender, EventArgs e)
        {
            Program.LoadAllData();
            if (Program.posters != null)
            {
                posters = Program.posters;
            }
            BindingSource PerfomanceBS = new BindingSource();
            PerfomanceBS.DataSource = Program.perfomances;
            PerfomanceComboBox.DataSource = PerfomanceBS;
            PerfomanceComboBox.ValueMember = "Name";
            PerfomanceComboBox.DisplayMember = "Name";
            PosterBindingSource.DataSource = posters;
            PosterDataGridView.DataSource = PosterBindingSource;
            PosterBindingNavigator.BindingSource = PosterBindingSource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Poster poster = new Poster();
            poster.Name = PerfomanceComboBox.Text;
            poster.Date = DateTimePicker.Value.Date;
            poster.Time = TimeTextBox.Text;
            bool DateExist = false;
            foreach(Poster poster1 in Program.posters)
            {
                if(poster1.Date == poster.Date)
                {
                    DateExist = true;
                }
            }
            if (DateExist)
            {
                MessageBox.Show("На данную дату представление запланировано");
            }
            else
            {
                posters.Add(poster);
                PosterBindingSource.ResetBindings(true);
            }
        }
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.posters = posters;
            // Program.DataWorkerXML(posters, "Save");
            //posters = Program.posters;
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            posters = (List<Poster>)ConcreteFactoryXML.CreateWriteData().SetObject(posters);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PosterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PosterBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void PerfomanceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
