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
    public partial class Createorder : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Person;Integrated Security=True");
        //SqlCommand cmd;
        public Createorder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Food;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Food_order values(@Order_id,@Food_name,@Food_quantity)", con);

            cmd.Parameters.AddWithValue("@Order_id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Food_name", (textBox2.Text));
            cmd.Parameters.AddWithValue("@Food_quantity", int.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Order Recieved!");
            displayDataOrder();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        public void displayData()
        {
            SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Food;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Food_table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Food;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Food_order where Order_id = @Order_id", con);
            cmd.Parameters.AddWithValue("@Order_id", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Order Removed!");

            displayDataOrder();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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
            dataGridView2.DataSource = dt;
            con.Close();

        }

        private void Createorder_Load(object sender, EventArgs e)
        {
            displayData();
            displayDataOrder();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employeeact().Show();
        }
    }
}
