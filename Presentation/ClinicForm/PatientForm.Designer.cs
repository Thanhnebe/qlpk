
namespace ClinicManagement.ClinicForm
{
    partial class PatientForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.dgvcPatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIdentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Bệnh Nhân";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số CMND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Điện Thoại";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(430, 30);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Location = new System.Drawing.Point(430, 106);
            this.txtIdentityNumber.MaxLength = 15;
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(134, 20);
            this.txtIdentityNumber.TabIndex = 10;
            this.txtIdentityNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumeric_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(430, 69);
            this.txtPhone.MaxLength = 12;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 20);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumeric_KeyPress);
            // 
            // dgvPatient
            // 
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcPatientId,
            this.dgvcName,
            this.dgvcSex,
            this.dgvcBirthday,
            this.dgvcAddress,
            this.dgvcPhone,
            this.dgvcIdentityNumber});
            this.dgvPatient.Location = new System.Drawing.Point(16, 55);
            this.dgvPatient.MultiSelect = false;
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(715, 306);
            this.dgvPatient.TabIndex = 2;
            // 
            // dgvcPatientId
            // 
            this.dgvcPatientId.DataPropertyName = "PatientId";
            this.dgvcPatientId.HeaderText = "Mã Bệnh Nhân";
            this.dgvcPatientId.Name = "dgvcPatientId";
            this.dgvcPatientId.ReadOnly = true;
            // 
            // dgvcName
            // 
            this.dgvcName.DataPropertyName = "Name";
            this.dgvcName.HeaderText = "Họ Tên";
            this.dgvcName.Name = "dgvcName";
            this.dgvcName.ReadOnly = true;
            // 
            // dgvcSex
            // 
            this.dgvcSex.DataPropertyName = "Sex";
            this.dgvcSex.HeaderText = "Giới Tính";
            this.dgvcSex.Name = "dgvcSex";
            this.dgvcSex.ReadOnly = true;
            this.dgvcSex.Width = 80;
            // 
            // dgvcBirthday
            // 
            this.dgvcBirthday.DataPropertyName = "Birthday";
            this.dgvcBirthday.HeaderText = "Ngày Sinh";
            this.dgvcBirthday.Name = "dgvcBirthday";
            this.dgvcBirthday.ReadOnly = true;
            this.dgvcBirthday.Width = 85;
            // 
            // dgvcAddress
            // 
            this.dgvcAddress.DataPropertyName = "Address";
            this.dgvcAddress.HeaderText = "Địa Chỉ";
            this.dgvcAddress.Name = "dgvcAddress";
            this.dgvcAddress.ReadOnly = true;
            // 
            // dgvcPhone
            // 
            this.dgvcPhone.DataPropertyName = "Phone";
            this.dgvcPhone.HeaderText = "Số Điện Thoại";
            this.dgvcPhone.Name = "dgvcPhone";
            this.dgvcPhone.ReadOnly = true;
            // 
            // dgvcIdentityNumber
            // 
            this.dgvcIdentityNumber.DataPropertyName = "IdentityNumber";
            this.dgvcIdentityNumber.HeaderText = "CMND";
            this.dgvcIdentityNumber.Name = "dgvcIdentityNumber";
            this.dgvcIdentityNumber.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(331, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 45);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(433, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 45);
            this.btnAdd.TabIndex = 11;
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
            this.btnSearch.Location = new System.Drawing.Point(226, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dgvPatient);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 384);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Dách Bệnh Nhân";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(307, 29);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnFemale);
            this.groupBox2.Controls.Add(this.rbtnMale);
            this.groupBox2.Controls.Add(this.dtpBirthday);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIdentityNumber);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 193);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Bệnh Nhân";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(171, 108);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(39, 17);
            this.rbtnFemale.TabIndex = 7;
            this.rbtnFemale.Text = "Nữ";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(118, 108);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(47, 17);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Nam";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(118, 68);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(90, 20);
            this.dtpBirthday.TabIndex = 5;
            this.dtpBirthday.Value = new System.DateTime(1990, 1, 1, 10, 48, 0, 0);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientForm";
            this.Text = "Quản Lý Bệnh Nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIdentityNumber;
    }
}

