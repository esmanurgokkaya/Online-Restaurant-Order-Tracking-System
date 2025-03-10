﻿namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class AdminHomePage
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Dispose işlemi.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(100, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(600, 40);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Hoş Geldiniz, Yönetici!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonEmployees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployees.Location = new System.Drawing.Point(100, 100);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(200, 50);
            this.buttonEmployees.TabIndex = 1;
            this.buttonEmployees.Text = "Çalışanlar";
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Click += new System.EventHandler(this.ButtonEmployees_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonProducts.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.Location = new System.Drawing.Point(100, 170);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(200, 50);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Ürünler";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.ButtonProducts_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonReports.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.Location = new System.Drawing.Point(100, 240);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(200, 50);
            this.buttonReports.TabIndex = 3;
            this.buttonReports.Text = "Raporlar";
            this.buttonReports.UseVisualStyleBackColor = false;
            this.buttonReports.Click += new System.EventHandler(this.ButtonReports_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Brown;
            this.buttonLogout.Font = new System.Drawing.Font("Arial Black", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogout.Location = new System.Drawing.Point(600, 288);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(120, 52);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Çıkış Yap";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click_1);
            // 
            // AdminHomePage
            // 
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.labelWelcome);
            this.Name = "AdminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonLogout;
    }
}
