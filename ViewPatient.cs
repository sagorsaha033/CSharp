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
    public partial class ViewPatient : Form
    {
        public ViewPatient()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
        private void populate()
        {
            conn.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            viewPatientGDV.DataSource = ds.Tables[0];
            conn.Close();
        }
        int key = 0;
        private void viewPatientGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PIdI.Text = viewPatientGDV.SelectedRows[0].Cells[1].Value.ToString();
            PAgeI.Text = viewPatientGDV.SelectedRows[0].Cells[2].Value.ToString();
            PGenderC.SelectedItem = viewPatientGDV.SelectedRows[0].Cells[3].Value.ToString();
            PPhoneI.Text = viewPatientGDV.SelectedRows[0].Cells[4].Value.ToString();
            PAddressI.Text = viewPatientGDV.SelectedRows[0].Cells[5].Value.ToString();
            PBGroupC.SelectedItem = viewPatientGDV.SelectedRows[0].Cells[6].Value.ToString();
            if(PIdI.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(viewPatientGDV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void resetForm()
        {
            PIdI.Text = "";
            PAddressI.Text = "";
            PAgeI.Text = "";
            PPhoneI.Text = "";
            PGenderC.SelectedIndex = -1;
            PBGroupC.SelectedIndex = -1;
            key = 0;
        }
        private void deletePatient_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Select The Patient To Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTbl where PId="+key+"";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succussfully Patient Deleted!");
                    conn.Close();
                    resetForm();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void patientMenu_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void editPatientList_Click(object sender, EventArgs e)
        {
            if (PIdI.Text == "" || PAgeI.Text == "" || PPhoneI.Text == "" || PGenderC.SelectedIndex == -1 || PBGroupC.SelectedIndex == -1 || PAddressI.Text == "")
            {
                MessageBox.Show("Select A Patient To Edit");
            }
            else
            {
                try
                {
                    string query = "update PatientTbl set PName = '"+PIdI.Text+ "', PAge = '" + PAgeI.Text + "', PGender = '" + PGenderC.SelectedItem.ToString() + "', PPhone = '" + PPhoneI.Text + "', PAddress= '" + PAddressI.Text + "', PBGroup = '" + PBGroupC.SelectedItem.ToString() + "'  where PId=" + key + ";";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succussfully Patient Deleted!");
                    conn.Close();
                    resetForm();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void searchPatientBtn_Click(object sender, EventArgs e)
        {
            if(PIdI.Text == "")
            {
                MessageBox.Show("Enter Patient Id");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PatientTbl WHERE PId=@PId", conn);
                cmd.Parameters.AddWithValue("@PId", int.Parse(PIdI.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                viewPatientGDV.DataSource = dt;
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donar ob = new Donar();
            ob.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor ob = new ViewDonor();
            ob.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Donate ob = new Donate();
            ob.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock ob = new BloodStock();
            ob.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer ob = new BloodTransfer();
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
    }
}
