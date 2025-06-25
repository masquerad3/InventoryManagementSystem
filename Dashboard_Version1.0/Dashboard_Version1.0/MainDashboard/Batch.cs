using MainDashboard.Backend.Logics.BatchOrders.Reload;
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
    public partial class Batch : UserControl
    {
        public Batch()
        {
            InitializeComponent();

            // load the data to the table
            ReloadBatchOrders.LoadBatchOrdersData(BatchOrdersGridView);
        }

        private void BatchOrdersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
