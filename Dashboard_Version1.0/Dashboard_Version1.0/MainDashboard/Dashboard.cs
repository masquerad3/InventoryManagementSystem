namespace MainDashboard
{
    public partial class Dashboard : Form
    {
        private DashboardContent dashboardContent; // Declare the field
        private Inventory inventory; // Declare the Inventory field

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

        }
    }
}
