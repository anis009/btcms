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
    public partial class Ticket_Cancel : Form
    {
        private readonly ErrorProvider errorProvider;
        private List<string> bookingIds;

        public Ticket_Cancel()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };
            
            // Wire event handlers
            button1.Click += Button1_Click;  // Submit Request button
            
            // Initialize booking IDs (would come from database in real application)
            InitializeBookingIds();
        }

        private void InitializeBookingIds()
        {
            // Sample booking IDs (in real application, fetch from database)
            bookingIds = new List<string>
            {
                "TKT20260120001",
                "TKT20260120002",
                "TKT20260120003",
                "TKT20260119004",
                "TKT20260119005"
            };

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(bookingIds.ToArray());
        }

        private void Ticket_Cancel_Load(object sender, EventArgs e)
        {
            // Clear any pre-selected values
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
        }

        // Submit Request button
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                string ticketId = (comboBox1.SelectedItem ?? string.Empty).ToString().Trim();
                string cancelReason = textBox1.Text.Trim();

                // Validate Ticket ID
                if (string.IsNullOrEmpty(ticketId))
                {
                    errorProvider.SetError(comboBox1, "Please select a Ticket ID.");
                    comboBox1.Focus();
                    return;
                }

                // Validate Cancel Reason
                if (string.IsNullOrEmpty(cancelReason))
                {
                    errorProvider.SetError(textBox1, "Please provide a cancellation reason.");
                    textBox1.Focus();
                    return;
                }

                if (cancelReason.Length < 10)
                {
                    errorProvider.SetError(textBox1, "Cancellation reason must be at least 10 characters.");
                    textBox1.Focus();
                    return;
                }

                // Confirm cancellation
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to cancel this ticket?\n\nTicket ID: {ticketId}\nReason: {cancelReason}\n\nThis action cannot be undone.",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Process cancellation (in real app, update database)
                    string cancellationId = $"CXL{DateTime.Now:yyyyMMddHHmmss}";
                    
                    MessageBox.Show(
                        $"Ticket Cancellation Successful!\n\nTicket ID: {ticketId}\nCancellation ID: {cancellationId}\nReason: {cancelReason}\n\nRefund will be processed within 7-10 business days.",
                        "Cancellation Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Clear form
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during cancellation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            errorProvider.Clear();
        }
    }
}
