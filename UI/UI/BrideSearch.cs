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
    public partial class BrideSearch : Form
    {
        public BrideSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string query = "select * from bride WHERE brideID = brideID ";
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

                Bride b = new Bride();
                dgvbridesearch.DataSource = b.SearchBride(query);

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
                    dgvbridesearch.DataSource = null;
                    return;
                }
                Bride b = new Bride();
                dgvbridesearch.DataSource = b.SearchBrideByName(text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
    }

