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
   
    public partial class Managersignup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Person;Integrated Security=True");
        SqlCommand cmd1;
        SqlCommand cmd2;

        public Managersignup()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, EventArgs e)
        {



            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                con.Open();
                cmd1 = new SqlCommand("insert into Manager_table values (' " + textBox1.Text + " ','" + textBox2.Text + " ',' " + textBox3.Text + " ')", con);
                cmd1.ExecuteNonQuery();

                cmd2 = new SqlCommand("insert into Manager_login values (' " + textBox4.Text + "',' " + textBox5.Text + "')", con);
                cmd2.ExecuteNonQuery();

                //MessageBox.Show("Data Saved Successfully");
                con.Close();





                this.Hide();
                new Alllogin().Show();
                
            }
            else
            {
                MessageBox.Show("Please enter Data Properly!!");
            }
            
            
           

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Allsignup().Show();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please enter Phone Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, null);
            }

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider3.SetError(textBox3, "Please enter Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(textBox3, null);
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                textBox4.Focus();
                errorProvider4.SetError(textBox4, "Please enter User ID");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(textBox4, null);
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider5.SetError(textBox5, "Please enter Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(textBox5, null);
            }
        }
    }
}
