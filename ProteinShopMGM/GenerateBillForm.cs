using ProteinShopMGM.DAL;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static ProteinShopMGM.Utility.Common;

namespace ProteinShopMGM
{
    public partial class GenerateBillForm : Form
    {
        private readonly ICustomerDAL _customerDAL = new CustomerDAL();
        private readonly IProductDAL _productDAL = new ProductDAL();
        private readonly IPurchaseDetailsDAL _purchaseDetailsDAL = new PurchaseDetailsDAL();
        private readonly IStockDAL _stockDAL = new StockDAL();
        private readonly ISellDAL _sellDAL = new SellDAL();
        private readonly ISellDetailsDAL _saleDetailsDAL = new SellDetailsDAL();
        private int _productRowIndex = 0;
        private int _stockQuantity = 0;
        private float _totalAmount = 0;
        private float _netAmount = 0;
        private float _discount = 0;

        public GenerateBillForm()
        {
            InitializeComponent();
        }

        private void GenerateBillForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
        }

        private void RefreshCustomersButton_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // First validate the input.
            if (!ValidateProductForm(out string errorMessage))
            {
                MessageBox.Show(errorMessage, Common.STRINGS.VALIDATION_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = (Product)ProductComboBox.SelectedItem;

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
            row.Cells["price"].Value = PriceTextBox.Text.Trim();
            row.Cells["quantity"].Value = QuantityTextBox.Text.Trim();

            Common.Utility.ResetControls(DataEntryPanel);

            CalculateTotal();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ProductDataGridView.Rows[_productRowIndex];
            row.Cells["quantity"].Value = QuantityTextBox.Text.Trim();
            row.Cells["price"].Value = PriceTextBox.Text.Trim();

            Common.Utility.ResetControls(DataEntryPanel);

            AddButton.Enabled = true;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;

            ProductComboBox.Enabled = true;
            _productRowIndex = -1;

            CalculateTotal();
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

            CalculateTotal();
        }

        private void ProductComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ProductComboBox.SelectedIndex < 0)
            {
                return;
            }

            Product product = (Product)ProductComboBox.SelectedItem;

            // Get MRP.
            float mrp = _purchaseDetailsDAL.GetMRPByProductId(product.Id);
            PriceTextBox.Text = mrp.ToString();

            _stockQuantity = _stockDAL.GetStockQuantityByProductId(product.Id);
            if (_stockQuantity > 0)
            {
                // Check whether products are already added.
                if (ProductDataGridView.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in ProductDataGridView.Rows)
                    {
                        Guid productId = Guid.Parse(row.Cells[0].Value.ToString());
                        if (product.Id == productId)
                        {
                            _stockQuantity = _stockQuantity - int.Parse(row.Cells[4].Value.ToString());
                            break;
                        }
                    }
                }
            }

            if (_stockQuantity > 0)
            {
                StockInfoLabel.Text = "In Stock " + _stockQuantity;
                StockInfoLabel.ForeColor = Color.Green;
                AddButton.Enabled = true;
            }
            else
            {
                StockInfoLabel.Text = "Out of Stock";
                StockInfoLabel.ForeColor = Color.Red;
                AddButton.Enabled = false;
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void QuantityTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (QuantityTextBox.Text.Trim() == "")
                {
                    return;
                }

                int quantity = int.Parse(QuantityTextBox.Text.Trim());
                if (quantity > _stockQuantity)
                {
                    QuantityTextBox.Text = "0";
                }
            }
            catch { }
        }

        private void DiscountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DiscountTextBox_Leave(object sender, EventArgs e)
        {
            if (DiscountTextBox.Text.Trim() == "")
            {
                DiscountTextBox.Text = "0";
            }
            else
            {
                CalculateTotal();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // First validate the input.
            if (!ValidateForm(out string errorMessage))
            {
                MessageBox.Show(errorMessage, Common.STRINGS.VALIDATION_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guid customerId = (Guid)CustomerComboBox.SelectedValue;
            DateTime billDate = BillDateDTPicker.Value.Date;

            Guid billId = Guid.Empty;
            if (!_sellDAL.Save(customerId, billDate, _totalAmount, float.Parse(DiscountTextBox.Text.Trim()), _netAmount, MDIParent._loggedInUser.UserId, out billId, out errorMessage))
            {
                MessageBox.Show(Common.STRINGS.SAVE_ERROR_MESSAGE, Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save purchase details.
            foreach (DataGridViewRow row in ProductDataGridView.Rows)
            {
                Guid productId = (Guid)row.Cells[0].Value;
                int quantity = int.Parse(row.Cells[4].Value.ToString());
                float price = float.Parse(row.Cells[5].Value.ToString());

                if (!_saleDetailsDAL.Save(billId, productId, quantity, price, MDIParent._loggedInUser.UserId, out errorMessage))
                {
                    MessageBox.Show(Common.STRINGS.SAVE_ERROR_MESSAGE, Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update stock.
                if (!_stockDAL.Save(productId, -quantity, MDIParent._loggedInUser.UserId, out errorMessage))
                {
                    MessageBox.Show(Common.STRINGS.SAVE_ERROR_MESSAGE, Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Bill entry has been added successfully.", Common.STRINGS.SAVED, MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitForm();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InitForm();
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
            PriceTextBox.Text = ProductDataGridView.Rows[_productRowIndex].Cells[5].Value.ToString();
            
            ProductComboBox.Enabled = false;
            AddButton.Enabled = false;
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        public void InitForm()
        {
            // Reset the form controls.
            Common.Utility.ResetControls(DataEntrySelectionPanel);
            Common.Utility.ResetControls(DataEntryPanel);
            ProductDataGridView.Rows.Clear();
            LoadCustomers();
            LoadProducts();

            AddButton.Enabled = true;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;

            ProductComboBox.Enabled = true;

            _productRowIndex = 0;

            DiscountTextBox.Text = "0";

            CustomerComboBox.Focus();
        }

        public void LoadCustomers()
        {
            List<Customer> customers = _customerDAL.GetAll(null);

            CustomerComboBox.DataSource = new BindingSource(customers, null);
            CustomerComboBox.DisplayMember = "name";
            CustomerComboBox.ValueMember = "id";
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

            if (!Common.Validation.IsNotEmpty(PriceTextBox))
            {
                errorMessage += "Price cannot be blank.";
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(QuantityTextBox))
            {
                errorMessage += "Quantity cannot be blank." + Environment.NewLine;
                returnValue = false;
            }
            else 
            {
                int quantity = int.Parse(QuantityTextBox.Text.Trim());
                if (quantity == 0)
                {
                    errorMessage += "Quantity cannot be zero." + Environment.NewLine;
                    returnValue = false;
                }
            }

            return returnValue;
        }

        public void CalculateTotal()
        {
            _totalAmount = 0;
            _netAmount = 0;
            _discount = 0;
            if (ProductComboBox.SelectedIndex >= 0)
            {
                foreach (DataGridViewRow row in ProductDataGridView.Rows)
                {
                    int quantity = int.Parse(row.Cells[4].Value.ToString());
                    float price = float.Parse(row.Cells[5].Value.ToString());
                    _totalAmount += (quantity * price);
                }

                _discount = _totalAmount * float.Parse(DiscountTextBox.Text.Trim()) / 100;
                _netAmount = _totalAmount - _discount;
            }

            TotalLabel.Text = "Total : Rs. " + _totalAmount;
            NetTotalLabel.Text = "Net Total : Rs. " + _netAmount;
        }

        public bool ValidateForm(out string errorMessage)
        {
            bool returnValue = true;
            errorMessage = string.Empty;

            if (CustomerComboBox.SelectedIndex < 0)
            {
                errorMessage = "Please select Customer." + Environment.NewLine;
                returnValue = false;
            }

            if (ProductDataGridView.Rows.Count == 0)
            {
                errorMessage += "Please add products.";
                returnValue = false;
            }

            return returnValue;
        }
    }
}
