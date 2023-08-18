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
    public partial class Manager_home : Form
    {
        public Manager_home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Edit_menu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_order_manager().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_staff().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Manager_home_Load(object sender, EventArgs e)
        {

        }
    }
}
