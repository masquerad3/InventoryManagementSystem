namespace MainDashboard
{
    public partial class Dashboard : Form
    {
        private DashboardContent dashboardContent; // Declare the field
        private Inventory inventory; // Declare the Inventory field
        private Employee employee; // Declare the Employee field
        private ProductAlert productAlert; // Declare the ProductAlert field
        private Batch batch; // Declare the Batch field

        public Dashboard()
        {
            InitializeComponent();
            dashboardContent = new DashboardContent() // Initialize the field
            {
                Dock = DockStyle.Fill // Set the Dock property to fill the parent container
            };

            this.Controls.Add(dashboardContent);

            inventory = new Inventory() // Initialize the Inventory field
            {
                Dock = DockStyle.Fill // Set the Dock property to fill the parent container
            };
            this.Controls.Add(inventory);

            employee = new Employee() // Initialize the Employee field
            {
                Dock = DockStyle.Fill // Set the Dock property to fill the parent container
            };
            this.Controls.Add(employee);

            productAlert = new ProductAlert() // Initialize the ProductAlert field
            {
                Dock = DockStyle.Fill // Set the Dock property to fill the parent container
            };
            this.Controls.Add(productAlert);

            batch = new Batch() // Initialize the Batch field
            {
                Dock = DockStyle.Fill // Set the Dock property to fill the parent container
            };
            this.Controls.Add(batch);

        }

        private void cuiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePicture_Load(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {

        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            inventory.BringToFront(); // Bring the Inventory control to the front
        }

        private void DashboardHeader_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBar_ContentChanged(object sender, EventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardContent.BringToFront();
        }

        private void ProductAlertBtn_Click(object sender, EventArgs e)
        {
            productAlert.BringToFront(); // Bring the ProductAlert control to the front
        }

        private void BatchBtn_Click(object sender, EventArgs e)
        {
            batch.BringToFront(); // Bring the Batch control to the front
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            employee.BringToFront(); // Bring the Employee control to the front
        }
    }
}
