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
    public partial class Chefact : Form
    {
        public Chefact()
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

        private void Chefact_Load(object sender, EventArgs e)
        {
            displayDataOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Food;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Food_order where Order_id = @Order_id", con);
            cmd.Parameters.AddWithValue("@Order_id", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Order Done!");

            displayDataOrder();

            textBox1.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}
