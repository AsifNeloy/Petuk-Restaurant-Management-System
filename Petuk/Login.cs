using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Petuk
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Person;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //con.Open();
            /*---String username, password;

            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                String querry = "SELECT * FROM Manager_table WHERE Manager_userID = '" + textBox1.Text + "' AND Manager_password = '" + textBox2.Text + "' ";
                SqlDataAdapter adpt = new SqlDataAdapter(querry, con);
                DataTable managertable = new DataTable();
                adpt.Fill(managertable);
                if (managertable.Rows.Count == 1)
                { 

                    username = textBox1.Text;
                    password = textBox2.Text;

                    this.Hide();
                    
                    new Manageract().Show();
                }
                else
                {
                    MessageBox.Show("Invalid User Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            finally
            {
                con.Close();
            }*/


            /*---SqlConnection con = new SqlConnection("Data Source=ARNAB;Initial Catalog=Person;Integrated Security=True");

            string query = "SELECT * FROM Manager_table WHERE Manager_userID = '" + textBox1.Text.Trim() + "' AND Manager_password = '" + textBox2.Text.Trim() + "' ";

            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                new Manageract().Show();
            }
            else
            {
                MessageBox.Show("Check your Username and password");
            }*/


            /*---SqlConnection con = new SqlConnection(@"Data Source=ARNAB;Initial Catalog=Person;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Manager_table WHERE Manager_userID='" + textBox1.Text + "' AND Manager_password='" + textBox2.Text + "'", con);
             
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                 
                this.Hide();
                new Manageract().Show();
            }
            else
                MessageBox.Show("Invalid username or password");
            */
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

                        SqlCommand cmd = new SqlCommand("SELECT * FROM Manager_login WHERE Manager_userid='" + textBox1.Text + "' AND Manager_password='" + textBox2.Text + "'", con);
                        //cmd.Parameters.AddWithValue("@Manager_userid", textBox1.Text);
                        //cmd.Parameters.AddWithValue("@Manager_password", textBox2.Text);
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.Hide();
                            new Manager_home().Show();
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

            /*if (textBox_user_name.Text != "" && textBox_password.Text != "")
            {
                if (comboBoxs_select_user.SelectedItem.ToString() == "user")
                {
                    SqlConnection con = new SqlConnection(connectionstring);
                    string query = "SELECT * FROM user_Table_1 where user_name= @user and Password = @pass";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", textBox_user_name.Text);
                    cmd.Parameters.AddWithValue("@pass", textBox_password.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        MessageBox.Show("Login Successful !!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //GetUser_Name = textBox_user_name.Text;
                        user f = new user();
                        this.Hide();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! Incorrect username & password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Enter username and password.", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }
            else
            {
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/



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
