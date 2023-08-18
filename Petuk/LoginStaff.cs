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
    public partial class LoginStaff : Form
    {
        public LoginStaff()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter the username");

                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Enter the password");
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Person;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_login WHERE Employee_userid='" + textBox1.Text + "' AND Employee_password='" + textBox2.Text + "'", con);
                        //cmd.Parameters.AddWithValue("@Manager_userid", textBox1.Text);
                        //cmd.Parameters.AddWithValue("@Manager_password", textBox2.Text);
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.Hide();
                            new Employeeact().Show();
                        }
                        else
                        {
                            MessageBox.Show("username/ pass is invalid");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter Data Properly!!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter Userid");
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
                errorProvider2.SetError(textBox2, "Please enter Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, null);
            }
        }
    }
}
