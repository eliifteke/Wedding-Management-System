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
    public partial class GroomAdd : Form
    {
        public GroomAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtgroomname.Text;
                string surname = txtgroomsurname.Text;
                string phonenumber = txtgroomphone.Text;
                string email = txtgroomemail.Text;
                string username = txtgroomusername.Text;
                string password = txtgroomasswo.Text;
                string weddingdate = txtgroomdate.Text;
                string weddingvenue = txtgroomvenue.Text;
                string bridename = txtgroomsbride.Text;

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
                if (bridename == string.Empty)
                {
                    MessageBox.Show("Please enter groom name");
                    return;
                }

               
                Groom g = new Groom();
                

                g.Name = name;
                g.Surname = surname;
                g.Phonenumber = phonenumber;
                g.Email = email;
                g.Username = username;
                g.Password = password;
                g.Weddingdate = weddingdate;
                g.Weddingvenue = weddingvenue;
                g.Bridename = bridename;

                int result = g.AddGroom(g);

                if (result > 0)
                {
                    label10.Text = "Groom Added";

                    Adminpage adminpage = new Adminpage();
                    adminpage.Show();
                    this.Hide();

                }
                else
                {
                    label10.Text = "Groom not Added";

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

