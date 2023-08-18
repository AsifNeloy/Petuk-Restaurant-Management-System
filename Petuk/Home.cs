using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petuk
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Allsignup().Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Alllogin().Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Aboutus().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
