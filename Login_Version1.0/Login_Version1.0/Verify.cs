using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainDashboard.Backend.Queries.AuthCrud;
using MainDashboard.Backend.Queries.StaffCrud;

namespace Login_Version1._0
{
    public partial class Verify : Form
    {

        private string expectedCode;
        private string staffName;
        private string staffEmail;
        private string staffPassword;
        private bool isRegistration;

        // Default constructor
        public Verify()
        {
            InitializeComponent();
        }

        // Basic constructor for just verification
        public Verify(string verificationCode)
        {
            expectedCode = verificationCode;
            isRegistration = false;
            InitializeComponent();
        }

        // Constructor for registration flow (with user details)
        public Verify(string verificationCode, string staffName, string staffEmail, string staffPassword)
        {
            expectedCode = verificationCode;
            this.staffName = staffName;
            this.staffEmail = staffEmail;
            this.staffPassword = staffPassword;
            isRegistration = true;
            InitializeComponent();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            // You can implement button verification here if needed
        }

        private void VerificationBox_FinishedTypingContent(object sender, EventArgs e)
        {
            string enteredCode = VerificationBox.Content.Trim();
            if (!string.IsNullOrWhiteSpace(enteredCode) && enteredCode.Length == 6 && enteredCode.All(char.IsDigit))
            {
                if (enteredCode == expectedCode)
                {
                    if (isRegistration)
                    {
                        // Complete the registration process
                        if (CompleteRegistration())
                        {
                            MessageBox.Show("Verification successful! Your account has been created.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Navigate to login
                            Login loginForm = new Login();
                            loginForm.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verification successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid verification code. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerificationBox.Content = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid 6-digit code.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                VerificationBox.Content = "";
            }
        }

        private bool CompleteRegistration()
        {
            try
            {
                // 1. Create staff record
                var staffCrud = new StaffCrud();

                // Double-check email is not already in use
                if (staffCrud.IsEmailInUse(staffEmail))
                {
                    MessageBox.Show("This email is already registered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Create the staff record - NOTE: fixed constructor parameters
                Staff newStaff = new Staff(
                    staffName: staffName,
                    staffPosition: "Employee", // Default role
                    staffEmail: staffEmail,
                    staffPassword: staffPassword
                );

                // Add staff and get the new ID
                int staffId = staffCrud.AddStaff(newStaff);

                // Check if staff creation failed
                if (staffId <= 0)
                {
                    MessageBox.Show("Failed to create staff record.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // 2. Create auth record with hashed password
                var authCrud = new AuthCrud();
                bool success = authCrud.Register(staffId, staffPassword);

                if (!success)
                {
                    MessageBox.Show("Failed to create authentication record.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration error: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}