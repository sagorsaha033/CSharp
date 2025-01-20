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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            getDonor();
            getTransfer();
            getUser();
            getTotalStock();
            bloodGroupIni();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
        private void getDonor()
        {
            donorL.Text = getData("Select count(*) from DonorTbl");
        }
        private void getTransfer()
        {
            transferL.Text = getData("Select count(*) from TransferTbl");
        }

        private void getUser()
        {
            userL.Text = getData("Select count(*) from EmployeeTable");
        }
        private void getTotalStock()
        {
            totalStock.Text = getData("Select Sum(BloodStock) from BloodStockTable");
        }
        private string getData(string Query)
        {
            string data;
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data = dt.Rows[0][0].ToString();
            conn.Close();
            return data;
        }
        
        private int singleBloodGroupData(string Query)
        {
            string data;
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            data = dt.Rows[0][0].ToString();
            conn.Close();
            return Convert.ToInt32(data);
        }
        int apBlood = 0;
        int anBlood = 0;
        int abpBlood = 0;
        int abnBlood = 0;
        int bpBlood = 0;
        int bnBlood = 0;
        int opBlood = 0;
        int onBlood = 0;
        int totalBlood = 0;
        private void bloodGroupIni()
        {
            apBlood = singleBloodGroupData("Select BloodStock from BloodStockTable where BloodGroup='" + "A+" + "' ");
            anBlood = singleBloodGroupData("Select BloodStock from BloodStockTable where BloodGroup='" + "A-" + "' ");
            abpBlood = singleBloodGroupData("Select BloodStock from BloodStockTable where BloodGroup='" + "AB+" + "' ");
            abnBlood = singleBloodGroupData("Select BloodStock from BloodStockTable where BloodGroup='" + "AB-" + "' ");
            bpBlood = singleBloodGroupData("Select BloodStock from BloodStockTable where BloodGroup='" + "B+" + "' ");
            bnBlood = singleBloodGroupData("Select BloodStock from BloodStockTable where BloodGroup='" + "B-" + "' ");
            opBlood = singleBloodGroupData("Select BloodStock from BloodStockTable where BloodGroup='" + "O+" + "' ");
            onBlood = singleBloodGroupData("Select BloodStock from BloodStockTable where BloodGroup='" + "O-" + "' ");
            totalBlood = singleBloodGroupData("Select Sum(BloodStock) from BloodStockTable");

            apProgressBar.Value = Convert.ToInt32(Convert.ToDouble(apBlood / (double)totalBlood) * 100);
            ap.Text = apBlood.ToString();

            anProgressBar.Value = Convert.ToInt32(Convert.ToDouble(anBlood / (double)totalBlood) * 100);
            an.Text = anBlood.ToString();

            bpProgressBar.Value = Convert.ToInt32(Convert.ToDouble(bpBlood / (double)totalBlood) * 100);
            bp.Text = bpBlood.ToString();

            bnProgressBar.Value = Convert.ToInt32(Convert.ToDouble(bnBlood / (double)totalBlood) * 100);
            bn.Text = bnBlood.ToString();

            abpProgressBar.Value = Convert.ToInt32(Convert.ToDouble(abpBlood / (double)totalBlood) * 100);
            abp.Text = abpBlood.ToString();

            abnProgressBar.Value = Convert.ToInt32(Convert.ToDouble(abnBlood / (double)totalBlood) * 100);
            abn.Text = abnBlood.ToString();

            opProgressBar.Value = Convert.ToInt32(Convert.ToDouble(opBlood / (double)totalBlood) * 100);
            op.Text = opBlood.ToString();

            onProgressBar.Value = Convert.ToInt32(Convert.ToDouble(onBlood / (double)totalBlood) * 100);
            on.Text = onBlood.ToString();


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

        private void label13_Click(object sender, EventArgs e)
        {
            Donate ob = new Donate();
            ob.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient ob = new Patient();
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void donorL_Click(object sender, EventArgs e)
        {

        }
    }
}
