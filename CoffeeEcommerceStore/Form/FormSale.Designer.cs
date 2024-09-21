﻿namespace CoffeeEcommerceStore
{
    partial class FormSale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_products = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_confirm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_selected_product_image = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_selected_product_price = new System.Windows.Forms.Label();
            this.label_selected_product_name = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_add_product = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.panel_sizes = new System.Windows.Forms.Panel();
            this.radioButton_size_large = new System.Windows.Forms.RadioButton();
            this.radioButton_size_medium = new System.Windows.Forms.RadioButton();
            this.radioButton_size_small = new System.Windows.Forms.RadioButton();
            this.panel_toppings = new System.Windows.Forms.Panel();
            this.listBox_cart = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox_toppings = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_selected_product_image)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.panel_sizes.SuspendLayout();
            this.panel_toppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.flowLayoutPanel_products);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 771);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button_search);
            this.panel3.Controls.Add(this.comboBox_category);
            this.panel3.Controls.Add(this.textBox_search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 97);
            this.panel3.TabIndex = 0;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_search.Location = new System.Drawing.Point(197, 28);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(198, 45);
            this.textBox_search.TabIndex = 0;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.ItemHeight = 16;
            this.comboBox_category.Location = new System.Drawing.Point(12, 49);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(165, 24);
            this.comboBox_category.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.Image = global::CoffeeEcommerceStore.Properties.Resources.icons8_search_24;
            this.button_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_search.Location = new System.Drawing.Point(414, 28);
            this.button_search.Name = "button_search";
            this.button_search.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_search.Size = new System.Drawing.Size(134, 45);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Tìm kiếm";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh mục";
            // 
            // flowLayoutPanel_products
            // 
            this.flowLayoutPanel_products.AutoScroll = true;
            this.flowLayoutPanel_products.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_products.Location = new System.Drawing.Point(0, 97);
            this.flowLayoutPanel_products.Name = "flowLayoutPanel_products";
            this.flowLayoutPanel_products.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flowLayoutPanel_products.Size = new System.Drawing.Size(925, 674);
            this.flowLayoutPanel_products.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1337, 781);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.listBox_cart);
            this.panel5.Controls.Add(this.button_confirm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 426);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 349);
            this.panel5.TabIndex = 0;
            // 
            // button_confirm
            // 
            this.button_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(121)))), ((int)(((byte)(5)))));
            this.button_confirm.FlatAppearance.BorderSize = 0;
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_confirm.ForeColor = System.Drawing.Color.Snow;
            this.button_confirm.Location = new System.Drawing.Point(3, 288);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(387, 57);
            this.button_confirm.TabIndex = 14;
            this.button_confirm.Text = "Xác nhận thanh toán";
            this.button_confirm.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(938, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 775);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_selected_product_image, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel_sizes, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_toppings, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 426);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox_selected_product_image
            // 
            this.pictureBox_selected_product_image.BackColor = System.Drawing.Color.Snow;
            this.pictureBox_selected_product_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_selected_product_image.Image = global::CoffeeEcommerceStore.Properties.Resources.coffee_placeholder;
            this.pictureBox_selected_product_image.Location = new System.Drawing.Point(201, 3);
            this.pictureBox_selected_product_image.Name = "pictureBox_selected_product_image";
            this.pictureBox_selected_product_image.Size = new System.Drawing.Size(192, 121);
            this.pictureBox_selected_product_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_selected_product_image.TabIndex = 0;
            this.pictureBox_selected_product_image.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Snow;
            this.panel6.Controls.Add(this.label_selected_product_price);
            this.panel6.Controls.Add(this.label_selected_product_name);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 121);
            this.panel6.TabIndex = 17;
            // 
            // label_selected_product_price
            // 
            this.label_selected_product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_selected_product_price.Location = new System.Drawing.Point(8, 96);
            this.label_selected_product_price.Name = "label_selected_product_price";
            this.label_selected_product_price.Size = new System.Drawing.Size(180, 24);
            this.label_selected_product_price.TabIndex = 16;
            // 
            // label_selected_product_name
            // 
            this.label_selected_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_selected_product_name.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_selected_product_name.Location = new System.Drawing.Point(7, 16);
            this.label_selected_product_name.Name = "label_selected_product_name";
            this.label_selected_product_name.Size = new System.Drawing.Size(181, 69);
            this.label_selected_product_name.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button_add_product);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(201, 343);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 80);
            this.panel7.TabIndex = 18;
            // 
            // button_add_product
            // 
            this.button_add_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add_product.BackColor = System.Drawing.Color.Snow;
            this.button_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_product.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_add_product.ForeColor = System.Drawing.Color.Orange;
            this.button_add_product.Location = new System.Drawing.Point(2, 24);
            this.button_add_product.Name = "button_add_product";
            this.button_add_product.Size = new System.Drawing.Size(187, 53);
            this.button_add_product.TabIndex = 14;
            this.button_add_product.Text = "Thêm vào";
            this.button_add_product.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.numericUpDown_quantity);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 343);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(192, 80);
            this.panel8.TabIndex = 19;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_quantity.Location = new System.Drawing.Point(5, 42);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(183, 22);
            this.numericUpDown_quantity.TabIndex = 17;
            // 
            // panel_sizes
            // 
            this.panel_sizes.BackColor = System.Drawing.SystemColors.Control;
            this.panel_sizes.Controls.Add(this.radioButton_size_large);
            this.panel_sizes.Controls.Add(this.radioButton_size_medium);
            this.panel_sizes.Controls.Add(this.radioButton_size_small);
            this.panel_sizes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sizes.Location = new System.Drawing.Point(3, 130);
            this.panel_sizes.Name = "panel_sizes";
            this.panel_sizes.Size = new System.Drawing.Size(192, 207);
            this.panel_sizes.TabIndex = 20;
            // 
            // radioButton_size_large
            // 
            this.radioButton_size_large.AutoSize = true;
            this.radioButton_size_large.Location = new System.Drawing.Point(5, 89);
            this.radioButton_size_large.Name = "radioButton_size_large";
            this.radioButton_size_large.Size = new System.Drawing.Size(75, 20);
            this.radioButton_size_large.TabIndex = 0;
            this.radioButton_size_large.TabStop = true;
            this.radioButton_size_large.Text = "Size lớn";
            this.radioButton_size_large.UseVisualStyleBackColor = true;
            // 
            // radioButton_size_medium
            // 
            this.radioButton_size_medium.AutoSize = true;
            this.radioButton_size_medium.Location = new System.Drawing.Point(5, 46);
            this.radioButton_size_medium.Name = "radioButton_size_medium";
            this.radioButton_size_medium.Size = new System.Drawing.Size(79, 20);
            this.radioButton_size_medium.TabIndex = 0;
            this.radioButton_size_medium.TabStop = true;
            this.radioButton_size_medium.Text = "Size vừa";
            this.radioButton_size_medium.UseVisualStyleBackColor = true;
            // 
            // radioButton_size_small
            // 
            this.radioButton_size_small.AutoSize = true;
            this.radioButton_size_small.Location = new System.Drawing.Point(5, 3);
            this.radioButton_size_small.Name = "radioButton_size_small";
            this.radioButton_size_small.Size = new System.Drawing.Size(79, 20);
            this.radioButton_size_small.TabIndex = 0;
            this.radioButton_size_small.TabStop = true;
            this.radioButton_size_small.Text = "Size nhỏ";
            this.radioButton_size_small.UseVisualStyleBackColor = true;
            // 
            // panel_toppings
            // 
            this.panel_toppings.Controls.Add(this.checkedListBox_toppings);
            this.panel_toppings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_toppings.Location = new System.Drawing.Point(201, 130);
            this.panel_toppings.Name = "panel_toppings";
            this.panel_toppings.Size = new System.Drawing.Size(192, 207);
            this.panel_toppings.TabIndex = 21;
            // 
            // listBox_cart
            // 
            this.listBox_cart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_cart.FormattingEnabled = true;
            this.listBox_cart.ItemHeight = 16;
            this.listBox_cart.Location = new System.Drawing.Point(3, 2);
            this.listBox_cart.Name = "listBox_cart";
            this.listBox_cart.Size = new System.Drawing.Size(389, 164);
            this.listBox_cart.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(107, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "0 đ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email khách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(308, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox_toppings
            // 
            this.checkedListBox_toppings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_toppings.FormattingEnabled = true;
            this.checkedListBox_toppings.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox_toppings.Name = "checkedListBox_toppings";
            this.checkedListBox_toppings.Size = new System.Drawing.Size(192, 207);
            this.checkedListBox_toppings.TabIndex = 1;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 787);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSale";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "FormDashboard";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_selected_product_image)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.panel_sizes.ResumeLayout(false);
            this.panel_sizes.PerformLayout();
            this.panel_toppings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_products;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox_selected_product_image;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label_selected_product_price;
        private System.Windows.Forms.Label label_selected_product_name;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_add_product;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Panel panel_sizes;
        private System.Windows.Forms.RadioButton radioButton_size_large;
        private System.Windows.Forms.RadioButton radioButton_size_medium;
        private System.Windows.Forms.RadioButton radioButton_size_small;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Panel panel_toppings;
        private System.Windows.Forms.ListBox listBox_cart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox_toppings;
    }
}