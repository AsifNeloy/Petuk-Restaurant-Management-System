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
    public partial class View_order : Form
    {
        public View_order()
        {
            InitializeComponent();
        }

        public void displayDataOrder()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Food;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Food_order";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void View_order_Load(object sender, EventArgs e)
        {
            displayDataOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employeeact().Show();
        }
    }
}
