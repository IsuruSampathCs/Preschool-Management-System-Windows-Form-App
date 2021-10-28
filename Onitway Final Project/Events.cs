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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EP4DAN9;Initial Catalog=OnitwayDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnEvSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtevid.Text))
            {
                MessageBox.Show("Event Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtstuid.Text))
            {
                MessageBox.Show("Student Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtstuname.Text))
            {
                MessageBox.Show("Student Name Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtevname.Text))
            {
                MessageBox.Show("Event Name Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtamount.Text))
            {
                MessageBox.Show("Amount Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtTotalA.Text))
            {
                MessageBox.Show("Total Amount Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("Insert Into Event values('" + txtevid.Text + "','" + txtstuid.Text + "','" + txtstuname.Text + "','" + txtevname.Text + "','" + DObP1.Value + "','" + txtamount.Text + "','" + txtTotalA.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show(this, "Data Save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEvClear_Click(object sender, EventArgs e)
        {
            txtevid.Text = "";
            txtstuid.Text = "";
            txtstuname.Text = "";
            txtevname.Text = "";
            txtamount.Text = "";
            txtTotalA.Text = "";
            txtevid.Focus();

        }

        private void btnEvCancel_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void EvSearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEvSearchBar.Text))
            {
                MessageBox.Show("Search Bar Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (btnEvIDSearch.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Event where Stud_ID = '" + txtEvSearchBar.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TableEvent.DataSource = dt;
                    con.Close();
                }
                else if (btnEvNameSearch.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Event where Student_Name LIKE '" + txtEvSearchBar.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TableEvent.DataSource = dt;
                    con.Close();
                }
                
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblEvclear_Click(object sender, EventArgs e)
        {
            txtEvSearchBar.Text = "";
        }

        private void btEvncan_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
