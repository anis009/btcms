using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCMS
{
    public partial class Ticket_Payment : Form
    {
        private readonly ErrorProvider errorProvider;
        private decimal fareAmount = 0;

        public Ticket_Payment()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };
            
            // Wire event handlers
            button1.Click += Button1_Click;  // Pay button
            button2.Click += Button2_Click;  // Cancel button
            
            // Set default fare (can be passed from previous form)
            SetFareAmount(800);
        }

        // Constructor overload to accept fare amount
        public Ticket_Payment(decimal fare) : this()
        {
            SetFareAmount(fare);
        }

        private void SetFareAmount(decimal amount)
        {
            fareAmount = amount;
            textBox1.Text = fareAmount.ToString("C");
        }

        private void Ticket_Payment_Load(object sender, EventArgs e)
        {
            // Default to Bkash
            radioButton2.Checked = true;
        }

        // Pay button
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                // Validate payment method selection
                if (!radioButton2.Checked && !radioButton3.Checked)
                {
                    MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate fare amount
                if (fareAmount <= 0)
                {
                    MessageBox.Show("Invalid fare amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string paymentMethod = radioButton2.Checked ? "Bkash" : "Nagad";
                string transactionId = GenerateTransactionId();

                DialogResult result = MessageBox.Show(
                    $"Confirm Payment?\n\nPayment Method: {paymentMethod}\nAmount: {fareAmount:C}\n\nProceed with payment?",
                    "Confirm Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Simulate payment processing
                    MessageBox.Show(
                        $"Payment Successful!\n\nTransaction ID: {transactionId}\nPayment Method: {paymentMethod}\nAmount Paid: {fareAmount:C}\n\nThank you for your payment!",
                        "Payment Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Clear form or close
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel button
        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel the payment?",
                "Cancel Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private string GenerateTransactionId()
        {
            return $"TXN{DateTime.Now:yyyyMMddHHmmss}{new Random().Next(1000, 9999)}";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
