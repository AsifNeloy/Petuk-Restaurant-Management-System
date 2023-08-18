
namespace Petuk
{
    partial class Chefsignup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chefsignup));
            this.Aschef = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.Chefname = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // Aschef
            // 
            this.Aschef.AutoSize = true;
            this.Aschef.BackColor = System.Drawing.Color.Transparent;
            this.Aschef.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aschef.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Aschef.Location = new System.Drawing.Point(342, 93);
            this.Aschef.Name = "Aschef";
            this.Aschef.Size = new System.Drawing.Size(103, 26);
            this.Aschef.TabIndex = 22;
            this.Aschef.Text = "As Chef";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(253, 330);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(260, 27);
            this.textBox5.TabIndex = 21;
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(253, 286);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(260, 27);
            this.textBox4.TabIndex = 20;
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 27);
            this.textBox3.TabIndex = 19;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 27);
            this.textBox2.TabIndex = 18;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 27);
            this.textBox1.TabIndex = 17;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Location = new System.Drawing.Point(108, 337);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(99, 20);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password:";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.BackColor = System.Drawing.Color.Transparent;
            this.UserID.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserID.ForeColor = System.Drawing.Color.White;
            this.UserID.Location = new System.Drawing.Point(108, 289);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(79, 20);
            this.UserID.TabIndex = 15;
            this.UserID.Text = "User ID:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Location = new System.Drawing.Point(107, 245);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(64, 20);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email:";
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.PhoneNo.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneNo.Location = new System.Drawing.Point(106, 202);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(101, 20);
            this.PhoneNo.TabIndex = 13;
            this.PhoneNo.Text = "Phone No.:";
            // 
            // Chefname
            // 
            this.Chefname.AutoSize = true;
            this.Chefname.BackColor = System.Drawing.Color.Transparent;
            this.Chefname.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chefname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Chefname.Location = new System.Drawing.Point(108, 163);
            this.Chefname.Name = "Chefname";
            this.Chefname.Size = new System.Drawing.Size(63, 20);
            this.Chefname.TabIndex = 12;
            this.Chefname.Text = "Name:";
            // 
            // Signup
            // 
            this.Signup.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Signup.Location = new System.Drawing.Point(656, 384);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(94, 29);
            this.Signup.TabIndex = 23;
            this.Signup.Text = "Sign-up";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.back.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(542, 382);
            this.back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(86, 31);
            this.back.TabIndex = 24;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.UseWaitCursor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // Chefsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Aschef);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNo);
            this.Controls.Add(this.Chefname);
            this.DoubleBuffered = true;
            this.Name = "Chefsignup";
            this.Text = "Chef Sign-up";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Aschef;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.Label Chefname;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}