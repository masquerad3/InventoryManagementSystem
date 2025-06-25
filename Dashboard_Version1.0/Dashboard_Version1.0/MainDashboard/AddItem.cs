
using MainDashboard.Backend.Logics.Products.Add;

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
        private string value;
        private DataGridView _targetDataGridView;
        private int? productId;



        public AddItemForm(string value, DataGridView dgv)
        {
            InitializeComponent();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // CORE PRODUCT INFO
            string productName = ProductNameTextBox.Content.Trim();
            string manufacturer = ManufacturerCB.SelectedItem.Trim();
            string model = ModelTextbox.Content.Trim();
            string category = CategoryCB.SelectedItem.Trim();
            string supplierID = SupplierIDTextbox.Content.Trim();

            // INVENTORY
            string quantityText = QuantityTextbox.Content.Trim();
            string condition = ConditionTextbox.Content.Trim();

            // PRICING & DELIVERY
            string priceText = PriceTextbox.Content.Trim();
            DateTime dateDelivered = DateDeliveredCDP.Value;
            DateTime warrantyDate = WarrantyDatePicker.Value;
            string weightText = WeightTextbox.Content.Trim();

            // OPTIONAL
            string description = DescriptionTextbox.Content.Trim();

            bool addSuccess = AddToProduct.HandleAddProduct(
                    productName,
                    manufacturer,
                    model,
                    category,
                    supplierID,
                    quantityText,
                    condition,
                    priceText,
                    dateDelivered,
                    warrantyDate,
                    weightText,
                    description,
                    _targetDataGridView
                );

            if (addSuccess)
            {
                // Clear fields

                /*
                // CORE PRODUCT INFO
                ProductNameTextBox = string.Empty;
                ManufacturerCB.SelectedIndex = -1;
                ModelTextbox = string.Empty;
                CategoryCB.SelectedIndex = -1;
                SupplierIDTextbox = string.Empty;

                // INVENTORY
                QuantityTextbox = string.Empty);
                ConditionTextbox = string.Empty;

                // PRICING & DELIVERY
                PriceTextbox.Clear();
                DateDeliveredCDP.Value = DateTime.Now;
                WarrantyDatePicker.Value = DateTime.Now;
                WeightTextbox.Clear();

                // OPTIONAL
                DescriptionTextbox = string.Empty;


                TextBox_ofItemNameLabel.Content = string.Empty;
                QtyTypeComboBox.Text = string.Empty;
                TextBox_ofQtyLabel.Content = string.Empty;
                TextBox_ofBuyingPriceLabel.Content = string.Empty;
                TextBox_ofSellingPriceLabel.Content = string.Empty;
                */

                this.Close();
            }
            else
            {
                MessageBox.Show("Cannot add item: Unknown Error.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
