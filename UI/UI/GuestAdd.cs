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
    public partial class GuestAdd : Form
    {
        public GuestAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtguestname.Text;
                string surname = txtguestsurnm.Text;
                string whosewedding = txtwhosewed.Text;
                string weddingdate = txtguestdate.Text;
                string weddingvenue = txtguestvene.Text;
               

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
                if (whosewedding == string.Empty)
                {
                    MessageBox.Show("Please enter wedding of who");
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


                Guests g = new Guests();

                g.Name = name;
                g.Surname = surname;
                g.Whosewedding = whosewedding;
                g.Weddingdate = weddingdate;
                g.Weddingvenue = weddingvenue;


                int result = g.AddGuest(g);

                if (result > 0)
                {
                    label11.Text = "Guest Added";

                    Adminpage adminpage = new Adminpage();
                    adminpage.Show();
                    this.Hide();

                }
                else
                {
                    label11.Text = "Guest not Added";

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

