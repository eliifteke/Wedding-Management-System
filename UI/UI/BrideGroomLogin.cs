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
    public partial class BrideGroomLogin : Form
    {
        public BrideGroomLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtbrideusername.Text;
            string password = txtbridepass.Text;


            

            if (username == "")
            {
                txtbrideusername.Text = "Please enter username";
                return;
            }

            if (password == string.Empty)
            {
                txtbridepass.Text = "Please enter password";
                return;
            }


            Bride b = new Bride();
            int result = b.Login(username, password);

            Groom g = new Groom();
            int result2 = g.Login(username, password);

            if (result == 1 || result2==1)
            {
                BrideGroomPage brideGroomPage = new BrideGroomPage();
                brideGroomPage.Show();
                this.Hide();
            }

            else
            {
                lblmesaj.Text = "Invalid username or password";
                lblmesaj.ForeColor = Color.Red;
            }


        }
    }
    }
