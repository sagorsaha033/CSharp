using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
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

        private void AdminloginBtn_Click(object sender, EventArgs e)
        {
            if(pass.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");
            }else if(pass.Text == "admin123"){
                Employee emp = new Employee();
                emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password. Contact With System Admin.");
            }
        }
        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.BackColor = Color.White;
            panel4.BackColor = Color.White;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
