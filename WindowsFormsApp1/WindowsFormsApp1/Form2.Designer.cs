﻿
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categ = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeItem = new System.Windows.Forms.Button();
            this.placeOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.coup = new System.Windows.Forms.TextBox();
            this.coupon = new System.Windows.Forms.Button();
            this.viewOrders = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(411, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // categ
            // 
            this.categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ.FormattingEnabled = true;
            this.categ.Location = new System.Drawing.Point(385, 108);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(220, 30);
            this.categ.TabIndex = 1;
            this.categ.SelectedIndexChanged += new System.EventHandler(this.categ_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(267, 108);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(90, 24);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(779, 158);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(411, 407);
            this.dataGridView2.TabIndex = 3;
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(271, 581);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(164, 43);
            this.addOrder.TabIndex = 4;
            this.addOrder.Text = "Add Order";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item:";
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.Location = new System.Drawing.Point(87, 136);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(16, 24);
            this.item.TabIndex = 6;
            this.item.Text = "-";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(127, 207);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(16, 24);
            this.category.TabIndex = 8;
            this.category.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(105, 280);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(16, 24);
            this.price.TabIndex = 10;
            this.price.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price:";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(889, 592);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(16, 24);
            this.amount.TabIndex = 12;
            this.amount.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount:";
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(980, 584);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(124, 43);
            this.removeItem.TabIndex = 13;
            this.removeItem.Text = "Remove Item";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // placeOrder
            // 
            this.placeOrder.Location = new System.Drawing.Point(1144, 584);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(124, 43);
            this.placeOrder.TabIndex = 14;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = true;
            this.placeOrder.Click += new System.EventHandler(this.placeOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Coupon:";
            // 
            // coup
            // 
            this.coup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coup.Location = new System.Drawing.Point(893, 108);
            this.coup.Name = "coup";
            this.coup.Size = new System.Drawing.Size(144, 28);
            this.coup.TabIndex = 16;
            // 
            // coupon
            // 
            this.coupon.Location = new System.Drawing.Point(1080, 100);
            this.coupon.Name = "coupon";
            this.coupon.Size = new System.Drawing.Size(124, 43);
            this.coupon.TabIndex = 17;
            this.coupon.Text = "Enter Coupon";
            this.coupon.UseVisualStyleBackColor = true;
            this.coupon.Click += new System.EventHandler(this.coupon_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.Location = new System.Drawing.Point(494, 581);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(164, 43);
            this.viewOrders.TabIndex = 19;
            this.viewOrders.Text = "Order Summary";
            this.viewOrders.UseVisualStyleBackColor = true;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(19, 581);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(164, 43);
            this.logout.TabIndex = 20;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 39);
            this.label5.TabIndex = 21;
            this.label5.Text = "Inventory List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(864, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 39);
            this.label7.TabIndex = 22;
            this.label7.Text = "Pending Orders";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 671);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.viewOrders);
            this.Controls.Add(this.coupon);
            this.Controls.Add(this.coup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.placeOrder);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categ);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox categ;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label item;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button placeOrder;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox coup;
        private System.Windows.Forms.Button viewOrders;
        private System.Windows.Forms.Button logout;
        public System.Windows.Forms.Button coupon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}