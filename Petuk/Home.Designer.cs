
namespace Petuk
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Menu = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Orange;
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu.Location = new System.Drawing.Point(247, 311);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(102, 29);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "View Menu";
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Signup
            // 
            this.Signup.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Signup.Location = new System.Drawing.Point(457, 51);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(94, 29);
            this.Signup.TabIndex = 1;
            this.Signup.Text = "Sign-up";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login.Location = new System.Drawing.Point(572, 51);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(94, 29);
            this.Login.TabIndex = 2;
            this.Login.Text = "Log-in";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.About.Location = new System.Drawing.Point(691, 51);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 29);
            this.About.TabIndex = 3;
            this.About.Text = "About us";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(691, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button button1;
    }
}

