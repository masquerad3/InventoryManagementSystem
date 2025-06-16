using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoreSys
{
    public partial class Form1 : Form
    {
        formDashboard dashboard;
        formInventory inventory;
        formProductAlert productAlert;
        formBatch batch;
        formEmployee employee;


        bool sidebarExpand;
        private Timer sidebarTimer; // Added declaration for sidebarTimer  
        private void midProp()
        {
            this.SetBevel(false);
            Control.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(255, 255, 255);
        }
        public Form1()
        {
            InitializeComponent();
            midProp(); // Call the method to set MDI properties
            sidebarTimer = new Timer(); // Initialize sidebarTimer  
            sidebarTimer.Interval = 10; // Set an appropriate interval  
            sidebarTimer.Tick += sidebarTimer_Tick; // Attach the Tick event handler  
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void Menubutton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); // Start the timer to animate sidebar
        }

        // dashboard button click event you probably need to rename this
        private void cuiButton1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                // this green is the public partial class <formdashboard>
                formDashboard dashboard = new formDashboard();
                //misreferenced ka ng tinatawag
                dashboard.formDashboard_Load(sender, e); // Call the Load method to set ControlBox to false
                //dashboard.FormClosed += Dashboard_FormClosed;
                //dashboard.MidParent = this; // Set the parent form
                dashboard.Show();

                //this didnt fix anything but i found the error
            }
            else
            {
                dashboard.Activate(); // Activate the existing dashboard form
            }
        }


        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null; // Reset the dashboard reference when closed
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new formInventory();
                inventory.FormClosed += Inventory_FormClosed;
                inventory.MidParent = this; // Set the parent form
                inventory.Show();
            }
            else
            {
                inventory.Activate(); // Activate the existing inventory form
            }


        }
        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventory = null; // Reset the inventory reference when closed
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            if (productAlert == null)
            {
                productAlert = new formProductAlert();
                productAlert.FormClosed += ProductAlert_FormClosed;
                productAlert.MidParent = this; // Set the parent form
                productAlert.Show();
            }
            else
            {
                productAlert.Activate(); // Activate the existing product alert form
            }

        }

        //--
        private void ProductAlert_FormClosed(object sender, FormClosedEventArgs e)
        {
            productAlert = null; // Reset the product alert reference when closed
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            if (batch == null)
            {
                batch = new formBatch();
                batch.FormClosed += Batch_FormClosed;
                batch.MidParent = this; // Set the parent form
                batch.Show();
            }
            else
            {
                batch.Activate(); // Activate the existing batch form
            }
        }
        private void Batch_FormClosed(object sender, FormClosedEventArgs e)
        {
            batch = null; // Reset the batch reference when closed
        }

        private void cuiButton5_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                employee = new formEmployee();
                employee.FormClosed += Employee_FormClosed;
                employee.MidParent = this; // Set the parent form
                employee.Show();
            }
            else
            {
                employee.Activate(); // Activate the existing employee form
            }
        }
        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            employee = null; // Reset the employee reference when closed
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}