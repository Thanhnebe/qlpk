namespace ClinicManagement.ClinicForm
{
    partial class DiseaseDetailForm
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
            this.dgvDiseaseDetail = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbTreatmentMethod = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTreatmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDisease = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvcDiseaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTreatmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTreatmentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiseaseDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiseaseDetail
            // 
            this.dgvDiseaseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiseaseDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcDiseaseId,
            this.TenBenh,
            this.dgvcTreatmentDate,
            this.dgvcTreatmentMethod});
            this.dgvDiseaseDetail.Location = new System.Drawing.Point(16, 55);
            this.dgvDiseaseDetail.MultiSelect = false;
            this.dgvDiseaseDetail.Name = "dgvDiseaseDetail";
            this.dgvDiseaseDetail.ReadOnly = true;
            this.dgvDiseaseDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiseaseDetail.Size = new System.Drawing.Size(630, 306);
            this.dgvDiseaseDetail.TabIndex = 2;
            this.dgvDiseaseDetail.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(270, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 45);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(384, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dgvDiseaseDetail);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 384);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Dách Bệnh";
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
            this.groupBox2.Controls.Add(this.rtbTreatmentMethod);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpTreatmentDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbDisease);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Bệnh";
            // 
            // rtbTreatmentMethod
            // 
            this.rtbTreatmentMethod.Location = new System.Drawing.Point(445, 31);
            this.rtbTreatmentMethod.Name = "rtbTreatmentMethod";
            this.rtbTreatmentMethod.Size = new System.Drawing.Size(201, 57);
            this.rtbTreatmentMethod.TabIndex = 3;
            this.rtbTreatmentMethod.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phương Pháp Điều Trị";
            // 
            // dtpTreatmentDate
            // 
            this.dtpTreatmentDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpTreatmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTreatmentDate.Location = new System.Drawing.Point(132, 68);
            this.dtpTreatmentDate.Name = "dtpTreatmentDate";
            this.dtpTreatmentDate.Size = new System.Drawing.Size(163, 20);
            this.dtpTreatmentDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thời Gian Chuẩn Đoán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bệnh";
            // 
            // cbDisease
            // 
            this.cbDisease.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDisease.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDisease.FormattingEnabled = true;
            this.cbDisease.Location = new System.Drawing.Point(132, 31);
            this.cbDisease.Name = "cbDisease";
            this.cbDisease.Size = new System.Drawing.Size(163, 21);
            this.cbDisease.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvcDiseaseId
            // 
            this.dgvcDiseaseId.DataPropertyName = "DiseaseId";
            this.dgvcDiseaseId.HeaderText = "Mã Bệnh";
            this.dgvcDiseaseId.Name = "dgvcDiseaseId";
            this.dgvcDiseaseId.ReadOnly = true;
            this.dgvcDiseaseId.Width = 80;
            // 
            // TenBenh
            // 
            this.TenBenh.DataPropertyName = "Disease.DiseaseName";
            this.TenBenh.HeaderText = "Tên Bệnh";
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.ReadOnly = true;
            this.TenBenh.Width = 140;
            // 
            // dgvcTreatmentDate
            // 
            this.dgvcTreatmentDate.DataPropertyName = "TreatmentDate";
            this.dgvcTreatmentDate.HeaderText = "Thời Gian Chuẩn Đoán";
            this.dgvcTreatmentDate.Name = "dgvcTreatmentDate";
            this.dgvcTreatmentDate.ReadOnly = true;
            this.dgvcTreatmentDate.Width = 160;
            // 
            // dgvcTreatmentMethod
            // 
            this.dgvcTreatmentMethod.DataPropertyName = "TreatmentMethod";
            this.dgvcTreatmentMethod.HeaderText = "Phương Pháp Điều Trị";
            this.dgvcTreatmentMethod.Name = "dgvcTreatmentMethod";
            this.dgvcTreatmentMethod.ReadOnly = true;
            this.dgvcTreatmentMethod.Width = 200;
            // 
            // DiseaseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DiseaseDetailForm";
            this.Text = "Chi Tiết Bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiseaseDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvDiseaseDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDisease;
        private System.Windows.Forms.DateTimePicker dtpTreatmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbTreatmentMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDiseaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTreatmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTreatmentMethod;
    }
}

