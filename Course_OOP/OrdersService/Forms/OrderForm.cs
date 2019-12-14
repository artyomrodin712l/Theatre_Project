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
    public partial class OrderForm : Form
    {
        List<Order> orders = new List<Order>();
        BindingSource OrderBindingSource = new BindingSource();
        
        public OrderForm()
        {
            InitializeComponent();
        }

        private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Perfomance = PerfomanceComboBox.Text;
            order.Category = CategoryComboBox.Text;
            order.User = UserComboBox.Text;
            order.date = DateTimePicker.Value.Date;
            if (orders.Count == 0)
            {
                order.id = 1;
            }
            else
            {
                order.id = orders.Max(point => point.id) + 1;
            }
            orders.Add(order);
            OrderBindingSource.ResetBindings(true);
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Program.LoadAllData();
            if (Program.orders != null)
            {
                orders = Program.orders;
            }
            BindingSource PerfomanceBS = new BindingSource();
            if (Program.perfomances != null)
            {
                PerfomanceBS.DataSource = Program.perfomances;
                PerfomanceComboBox.DataSource = PerfomanceBS;
                PerfomanceComboBox.ValueMember = "Name";
                PerfomanceComboBox.DisplayMember = "Name";
            }
            BindingSource UserBS = new BindingSource();
            if (Program.users != null)
            {
                UserBS.DataSource = Program.users;
                UserComboBox.DataSource = UserBS;
                UserComboBox.ValueMember = "Login";
                UserComboBox.DisplayMember = "Login";
            }
            BindingSource CategoryBS = new BindingSource();
            if (Program.tkts != null)
            {
                CategoryBS.DataSource = Program.tkts;
                CategoryComboBox.DataSource = CategoryBS;
                CategoryComboBox.ValueMember = "CategoryModifier";
                CategoryComboBox.DisplayMember = "CategoryModifier";
            }

            OrderBindingSource.DataSource = orders;
            OrderDataGridView.DataSource = OrderBindingSource;
            OrderBindingNavigator.BindingSource = OrderBindingSource;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.orders = orders;
           // Program.DataWorkerXML(orders, "Save");
          //  orders = Program.orders;
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            orders = (List<Order>)ConcreteFactoryXML.CreateWriteData().SetObject(orders);
            //  authors = Program.authors;
        }

        private void OrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
          
                Program.order = null;
        }
    }
}
