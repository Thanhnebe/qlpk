namespace ClinicManagement.ClinicForm
{
    partial class TreatmentRequestForm
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
            this.dgvTreatmentRequest = new System.Windows.Forms.DataGridView();
            this.dgvcTreatmentRequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDoctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcRegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnMedicalCare = new System.Windows.Forms.Button();
            this.btnDiseaseDetail = new System.Windows.Forms.Button();
            this.btnMedicineDetail = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentRequest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTreatmentRequest
            // 
            this.dgvTreatmentRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatmentRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcTreatmentRequestId,
            this.dgvcPatientId,
            this.dgvcPatientName,
            this.dgvcDoctorId,
            this.dgvcDoctorName,
            this.dgvcRegisterDate,
            this.dgvcNote});
            this.dgvTreatmentRequest.Location = new System.Drawing.Point(16, 55);
            this.dgvTreatmentRequest.MultiSelect = false;
            this.dgvTreatmentRequest.Name = "dgvTreatmentRequest";
            this.dgvTreatmentRequest.ReadOnly = true;
            this.dgvTreatmentRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatmentRequest.Size = new System.Drawing.Size(752, 306);
            this.dgvTreatmentRequest.TabIndex = 2;
            this.dgvTreatmentRequest.TabStop = false;
            // 
            // dgvcTreatmentRequestId
            // 
            this.dgvcTreatmentRequestId.DataPropertyName = "TreatmentRequestId";
            this.dgvcTreatmentRequestId.HeaderText = "Mã Phiếu Khám Chữa Bệnh";
            this.dgvcTreatmentRequestId.Name = "dgvcTreatmentRequestId";
            this.dgvcTreatmentRequestId.ReadOnly = true;
            // 
            // dgvcPatientId
            // 
            this.dgvcPatientId.DataPropertyName = "PatientId";
            this.dgvcPatientId.HeaderText = "Mã Bệnh Nhân";
            this.dgvcPatientId.Name = "dgvcPatientId";
            this.dgvcPatientId.ReadOnly = true;
            // 
            // dgvcPatientName
            // 
            this.dgvcPatientName.DataPropertyName = "Patient.Name";
            this.dgvcPatientName.HeaderText = "Tên Bệnh Nhân";
            this.dgvcPatientName.Name = "dgvcPatientName";
            this.dgvcPatientName.ReadOnly = true;
            this.dgvcPatientName.Width = 80;
            // 
            // dgvcDoctorId
            // 
            this.dgvcDoctorId.DataPropertyName = "DoctorId";
            this.dgvcDoctorId.HeaderText = "Mã Bác Sĩ";
            this.dgvcDoctorId.Name = "dgvcDoctorId";
            this.dgvcDoctorId.ReadOnly = true;
            this.dgvcDoctorId.Width = 85;
            // 
            // dgvcDoctorName
            // 
            this.dgvcDoctorName.DataPropertyName = "Doctor.Name";
            this.dgvcDoctorName.HeaderText = "Tên Bác Sĩ";
            this.dgvcDoctorName.Name = "dgvcDoctorName";
            this.dgvcDoctorName.ReadOnly = true;
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
            this.btnUpdate.Location = new System.Drawing.Point(117, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 45);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 45);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Tạo Mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(226, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dgvTreatmentRequest);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 384);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Dách Phiếu Khám Chữa Bệnh";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(307, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReceipt);
            this.groupBox2.Controls.Add(this.btnMedicalCare);
            this.groupBox2.Controls.Add(this.btnDiseaseDetail);
            this.groupBox2.Controls.Add(this.btnMedicineDetail);
            this.groupBox2.Controls.Add(this.rtbNote);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpRegisterDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbDoctor);
            this.groupBox2.Controls.Add(this.cbPatient);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Phiếu Khám Chữa Bệnh";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(671, 170);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(99, 45);
            this.btnReceipt.TabIndex = 13;
            this.btnReceipt.Text = "Hóa Đơn";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnMedicalCare
            // 
            this.btnMedicalCare.Location = new System.Drawing.Point(364, 170);
            this.btnMedicalCare.Name = "btnMedicalCare";
            this.btnMedicalCare.Size = new System.Drawing.Size(99, 45);
            this.btnMedicalCare.TabIndex = 10;
            this.btnMedicalCare.Text = "Chi Tiết Dịch Vụ";
            this.btnMedicalCare.UseVisualStyleBackColor = true;
            this.btnMedicalCare.Click += new System.EventHandler(this.btnMedicalCare_Click);
            // 
            // btnDiseaseDetail
            // 
            this.btnDiseaseDetail.Location = new System.Drawing.Point(466, 170);
            this.btnDiseaseDetail.Name = "btnDiseaseDetail";
            this.btnDiseaseDetail.Size = new System.Drawing.Size(99, 45);
            this.btnDiseaseDetail.TabIndex = 11;
            this.btnDiseaseDetail.Text = "Chi Tiết Bệnh";
            this.btnDiseaseDetail.UseVisualStyleBackColor = true;
            this.btnDiseaseDetail.Click += new System.EventHandler(this.btnDiseaseDetail_Click);
            // 
            // btnMedicineDetail
            // 
            this.btnMedicineDetail.Location = new System.Drawing.Point(569, 170);
            this.btnMedicineDetail.Name = "btnMedicineDetail";
            this.btnMedicineDetail.Size = new System.Drawing.Size(99, 45);
            this.btnMedicineDetail.TabIndex = 12;
            this.btnMedicineDetail.Text = "Đơn Thuốc";
            this.btnMedicineDetail.UseVisualStyleBackColor = true;
            this.btnMedicineDetail.Click += new System.EventHandler(this.btnMedicineDetail_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(408, 31);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(360, 112);
            this.rtbNote.TabIndex = 7;
            this.rtbNote.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ghi Chú";
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegisterDate.Location = new System.Drawing.Point(117, 123);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(145, 20);
            this.dtpRegisterDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thời Gian Đăng Ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bác Sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bệnh Nhân";
            // 
            // cbDoctor
            // 
            this.cbDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(117, 77);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(212, 21);
            this.cbDoctor.TabIndex = 5;
            // 
            // cbPatient
            // 
            this.cbPatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(117, 31);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(212, 21);
            this.cbPatient.TabIndex = 4;
            // 
            // TreatmentRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TreatmentRequestForm";
            this.Text = "Quản Lý Phiếu Khám Chữa Bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentRequest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvTreatmentRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnMedicalCare;
        private System.Windows.Forms.Button btnDiseaseDetail;
        private System.Windows.Forms.Button btnMedicineDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTreatmentRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDoctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcRegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNote;
    }
}

