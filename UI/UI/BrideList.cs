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
    public partial class BrideList : Form
    {
        private Dictionary<string, string> dictionaryBrideData = new Dictionary<string, string>();
        public BrideList()
        {
            InitializeComponent();
            
        }


        public void BindGridView()
        {
            try
            {
                Bride b = new Bride();
                dgvBridelist.DataSource = b.ListBride();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bride b = new Bride();
                b.DeleteBride(int.Parse(dgvBridelist.SelectedRows[0].Cells["brideID"].Value.ToString()));
                updateGridView();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        private void BrideList_Load(object sender, EventArgs e)
        {
            try
            {
                Bride b = new Bride();
                dgvBridelist.DataSource = b.ListBride();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void updateGridView()
        {
            //dgvBridelist.AutoGenerateColumns = false;
            Bride b = new Bride();
            dgvBridelist.DataSource = b.ListBride();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvBridelist.SelectedRows.Count>0)
            {
                dictionaryBrideData.Add("name",dgvBridelist.SelectedRows[0].Cells["name"].Value.ToString());
                dictionaryBrideData.Add("brideID", dgvBridelist.SelectedRows[0].Cells["brideID"].Value.ToString());
                dictionaryBrideData.Add("surname", dgvBridelist.SelectedRows[0].Cells["surname"].Value.ToString());
                dictionaryBrideData.Add("phonenumber", dgvBridelist.SelectedRows[0].Cells["phonenumber"].Value.ToString());
                dictionaryBrideData.Add("email", dgvBridelist.SelectedRows[0].Cells["email"].Value.ToString());
                dictionaryBrideData.Add("username", dgvBridelist.SelectedRows[0].Cells["username"].Value.ToString());
                dictionaryBrideData.Add("password", dgvBridelist.SelectedRows[0].Cells["password"].Value.ToString());
                dictionaryBrideData.Add("weddingdate", dgvBridelist.SelectedRows[0].Cells["weddingdate"].Value.ToString());
                dictionaryBrideData.Add("weddingvenue", dgvBridelist.SelectedRows[0].Cells["weddingvenue"].Value.ToString());
                dictionaryBrideData.Add("groomsname", dgvBridelist.SelectedRows[0].Cells["groomsname"].Value.ToString());

                BrideUpdate ba = new BrideUpdate(dictionaryBrideData,this);
                ba.ShowDialog();
            }
            else
            {
                MessageBox.Show("Olm bi şeyler gir");
            }
        }

       
    }
}
