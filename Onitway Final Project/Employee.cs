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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EP4DAN9;Initial Catalog=OnitwayDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        private void label1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btncom_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmpId.Text))
            {
                MessageBox.Show("Employee Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtDes.Text))
            {
                MessageBox.Show("Designation Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtEfullname.Text))
            {
                MessageBox.Show("Employee Name Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Age Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtGender.Text))
            {
                MessageBox.Show("Gender Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtEduQual.Text))
            {
                MessageBox.Show("Education Qualifications Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtProQual.Text))
            {
                MessageBox.Show("Professional Qualification Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtWorkExp.Text))
            {
                MessageBox.Show("Work Experience Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtNIC.Text))
            {
                MessageBox.Show("NIC Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtPhoneNo.Text))
            {
                MessageBox.Show("Phone Number Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try 
            {
                con.Open();
                string sqlQuery = "Insert into Employee(Employee_ID,Full_Name,DOB,Age,Gender,Address,Designation,Education_Qualifications,Professional_Qualifications,Work_Experience,Email,NIC,Mobile)Values('" + txtEmpId.Text + "','" + txtEfullname.Text + "','" + dateTimePicker1.Value + "','" + txtAge.Text + "','" + txtGender.Text + "','" + txtAddress.Text + "','" + txtDes.Text + "','" + txtEduQual.Text + "','" + txtProQual.Text + "','" + txtWorkExp.Text + "','" + txtEmail.Text + "','" + txtNIC.Text + "','" + txtPhoneNo.Text + "')";
                cmd = new SqlCommand(sqlQuery, con);
                int n = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(n.ToString() + "Data Saved Successfully......");
                txtEmpId.Text = "";
                txtEfullname.Text = "";
                txtAge.Text = "";
                txtGender.Text = "";
                txtDes.Text = "";
                txtEduQual.Text = "";
                txtProQual.Text = "";
                txtWorkExp.Text = "";
                txtEmail.Text = "";
                txtNIC.Text = "";
                txtPhoneNo.Text = "";
                txtAddress.Text = "";
                txtEmpId.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btncle_Click(object sender, EventArgs e)
        {
            txtEmpId.Text = "";
            txtEfullname.Text = "";
            txtAge.Text = "";
            txtGender.Text = "";
            txtDes.Text = "";
            txtEduQual.Text = "";
            txtProQual.Text = "";
            txtWorkExp.Text = "";
            txtEmail.Text = "";
            txtNIC.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            txtEmpId.Focus();
        }

        private void btncan_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btn_Con_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Employee ID Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_des.Text))
            {
                MessageBox.Show("Employee Designation Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_fn.Text))
            {
                MessageBox.Show("Employee Name Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_age.Text))
            {
                MessageBox.Show("Age Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_add.Text))
            {
                MessageBox.Show("Address Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_EQ.Text))
            {
                MessageBox.Show("Education Qualification Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_PQ.Text))
            {
                MessageBox.Show("Professionl Qualifications Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_WE.Text))
            {
                MessageBox.Show("Work Experience Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Email Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_Mob.Text))
            {
                MessageBox.Show("Mobile Number Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("Update Employee set Full_Name='" + txt_fn.Text + "',DOB='" + dob_2.Value + "',Age='" + txt_age.Text + "',Gender='" + txt_gen.Text + "',Address='" + txt_add.Text + "',Designation='" + txt_des.Text + "',Education_Qualifications='" + txt_EQ.Text + "',Professional_Qualifications='" + txt_PQ.Text + "',Work_Experience='" + txt_WE.Text + "',Email='" + txt_Email.Text + "',NIC='" + txt_Nic.Text + "',Mobile='" + txt_Mob.Text + "' WHERE Employee_ID ='" + txt_id.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_cle_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_fn.Text = "";
            txt_age.Text = "";
            txt_gen.Text = "";
            txt_add.Text = "";
            txt_des.Text = "";
            txt_EQ.Text = "";
            txt_PQ.Text = "";
            txt_WE.Text = "";
            txt_Email.Text = "";
            txt_Nic.Text = "";
            txt_Mob.Text = "";
            txt_id.Focus();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void SearchBtnE_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtESearchBar.Text))
            {
                MessageBox.Show("Search Bar Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (btnEIDSearch.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Employee where Employee_ID = '" + txtESearchBar.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    EmpTable.DataSource = dt;
                    con.Close();
                }
                else if (btnENameSearch.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Employee where Full_Name LIKE '" + txtESearchBar.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    EmpTable.DataSource = dt;
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

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txtESearchBar.Text = "";

        }

        private void btnc_Can_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
