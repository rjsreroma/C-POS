
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bankNumber = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.payments = new System.Windows.Forms.Label();
            this.placePayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coupCopy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(575, 129);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(57, 24);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Bank:";
            // 
            // bank
            // 
            this.bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank.FormattingEnabled = true;
            this.bank.Items.AddRange(new object[] {
            "BANCO DE ORO",
            "BANK OF THE PHILIPPINES",
            "GCASH(GXI)",
            "METROBANK",
            "UNIBANK"});
            this.bank.Location = new System.Drawing.Point(693, 129);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(220, 30);
            this.bank.TabIndex = 3;
            this.bank.SelectedIndexChanged += new System.EventHandler(this.bank_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Credit Card Number:";
            // 
            // bankNumber
            // 
            this.bankNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNumber.Location = new System.Drawing.Point(693, 213);
            this.bankNumber.Name = "bankNumber";
            this.bankNumber.Size = new System.Drawing.Size(220, 28);
            this.bankNumber.TabIndex = 17;
            this.bankNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bankNumber_KeyPress);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(683, 291);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(16, 24);
            this.amount.TabIndex = 19;
            this.amount.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Amount:";
            // 
            // payments
            // 
            this.payments.AutoSize = true;
            this.payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payments.Location = new System.Drawing.Point(706, 28);
            this.payments.Name = "payments";
            this.payments.Size = new System.Drawing.Size(114, 24);
            this.payments.TabIndex = 20;
            this.payments.Text = "PAYMENTS";
            // 
            // placePayment
            // 
            this.placePayment.Location = new System.Drawing.Point(751, 390);
            this.placePayment.Name = "placePayment";
            this.placePayment.Size = new System.Drawing.Size(162, 68);
            this.placePayment.TabIndex = 21;
            this.placePayment.Text = "Place Payment";
            this.placePayment.UseVisualStyleBackColor = true;
            this.placePayment.Click += new System.EventHandler(this.placePayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "ORDER SUMMARY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(366, 399);
            this.dataGridView1.TabIndex = 23;
            // 
            // coupCopy
            // 
            this.coupCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coupCopy.Location = new System.Drawing.Point(353, 25);
            this.coupCopy.Name = "coupCopy";
            this.coupCopy.Size = new System.Drawing.Size(220, 28);
            this.coupCopy.TabIndex = 24;
            this.coupCopy.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 502);
            this.Controls.Add(this.coupCopy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.placePayment);
            this.Controls.Add(this.payments);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bankNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.bank);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox bank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bankNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label payments;
        private System.Windows.Forms.Button placePayment;
        public System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox coupCopy;
    }
}