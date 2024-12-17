namespace ClinicManagement.ClinicForm
{
    partial class MedicineForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.dgvcMedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.rtbUsage = new System.Windows.Forms.RichTextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Thuốc";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(109, 29);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(134, 20);
            this.txtMedicineName.TabIndex = 4;
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcMedicineId,
            this.dgvcMedicineName,
            this.dgvcPrice,
            this.dgvcQuantity,
            this.dgvcUnit,
            this.dgvcUsage});
            this.dgvMedicine.Location = new System.Drawing.Point(16, 55);
            this.dgvMedicine.MultiSelect = false;
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicine.Size = new System.Drawing.Size(639, 306);
            this.dgvMedicine.TabIndex = 2;
            this.dgvMedicine.TabStop = false;
            // 
            // dgvcMedicineId
            // 
            this.dgvcMedicineId.DataPropertyName = "MedicineId";
            this.dgvcMedicineId.HeaderText = "Mã Thuốc";
            this.dgvcMedicineId.Name = "dgvcMedicineId";
            this.dgvcMedicineId.ReadOnly = true;
            this.dgvcMedicineId.Width = 90;
            // 
            // dgvcMedicineName
            // 
            this.dgvcMedicineName.DataPropertyName = "MedicineName";
            this.dgvcMedicineName.HeaderText = "Tên Thuốc";
            this.dgvcMedicineName.Name = "dgvcMedicineName";
            this.dgvcMedicineName.ReadOnly = true;
            // 
            // dgvcPrice
            // 
            this.dgvcPrice.DataPropertyName = "Price";
            this.dgvcPrice.HeaderText = "Đơn Giá";
            this.dgvcPrice.Name = "dgvcPrice";
            this.dgvcPrice.ReadOnly = true;
            this.dgvcPrice.Width = 85;
            // 
            // dgvcQuantity
            // 
            this.dgvcQuantity.DataPropertyName = "Quantity";
            this.dgvcQuantity.HeaderText = "Số Lượng Tồn";
            this.dgvcQuantity.Name = "dgvcQuantity";
            this.dgvcQuantity.ReadOnly = true;
            this.dgvcQuantity.Width = 85;
            // 
            // dgvcUnit
            // 
            this.dgvcUnit.DataPropertyName = "Unit";
            this.dgvcUnit.HeaderText = "Đơn Vị Tính";
            this.dgvcUnit.Name = "dgvcUnit";
            this.dgvcUnit.ReadOnly = true;
            this.dgvcUnit.Width = 85;
            // 
            // dgvcUsage
            // 
            this.dgvcUsage.DataPropertyName = "Usage";
            this.dgvcUsage.HeaderText = "Hướng Dẫn Sử Dụng";
            this.dgvcUsage.Name = "dgvcUsage";
            this.dgvcUsage.ReadOnly = true;
            this.dgvcUsage.Width = 120;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(278, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 45);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(374, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(183, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 45);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(226, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dgvMedicine);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 376);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Dách Thuốc";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(307, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudPrice);
            this.groupBox2.Controls.Add(this.rtbUsage);
            this.groupBox2.Controls.Add(this.nudQuantity);
            this.groupBox2.Controls.Add(this.cbUnit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMedicineName);
            this.groupBox2.Location = new System.Drawing.Point(12, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 250);
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
            this.nudPrice.Location = new System.Drawing.Point(109, 67);
            this.nudPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(134, 20);
            this.nudPrice.TabIndex = 5;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrice.ThousandsSeparator = true;
            // 
            // rtbUsage
            // 
            this.rtbUsage.Location = new System.Drawing.Point(383, 32);
            this.rtbUsage.Name = "rtbUsage";
            this.rtbUsage.Size = new System.Drawing.Size(272, 135);
            this.rtbUsage.TabIndex = 7;
            this.rtbUsage.Text = "";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(109, 108);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(134, 20);
            this.nudQuantity.TabIndex = 6;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantity.ThousandsSeparator = true;
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Viên",
            "Vỉ",
            "Cái",
            "Chiếc",
            "Chai",
            "Hộp",
            "ML",
            "L"});
            this.cbUnit.Location = new System.Drawing.Point(109, 145);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(134, 21);
            this.cbUnit.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đơn Vị Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hướng Dẫn Sử Dụng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Lượng Tồn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn Giá";
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedicineForm";
            this.Text = "Quản Lý Thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbUsage;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcUsage;
    }
}

