using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Course_OOP
{
    public partial class AcceptOrderForm : Form
    {
        public AcceptOrderForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
