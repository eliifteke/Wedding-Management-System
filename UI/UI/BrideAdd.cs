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
    public partial class BrideAdd : Form
    {
        public BrideAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtbridename.Text;
                string surname = txtbridesurname.Text;
                string phonenumber = txtbrideprohne.Text;
                string email = txtbrideemail.Text;
                string username = txtbrideusernae.Text;
                string password = txtbridepasswo.Text;
                string weddingdate = txtbrideweddingdate.Text;
                string weddingvenue = txtbridevenue.Text;
                string groomname = txtbridesgroom.Text;

                if (name == string.Empty)
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
                if (weddingdate == string.Empty)
                {
                    MessageBox.Show("Please enter wedding date");
                    return;
                }
                if (weddingvenue == string.Empty)
                {
                    MessageBox.Show("Please enter wedding venue");
                    return;
                }
                if (groomname == string.Empty)
                {
                    MessageBox.Show("Please enter groom name");
                    return;
                }

                Bride b = new Bride();

                b.Name = name;
                b.Surname = surname;
                b.Phonenumber = phonenumber;
                b.Email = email;
                b.Username = username;
                b.Password = password;
                b.Weddingdate = weddingdate;
                b.Weddingvenue = weddingvenue;
                b.Groomname = groomname;

                int result = b.AddBride(b);

                if (result > 0)
                {
                    label10.Text = "Bride Added";

                    Adminpage adminpage = new Adminpage();
                    adminpage.Show();
                    this.Hide();

                }
                else
                {
                    label10.Text = "Bride not Added";

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtbridesgroom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbridevenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbrideweddingdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbridepasswo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbrideusernae_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbrideemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbrideprohne_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbridesurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbridename_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

