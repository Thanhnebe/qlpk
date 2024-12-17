namespace ClinicManagement.ClinicForm
{
    partial class HealthcareFacilityForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvHealthcareFacility = new System.Windows.Forms.DataGridView();
            this.dgvcHealthcareFacilityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthcareFacility)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 4;
            // 
            // dgvHealthcareFacility
            // 
            this.dgvHealthcareFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealthcareFacility.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcHealthcareFacilityId,
            this.dgvcName,
            this.dgvcPrice});
            this.dgvHealthcareFacility.Location = new System.Drawing.Point(16, 55);
            this.dgvHealthcareFacility.MultiSelect = false;
            this.dgvHealthcareFacility.Name = "dgvHealthcareFacility";
            this.dgvHealthcareFacility.ReadOnly = true;
            this.dgvHealthcareFacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHealthcareFacility.Size = new System.Drawing.Size(366, 306);
            this.dgvHealthcareFacility.TabIndex = 2;
            this.dgvHealthcareFacility.TabStop = false;
            // 
            // dgvcHealthcareFacilityId
            // 
            this.dgvcHealthcareFacilityId.DataPropertyName = "HealthcareFacilityId";
            this.dgvcHealthcareFacilityId.HeaderText = "Mã Dịch Vụ";
            this.dgvcHealthcareFacilityId.Name = "dgvcHealthcareFacilityId";
            this.dgvcHealthcareFacilityId.ReadOnly = true;
            this.dgvcHealthcareFacilityId.Width = 90;
            // 
            // dgvcName
            // 
            this.dgvcName.DataPropertyName = "Name";
            this.dgvcName.HeaderText = "Tên Dịch Vụ";
            this.dgvcName.Name = "dgvcName";
            this.dgvcName.ReadOnly = true;
            this.dgvcName.Width = 140;
            // 
            // dgvcPrice
            // 
            this.dgvcPrice.DataPropertyName = "Price";
            this.dgvcPrice.HeaderText = "Đơn Giá";
            this.dgvcPrice.Name = "dgvcPrice";
            this.dgvcPrice.ReadOnly = true;
            this.dgvcPrice.Width = 85;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 45);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(218, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dgvHealthcareFacility);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 377);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Dách Dịch Vụ Khám Chữa Bệnh ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(299, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudPrice);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 178);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Dịch Vụ Khám Chữa Bệnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đơn Giá";
            // 
            // nudPrice
            // 
            this.nudPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(118, 65);
            this.nudPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(140, 20);
            this.nudPrice.TabIndex = 5;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrice.ThousandsSeparator = true;
            // 
            // HealthcareFacilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HealthcareFacilityForm";
            this.Text = "Quản Lý Dịch Vụ Khám Chữa Bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthcareFacility)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvHealthcareFacility;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHealthcareFacilityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrice;
    }
}

