namespace ClinicManagement.ClinicForm
{
    partial class MedicineDetailForm
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
            this.dgvMedicineDetail = new System.Windows.Forms.DataGridView();
            this.dgvcMedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbUsage = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMedicine = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicineDetail
            // 
            this.dgvMedicineDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicineDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcMedicineId,
            this.dgvcMedicineName,
            this.dgvcQuantity,
            this.dgvcPrice,
            this.dgvcUsage});
            this.dgvMedicineDetail.Location = new System.Drawing.Point(16, 55);
            this.dgvMedicineDetail.MultiSelect = false;
            this.dgvMedicineDetail.Name = "dgvMedicineDetail";
            this.dgvMedicineDetail.ReadOnly = true;
            this.dgvMedicineDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineDetail.Size = new System.Drawing.Size(611, 306);
            this.dgvMedicineDetail.TabIndex = 2;
            this.dgvMedicineDetail.TabStop = false;
            // 
            // dgvcMedicineId
            // 
            this.dgvcMedicineId.DataPropertyName = "MedicineId";
            this.dgvcMedicineId.HeaderText = "Mã Thuốc";
            this.dgvcMedicineId.Name = "dgvcMedicineId";
            this.dgvcMedicineId.ReadOnly = true;
            // 
            // dgvcMedicineName
            // 
            this.dgvcMedicineName.DataPropertyName = "Medicine.MedicineName";
            this.dgvcMedicineName.HeaderText = "Tên Thuốc";
            this.dgvcMedicineName.Name = "dgvcMedicineName";
            this.dgvcMedicineName.ReadOnly = true;
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
            this.dgvcPrice.DataPropertyName = "Medicine.Price";
            this.dgvcPrice.HeaderText = "Đơn Giá";
            this.dgvcPrice.Name = "dgvcPrice";
            this.dgvcPrice.ReadOnly = true;
            // 
            // dgvcUsage
            // 
            this.dgvcUsage.DataPropertyName = "Usage";
            this.dgvcUsage.HeaderText = "Hướng Dẫn Sử Dụng";
            this.dgvcUsage.Name = "dgvcUsage";
            this.dgvcUsage.ReadOnly = true;
            this.dgvcUsage.Width = 150;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(276, 154);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 45);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dgvMedicineDetail);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 384);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Dách Thuốc";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(16, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudQuantity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtbUsage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbMedicine);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 215);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Thuốc";
            // 
            // nudPrice
            // 
            this.nudPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(80, 112);
            this.nudPrice.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ReadOnly = true;
            this.nudPrice.Size = new System.Drawing.Size(116, 20);
            this.nudPrice.TabIndex = 15;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrice.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đơn Giá";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(80, 74);
            this.nudQuantity.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(61, 20);
            this.nudQuantity.TabIndex = 2;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số Lượng";
            // 
            // rtbUsage
            // 
            this.rtbUsage.Location = new System.Drawing.Point(427, 34);
            this.rtbUsage.Name = "rtbUsage";
            this.rtbUsage.Size = new System.Drawing.Size(200, 113);
            this.rtbUsage.TabIndex = 3;
            this.rtbUsage.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hướng Dẫn Sử Dụng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thuốc";
            // 
            // cbMedicine
            // 
            this.cbMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMedicine.FormattingEnabled = true;
            this.cbMedicine.Location = new System.Drawing.Point(80, 34);
            this.cbMedicine.Name = "cbMedicine";
            this.cbMedicine.Size = new System.Drawing.Size(222, 21);
            this.cbMedicine.TabIndex = 1;
            this.cbMedicine.SelectedIndexChanged += new System.EventHandler(this.cbMedicine_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // MedicineDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedicineDetailForm";
            this.Text = "Chi Tiết Đơn Thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMedicineDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMedicine;
        private System.Windows.Forms.RichTextBox rtbUsage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUsage;
    }
}

