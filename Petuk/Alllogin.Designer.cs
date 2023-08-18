
namespace Petuk
{
    partial class Alllogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alllogin));
            this.Back = new System.Windows.Forms.Button();
            this.Cheflogin = new System.Windows.Forms.Button();
            this.Employeelogin = new System.Windows.Forms.Button();
            this.Managerlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(611, 365);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 29);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Cheflogin
            // 
            this.Cheflogin.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cheflogin.Location = new System.Drawing.Point(303, 263);
            this.Cheflogin.Name = "Cheflogin";
            this.Cheflogin.Size = new System.Drawing.Size(193, 46);
            this.Cheflogin.TabIndex = 6;
            this.Cheflogin.Text = "Login as chef";
            this.Cheflogin.UseVisualStyleBackColor = true;
            this.Cheflogin.Click += new System.EventHandler(this.Cheflogin_Click);
            // 
            // Employeelogin
            // 
            this.Employeelogin.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Employeelogin.Location = new System.Drawing.Point(303, 180);
            this.Employeelogin.Name = "Employeelogin";
            this.Employeelogin.Size = new System.Drawing.Size(193, 51);
            this.Employeelogin.TabIndex = 5;
            this.Employeelogin.Text = "Login as employee";
            this.Employeelogin.UseVisualStyleBackColor = true;
            this.Employeelogin.Click += new System.EventHandler(this.Employeelogin_Click);
            // 
            // Managerlogin
            // 
            this.Managerlogin.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Managerlogin.Location = new System.Drawing.Point(303, 94);
            this.Managerlogin.Name = "Managerlogin";
            this.Managerlogin.Size = new System.Drawing.Size(193, 53);
            this.Managerlogin.TabIndex = 4;
            this.Managerlogin.Text = "Login as manager";
            this.Managerlogin.UseVisualStyleBackColor = true;
            this.Managerlogin.Click += new System.EventHandler(this.Managerlogin_Click);
            // 
            // Alllogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Cheflogin);
            this.Controls.Add(this.Employeelogin);
            this.Controls.Add(this.Managerlogin);
            this.DoubleBuffered = true;
            this.Name = "Alllogin";
            this.Text = "All Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Cheflogin;
        private System.Windows.Forms.Button Employeelogin;
        private System.Windows.Forms.Button Managerlogin;
    }
}