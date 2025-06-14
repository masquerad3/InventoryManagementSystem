using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoreSys
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        private Timer sidebarTimer; // Added declaration for sidebarTimer  

        public Form1()
        {
            InitializeComponent();
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
    }
}
