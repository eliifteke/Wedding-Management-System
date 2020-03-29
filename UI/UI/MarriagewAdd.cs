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
    public partial class MarriagewAdd : Form
    {
        public MarriagewAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 

            string name = txtmarriagename.Text;
            string surname = txtmarriagesurname.Text;
            string from_who = txtmarriagewho.Text;
            string weddingdate = txtmarriageweddate.Text;
            string weddingvenue = txtmarriagewvenue.Text;


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


            MarriageWitness m = new MarriageWitness();

            m.Name = name;
            m.Surname = surname;
            m.From_who = from_who;
            m.Weddingdate = weddingdate;
            m.Weddingvenue = weddingvenue;


            int result = m.AddMarriageW(m);

            if (result > 0)
            {
                label6.Text = "Marriage Witness Added";

                Adminpage adminpage = new Adminpage();
                adminpage.Show();
                this.Hide();

            }
            else
            {
                label6.Text = "Marriage Witness not Added";

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

