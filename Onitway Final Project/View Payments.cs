using System;
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
    public partial class View_Payments : Form
    {
        public View_Payments()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EP4DAN9;Initial Catalog=OnitwayDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        private void label9_Click(object sender, EventArgs e)
        {
            new Admin_Panel().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Payments", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            dataGridView1.DataSource = dtb;
        }
    }
}
