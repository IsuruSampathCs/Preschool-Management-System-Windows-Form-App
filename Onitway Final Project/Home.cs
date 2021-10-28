using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onitway_Final_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new Adminlogin().Show();
            this.Hide();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void lblStudent_Click(object sender, EventArgs e)
        {
            new Student().Show();
            this.Hide();
        }

        private void lblEmployees_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void lblSalary_Click(object sender, EventArgs e)
        {
            new Salary().Show();
            this.Hide();
        }

        private void lblPayments_Click(object sender, EventArgs e)
        {
            new Payments().Show();
            this.Hide();
        }

        private void lblEvents_Click(object sender, EventArgs e)
        {
            new Events().Show();
            this.Hide();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            new Reports().Show();
            this.Hide();
        }

        private void lblBackupData_Click(object sender, EventArgs e)
        {
            
        }
    }
}
