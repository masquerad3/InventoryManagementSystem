using MainDashboard;
using MainDashboard.Backend.Queries.AuthCrud;
using MainDashboard.Backend.Queries.StaffCrud;

namespace Login_Version1._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignInButton_MouseClick(object sender, MouseEventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide(); //Optionally hide the login form 
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input (adjust property names to match your actual UI controls)
                string email = EmailLabel.Content?.Trim() ?? string.Empty;
                string password = cuiTextBox2.Content?.Trim() ?? string.Empty;

                // Basic validation
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both email and password.", "Login Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Find user by email
                var staffCrud = new StaffCrud();
                int? staffId = staffCrud.GetStaffIdByEmail(email);

                if (staffId == null)
                {
                    MessageBox.Show("Invalid email or password.", "Login Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verify password
                var authCrud = new AuthCrud();
                bool isValid = authCrud.Verify(staffId.Value, password);

                if (isValid)
                {
                    // Get staff details for display
                    Staff staffInfo = staffCrud.GetStaffById(staffId.Value);
                    if (staffInfo != null)
                    {
                        // Login successful - pass staff info to dashboard
                        Dashboard dashboardForm = new Dashboard(staffInfo.StaffName, staffInfo.StaffPosition);
                        dashboardForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error retrieving staff information.", "Login Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}