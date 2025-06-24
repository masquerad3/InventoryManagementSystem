using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard
{
    public partial class AddItemForm : Form
    {


        public AddItemForm()
        {
            InitializeComponent();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
