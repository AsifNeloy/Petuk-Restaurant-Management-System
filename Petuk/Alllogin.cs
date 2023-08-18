using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Petuk
{
    public partial class Alllogin : Form
    {
        public Alllogin()
        {
            InitializeComponent();
        }

        private void Managerlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void Employeelogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginStaff().Show();
        }

        private void Cheflogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginChef().Show();
        }
    }
}
