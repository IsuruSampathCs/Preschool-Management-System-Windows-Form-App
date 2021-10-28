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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EP4DAN9;Initial Catalog=OnitwayDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        int n1, n2, n3, n4, ans;

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void SalSearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSalSearchBar.Text))
            {
                MessageBox.Show("Search Bar Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (btnSIDSearch.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Salary where Emp_ID = '" + txtSalSearchBar.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TableSal.DataSource = dt;
                    con.Close();
                }
                else if (btnSNameSearch.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Salary where Employee_Name LIKE '" + txtSalSearchBar.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TableSal.DataSource = dt;
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

        private void btnScan_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnSClear_Click(object sender, EventArgs e)
        {
            txt_salid.Text = "";
            txt_empid.Text = "";
            txt_empname.Text = "";
            txt_bs.Text = "";
            txt_Adv.Text = "";
            txt_allow.Text = "";
            txt_attAll.Text = "";
            txt_ns.Text = "";
            txt_salid.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_salid.Text))
            {
                MessageBox.Show("Salary Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_empid.Text))
            {
                MessageBox.Show("Employee Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_empname.Text))
            {
                MessageBox.Show("Employee Name Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_bs.Text))
            {
                MessageBox.Show("Basic Salary Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_ns.Text))
            {
                MessageBox.Show("Net Salary Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("Insert Into Salary values('"+txt_salid.Text+"','"+txt_empid.Text+"','"+txt_empname.Text+"','"+txt_bs.Text+"','"+txt_Adv.Text+"','"+txt_allow.Text+"','"+txt_attAll.Text+"','"+txt_ns.Text+"')",con);
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

        private void label9_Click(object sender, EventArgs e)
        {
            txtSalSearchBar.Text = "";
        }

        private void btnSCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(txt_bs.Text);
                n2 = Convert.ToInt32(txt_Adv.Text);
                n3 = Convert.ToInt32(txt_allow.Text);
                n4 = Convert.ToInt32(txt_attAll.Text);
                ans = n1 + n2 + n3 + n4;
                txt_ns.Text = ans.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
