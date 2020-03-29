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
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = adminnm.Text;
                string surname = adminsrname.Text;
                string phonenumber = adminpnum.Text;
                string email = adminmail.Text;
                string username = adminuser.Text;
                string password = adminpass.Text;

                if (name==string.Empty)
                {
                    MessageBox.Show("Please enter name");
                    return;
                }
                if (surname == string.Empty)
                {
                    MessageBox.Show("Please enter surname");
                    return;
                }
                if (phonenumber == string.Empty)
                {
                    MessageBox.Show("Please enter phone number");
                    return;
                }
                if (email == string.Empty)
                {
                    MessageBox.Show("Please enter email");
                    return;
                }
                if (username == string.Empty)
                {
                    MessageBox.Show("Please enter username");
                    return;
                }
                if (password == string.Empty)
                {
                    MessageBox.Show("Please enter password");
                    return;
                }

                Admin a = new Admin();

                a.Name = name;
                a.Surname = surname;
                a.Phonenumber = phonenumber;
                a.Email = email;
                a.Username = username;
                a.Password = password;

               int result= a.AddAdmin(a);

                if (result>0)
                {
                    lblmes.Text = "Admin Added";

                    Adminpage adminpage = new Adminpage();
                    adminpage.Show();
                    this.Hide();

                }
                else
                {
                    lblmes.Text = "Admin not Added";

                    Adminpage adminpage = new Adminpage();
                    adminpage.Show();
                    this.Hide();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
