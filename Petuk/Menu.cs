using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Petuk
{
    public partial class Menu : Form
    {
        SqlConnection con = new SqlConnection("Data Source = ARNAB; Initial Catalog = Food; Integrated Security = True");
        SqlDataAdapter adpt;
        DataTable foodtable;
        public Menu()
        {
            InitializeComponent();
            showData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
           

        }

        public void showData()
        {
            adpt = new SqlDataAdapter("SELECT * FROM Food_table", con);
            foodtable = new DataTable();
            adpt.Fill(foodtable);
            dataGridView1.DataSource = foodtable;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}
