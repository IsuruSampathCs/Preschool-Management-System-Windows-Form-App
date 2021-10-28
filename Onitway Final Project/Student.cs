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
using System.IO;


namespace Onitway_Final_Project
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EP4DAN9;Initial Catalog=OnitwayDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        string imgLocation = "";

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void BTn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog()==DialogResult.OK)
            {
              
                
                    imgLocation = dialog.FileName.ToString();
                    picbox1.ImageLocation = imgLocation;
                
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStuID.Text))
            {
                MessageBox.Show("Student Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtFullname.Text))
            {
                MessageBox.Show("Student Name Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Age Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtNationality.Text))
            {
                MessageBox.Show("Nationality Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtReligion.Text))
            {
                MessageBox.Show("Religion Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtBloodGroup.Text))
            {
                MessageBox.Show("Blood Group Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtGender.Text))
            {
                MessageBox.Show("Gender Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtAssignClass.Text))
            {
                MessageBox.Show("Assign Class Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtAdmissionFee.Text))
            {
                MessageBox.Show("Admission Fees Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                con.Open();
                string sqlQuery = "Insert into Student(Student_ID,Full_Name,DOB,Age,Profile_Picture,Nationality,Religion,Blood_Group,Gender,Address,Alergies_OR_Medical_Conditions,Any_Long_Term_Medication,Assign_Class,Admission_Fees)Values('"+txtStuID.Text+"','"+txtFullname.Text+"','"+DObP1.Value+"','"+txtAge.Text+"',@images,'"+txtNationality.Text+"','"+txtReligion.Text+"','"+txtBloodGroup.Text+"','"+txtGender.Text+"','"+txtAddress.Text+"','"+txtAlergies.Text+"','"+txtAnyLongTermMedication.Text+"','"+txtAssignClass.Text+"','"+txtAdmissionFee.Text+"')";
                cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(n.ToString() + "Data Saved Successfully......");
                txtStuID.Text = "";
                txtFullname.Text = "";
                txtAge.Text = "";
                txtNationality.Text = "";
                txtReligion.Text = "";
                txtBloodGroup.Text = "";
                txtGender.Text = "";
                txtAddress.Text = "";
                txtAlergies.Text = "";
                txtAnyLongTermMedication.Text = "";
                txtAssignClass.Text = "";
                txtAdmissionFee.Text = "";
                picbox1.Image = null;
                txtStuID.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStuID.Text = "";
            txtFullname.Text = "";
            txtAge.Text = "";
            txtNationality.Text = "";
            txtReligion.Text = "";
            txtBloodGroup.Text = "";
            txtGender.Text = "";
            txtAddress.Text = "";
            txtAlergies.Text = "";
            txtAnyLongTermMedication.Text = "";
            txtAssignClass.Text = "";
            txtAdmissionFee.Text = "";
            picbox1.Image = null;
            txtStuID.Focus();
        }

        private void btncan_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Student Id Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txtfn.Text))
            {
                MessageBox.Show("Student Name Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_Age.Text))
            {
                MessageBox.Show("Age Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_Add.Text))
            {
                MessageBox.Show("Address Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(txt_ASIGN.Text))
            {
                MessageBox.Show("Assign Class Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("Update Student set Full_Name='" + txtfn.Text + "',DOB='" + dobpic2.Value + "',Age='" + txt_Age.Text + "',Nationality='" + txt_Nationality.Text + "',Religion='" + txt_region.Text + "',Blood_Group='" + txtBG.Text + "',Gender='" + txtGen.Text + "',Address='" + txt_Add.Text + "',Alergies_OR_Medical_Conditions='" + txt_AOMC.Text + "',Any_Long_Term_Medication='" + txt_ALTM.Text + "',Assign_Class='" + txt_ASIGN.Text + "',Admission_Fees='" + txt_ADDMI.Text + "' WHERE Student_ID ='" + txtid.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if(i == 1)
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
            catch(SqlException)
            {
                MessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cle_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtfn.Text = "";
            txt_Age.Text = "";
            txt_Nationality.Text = "";
            txt_region.Text = "";
            txtBG.Text = "";
            txtGen.Text = "";
            txt_Add.Text = "";
            txt_AOMC.Text = "";
            txt_ALTM.Text = "";
            txt_ASIGN.Text = "";
            txt_ADDMI.Text = "";
            txtid.Focus();
        }

        private void txt_cancel_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchBar.Text))
            {
                MessageBox.Show("Search Bar Cannot Be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try 
            {
                if(btnIDSearch.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Student where Student_ID = '" + txtSearchBar.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TableStudent.DataSource = dt;
                    con.Close();
                }
                else if (btnNameSearch.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Student where Full_Name LIKE '" + txtSearchBar.Text + "%'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    TableStudent.DataSource = dt;
                    con.Close();
                }
                
            }
            catch(SqlException)
            {
                MessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show(this, "Please Check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "";
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
