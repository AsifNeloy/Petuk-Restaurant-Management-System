
namespace Petuk
{
    partial class Employeeact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeeact));
            this.Createorder = new System.Windows.Forms.Button();
            this.Vieworders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Createorder
            // 
            this.Createorder.BackColor = System.Drawing.Color.Gold;
            this.Createorder.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Createorder.Location = new System.Drawing.Point(159, 209);
            this.Createorder.Name = "Createorder";
            this.Createorder.Size = new System.Drawing.Size(171, 62);
            this.Createorder.TabIndex = 0;
            this.Createorder.Text = "Create Order";
            this.Createorder.UseVisualStyleBackColor = false;
            this.Createorder.Click += new System.EventHandler(this.Createorder_Click);
            // 
            // Vieworders
            // 
            this.Vieworders.BackColor = System.Drawing.Color.Gold;
            this.Vieworders.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vieworders.Location = new System.Drawing.Point(484, 209);
            this.Vieworders.Name = "Vieworders";
            this.Vieworders.Size = new System.Drawing.Size(171, 62);
            this.Vieworders.TabIndex = 2;
            this.Vieworders.Text = "View Orders";
            this.Vieworders.UseVisualStyleBackColor = false;
            this.Vieworders.Click += new System.EventHandler(this.Vieworders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Employee!";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(650, 76);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Employeeact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vieworders);
            this.Controls.Add(this.Createorder);
            this.DoubleBuffered = true;
            this.Name = "Employeeact";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Createorder;
        private System.Windows.Forms.Button Vieworders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}