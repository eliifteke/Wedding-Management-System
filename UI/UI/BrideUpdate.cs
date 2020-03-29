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
    public partial class BrideUpdate : Form
    {
        private Dictionary<string, string> dictionaryBrideData;
        BrideList home = null;
        public BrideUpdate(Dictionary<string, string> dictionary, BrideList home = null)
        {
            InitializeComponent();
            this.dictionaryBrideData = dictionary;
            this.home = home;
        }

        public Dictionary<string, string> DictionaryBrideData { get => dictionaryBrideData; set => dictionaryBrideData = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            Bride b = new Bride(int.Parse(dictionaryBrideData["brideID"]),txtbridesgroom.Text, txtbrideweddingdate.Text, txtbridevenue.Text,
                txtbridename.Text, txtbridesurname.Text, txtbrideprohne.Text, txtbrideemail.Text, txtbrideusernae.Text, txtbridepasswo.Text);

            b.UpdateBride(b);
            home.updateGridView();
            this.Close();
        }

        private void BrideUpdate_Load(object sender, EventArgs e)
        {
            txtbridename.Text = dictionaryBrideData["name"];
            txtbridesurname.Text = dictionaryBrideData["surname"];
            txtbrideprohne.Text = dictionaryBrideData["phonenumber"];
            txtbrideemail.Text = dictionaryBrideData["email"];
            txtbrideusernae.Text = dictionaryBrideData["username"];
            txtbridepasswo.Text = dictionaryBrideData["password"];
            txtbrideweddingdate.Text = dictionaryBrideData["weddingdate"];
            txtbridevenue.Text = dictionaryBrideData["weddingvenue"];
            txtbridesgroom.Text = dictionaryBrideData["groomsname"];
        }
    }  
}
