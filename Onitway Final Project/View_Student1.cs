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
    public partial class View_Student1 : Form
    {
        public View_Student1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EP4DAN9;Initial Catalog=OnitwayDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {
            new Admin_Reports().Show();
            this.Hide();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            DGVvs.DataSource = dtb;
        }
    }
}
