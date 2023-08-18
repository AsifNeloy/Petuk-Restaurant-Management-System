
namespace Petuk
{
    partial class LoginStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginStaff));
            this.Employeelogin = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Employeelogin
            // 
            this.Employeelogin.AutoSize = true;
            this.Employeelogin.BackColor = System.Drawing.Color.Transparent;
            this.Employeelogin.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Employeelogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Employeelogin.Location = new System.Drawing.Point(395, 162);
            this.Employeelogin.Name = "Employeelogin";
            this.Employeelogin.Size = new System.Drawing.Size(115, 20);
            this.Employeelogin.TabIndex = 0;
            this.Employeelogin.Text = "as Employee";
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.BackColor = System.Drawing.Color.Transparent;
            this.UserId.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserId.Location = new System.Drawing.Point(310, 235);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(72, 20);
            this.UserId.TabIndex = 1;
            this.UserId.Text = "User-Id";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login.Location = new System.Drawing.Point(310, 300);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(94, 20);
            this.login.TabIndex = 2;
            this.login.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 224);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(432, 300);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submit.Location = new System.Drawing.Point(538, 394);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(86, 31);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.UseWaitCursor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(296, 394);
            this.back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(86, 31);
            this.back.TabIndex = 6;
            this.back.Text = "Cancel";
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
            // LoginStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.back);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.Employeelogin);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginStaff";
            this.Text = "Login-Staff";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Employeelogin;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}