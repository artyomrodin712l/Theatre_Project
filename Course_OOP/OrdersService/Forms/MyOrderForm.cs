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
    public partial class MyOrderForm : Form
    {
        BindingSource MyOrderBindingSource = new BindingSource();
        List<Order> myOrders = new List<Order>();

        public MyOrderForm()
        {
            InitializeComponent();
        }

        private void MyOrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyOrderForm_Load(object sender, EventArgs e)
        {
                 Program.LoadAllData();
            if (Program.orders != null)
            {
                myOrders = Program.orders.Where(element =>element.User == Program.user.Login).ToList();
            }       
            MyOrderBindingSource.DataSource = myOrders;
            MyOrderDataGridView.DataSource = MyOrderBindingSource;
            MyOrderBindingNavigator.BindingSource = MyOrderBindingSource;
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {


        }

 
        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void MyOrderBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolSaveStripButton_Click(object sender, EventArgs e)
        {
            ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
            Program.orders = (List<Order>)ConcreteFactoryXML.CreateWriteData().SetObject(Program.orders);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MyOrderBindingSource.Current != null)
            {
                Order current = (Order)MyOrderBindingSource.Current;
                myOrders.RemoveAll(x => x.id == current.id);
                Program.orders.RemoveAll(x => x.id == current.id);
                MyOrderBindingSource.ResetBindings(true);


            }
        }
    }
}
