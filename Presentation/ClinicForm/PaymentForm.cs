using BusinessLogic.DTO;
using BusinessLogic.Service;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement.ClinicForm
{
    public partial class PaymentForm : Form
    {
        private long treatmentRequestId;
        private PaymentService paymentService = new PaymentService();

        public PaymentForm(long treatmentRequestId)
        {
            this.treatmentRequestId = treatmentRequestId;
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal totalAmount = decimal.Parse(txtTotalAmount.Text);
            if (totalAmount <= 0)
            {
                MessageBox.Show("Không thể thanh toán hóa đơn không đồng!");
                return;
            }

            try
            {
                paymentService.Add(new Payment()
                {
                    TreatmentRequestId = treatmentRequestId,
                    PayDate = DateTime.Now,
                    AmountMoney = nupMoney.Value,
                    Note = rtbNote.Text
                });
                load();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetPayState()
        {
            List<BillItem> billItems = paymentService.GetBillByTreamentRequestId(treatmentRequestId);
            decimal amountTotal = billItems.Sum(b => b.totalAmount);

            List<Payment> payments = paymentService.FindByTreatmentRequestId(treatmentRequestId);
            decimal payed = payments.Sum(p => p.AmountMoney);
            bool isPayed = payments.Count > 0 && payed >= amountTotal;
            
            if (isPayed)
            {
                btnPay.Enabled = false;
                nupMoney.Enabled = false;
                btnPay.Text = "Đã Thanh Toán";
                rtbNote.Enabled = false;
                return;
            }

            btnPay.Enabled = true;
            nupMoney.Enabled = true;
            btnPay.Text = "Thanh Toán";
            rtbNote.Enabled = true;
        }

        private void load()
        {
            List<BillItem> billItems = paymentService.GetBillByTreamentRequestId(treatmentRequestId);
            dgvBill.DataSource = billItems;

            List<Payment> payments = paymentService.FindByTreatmentRequestId(treatmentRequestId);
            decimal payedAmount = payments.Sum(p => p.AmountMoney);

            decimal amountTotal = billItems.Sum(b => b.totalAmount);
            txtTotalAmount.Text = string.Format("{0:#,##0}", amountTotal);
            txtPaidAmount.Text = string.Format("{0:#,##0}", payedAmount);
            nupMoney.Value = Math.Max(amountTotal - payedAmount, 0);

            SetPayState();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            load();

            foreach (DataGridViewColumn column in dgvBill.Columns)
            {

                if (column.Name.EndsWith("TotalAmount") || column.Name.EndsWith("Price"))
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void dgvBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
            if (columnName == "dgvcPrice" || columnName == "dgvcTotalAmount")
            {
                e.Value = string.Format("{0:#,##0}", decimal.Parse(e.Value.ToString()));
                e.FormattingApplied = true;
            }
        }
    }
}
