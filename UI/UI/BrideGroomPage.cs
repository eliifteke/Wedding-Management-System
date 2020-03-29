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
    public partial class BrideGroomPage : Form
    {
        public BrideGroomPage()
        {
            InitializeComponent();
        }

        //public void BindGridView()
        //{
        //    try
        //    {
        //        Bride b = new Bride();
        //        dgvbridepage.DataSource = b.ListBride();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        private void DgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvbridepage.SelectedRows.Count > 0)
            //{
            //    int id = int.Parse(dgvbridepage.SelectedRows[0].Cells[0].Value.ToString());
            //    BrideUpdate se = new BrideUpdate();
            //    se.ShowDialog();
            //}
        }


        private void BrideGroomPage_Load(object sender, EventArgs e)
        {

            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
