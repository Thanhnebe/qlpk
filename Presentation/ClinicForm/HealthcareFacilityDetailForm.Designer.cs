namespace ClinicManagement.ClinicForm
{
    partial class HealthcareFacilityDetailForm
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
            this.dgvHealthcareFacilityDetail = new System.Windows.Forms.DataGridView();
            this.dgvcHealthcareFacilityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcRegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHealthcareFacility = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthcareFacilityDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHealthcareFacilityDetail
            // 
            this.dgvHealthcareFacilityDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealthcareFacilityDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcHealthcareFacilityId,
            this.dgvcName,
            this.dgvcQuantity,
            this.dgvcPrice,
            this.dgvcRegisterDate,
            this.dgvcNote});
            this.dgvHealthcareFacilityDetail.Location = new System.Drawing.Point(16, 55);
            this.dgvHealthcareFacilityDetail.MultiSelect = false;
            this.dgvHealthcareFacilityDetail.Name = "dgvHealthcareFacilityDetail";
            this.dgvHealthcareFacilityDetail.ReadOnly = true;
            this.dgvHealthcareFacilityDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHealthcareFacilityDetail.Size = new System.Drawing.Size(712, 306);
            this.dgvHealthcareFacilityDetail.TabIndex = 2;
            this.dgvHealthcareFacilityDetail.TabStop = false;
            // 
            // dgvcHealthcareFacilityId
            // 
            this.dgvcHealthcareFacilityId.DataPropertyName = "HealthcareFacilityId";
            this.dgvcHealthcareFacilityId.HeaderText = "Mã Dịch Vụ";
            this.dgvcHealthcareFacilityId.Name = "dgvcHealthcareFacilityId";
            this.dgvcHealthcareFacilityId.ReadOnly = true;
            // 
            // dgvcName
            // 
            this.dgvcName.DataPropertyName = "HealthcareFacility.Name";
            this.dgvcName.HeaderText = "Tên Dịch Vụ";
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
            // dgvcRegisterDate
            // 
            this.dgvcRegisterDate.DataPropertyName = "RegisterDate";
            this.dgvcRegisterDate.HeaderText = "Ngày Đăng Ký";
            this.dgvcRegisterDate.Name = "dgvcRegisterDate";
            this.dgvcRegisterDate.ReadOnly = true;
            // 
            // dgvcNote
            // 
            this.dgvcNote.DataPropertyName = "Note";
            this.dgvcNote.HeaderText = "Ghi Chú";
            this.dgvcNote.Name = "dgvcNote";
            this.dgvcNote.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(350, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 45);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(464, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dgvHealthcareFacilityDetail);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 379);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Dách Dịch Vụ";
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
            this.groupBox2.Controls.Add(this.rtbNote);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpRegisterDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbHealthcareFacility);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 219);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Dịch Vụ";
            // 
            // nudPrice
            // 
            this.nudPrice.Enabled = false;
            this.nudPrice.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(113, 134);
            this.nudPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ReadOnly = true;
            this.nudPrice.Size = new System.Drawing.Size(132, 20);
            this.nudPrice.TabIndex = 4;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrice.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đơn Giá";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(113, 100);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(48, 20);
            this.nudQuantity.TabIndex = 3;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(408, 31);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(320, 123);
            this.rtbNote.TabIndex = 5;
            this.rtbNote.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ghi Chú";
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegisterDate.Location = new System.Drawing.Point(112, 68);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(101, 20);
            this.dtpRegisterDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Đăng Ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dịch Vụ";
            // 
            // cbHealthcareFacility
            // 
            this.cbHealthcareFacility.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHealthcareFacility.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHealthcareFacility.FormattingEnabled = true;
            this.cbHealthcareFacility.Location = new System.Drawing.Point(112, 31);
            this.cbHealthcareFacility.Name = "cbHealthcareFacility";
            this.cbHealthcareFacility.Size = new System.Drawing.Size(222, 21);
            this.cbHealthcareFacility.TabIndex = 1;
            this.cbHealthcareFacility.SelectedIndexChanged += new System.EventHandler(this.cbHealthcareFacility_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // HealthcareFacilityDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HealthcareFacilityDetailForm";
            this.Text = "Chi Tiết Dịch Vụ Khám Chữa Bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthcareFacilityDetail)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvHealthcareFacilityDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHealthcareFacility;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHealthcareFacilityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcRegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNote;
    }
}

