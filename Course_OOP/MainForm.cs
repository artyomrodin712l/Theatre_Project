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
    public partial class MainForm : System.Windows.Forms.Form
    {
        BindingSource PosterBindingSource = new BindingSource();
        List<PosterView> posterViews = new List<PosterView>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (Program.user.AccessModifier == User.Access.Guest)
            {
                LoginForm LoginForm = new LoginForm();
                LoginForm.FormClosing += (sender1, e1) =>
                {
                    LoadData();
                };
                LoginForm.Show();
            }
            else
            {
                Program.user.AccessModifier = User.Access.Guest;
                LoadData();
            }
        }
        private void Form_Load(object sender, EventArgs e)
        {
            Program.LoadAllData();
            PosterBindingSource.DataSource = posterViews;
            PosterDataGridView.DataSource = PosterBindingSource;
            PosterBindingNavigator.BindingSource = PosterBindingSource;
            DataGridViewImageColumn column1 = (DataGridViewImageColumn)PosterDataGridView.Columns["Picture"];
            column1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            column1.Description = "Zoomed";
             DataGridViewButtonColumn btn1category = new DataGridViewButtonColumn();
            PosterDataGridView.Columns.Add(btn1category);
            btn1category.HeaderText = "First category price";
            foreach (TKT tkt in Program.tkts)
            {
                if (tkt.CategoryModifier == TKT.Category.First)
                {
                    btn1category.Text = tkt.price.ToString() + " руб";
                }
            }
            btn1category.Name = "btn1category";
            btn1category.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btn2category = new DataGridViewButtonColumn();
            PosterDataGridView.Columns.Add(btn2category);
            btn2category.HeaderText = "Second category price";
            foreach (TKT tkt in Program.tkts)
            {
                if (tkt.CategoryModifier == TKT.Category.Second)
                {
                    btn2category.Text = tkt.price.ToString() + " руб";
                }
            }
            btn2category.Name = "btn2category";
            btn2category.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btn3category = new DataGridViewButtonColumn();
            PosterDataGridView.Columns.Add(btn3category);
            btn3category.HeaderText = "Third category price";
            foreach (TKT tkt in Program.tkts)
            {
                if (tkt.CategoryModifier == TKT.Category.Third)
                {
                    btn3category.Text = tkt.price.ToString() + " руб";
                }
            }
            btn3category.Name = "btn3category";
            btn3category.UseColumnTextForButtonValue = true;
            LoadData();
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            RegistrForm Form = new RegistrForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
          
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справочникПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm Form = new UsersForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
        }

        private void справочникЖанровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenreForm Form = new GenreForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
        }

        private void справочникАвторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm Form = new AuthorForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
        }

        private void справочникПьесToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PerfomanceForm Form = new PerfomanceForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
        }

        private void справочникКатегорийБилетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKTForm Form = new TKTForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void справочникАфишToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosterForm Form = new PosterForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm Form = new OrderForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
        }

        private void PosterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PosterDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == PosterDataGridView.Columns["btn1category"].Index
                || e.ColumnIndex == PosterDataGridView.Columns["btn2category"].Index
                || e.ColumnIndex == PosterDataGridView.Columns["btn3category"].Index)
            {

                PosterView current = (PosterView)PosterBindingSource.Current;
                if (Program.user.AccessModifier != User.Access.Guest)
                {
                    if (e.ColumnIndex == PosterDataGridView.Columns["btn1category"].Index)
                    {
                        if (current.FreeTicket1Categ > 0)
                        {
                            current.AddOrder(current.Name, current.Date, "First");
                            AcceptOrderForm Form = new AcceptOrderForm();
                            Form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Билеты первой категории закончились");
                        }
                    }
                    if (e.ColumnIndex == PosterDataGridView.Columns["btn2category"].Index)
                    {
                        if (current.FreeTicket2Categ > 0)
                        {
                            current.AddOrder(current.Name, current.Date, "Second");
                            AcceptOrderForm Form = new AcceptOrderForm();
                            Form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Билеты второй категории закончились");
                        }

                    }
                    if (e.ColumnIndex == PosterDataGridView.Columns["btn3category"].Index)
                    {
                        if (current.FreeTicket2Categ > 0)
                        {
                            current.AddOrder(current.Name, current.Date, "Third");
                            AcceptOrderForm Form = new AcceptOrderForm();
                            Form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Билеты третьей категории закончились");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Зарегистрируйтесь");
                }
                ConcreteFactoryXML ConcreteFactoryXML = new ConcreteFactoryXML();
                Program.orders = (List<Order>)ConcreteFactoryXML.CreateWriteData().SetObject(Program.orders);
                LoadData();
                PosterBindingSource.ResetBindings(true);
            }
            

        }

        private void моиЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MyOrderForm Form = new MyOrderForm();
            Form.FormClosing += (sender1, e1) =>
            {
                LoadData();
            };
            Form.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

 
        private void toolStripTextBoxSearch_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripSaerchNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (Program.posterViews == null)
                {
                    Program.posterViews = posterViews;
                }
                posterViews = Program.posterViews.Where(element => element.Genre.ToUpper().Contains(toolStripSaerchNameTextBox.Text.ToUpper()) == true).ToList();
                PosterBindingSource.DataSource = posterViews;

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (Program.posterViews == null)
            {
                Program.posterViews = posterViews;
            }
           posterViews = Program.posterViews.Where(element => element.Date == SearchDateTimePicker.Value.Date).ToList();
           PosterBindingSource.DataSource = posterViews;
        }

        private void SearchDateTimePicker_Enter(object sender, EventArgs e)
        {

        }

        private void SearchFreeTKTtoolStripComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void SearchFreeTKTtoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (Program.posterViews == null)
                {
                    Program.posterViews = posterViews;
                }
                if (SearchFreeTKTtoolStripComboBox.Text == "First")
                {
                    posterViews = Program.posterViews.Where(element => element.FreeTicket1Categ >= Int32.Parse(FreeTKTtoolStripTextBox.Text)).ToList();
                }
                else if (SearchFreeTKTtoolStripComboBox.Text == "Second")
                {
                    posterViews = Program.posterViews.Where(element => element.FreeTicket2Categ >= Int32.Parse(FreeTKTtoolStripTextBox.Text)).ToList();
                }
                else if (SearchFreeTKTtoolStripComboBox.Text == "Third")
                {
                    posterViews = Program.posterViews.Where(element => element.FreeTicket3Categ >= Int32.Parse(FreeTKTtoolStripTextBox.Text)).ToList();
                }
                 PosterBindingSource.DataSource = posterViews;
        }

        private void FreeTKTtoolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm Form = new ReportForm();
            Form.Show();
        }

        private void toolStripSaerchNameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void SearchFreeTKTtoolStripComboBox_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            posterViews = new List<PosterView>();

            if (Program.user == null)
            {
                User user = new User();
                user.AccessModifier = User.Access.Guest;
                Program.user = user;

                
            }
            if (Program.user.AccessModifier == User.Access.Guest)
            {
                EnterButton.Text = "Вход";
                RegistrButton.Text = "Регистрация";
                RegistrButton.Enabled = true;
            }
            Program.LoadAllData();
            if (Program.user.AccessModifier != User.Access.Admin)
            {
                настройкиToolStripMenuItem.Visible = false;
                заказыToolStripMenuItem.Visible = false;
                отчётыToolStripMenuItem.Visible = false;
            }
            else
            {
                настройкиToolStripMenuItem.Visible = true;
                заказыToolStripMenuItem.Visible = true;
                отчётыToolStripMenuItem.Visible = true;
            }
            if (Program.posters != null)
            {
                foreach (Poster poster in Program.posters)
                {
                    PosterView posterView = new PosterView();
                    posterView.Name = poster.Name;
                    posterView.Date = poster.Date;
                    posterView.Time = poster.Time;
                    foreach (Perfomance perfomance in Program.perfomances)
                    {
                        if (perfomance.Name == posterView.Name)
                        {
                            posterView.Author = perfomance.Author;
                            posterView.Genre = perfomance.Genre;
                            posterView.Picture = perfomance.Picture;
                            posterView.FreeTicket1Categ = posterView.AmountTKTFirstCategory(poster.Date);
                            posterView.FreeTicket2Categ = posterView.AmountTKTSecondCategory(poster.Date);
                            posterView.FreeTicket3Categ = posterView.AmountTKTThirdCategory(poster.Date);
                        }
                    }
                    posterViews.Add(posterView);
                }
            }
            
            if (Program.user.AccessModifier != User.Access.Guest)
            {
                EnterButton.Text = "Выход";
                RegistrButton.Text = "Здравствуйте, " + Program.user.Login;
                RegistrButton.Enabled = false;
            }

           
            PosterBindingSource.DataSource = posterViews;
            PosterDataGridView.DataSource = PosterBindingSource;
            PosterBindingNavigator.BindingSource = PosterBindingSource;
        }
    }
}
