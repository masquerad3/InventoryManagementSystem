using MainDashboard.Backend.Queries.BatchOrdersCrud;
using MainDashboard.Backend.Queries.Dashboard;
using MainDashboard.Backend.Queries.ProductsCrud;
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
    public partial class DashboardContent : UserControl
    {
        public DashboardContent()
        {
            InitializeComponent();

            LoadDashboardContents();
        }

        private void LoadDashboardContents()
        {
            // item summary
            Read productQtyReader = new Read();
            int TotalProductQuantity = productQtyReader.GetTotalProductQuantity();

            ISNumber.Content = TotalProductQuantity.ToString();     // total quantity
            ISNumber2.Content = "TBA";
            //ISNumber2.Content = TotalProductQuantity.ToString();

            // product summary
            // hardcoded values based on the excel inventory data sheet
            PSNumber1.Content = "25";   // supplier
            PSNumber2.Content = "10";  // categories

            // total items
            Read productCountReader = new Read();
            int TotalProductCount = productCountReader.GetTotalProductCount();

            TInumber1.Content = TotalProductCount.ToString();   // total items
            TINumber2.Content = "10";   // to be received

            // total batches
            Read readTotalOrder = new Read();
            int TotalBatchOrders = readTotalOrder.CountTotalBatchOrders();

            Read readOrderOtw = new Read();
            int ToBeReceivedOrders = readOrderOtw.CountToBeReceivedOrders();

            TBNumber1.Content = TotalBatchOrders.ToString();   // total orders ?
            TBNumber2.Content = ToBeReceivedOrders.ToString();   // to be received
            
        }

    }
}
