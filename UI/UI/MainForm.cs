using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLoginpage loginpage = new AdminLoginpage();
            loginpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BrideGroomLogin brideGroomLogin = new BrideGroomLogin();
            brideGroomLogin.Show();
            this.Hide();
        }
    }
}
