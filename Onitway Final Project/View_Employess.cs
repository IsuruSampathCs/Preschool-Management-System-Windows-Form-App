﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Onitway_Final_Project
{
    public partial class View_Employess : Form
    {
        public View_Employess()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EP4DAN9;Initial Catalog=OnitwayDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {
            new Reports().Show();
            this.Hide();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employee", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            DGVve.DataSource = dtb;
        }
    }
}
