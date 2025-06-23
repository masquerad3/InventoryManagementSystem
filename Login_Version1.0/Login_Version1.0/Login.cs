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
    }
}
