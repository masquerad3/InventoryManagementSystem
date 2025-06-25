
using MainDashboard.Backend.Logics.Products.Add;
using MainDashboard.Backend.Logics.Products.Edit;
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
    public partial class AddItemForm : Form
    {
        private string value;
        private DataGridView _targetDataGridView;
        private int? productId;

        //CONSTRUCTOR FOR ADD
        public AddItemForm(string value, DataGridView dgv)
        {
            InitializeComponent();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;

            // checks the value
            if (this.value == "Add")
            {
                //replaces the dashboard title and button with "Add Item"
                AddEditProductLabel.Content = "Add New Product";
                SaveBtn.Content = "Add Product";
            }
            else
            {
                // for checking
                AddEditProductLabel.Content = "ADD ERROR DO NOT PROCEED";
                SaveBtn.Content = "ERROR DO NOT CLICK";
            }
        }

        // CONSTRUCTOR FOR EDIT
        public AddItemForm(string value, DataGridView dgv, int productId)
        {
            InitializeComponent();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;
            this.productId = productId;   //receives the item ID to edit

            if (this.value == "Edit")
            {
                //replaces the dashboard title and button with "Add Item"
                AddEditProductLabel.Content = "Edit Product";
                SaveBtn.Content = "Edit Product";
                SubLabel.Visible = false;
            }
            else
            {
                // for checking
                AddEditProductLabel.Content = "EDIT ERROR DO NOT PROCEED";
                SaveBtn.Content = "ERROR DO NOT CLICK";
                SubLabel.Visible = false;
            }

            LoadProductDetails();
        }

        // CONSTRUCTOR FOR view
        public AddItemForm(string value, int productId, DataGridView dgv)
        {
            InitializeComponent();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;
            this.productId = productId;   //receives the item ID to edit

            if (this.value == "View")
            {
                //replaces the dashboard title and button with "Add Item"
                AddEditProductLabel.Content = "Product Details";
                CancelBtn.Content = "Close";
                SaveBtn.Visible = false;
                SubLabel.Visible = false;
            }
            else
            {
                // for checking
                AddEditProductLabel.Content = "Product Viewing ERROR";
                SaveBtn.Visible = false;
                SubLabel.Visible = false;
            }

            LoadProductDetails();

            // disables them
            // --- CORE PRODUCT INFO ---
            ProductNameTextBox.Enabled = false;
            ManufacturerCB.Enabled = false;
            ModelTextbox.Enabled = false;
            CategoryCB.Enabled = false;
            SupplierIDTextbox.Enabled = false;

            // --- INVENTORY ---
            QuantityTextbox.Enabled = false;
            ConditionCB.Enabled = false;

            // --- PRICING & DELIVERY ---
            PriceTextbox.Enabled = false;
            DateDeliveredCDP.Enabled = false;
            WarrantyDatePicker.Enabled = false;

            // --- OPTIONAL INFO ---
            WeightTextbox.Enabled = false;
            DescriptionTextbox.Enabled = false;

        }

        private void LoadProductDetails()
        {
            if (!productId.HasValue) return;

            // Get the product details
            Product? product = new ProductRead().GetProductByID(productId.Value);

            if (product == null)
            {
                MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // --- CORE PRODUCT INFO ---
            ProductNameTextBox.Content = product.ProductName.Trim();
            ManufacturerCB.SelectedItem = product.Manufacturer.Trim();
            ModelTextbox.Content = product.Model.Trim();
            CategoryCB.SelectedItem = product.CategoryName.Trim(); // Assuming it's a simple string combobox
            SupplierIDTextbox.Content = product.SupplierID?.Trim() ?? "";

            // --- INVENTORY ---
            QuantityTextbox.Content = product.ProductQuantity.Trim();
            ConditionCB.SelectedItem = product.Manufacturer.Trim();

            // --- PRICING & DELIVERY ---
            PriceTextbox.Content = product.ProductPrice.ToString("N2");
            DateDeliveredCDP.Value = product.DateDelivered ?? DateTime.Now;
            WarrantyDatePicker.Value = DateTime.TryParse(product.ProductWarranty, out DateTime parsedWarranty)
                ? parsedWarranty
                : DateTime.Now;

            // --- OPTIONAL INFO ---
            WeightTextbox.Content = product.PackageWeight?.ToString("N2") ?? "";
            DescriptionTextbox.Content = product.ProductDescription ?? "";
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
            string condition = ConditionCB.SelectedItem.Trim();

            // PRICING & DELIVERY
            string priceText = PriceTextbox.Content.Trim();
            DateTime dateDelivered = DateDeliveredCDP.Value;
            DateTime warrantyDate = WarrantyDatePicker.Value;
            string weightText = WeightTextbox.Content.Trim();

            // OPTIONAL
            string description = DescriptionTextbox.Content.Trim();

            if (SaveBtn.Content == "Add Product")
            {
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
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot add product: Unknown Error.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (SaveBtn.Content == "Edit Product")
            {
                bool editSuccess = EditProduct.HandleEditProduct(
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

                if (editSuccess)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot edit product: Unknown Error.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
