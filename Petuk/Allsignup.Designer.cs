
namespace Petuk
{
    partial class Allsignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Allsignup));
            this.Managersignup = new System.Windows.Forms.Button();
            this.Employeesignup = new System.Windows.Forms.Button();
            this.Chefsignup = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Managersignup
            // 
            this.Managersignup.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Managersignup.Location = new System.Drawing.Point(324, 103);
            this.Managersignup.Name = "Managersignup";
            this.Managersignup.Size = new System.Drawing.Size(193, 53);
            this.Managersignup.TabIndex = 0;
            this.Managersignup.Text = "Sign-up as manager";
            this.Managersignup.UseVisualStyleBackColor = true;
            this.Managersignup.Click += new System.EventHandler(this.Managersignup_Click);
            // 
            // Employeesignup
            // 
            this.Employeesignup.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Employeesignup.Location = new System.Drawing.Point(324, 189);
            this.Employeesignup.Name = "Employeesignup";
            this.Employeesignup.Size = new System.Drawing.Size(193, 51);
            this.Employeesignup.TabIndex = 1;
            this.Employeesignup.Text = "Sign-up as employee";
            this.Employeesignup.UseVisualStyleBackColor = true;
            this.Employeesignup.Click += new System.EventHandler(this.Employeesignup_Click);
            // 
            // Chefsignup
            // 
            this.Chefsignup.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chefsignup.Location = new System.Drawing.Point(324, 272);
            this.Chefsignup.Name = "Chefsignup";
            this.Chefsignup.Size = new System.Drawing.Size(193, 46);
            this.Chefsignup.TabIndex = 2;
            this.Chefsignup.Text = "Sign-up as chef";
            this.Chefsignup.UseVisualStyleBackColor = true;
            this.Chefsignup.Click += new System.EventHandler(this.Chefsignup_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(632, 374);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 29);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Allsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Chefsignup);
            this.Controls.Add(this.Employeesignup);
            this.Controls.Add(this.Managersignup);
            this.DoubleBuffered = true;
            this.Name = "Allsignup";
            this.Text = "All Sign-up";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Managersignup;
        private System.Windows.Forms.Button Employeesignup;
        private System.Windows.Forms.Button Chefsignup;
        private System.Windows.Forms.Button Back;
    }
}