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
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrideList brideList = new BrideList();
            brideList.Show();
        }

        private void brideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       



        //Adminleri listeliyor
        private void listToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                Admin a = new Admin();
                dgvAdmin.Visible = true;
                dgvAdmin.DataSource = a.ListAdmin();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AdminAdd adminAdd = new AdminAdd();
            adminAdd.Show();
            this.Hide();

            
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrideAdd brideAdd = new BrideAdd();
            brideAdd.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BrideUpdate brideUpdate = new BrideUpdate();
            //brideUpdate.Show();

        }

        
        private void Adminpage_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroomAdd groomAdd = new GroomAdd();
            groomAdd.Show();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroomList groomList = new GroomList();
            groomList.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MarriagewAdd mw = new MarriagewAdd();
            mw.Show();
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MarriagewList ml = new MarriagewList();
            ml.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrideSearch bs = new BrideSearch();
            bs.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroomSearch gs = new GroomSearch();
            gs.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GuestAdd ga = new GuestAdd();
            ga.Show();
        }

        private void listToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GuestList gl = new GuestList();
            gl.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
