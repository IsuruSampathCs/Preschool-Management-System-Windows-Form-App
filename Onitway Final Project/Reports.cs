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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnvs_Click(object sender, EventArgs e)
        {
            new View_Students().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new View_Employess().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new View_Salary().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new View_Payment1().Show();
            this.Hide();
        }
    }
}
