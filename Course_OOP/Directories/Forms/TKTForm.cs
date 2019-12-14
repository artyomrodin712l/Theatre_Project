using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Course_OOP
{
    [Serializable]
    public partial class TKTForm : Form
    {
        public TKTForm()
        {
            InitializeComponent();
        }
        List<TKT> tkts = new List<TKT>();
        BindingSource TKTBindingSource = new BindingSource();
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            TKT tkt = new TKT();
            switch (CategoryComboBox.SelectedItem)
            {
                case "First": tkt.CategoryModifier = TKT.Category.First; break;
                case "Second": tkt.CategoryModifier = TKT.Category.Second; break;
                default: tkt.CategoryModifier = TKT.Category.Third; break;
            }
            tkt.price = float.Parse(PriceTextBox.Text, CultureInfo.InvariantCulture);
            tkt.amount = Int32.Parse(AmountTextBox.Text);
            tkts.Add(tkt);
            TKTBindingSource.ResetBindings(true);
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TKTForm_Load(object sender, EventArgs e)
        {
            // Program.DataWorkerXML(tkts, "Load");
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            tkts = (List<TKT>)ConcreteFactoryXML.CreateReadData().GetObject(tkts);
            if (Program.tkts != null)
                tkts = Program.tkts;
            TKTBindingSource.DataSource = tkts;
            TicketDataGridView.DataSource = TKTBindingSource;
            TicketBindingNavigator.BindingSource = TKTBindingSource;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.tkts = tkts;
            // Program.DataWorkerXML(tkts, "Save");
            //tkts = Program.tkts;
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            tkts = (List<TKT>)ConcreteFactoryXML.CreateWriteData().SetObject(tkts);
        }

        private void PerfomanceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TicketDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
