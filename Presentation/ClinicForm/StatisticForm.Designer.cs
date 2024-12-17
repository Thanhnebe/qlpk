namespace ClinicManagement.ClinicForm
{
    partial class StatisticForm
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.txtNumberOfPatient = new System.Windows.Forms.TextBox();
            this.txtMostDiseaseName = new System.Windows.Forms.TextBox();
            this.txtMostUsedHealthcareFacilityName = new System.Windows.Forms.TextBox();
            this.txtMostUsedMedicineName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(42, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(118, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(43, 61);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(117, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(166, 28);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(231, 53);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng bệnh nhân khám chữa bệnh ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doanh thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dịch vụ được sử dụng nhiều nhất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bệnh nhiều nhất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Thuốc được sử dụng nhiều nhất";
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(224, 118);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(166, 20);
            this.txtRevenue.TabIndex = 9;
            this.txtRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumberOfPatient
            // 
            this.txtNumberOfPatient.Location = new System.Drawing.Point(224, 150);
            this.txtNumberOfPatient.Name = "txtNumberOfPatient";
            this.txtNumberOfPatient.ReadOnly = true;
            this.txtNumberOfPatient.Size = new System.Drawing.Size(166, 20);
            this.txtNumberOfPatient.TabIndex = 9;
            this.txtNumberOfPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMostDiseaseName
            // 
            this.txtMostDiseaseName.Location = new System.Drawing.Point(224, 181);
            this.txtMostDiseaseName.Name = "txtMostDiseaseName";
            this.txtMostDiseaseName.ReadOnly = true;
            this.txtMostDiseaseName.Size = new System.Drawing.Size(166, 20);
            this.txtMostDiseaseName.TabIndex = 9;
            // 
            // txtMostUsedHealthcareFacilityName
            // 
            this.txtMostUsedHealthcareFacilityName.Location = new System.Drawing.Point(224, 211);
            this.txtMostUsedHealthcareFacilityName.Name = "txtMostUsedHealthcareFacilityName";
            this.txtMostUsedHealthcareFacilityName.ReadOnly = true;
            this.txtMostUsedHealthcareFacilityName.Size = new System.Drawing.Size(166, 20);
            this.txtMostUsedHealthcareFacilityName.TabIndex = 9;
            // 
            // txtMostUsedMedicineName
            // 
            this.txtMostUsedMedicineName.Location = new System.Drawing.Point(224, 242);
            this.txtMostUsedMedicineName.Name = "txtMostUsedMedicineName";
            this.txtMostUsedMedicineName.ReadOnly = true;
            this.txtMostUsedMedicineName.Size = new System.Drawing.Size(166, 20);
            this.txtMostUsedMedicineName.TabIndex = 9;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 291);
            this.Controls.Add(this.txtMostUsedMedicineName);
            this.Controls.Add(this.txtMostUsedHealthcareFacilityName);
            this.Controls.Add(this.txtMostDiseaseName);
            this.Controls.Add(this.txtNumberOfPatient);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "StatisticForm";
            this.Text = "Thống Kê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.TextBox txtNumberOfPatient;
        private System.Windows.Forms.TextBox txtMostDiseaseName;
        private System.Windows.Forms.TextBox txtMostUsedHealthcareFacilityName;
        private System.Windows.Forms.TextBox txtMostUsedMedicineName;
    }
}