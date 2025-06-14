using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Version1._0
{
    public partial class Verify : Form
    {

        private string expectedCode;

        public Verify()
        {
            InitializeComponent();
        }

        public Verify(string verificationCode)
        {
            expectedCode = verificationCode;
            InitializeComponent();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
        }

        private void VerificationBox_FinishedTypingContent(object sender, EventArgs e)
        {
            string enteredCode = VerificationBox.Content.Trim();
            if (!string.IsNullOrWhiteSpace(enteredCode) && enteredCode.Length == 6 && enteredCode.All(char.IsDigit))
            {
                if (enteredCode == expectedCode)
                {
                    MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerificationBox.Content = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid 6-digit code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VerificationBox.Content = "";
            }
        }
    }
}

