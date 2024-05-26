using ProteinShopMGM.DAL;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProteinShopMGM
{
    public partial class ProductForm : Form
    {
        private readonly IProductDAL _productDAL = new ProductDAL();
        private readonly IProductCategoryDAL _productCategoryDAL = new ProductCategoryDAL();
        
        private Guid? _productIdSelected = null; // Specifies selected ID of Product Category in case of Edit / Delete operation.
        private string _formTitle;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            _formTitle = "Product";
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

            // Input data.            
            string code = ProductCodeTextBox.Text.Trim();
            string name = NameTextBox.Text.Trim();
            Guid productcategoryId = ((ProductCategory)ProductCategoryComboBox.SelectedItem).Id;
            float price = float.Parse(PriceTextBox.Text.Trim());          
            string description = DescriptionTextBox.Text.Trim();
            string size = SizeTextBox.Text.Trim() + " " + UOMComboBox.Text.Trim();
            int reorderLevel = int.Parse(ReorderLevelTextBox.Text.Trim());

            if (!_productDAL.Save(_productIdSelected, code, name, price, productcategoryId, description, reorderLevel, size, MDIParent._loggedInUser.UserId, out errorMessage))
            {
                MessageBox.Show(Common.STRINGS.SAVE_ERROR_MESSAGE, Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(name + " has been saved successfully.", Common.STRINGS.SAVED, MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitForm();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InitForm();
        }

        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }

            _productIdSelected = Guid.Parse(ProductDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
            string[] sizeParts = ProductDataGridView.Rows[rowIndex].Cells[6].Value.ToString().Split(' ');

            NameTextBox.Text = ProductDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            ProductCodeTextBox.Text = ProductDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Guid productCategoryId = Guid.Parse(ProductDataGridView.Rows[rowIndex].Cells[8].Value.ToString());
            var matchingProductCategory = ProductCategoryComboBox.Items.Cast<ProductCategory>().FirstOrDefault(z => z.Id == productCategoryId);
            if (matchingProductCategory != null)
            {
                ProductCategoryComboBox.SelectedItem = matchingProductCategory;
            }
            PriceTextBox.Text = ProductDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            SizeTextBox.Text = sizeParts[0];
            UOMComboBox.Text = sizeParts[1];
            DescriptionTextBox.Text = ProductDataGridView.Rows[rowIndex].Cells[7].Value.ToString();
            ReorderLevelTextBox.Text = ProductDataGridView.Rows[rowIndex].Cells[9].Value.ToString();

            SetControls();
        }

     
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_productIdSelected != null)
            {
                if (!_productDAL.Delete((Guid)_productIdSelected, MDIParent._loggedInUser.UserId, out string errorMessage))
                {
                    MessageBox.Show(Common.STRINGS.DELETE_ERROR_MESSAGE, Common.STRINGS.DELETE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(NameTextBox.Text.Trim() + " has been deleted successfully.", Common.STRINGS.DELETED, MessageBoxButtons.OK, MessageBoxIcon.Information);

                InitForm();
            }
        }

        private void SearchByNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowDataInGrid();
        }

        private void SearchByCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataInGrid();
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

        private void SizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ReorderLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public void InitForm()
        {
            _productIdSelected = null; // Reset selected ID as null in order to perform Add operation.

            // Reset the form controls.
            Common.Utility.ResetControls(DataEntryPanel);
            Common.Utility.ResetControls(SearchPanel);
            SetControls();
            LoadProductCategories();

            ShowDataInGrid();

            ProductCodeTextBox.Focus();
        }

        public void SetControls()
        {
            if (_productIdSelected == null) // This is Add operation only.
            {
                this.Text = "New " + _formTitle;
                NameTextBox.Enabled = true;
                DeleteButton.Enabled = false;
            }
            else
            {
                this.Text = "Edit " + _formTitle;
                NameTextBox.Enabled = false;
                DeleteButton.Enabled = true;
            }
        }

        public void ShowDataInGrid()
        {
            // Clear.
            //ProductDataGridView.Rows.Clear();

            // Retrieve the available product categories.
            try
            {
                ProductDataGridView.Rows.Clear();

                if (SearchByCategoryComboBox.SelectedItem != null)
                {
                    List<Product> products = _productDAL.GetAll(SearchByNameTextBox.Text.Trim(), ((ProductCategory)SearchByCategoryComboBox.SelectedItem).Id);

                    foreach (Product product in products)
                    {
                        int rowIndex = ProductDataGridView.Rows.Add();
                        DataGridViewRow row = ProductDataGridView.Rows[rowIndex];
                        row.Cells["id"].Value = product.Id;
                        row.Cells["srNumber"].Value = (rowIndex + 1).ToString();
                        row.Cells["code"].Value = product.Code;
                        row.Cells["name"].Value = product.Name;
                        row.Cells["productcategoryname"].Value = product.ProductCategoryName;
                        row.Cells["price"].Value = product.Price;
                        row.Cells["size"].Value = product.Size;
                        row.Cells["description"].Value = product.Description;
                        row.Cells["productcategoryid"].Value = product.ProductCategoryId;
                        row.Cells["reorderlevel"].Value = product.ReorderLevel;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error is" + e);
            }
        }

        public bool ValidateForm(out string errorMessage)
        {
            bool returnValue = true;
            errorMessage = string.Empty;

            if (!Common.Validation.IsNotEmpty(ProductCodeTextBox))
            {
                errorMessage = "Code cannot be blank." + Environment.NewLine;
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(NameTextBox))
            {
                errorMessage += "Name cannot be blank." + Environment.NewLine;
                returnValue = false;
            }

            if (ProductCategoryComboBox.SelectedIndex < 0)
            {
                errorMessage += "Please select Product Category." + Environment.NewLine;
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(PriceTextBox))
            {
                errorMessage += "Price cannot be blank." + Environment.NewLine;
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(SizeTextBox))
            {
                errorMessage += "Size cannot be blank." + Environment.NewLine;
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(ReorderLevelTextBox))
            {
                errorMessage += "Reorder Level cannot be blank.";
                returnValue = false;
            }

            return returnValue;
        }

        public void LoadProductCategories()
        {
            List<ProductCategory> productCategories = _productCategoryDAL.GetAll(null);

            ProductCategoryComboBox.DataSource = new BindingSource(productCategories, null);
            ProductCategoryComboBox.DisplayMember = "name";
            ProductCategoryComboBox.ValueMember = "id";

            SearchByCategoryComboBox.DataSource = new BindingSource(productCategories, null);
            SearchByCategoryComboBox.DisplayMember = "name";
            SearchByCategoryComboBox.ValueMember = "id";
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true; // Block the input
                MessageBox.Show("Please enter only letters in the name field.", Common.STRINGS.DELETED, MessageBoxButtons.OK, MessageBoxIcon.Information); // Show a message to the user
            }
        }
    }
}
