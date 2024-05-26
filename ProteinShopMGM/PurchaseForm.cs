using ProteinShopMGM.DAL;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static ProteinShopMGM.Utility.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProteinShopMGM
{
    public partial class PurchaseForm : Form
    {
        private readonly ISupplierDAL _supplierDAL = new SupplierDAL();
        private readonly IProductDAL _productDAL = new ProductDAL();
        private readonly IPurchaseDAL _purchaseDAL = new PurchaseDAL();
        private readonly IPurchaseDetailsDAL _purchaseDetailsDAL = new PurchaseDetailsDAL();
        private int _productRowIndex = 0;
        
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            InitForm();
            

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // First validate the input.
            if (!ValidateForm(out string errorMessage))
            {
                MessageBox.Show(errorMessage, Common.STRINGS.VALIDATION_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guid supplierId = (Guid)SupplierComboBox.SelectedValue;
            DateTime purchaseDate = PurchaseDateDTPicker.Value.Date;

            Guid purchaseId = Guid.Empty;
            if (!_purchaseDAL.Save(supplierId, purchaseDate, PURCHASESTATUS.INPROCESS, MDIParent._loggedInUser.UserId, out purchaseId, out errorMessage))
            {
                MessageBox.Show(Common.STRINGS.SAVE_ERROR_MESSAGE, Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save purchase details.
            foreach (DataGridViewRow row in ProductDataGridView.Rows)
            {
                Guid productId = (Guid)row.Cells[0].Value;
                DateTime packingDate = (DateTime)row.Cells[6].Value;
                DateTime expiryDate = (DateTime)row.Cells[7].Value;
                int quantity = int.Parse(row.Cells[4].Value.ToString());
                float rate = float.Parse(row.Cells[5].Value.ToString());
                float mrp = float.Parse(row.Cells[8].Value.ToString());

                if (!_purchaseDetailsDAL.Save(purchaseId, productId, packingDate, expiryDate, quantity, rate, mrp, MDIParent._loggedInUser.UserId, out errorMessage))
                {
                    MessageBox.Show(Common.STRINGS.SAVE_ERROR_MESSAGE, Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Purchase entry has been added successfully.", Common.STRINGS.SAVED, MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitForm();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InitForm();
        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void RateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.IndexOf(".") >= 0 || textBox.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void MRPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.IndexOf(".") >= 0 || textBox.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // First validate the input.
            if (!ValidateProductForm(out string errorMessage))
            {
                MessageBox.Show(errorMessage, Common.STRINGS.VALIDATION_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product =(Product)ProductComboBox.SelectedItem;
            // Check whether entry has been added for the product.
            bool fExists = false;
            foreach (DataGridViewRow dataRow in ProductDataGridView.Rows)
            {
                if (Guid.Parse(dataRow.Cells[0].Value.ToString()) == product.Id)
                {
                    fExists = true;
                    break;
                }
            }
            if (fExists)
            {
                MessageBox.Show("Product has been already added.", Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rowIndex = ProductDataGridView.Rows.Add();
            DataGridViewRow row = ProductDataGridView.Rows[rowIndex];
            row.Cells["productid"].Value = product.Id;
            row.Cells["srNumber"].Value = rowIndex + 1;
            row.Cells["code"].Value = product.Code;
            row.Cells["name"].Value = product.Name;
            row.Cells["packingdate"].Value = PackingDateDTPicker.Value.Date;
            row.Cells["expirydate"].Value = ExpiryDateDTPicker.Value.Date;
            row.Cells["quantity"].Value = QuantityTextBox.Text.Trim();
            row.Cells["rate"].Value = RateTextBox.Text.Trim();
            row.Cells["mrp"].Value = MRPTextBox.Text.Trim();
            Common.Utility.ResetControls(DataEntryPanel);
            
        }
        
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _productRowIndex = e.RowIndex;
            if (_productRowIndex < 0)
            {
                return;
            }

            Guid productId = Guid.Parse(ProductDataGridView.Rows[_productRowIndex].Cells[0].Value.ToString());
            ProductComboBox.SelectedValue = productId;
            QuantityTextBox.Text = ProductDataGridView.Rows[_productRowIndex].Cells[4].Value.ToString();
            RateTextBox.Text = ProductDataGridView.Rows[_productRowIndex].Cells[5].Value.ToString();
            PackingDateDTPicker.Value = (DateTime)ProductDataGridView.Rows[_productRowIndex].Cells[6].Value;
            ExpiryDateDTPicker.Value = (DateTime)ProductDataGridView.Rows[_productRowIndex].Cells[7].Value;
            MRPTextBox.Text = ProductDataGridView.Rows[_productRowIndex].Cells[8].Value.ToString();

            ProductComboBox.Enabled = false;
            AddButton.Enabled = false;
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ProductDataGridView.Rows[_productRowIndex];
            row.Cells["packingdate"].Value = PackingDateDTPicker.Value.Date;
            row.Cells["expirydate"].Value = ExpiryDateDTPicker.Value.Date;
            row.Cells["quantity"].Value = QuantityTextBox.Text.Trim();
            row.Cells["rate"].Value = RateTextBox.Text.Trim();
            row.Cells["mrp"].Value = MRPTextBox.Text.Trim();

            Common.Utility.ResetControls(DataEntryPanel);

            AddButton.Enabled = true;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;

            ProductComboBox.Enabled = true;
            _productRowIndex = -1;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ProductDataGridView.Rows[_productRowIndex];
            ProductDataGridView.Rows.Remove(row);

            Common.Utility.ResetControls(DataEntryPanel);

            AddButton.Enabled = true;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;

            ProductComboBox.Enabled = true;
            _productRowIndex = -1;
        }

        public void InitForm()
        {
            // Reset the form controls.
            Common.Utility.ResetControls(DataEntrySelectionPanel);
            Common.Utility.ResetControls(DataEntryPanel);
            ProductDataGridView.Rows.Clear();
            LoadSuppliers();
            LoadProducts();

            AddButton.Enabled = true;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;

            ProductComboBox.Enabled = true;

            _productRowIndex = 0;

            SupplierComboBox.Focus();
        }

        public void LoadSuppliers()
        {
            List<Supplier> suppliers = _supplierDAL.GetAll(null);

            SupplierComboBox.DataSource = new BindingSource(suppliers, null);
            SupplierComboBox.DisplayMember = "name";
            SupplierComboBox.ValueMember = "id";
        }

        public void LoadProducts()
        {
            List<Product> products = _productDAL.GetAll(null, null);

            ProductComboBox.DataSource = new BindingSource(products, null);
            ProductComboBox.DisplayMember = "name";
            ProductComboBox.ValueMember = "id";
        }

        public bool ValidateProductForm(out string errorMessage)
        {
            bool returnValue = true;
            errorMessage = string.Empty;

            if (ProductComboBox.SelectedIndex < 0)
            {
                errorMessage = "Please select Product." + Environment.NewLine;
                returnValue = false;
            }

            if (PackingDateDTPicker.Value.Date >= ExpiryDateDTPicker.Value.Date)
            {
                errorMessage += "Invalid Packing Date." + Environment.NewLine;
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(QuantityTextBox))
            {
                errorMessage += "Quantity cannot be blank." + Environment.NewLine;
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(RateTextBox))
            {
                errorMessage += "Rate cannot be blank.";
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(MRPTextBox))
            {
                errorMessage += "MRP cannot be blank.";
                returnValue = false;
            }

            return returnValue;
        }

        public bool ValidateForm(out string errorMessage)
        {
            bool returnValue = true;
            errorMessage = string.Empty;

            if (SupplierComboBox.SelectedIndex < 0)
            {
                errorMessage = "Please select Supplier." + Environment.NewLine;
                returnValue = false;
            }

            if (ProductDataGridView.Rows.Count == 0)
            {
                errorMessage += "Please enter purchase details.";
                returnValue = false;
            }

            return returnValue;
        }
    }
}
