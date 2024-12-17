namespace ClinicManagement.ClinicForm
{
    partial class PaymentForm
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
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupMoney = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(334, 461);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(125, 60);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcName,
            this.dgvcQuantity,
            this.dgvcPrice,
            this.dgvcTotalAmount});
            this.dgvBill.Location = new System.Drawing.Point(15, 14);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(443, 334);
            this.dgvBill.TabIndex = 1;
            this.dgvBill.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBill_CellFormatting);
            // 
            // dgvcName
            // 
            this.dgvcName.DataPropertyName = "Name";
            this.dgvcName.HeaderText = "Tên";
            this.dgvcName.Name = "dgvcName";
            this.dgvcName.ReadOnly = true;
            // 
            // dgvcQuantity
            // 
            this.dgvcQuantity.DataPropertyName = "Quantity";
            this.dgvcQuantity.HeaderText = "Số Lượng";
            this.dgvcQuantity.Name = "dgvcQuantity";
            this.dgvcQuantity.ReadOnly = true;
            // 
            // dgvcPrice
            // 
            this.dgvcPrice.DataPropertyName = "Price";
            this.dgvcPrice.HeaderText = "Đơn Giá";
            this.dgvcPrice.Name = "dgvcPrice";
            this.dgvcPrice.ReadOnly = true;
            // 
            // dgvcTotalAmount
            // 
            this.dgvcTotalAmount.DataPropertyName = "TotalAmount";
            this.dgvcTotalAmount.HeaderText = "Thành Tiền";
            this.dgvcTotalAmount.Name = "dgvcTotalAmount";
            this.dgvcTotalAmount.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng Tiền";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(333, 373);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(125, 20);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(66, 373);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(169, 124);
            this.rtbNote.TabIndex = 1;
            this.rtbNote.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thanh toán";
            // 
            // nupMoney
            // 
            this.nupMoney.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupMoney.Location = new System.Drawing.Point(333, 435);
            this.nupMoney.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupMoney.Name = "nupMoney";
            this.nupMoney.Size = new System.Drawing.Size(125, 20);
            this.nupMoney.TabIndex = 7;
            this.nupMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupMoney.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đã Thanh toán";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Enabled = false;
            this.txtPaidAmount.Location = new System.Drawing.Point(333, 405);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.ReadOnly = true;
            this.txtPaidAmount.Size = new System.Drawing.Size(125, 20);
            this.txtPaidAmount.TabIndex = 9;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 535);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nupMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnPay);
            this.Name = "PaymentForm";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaidAmount;
    }
}