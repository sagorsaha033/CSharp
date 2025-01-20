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
namespace BBMS
{
    public partial class Donar : Form
    {
        public Donar()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
        private void resetForm()
        {
            DNameI.Text = "";
            DAddressI.Text = "";
            DAgeI.Text = "";
            DPhoneI.Text = "";
            DGenderC.SelectedIndex = -1;
            DBloodGroupC.SelectedIndex = -1;
        }
        private void DonorSave_Click(object sender, EventArgs e)
        {
            if (DNameI.Text == "" || DAgeI.Text == "" || DPhoneI.Text == "" || DGenderC.SelectedIndex == -1 || DBloodGroupC.SelectedIndex == -1 || DAddressI.Text == "")
            {
                MessageBox.Show("Information Missing");                
            }
            else
            {
                try
                {
                    string query = "insert into DonorTbl values('" + DNameI.Text + "','" + Int16.Parse(DAgeI.Text) + "','" + DGenderC.SelectedItem.ToString() + "','" + DPhoneI.Text + "','" + DAddressI.Text + "','" + DBloodGroupC.SelectedItem.ToString() + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succussfully Donor Information Saved!");
                    conn.Close();
                    resetForm();
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ViewDonorMenu_Click(object sender, EventArgs e)
        {
            ViewDonor ob = new ViewDonor();
            ob.Show();
            this.Hide();
        }


        private void patientMenu_Click(object sender, EventArgs e)
        {
            Patient ob = new Patient();
            ob.Show();
            this.Hide();
        }

        private void viewPatientMenu_Click(object sender, EventArgs e)
        {
            ViewPatient ob = new ViewPatient();
            ob.Show();
            this.Hide();
        }

        private void bloodStockMenu_Click(object sender, EventArgs e)
        {
            BloodStock ob = new BloodStock();
            ob.Show();
            this.Hide();
        }

        private void bloodTransferMenu_Click(object sender, EventArgs e)
        {
            BloodTransfer ob = new BloodTransfer();
            ob.Show();
            this.Hide();
        }

        private void deshboardMenu_Click(object sender, EventArgs e)
        {
            DashBoard ob = new DashBoard();
            ob.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            this.Hide();
        }

        private void donateMenu_Click(object sender, EventArgs e)
        {
            Donate ob = new Donate();
            ob.Show();
            this.Hide();
        }

        private void DPhoneI_TextChanged(object sender, EventArgs e)
        {

        }

        private void donorMenu_Click(object sender, EventArgs e)
        {

        }

        private void DNameI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
