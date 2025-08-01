﻿using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MainDashboard.Backend.Queries.AuthCrud;
using MainDashboard.Backend.Queries.StaffCrud;

namespace Login_Version1._0
{
    public partial class Signup : Form
    {
        private void Signup_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed
        }

        private string verificationCode = string.Empty; // Property with initial value

        public Signup()
        {
            InitializeComponent();
        }

        // Method to set verification code (not a constructor, adjust Verify class accordingly)
        public void SetVerificationCode(string code)
        {
            verificationCode = code;
        }

        private void cuiTextBox2_ContentChanged(object sender, EventArgs e)
        {
            // Optional: Update UI or validation state based on email change
            if (sender == EmailTextBox1)
            {
                // Example: Clear error state if email is valid
                EmailTextBox1.PlaceholderText = IsValidEmail(EmailTextBox1.Content) ? "Email" : "Invalid Email";
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Validate input using Content for custom controls
            if (string.IsNullOrWhiteSpace(NameTextBox1.Content) ||
                string.IsNullOrWhiteSpace(NameTextBox2.Content) ||
                string.IsNullOrWhiteSpace(EmailTextBox1.Content) || 
                string.IsNullOrWhiteSpace(PasswordTextBox1.Content) ||
                string.IsNullOrWhiteSpace(PasswordTextBox2.Content) ||
                !TaCCheckBox.Checked)
            {
                MessageBox.Show("Please fill in all fields and accept Terms and Conditions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PasswordTextBox1.Content != PasswordTextBox2.Content)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add password length validation matching the employee creation requirement
            if (PasswordTextBox1.Content.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            string email = EmailTextBox1.Content.Trim();
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if email is already in use
            var staffCrud = new StaffCrud();
            if (staffCrud.IsEmailInUse(email))
            {
                MessageBox.Show("This email is already registered. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Collect user registration data
            string firstName = NameTextBox1.Content.Trim();
            string lastName = NameTextBox2.Content.Trim();
            string fullName = $"{firstName} {lastName}";
            string password = PasswordTextBox1.Content;

            // Generate a 6-digit verification code
            Random random = new Random();
            verificationCode = random.Next(100000, 999999).ToString();

            // Send verification email
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("masangcay.steven@gmail.com", "qaml blvw xzwl cyng"),
                    EnableSsl = true,
                    Timeout = 10000 // 10-second timeout
                };

                mail.From = new MailAddress("masangcay.steven@gmail.com"); // Your email
                mail.To.Add(email);
                mail.Subject = "Verification Code for Inventory Management System";
                mail.Body = $"Your verification code is: {verificationCode}";

                smtpClient.Send(mail);
                MessageBox.Show("Verification code sent to your email. Please check your inbox.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Proceed to Verify form with user details
                Verify verifyForm = new Verify(verificationCode, fullName, email, password);
                verifyForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
