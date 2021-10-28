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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EP4DAN9;Initial Catalog=OnitwayDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        private void label9_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPayID.Text))
            {
                MessageBox.Show("Payment Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtPStuName.Text))
            {
                MessageBox.Show("Student Name Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtPaytype.Text))
            {
                MessageBox.Show("Payment Type Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Amount Value  Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtMonth.Text))
            {
                MessageBox.Show("Month Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtPhoneNo.Text))
            {
                MessageBox.Show("Phone Number Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("Insert Into Payments values('" + txtPayID.Text + "','" + txtPStuName.Text + "','" + txtPaytype.Text + "','" + txtAmount.Text + "','" + txtMonth.Text + "','" + txtPhoneNo.Text + "')", con);
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

        private void btnPayClear_Click(object sender, EventArgs e)
        {
            txtPayID.Text = "";
            txtPStuName.Text = "";
            txtPaytype.Text = "";
            txtAmount.Text = "";
            txtMonth.Text = "";
            txtPhoneNo.Text = "";
            txtPayID.Focus();
        }

        private void btnPayCancel_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
