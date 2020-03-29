using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class AdminLoginpage : Form
    {
        public AdminLoginpage()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (username=="")
            {
                txtusername.Text = "Please enter username";
                return;
            }

            if (password==string.Empty)
            {
                txtpassword.Text = "Please enter password";
                return;
            }


            Admin a = new Admin();
            int result = a.Login(username, password);

            if (result==1)
            {
                Adminpage adminpage = new Adminpage();
                adminpage.Show();
                this.Hide();
            }

            else
            {
                lblmessage.Text = "Invalid username or password";
                lblmessage.ForeColor = Color.Red;
            }


        }
    }
}
