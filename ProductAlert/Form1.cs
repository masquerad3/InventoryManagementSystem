using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProductAlert
{
    public partial class PRODALERT : Form
    {
        public PRODALERT()
        {
            InitializeComponent();
        }

        // Example: Adding items to a ComboBox named comboBox1 in Form1
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Value 1");
            comboBox1.Items.Add("Value 2");
            comboBox1.Items.Add("Value 3");
        }

        private void btnRequestItem_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)   
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = true;
            panelFilter.BringToFront();
            // Optionally, load filter options here
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
