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
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
            populate();
            bloodStock();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
        //updataing database data in UI
        private void populate()
        {
            conn.Open();
            string query = "select * from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            viewDonorGDV.DataSource = ds.Tables[0];
            conn.Close();
        }
        //Updating database data in UI
        private void bloodStock()
        {
            conn.Open();
            string query = "select * from BloodStockTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            bloodStockGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        int oldStock;
        private void getBloodStock(string bloodGroup)
        {
            conn.Open();
            string Query = "select * from BloodStockTable where BloodGroup = '" + bloodGroup + "';";
            SqlCommand cmd = new SqlCommand(Query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                oldStock =Convert.ToInt32(dr["BloodStock"].ToString());
            }
            conn.Close();
        }
        private void viewDonorGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameI.Text = viewDonorGDV.SelectedRows[0].Cells[1].Value.ToString();
            bloodGroup.Text= viewDonorGDV.SelectedRows[0].Cells[6].Value.ToString();
            3222222222
            getBloodStock(bloodGroup.Text);
        }
        private void resetForm()
        {
            DNameI.Text = "";
            bloodGroup.Text= "";
        }
        private void donateBlood_Click(object sender, EventArgs e)
        {
            if(DNameI.Text == "")
            {
                MessageBox.Show("Select A Donor");
            }
            else
            {
                try
                {
                    int stoct = oldStock+1;
                    string query = "update BloodStockTable set BloodStock = " + stoct + " where BloodGroup = '"+ bloodGroup.Text +"'; ";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Succussfull!");
                    conn.Close();
                    resetForm();
                    bloodStock();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donar ob = new Donar();
            ob.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient ob = new ViewPatient();
            ob.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock ob = new BloodStock();
            ob.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer ob = new BloodTransfer();
            ob.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoard ob = new DashBoard();
            ob.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            this.Close();
        }

        private void DNameI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
