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
    public partial class BloodTransfer : Form
    {
        public BloodTransfer()
        {
            InitializeComponent();
            fillPatientIb();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
        private void fillPatientIb()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select PId from PatientTbl", conn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PId", typeof(int));
            dt.Load(sdr);
            patientIdCB.ValueMember = "PId";
            patientIdCB.DataSource = dt;
            conn.Close();
        }
        private void getPatientData()
        {
            conn.Open();
            string Query = "select * from PatientTbl where PId = " + patientIdCB.SelectedValue.ToString()+ "";
            SqlCommand cmd = new SqlCommand(Query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatientName.Text = dr["PName"].ToString();
                PBGroup.Text = dr["PBGroup"].ToString();
            }
            conn.Close();
        }

        //Cheacking is the any particular blood is abailable or not
        int stock=0;
        private void getBloodStock(string bloodGroup)
        {
            conn.Open();
            string Query = "select * from BloodStockTable where BloodGroup = '" + bloodGroup + "';";
            SqlCommand cmd = new SqlCommand(Query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BloodStock"].ToString());
            }
            conn.Close();
        }
        private void patientIdCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getPatientData();
            getBloodStock(PBGroup.Text);
            if (stock > 0)
            {
                bloodTransferBtn.Visible = true;
                isAbailable.Text = "Abailable Stock";
                isAbailable.Visible = true;
            }
            else
            {
                isAbailable.Text = "Stock Not Abailable";
                isAbailable.Visible=true;
                bloodTransferBtn.Visible = true;
            }
        }

        private void btPatient_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Hide();
        }
        private void resetForm()
        {
            PatientName.Text = "";
            PBGroup.Text = "";
            isAbailable.Visible = false;
            bloodTransferBtn.Visible=false;
        }
        private void bloodTransferBtn_Click(object sender, EventArgs e)
        {
            if (PatientName.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    string query = "insert into TransferTbl values('" + PatientName.Text + "','" + PBGroup.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succussfully Transfer");
                    conn.Close();
                    getBloodStock(PBGroup.Text);
                    updateStock(PBGroup.Text);
                    resetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void updateStock(string bloodGroup)
        {
            try
            {
                int newStock = stock - 1;
                string query = "update BloodStockTable set BloodStock = " + newStock+ " where BloodGroup = '" + bloodGroup + "'; ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient ob = new ViewPatient();
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

        private void patientIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
