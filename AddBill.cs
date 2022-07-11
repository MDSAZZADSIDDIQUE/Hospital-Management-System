using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class FormAddBill : Form
    {
        public FormAddBill()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Billing billing = new Billing();
        private void btnSave_Click(object sender, EventArgs e)
        {
            billing.AdmissionID = txtAID.Text;
            billing.PatientID = txtpatientID.Text;
            billing.BillDate = Convert.ToDateTime(dateTimePickerBillDate.Text);
            billing.PatientName = txtPatientName.Text;
            billing.DateOfBirth = Convert.ToDateTime(dateTimePickerDateOfBirth.Text);
            billing.Address = txtAddress.Text;
            if (rbtnMale.Checked)
                billing.Sex = "Male";
            else
                billing.Sex = "Female";
            billing.AdmissionDate = Convert.ToDateTime(dateTimePickerAdmissionDate.Text);
            billing.DischrageDate = Convert.ToDateTime(dateTimePickerDischargeDate.Text);
            billing.PaymentDate = Convert.ToDateTime(dateTimePickerPaymentDate.Text);
            billing.CardOrCheckNo = txtCardOrChequeNo.Text;
            billing.ReceiptNo = txtReceiptNo.Text;
            billing.Total = Convert.ToDouble(txtTotal.Text);
            billing.Discount = Convert.ToDouble(txtDiscount.Text);
            billing.Tax = Convert.ToDouble(txtTax.Text);
            billing.PayAdvance = Convert.ToDouble(txtPayAdvance.Text);
            billing.Payable = Convert.ToDouble(txtPayable.Text);
            if (checkBoxPaid.Checked)
                billing.Status = "Paid";
            else
                billing.Status = "Unpaid";

            SqlConnection sqlConnection = new SqlConnection("Data Source=Likhon;Initial Catalog=Hospital Management System;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Bills (AdmissionID, PatientID, BillDate, PatientName, DateOfBirth, Address, Sex, AdmissionDate, DischrageDate, PaymentDate, CardOrCheckNo, ReceiptNo, Total, Discount, Tax, PayAdvance, Payable, Status) values ('" + billing.AdmissionID + "','" + billing.PatientID + "','" + billing.BillDate + "','" + billing.PatientName + "','" + billing.DateOfBirth + "','" + billing.Address + "','" + billing.Sex + "','" + billing.AdmissionDate + "','" + billing.DischrageDate + "','" + billing.PaymentDate + "','" + billing.CardOrCheckNo + "','" + billing.ReceiptNo + "','" + billing.Total + "','" + billing.Discount + "','" + billing.Tax + "','" + billing.PayAdvance + "','" + billing.Payable + "','" + billing.Status + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAID.Text = "";
            txtpatientID.Text = "";
            txtPatientName.Text = "";
            txtCardOrChequeNo.Text = "";
            txtReceiptNo.Text = "";
            txtTotal.Text = "";
            txtDiscount.Text = "";
            txtTax.Text = "";
            txtPayAdvance.Text = "";
            txtPayable.Text = "";
        }
    }
}
