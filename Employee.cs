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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            populate();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
        private void populate()
        {
            conn.Open();
            string query = "select * from EmployeeTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            viewEmpGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void empSaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpName.Text == "" || empPass.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    string query = "insert into EmployeeTable values('" + EmpName.Text + "','" + empPass.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succussfully Employee Information Saved!");
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
        private void resetForm()
        {
            EmpName.Text = "";
            empPass.Text = "";
        }
        int key = 0;
        private void viewEmpGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpName.Text = viewEmpGV.SelectedRows[0].Cells[1].Value.ToString();
            empPass.Text = viewEmpGV.SelectedRows[0].Cells[2].Value.ToString();
            if (EmpName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(viewEmpGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void empDeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Employee To Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from EmployeeTable where EmpNum=" + key + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succussfully Employee Deleted!");
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

        private void empEditBtn_Click(object sender, EventArgs e)
        {
            if (EmpName.Text == "")
            {
                MessageBox.Show("Select A Patient To Edit");
            }
            else
            {
                try
                {
                    string query = "update EmployeeTable set EmpId = '" + EmpName.Text + "', EmpPass = '" + empPass.Text + "' ";
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

        private void label2_Click(object sender, EventArgs e)
        {
            MainFrom ob = new MainFrom();
            ob.Show();
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
