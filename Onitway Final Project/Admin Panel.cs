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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new User_Registration().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new View_Payments().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Admin_Reports().Show();
            this.Hide();
        }
    }
}
