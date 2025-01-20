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
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
            bloodStock();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
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

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor ob = new ViewDonor();
            ob.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
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

        private void bloodStockGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
