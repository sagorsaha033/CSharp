using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
        private void resetForm()
        {
            PNameI.Text = "";
            PAddressI.Text = "";
            PAgeI.Text = "";
            PPhoneI.Text = "";
            PGenderC.SelectedIndex = -1;
            PBloodGroupC.SelectedIndex = -1;
        }
        private void patientSaveBtn_Click(object sender, EventArgs e)
        {
            if(PNameI.Text == "" || PAgeI.Text == "" || PPhoneI.Text == "" || PGenderC.SelectedIndex == -1 || PBloodGroupC.SelectedIndex == -1 || PAddressI.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    string query = "insert into PatientTbl values('" + PNameI.Text + "','" + PAgeI.Text + "','" + PGenderC.SelectedItem.ToString() + "','" + PPhoneI.Text + "','" + PAddressI.Text + "','" + PBloodGroupC.SelectedItem.ToString() + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succussfully Patient Information Saved!");
                    conn.Close();
                    resetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void viewPatientMenu_Click(object sender, EventArgs e)
        {
            ViewPatient vp = new ViewPatient();
            vp.Show();
            this.Hide();
        }

        private void pBloodTransfer_Click(object sender, EventArgs e)
        {
            BloodTransfer bt = new BloodTransfer();
            bt.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor ob = new ViewDonor();
            ob.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock ob = new BloodStock();
            ob.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoard ob = new DashBoard();
            ob.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donar ob = new Donar();
            ob.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Donate ob = new Donate();
            ob.Show();
            this.Close();
        }

        private void PNameI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
