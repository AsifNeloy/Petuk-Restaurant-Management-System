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
    public partial class Edit_menu : Form
    {
        public Edit_menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Food;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Food_table set Food_name = @Food_name, Food_price = @Food_price where Food_id = @Food_id ", con);
            cmd.Parameters.AddWithValue("@Food_id", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Food_name", (textBox1.Text));
            cmd.Parameters.AddWithValue("@Food_price", double.Parse(textBox2.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully!!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            displayData();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager_home().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Food;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Food_table values(@Food_id,@Food_name,@Food_price)",con);

            cmd.Parameters.AddWithValue("@Food_id", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Food_name", (textBox1.Text));
            cmd.Parameters.AddWithValue("@Food_price", double.Parse(textBox2.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved!");
            displayData();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Food;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Food_table where Food_id = @Food_id",con);
            cmd.Parameters.AddWithValue("@Food_id", int.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Deleted!!");

            displayData();
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

        private void Edit_menu_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
