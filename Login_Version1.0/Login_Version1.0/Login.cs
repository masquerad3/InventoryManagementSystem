using MainDashboard;

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
            // Example: get user input from your textboxes
            string email = EmailLabel.Content; // or .Text, depending on your control
            string password = cuiTextBox2.Content;

            // TODO: Add your actual login validation logic here
            if (email == "admin" && password == "password") // Dummy check
            {
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
                this.Hide(); // or this.Close() if you want to close login completely
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
