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
    public partial class Admin_Reports : Form
    {
        public Admin_Reports()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new Admin_Panel().Show();
            this.Hide();
        }

        private void btnvs_Click(object sender, EventArgs e)
        {
            new View_Student1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new View_Employee1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new View_Salary1().Show();
            this.Hide();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            new View_User().Show();
            this.Hide();
        }
    }
}
