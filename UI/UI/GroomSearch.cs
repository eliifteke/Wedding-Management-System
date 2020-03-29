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
    public partial class GroomSearch : Form
    {
        public GroomSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "select * from groom WHERE groomID = groomID ";
                if (textBox1.Text.Length > 0)
                {
                    query += " AND name LIKE '%" + textBox1.Text + "%'";
                }

                if (textBox2.Text.Length > 0)
                {
                    query += " AND surname LIKE '%" + textBox2.Text + "%'";
                }

                //if (text == "")
                //    return;

                Groom g = new Groom();
                dgvgroomsearch.DataSource = g.SearchGroom(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text.Trim();
                if (text == "")
                {
                    dgvgroomsearch.DataSource = null;
                    return;
                }
                Groom g = new Groom();
                dgvgroomsearch.DataSource = g.SearchGroomByName(text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
