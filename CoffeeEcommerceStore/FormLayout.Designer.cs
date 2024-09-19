﻿namespace CoffeeEcommerceStore
{
    partial class FormLayout
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_nav_product = new System.Windows.Forms.Button();
            this.button_nav_dashboard = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_main, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button_nav_product);
            this.panel1.Controls.Add(this.button_nav_dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 570);
            this.panel1.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(176, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(979, 570);
            this.panel_main.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.Color.LightCoral;
            this.button4.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_logout_24;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(25, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 60);
            this.button4.TabIndex = 1;
            this.button4.Text = "Đăng xuất";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_dollar_coin_24;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(25, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 60);
            this.button5.TabIndex = 1;
            this.button5.Text = "Doanh thu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_sell_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(25, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đơn hàng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_nav_product
            // 
            this.button_nav_product.FlatAppearance.BorderSize = 0;
            this.button_nav_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nav_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_nav_product.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_coffee_cup_24;
            this.button_nav_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nav_product.Location = new System.Drawing.Point(25, 103);
            this.button_nav_product.Name = "button_nav_product";
            this.button_nav_product.Size = new System.Drawing.Size(162, 60);
            this.button_nav_product.TabIndex = 1;
            this.button_nav_product.Text = "Sản phẩm";
            this.button_nav_product.UseVisualStyleBackColor = true;
            // 
            // button_nav_dashboard
            // 
            this.button_nav_dashboard.FlatAppearance.BorderSize = 0;
            this.button_nav_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nav_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_nav_dashboard.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_home_24;
            this.button_nav_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nav_dashboard.Location = new System.Drawing.Point(25, 37);
            this.button_nav_dashboard.Name = "button_nav_dashboard";
            this.button_nav_dashboard.Size = new System.Drawing.Size(162, 60);
            this.button_nav_dashboard.TabIndex = 1;
            this.button_nav_dashboard.Text = "Trang chủ";
            this.button_nav_dashboard.UseVisualStyleBackColor = true;
            // 
            // FormLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1158, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormLayout";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_nav_product;
        private System.Windows.Forms.Button button_nav_dashboard;
        private System.Windows.Forms.Panel panel_main;
    }
}

