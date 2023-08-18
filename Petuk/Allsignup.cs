using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Petuk
{
    public partial class Allsignup : Form
    {
        public Allsignup()
        {
            InitializeComponent();
        }

        private void Managersignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Managersignup().Show();
        }

        private void Employeesignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employeesignup().Show();
        }

        private void Chefsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Chefsignup().Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}
