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
    public partial class ReportForm : Form
    {
        BindingSource ReportBindingSource = new BindingSource();
        List<Report> reports = new List<Report>();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            float moneyCount = 0;
            int amount = 0;
            int FirstAmount = 0;
            float FirstMoney = 0;
            int SecondAmount = 0;
            float SecondMoney = 0;
            int ThirdAmount = 0;
            float ThirdMoney = 0;
            if (Program.orders != null)
            {
                foreach (Order order in Program.orders)
                {
                    Report report = new Report();
                    report.date = order.date;
                    report.User = order.User;
                    report.Perfomance = order.Perfomance;
                    report.Category = order.Category;
                    report.id = order.id;

                    foreach (Perfomance perfomance in Program.perfomances)
                    {
                        if (report.Perfomance == perfomance.Name)
                        {
                            report.Author = perfomance.Author;
                            report.Genre = perfomance.Genre;
                            break;
                        }
                    }
                    report.Price = 0;
                    foreach (TKT tkt in Program.tkts)
                    {
                        string stringCategory = "";
                        if (tkt.CategoryModifier == TKT.Category.First) stringCategory = "First";                         
                        else if (tkt.CategoryModifier == TKT.Category.Second) stringCategory = "Second";
                        else if (tkt.CategoryModifier == TKT.Category.Third) stringCategory = "Third";
                        if (report.Category == stringCategory)
                        {
                            

                            report.Price = tkt.price;
                            if(report.Category == "First")
                            {
                                 FirstAmount++;
                                FirstMoney += report.Price;
                            }
                            if (report.Category == "Second")
                            {
                                SecondAmount++;
                                SecondMoney += report.Price;
                            }
                            if (report.Category == "Third")
                            {
                                ThirdAmount++;
                                ThirdMoney += report.Price;
                            }
                            moneyCount += report.Price;
                            amount++;
                        }
                    }
                    
                    reports.Add(report);
                }
                MoneyTextBox.Text = moneyCount.ToString();
                AmountTextBox.Text = amount.ToString();
                FirstAmountTextBox.Text = FirstAmount.ToString();
                FirstMoneyTextBox.Text = FirstMoney.ToString();
                SecondAmountTextBox.Text = SecondAmount.ToString();
                SecondMoneyTextBox.Text = SecondMoney.ToString();
                ThirdAmountTextBox.Text = ThirdAmount.ToString();
                ThirdMoneyTextBox.Text = ThirdMoney.ToString();
            }
          
                
            ReportBindingSource.DataSource = reports;
            ReportDataGridView.DataSource = ReportBindingSource;
            ReportBindingNavigator.BindingSource = ReportBindingSource;
        }

        private void ReportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            
            List<Report> reportsFilterData = 
            reports.Where(element => (element.date >= FromDateTimePicker.Value.Date && element.date <= ToDateTimePicker.Value.Date)).ToList();

            ReportBindingSource.DataSource = reportsFilterData;
        }

        private void ReportDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolSearchNameStripTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Program.reports == null)
                {
                    Program.reports = reports;
                }
                reports = Program.reports.Where(element => element.Perfomance.ToUpper().Contains(toolSearchNameStripTextBox.Text.ToUpper()) == true).ToList();
                ReportBindingSource.DataSource = reports;

            }
        }

        private void toolSearchGenreStripTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Program.reports == null)
                {
                    Program.reports = reports;
                }
                reports = Program.reports.Where(element => element.Genre.ToUpper().Contains(toolSaerchGenreStripTextBox.Text.ToUpper()) == true).ToList();
                ReportBindingSource.DataSource = reports;

            }
        }

        private void toolSearchAuthorStripTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Program.reports == null)
                {
                    Program.reports = reports;
                }
                reports = Program.reports.Where(element => element.Author.ToUpper().Contains(toolSearchAuthorStripTextBox.Text.ToUpper()) == true).ToList();
                ReportBindingSource.DataSource = reports;

            }
        }

        private void toolSearchUserStripTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Program.reports == null)
                {
                    Program.reports = reports;
                }
                reports = Program.reports.Where(element => element.User.ToUpper().Contains(toolSearchUserStripTextBox.Text.ToUpper()) == true).ToList();
                ReportBindingSource.DataSource = reports;

            }
        }
    }

   
    
}
