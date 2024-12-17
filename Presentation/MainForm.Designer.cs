namespace ClinicManagement
{
    partial class MainForm
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
            this.btnPatientManagement = new System.Windows.Forms.Button();
            this.btnDoctorManagement = new System.Windows.Forms.Button();
            this.btnMedicineManagement = new System.Windows.Forms.Button();
            this.btnHealthFacilityManagement = new System.Windows.Forms.Button();
            this.btnTreatmentRequestManagement = new System.Windows.Forms.Button();
            this.btnStatisticManagement = new System.Windows.Forms.Button();
            this.btnDiseaseManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatientManagement
            // 
            this.btnPatientManagement.Location = new System.Drawing.Point(48, 44);
            this.btnPatientManagement.Name = "btnPatientManagement";
            this.btnPatientManagement.Size = new System.Drawing.Size(129, 66);
            this.btnPatientManagement.TabIndex = 0;
            this.btnPatientManagement.Text = "Quản Lý Bệnh Nhân";
            this.btnPatientManagement.UseVisualStyleBackColor = true;
            this.btnPatientManagement.Click += new System.EventHandler(this.btnPatientManagement_Click);
            // 
            // btnDoctorManagement
            // 
            this.btnDoctorManagement.Location = new System.Drawing.Point(216, 44);
            this.btnDoctorManagement.Name = "btnDoctorManagement";
            this.btnDoctorManagement.Size = new System.Drawing.Size(129, 66);
            this.btnDoctorManagement.TabIndex = 0;
            this.btnDoctorManagement.Text = "Quản Lý Bác Sĩ";
            this.btnDoctorManagement.UseVisualStyleBackColor = true;
            this.btnDoctorManagement.Click += new System.EventHandler(this.btnDoctorManagement_Click);
            // 
            // btnMedicineManagement
            // 
            this.btnMedicineManagement.Location = new System.Drawing.Point(382, 44);
            this.btnMedicineManagement.Name = "btnMedicineManagement";
            this.btnMedicineManagement.Size = new System.Drawing.Size(129, 66);
            this.btnMedicineManagement.TabIndex = 0;
            this.btnMedicineManagement.Text = "Quản Lý Thuốc";
            this.btnMedicineManagement.UseVisualStyleBackColor = true;
            this.btnMedicineManagement.Click += new System.EventHandler(this.btnMedicineManagement_Click);
            // 
            // btnHealthFacilityManagement
            // 
            this.btnHealthFacilityManagement.Location = new System.Drawing.Point(48, 152);
            this.btnHealthFacilityManagement.Name = "btnHealthFacilityManagement";
            this.btnHealthFacilityManagement.Size = new System.Drawing.Size(129, 66);
            this.btnHealthFacilityManagement.TabIndex = 0;
            this.btnHealthFacilityManagement.Text = "Quản Lý Dịch Vụ Khám Chữa Bệnh";
            this.btnHealthFacilityManagement.UseVisualStyleBackColor = true;
            this.btnHealthFacilityManagement.Click += new System.EventHandler(this.btnHealthFacilityManagement_Click);
            // 
            // btnTreatmentRequestManagement
            // 
            this.btnTreatmentRequestManagement.Location = new System.Drawing.Point(216, 152);
            this.btnTreatmentRequestManagement.Name = "btnTreatmentRequestManagement";
            this.btnTreatmentRequestManagement.Size = new System.Drawing.Size(129, 66);
            this.btnTreatmentRequestManagement.TabIndex = 0;
            this.btnTreatmentRequestManagement.Text = "Quản Lý Hồ Sơ Khám Chữa Bệnh";
            this.btnTreatmentRequestManagement.UseVisualStyleBackColor = true;
            this.btnTreatmentRequestManagement.Click += new System.EventHandler(this.btnTreatmentRequestManagement_Click);
            // 
            // btnStatisticManagement
            // 
            this.btnStatisticManagement.Location = new System.Drawing.Point(382, 152);
            this.btnStatisticManagement.Name = "btnStatisticManagement";
            this.btnStatisticManagement.Size = new System.Drawing.Size(129, 66);
            this.btnStatisticManagement.TabIndex = 0;
            this.btnStatisticManagement.Text = "Thống Kê";
            this.btnStatisticManagement.UseVisualStyleBackColor = true;
            this.btnStatisticManagement.Click += new System.EventHandler(this.btnStatisticManagement_Click);
            // 
            // btnDiseaseManagement
            // 
            this.btnDiseaseManagement.Location = new System.Drawing.Point(547, 44);
            this.btnDiseaseManagement.Name = "btnDiseaseManagement";
            this.btnDiseaseManagement.Size = new System.Drawing.Size(129, 66);
            this.btnDiseaseManagement.TabIndex = 1;
            this.btnDiseaseManagement.Text = "Quản Lý Bệnh";
            this.btnDiseaseManagement.UseVisualStyleBackColor = true;
            this.btnDiseaseManagement.Click += new System.EventHandler(this.btnDiseaseManagement_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 285);
            this.Controls.Add(this.btnDiseaseManagement);
            this.Controls.Add(this.btnStatisticManagement);
            this.Controls.Add(this.btnTreatmentRequestManagement);
            this.Controls.Add(this.btnHealthFacilityManagement);
            this.Controls.Add(this.btnMedicineManagement);
            this.Controls.Add(this.btnDoctorManagement);
            this.Controls.Add(this.btnPatientManagement);
            this.Name = "MainForm";
            this.Text = "Quản Lý Phòng Khám Tư Nhân";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatientManagement;
        private System.Windows.Forms.Button btnDoctorManagement;
        private System.Windows.Forms.Button btnMedicineManagement;
        private System.Windows.Forms.Button btnHealthFacilityManagement;
        private System.Windows.Forms.Button btnTreatmentRequestManagement;
        private System.Windows.Forms.Button btnStatisticManagement;
        private System.Windows.Forms.Button btnDiseaseManagement;
    }
}