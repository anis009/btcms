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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void lblREGISTER_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text==String.Empty)
                {  MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txtPassword.Text==String.Empty)
                {
                    MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtConfirmPassword.Text == String.Empty)
                {
                    MessageBox.Show("Confirm Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtConfirmPassword.Text!=txtPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Please select gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txtEmail.Text==String.Empty)
                {
                    MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txtAddress.Text==String.Empty)
                {
                    MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txtMobileNumber.Text==String.Empty)
                {
                    MessageBox.Show("Mobile Number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txtMobileNumber.Text.Length!=11 || !txtMobileNumber.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Invalid Mobile Number. It should be 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string gender = radioButton1.Checked ? "Male" : "Female";
                string dateOfBirth = dateTimePickerDOB.Value.ToShortDateString();
                
                MessageBox.Show($"Registration successful!\n\nUsername: {txtUsername.Text}\nGender: {gender}\nDate of Birth: {dateOfBirth}\nEmail: {txtEmail.Text}\nMobile: {txtMobileNumber.Text}", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear form after successful registration
                ClearForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePickerDOB.Value = DateTime.Now;
            txtEmail.Clear();
            txtAddress.Clear();
            txtMobileNumber.Clear();
        }
    }
}
