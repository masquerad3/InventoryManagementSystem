namespace inventorymanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            loadform(new inventoryform());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            loadform(new productform());   
        }
    }
}
