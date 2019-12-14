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
    public class PosterView : Poster
    {

        int countAll = 0;
        
        public int AddOrder(string Name, DateTime date,string Category)
        {
            if (Program.user == null)
            {
                MessageBox.Show("Пожалуйста зарегистрируйтесь");
            }
            else
            {
                List<Order> orders = new List<Order>();
                if (Program.orders != null)
                {
                    orders = Program.orders;
                }
                Order order = new Order();
                order.Perfomance = Name;
                order.Category = Category;
                order.User = Program.user.Login;
                order.date = date;
                if (orders.Count == 0)
                {
                    order.id = 1;
                }
                else
                {
                    order.id = orders.Max(point => point.id) + 1;
                }
                orders.Add(order);
                Program.orders = orders;
            }
            return 1;
        }
        public int AmountTKTFirstCategory(DateTime date)
        {
            int ordered = 0;
            if (Program.tkts != null)
            {
                foreach (TKT tkt in Program.tkts)
                {

                    if (tkt.CategoryModifier.ToString() == "First")
                    {
                        countAll += tkt.amount;
                    }
                }
            }
            if (Program.orders != null)
            {
                foreach (Order order in Program.orders)
                {
                    if(order.Category.ToString() == "First" && order.date == date)
                    {
                        ordered++; 
                    }
                }    
            }     
            return countAll-ordered;
        }
        public int AmountTKTSecondCategory(DateTime date)
        {
            int ordered = 0;
            if (Program.tkts != null)
            {
                foreach (TKT tkt in Program.tkts)
                {

                    if (tkt.CategoryModifier.ToString() == "Second")
                    {
                        countAll += tkt.amount;
                    }
                }
            }
            if (Program.orders != null)
            {
                foreach (Order order in Program.orders)
                {
                    if (order.Category.ToString() == "Second" && order.date == date)
                    {
                        ordered++;
                    }
                }
            }
            return countAll - ordered;
        }

        public int AmountTKTThirdCategory(DateTime date)
        {
            int ordered = 0;
            if (Program.tkts != null)
            {
                foreach (TKT tkt in Program.tkts)
                {

                    if (tkt.CategoryModifier.ToString() == "Third")
                    {
                        countAll += tkt.amount;
                    }
                }
            }
            if (Program.orders != null)
            {
                foreach (Order order in Program.orders)
                {
                    if (order.Category.ToString() == "Third" && order.date == date)
                    {
                        ordered++;
                    }
                }
            }
            return countAll - ordered;
        }
        public Image Picture { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int FreeTicket1Categ { get; set; }
        public int FreeTicket2Categ { get; set; }
        public int FreeTicket3Categ { get; set; }
    }
}
