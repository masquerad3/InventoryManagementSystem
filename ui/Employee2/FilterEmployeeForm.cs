using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDragDrop
{
    public partial class FilterEmployeeForm : Form
    {
        public FilterEmployeeForm()
        {
            InitializeComponent();
        }

        private void FilterEmployeeForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("On Leave");
            cmbStatus.Items.Add("Suspended");
            cmbStatus.SelectedIndex = 0;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string SelectedStatus => cmbStatus.SelectedItem?.ToString();

        public List<string> SelectedPositions
        {
            get
            {
                List<string> positions = new List<string>();
                if (chkQC.Checked) positions.Add("Quality Control Inspector");
                if (chkStock.Checked) positions.Add("Stock Clerk");
                if (chkMaterial.Checked) positions.Add("Material Handle Clerk");
                return positions;
            }
        }
    }

}
