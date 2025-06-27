namespace MainDashboard
{
    public partial class Dashboard : Form
    {
        private DashboardContent dashboardContent; // Declare the field
        private Inventory inventory; // Declare the Inventory field
        private Employee employee; // Declare the Employee field
        private ProductAlert productAlert; // Declare the ProductAlert field
        private Batch batch; // Declare the Batch field

        // Default constructor
        public Dashboard()
        {
            InitializeComponent();
            InitializeControls();
        }

        // Constructor with user information
        public Dashboard(string staffName, string staffPosition)
        {
            InitializeComponent();
            InitializeControls();

            // Update profile section with user information
            ProfileName.Content = staffName;
            ProfileLabel.Content = staffPosition;
        }

        private void InitializeControls()
        {
            dashboardContent = new DashboardContent()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(dashboardContent);

            inventory = new Inventory()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(inventory);

            employee = new Employee()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(employee);

            productAlert = new ProductAlert()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(productAlert);

            batch = new Batch()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(batch);

            // Bring dashboard to front by default
            dashboardContent.BringToFront();

            // Set up the logout button click handler
            LogoutBtn.Click += LogoutBtn_Click;
        }

        // Logout button click handler
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            // Ask for confirmation
            var result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close all open forms
                this.Close();

                // Restart the application to show login form
                Application.Restart();
            }
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            inventory.BringToFront(); // Bring the Inventory control to the front
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardContent.LoadDashboardContents(); // Force refresh
            dashboardContent.BringToFront();
        }

        private void BatchBtn_Click(object sender, EventArgs e)
        {
            batch.BringToFront(); // Bring the Batch control to the front
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            employee.BringToFront(); // Bring the Employee control to the front
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            batch.BringToFront();
        }
    }
}