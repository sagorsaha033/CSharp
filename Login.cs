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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //TextBox placeholder text related code
        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text == "User Name")
            {
                userName.Text = "";
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "User Name";
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {
                pass.Text = "";
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Password";
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            userName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            pass.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.BackColor = Color.White;
            panel4.BackColor = Color.White;
            userName.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void continueAsAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-0FCE3NF6\SQLEXPRESS02;Initial Catalog=BBMDb;Integrated Security=True;Pooling=False");
        private void loginBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Query = "select count(*) from EmployeeTable where EmpId = '"+userName.Text+"' and EmpPass = '"+pass.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                MainFrom mf = new MainFrom();
                mf.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password!");
            }
            conn.Close();
        }

        private void userName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text))
            {
                e.Cancel = true;
                userName.Focus();
                errorProvider1.SetError(userName, "Please Enter your User Name !");
            }
            else
            {
                errorProvider1.SetError(userName, null);
            }
        }

        private void pass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(pass.Text))
            {
                e.Cancel = true;
                pass.Focus();
                errorProvider1.SetError(pass, "Please Enter your User Name !");
            }
            else
            {
                errorProvider2.SetError(pass, null);
            }
        }
    }
}
