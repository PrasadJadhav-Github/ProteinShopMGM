using ProteinShopMGM.DAL;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProteinShopMGM
{
    public partial class ProductCategoryForm : Form
    {
        private readonly IProductCategoryDAL _productCategoryDAL = new ProductCategoryDAL();
        private Guid? _productCategoryIdSelected = null; // Specifies selected ID of Product Category in case of Edit / Delete operation.
        private string _formTitle;

        public ProductCategoryForm()
        {
            InitializeComponent();
        }

        private void ProductCategoryForm_Load(object sender, EventArgs e)
        {
            _formTitle = "Product Category";
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
            string name = NameTextBox.Text.Trim();
            string description = DescriptionTextBox.Text.Trim();
            string subCategoryName = SubCategoryNameTextBox.Text.Trim();

            // Check whether the product category with the same name exists.
            ProductCategory productCategoryEx = _productCategoryDAL.GetByName(name, subCategoryName);

            if ((_productCategoryIdSelected == null && productCategoryEx != null) || 
                (_productCategoryIdSelected != null && productCategoryEx != null && _productCategoryIdSelected != productCategoryEx.Id))
            {
                MessageBox.Show(name + " already exists.", Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_productCategoryDAL.Save(_productCategoryIdSelected, name, description, subCategoryName, MDIParent._loggedInUser.UserId, out errorMessage))
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

        private void ProductCategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }

            _productCategoryIdSelected = Guid.Parse(ProductCategoryDataGridView.Rows[rowIndex].Cells[4].Value.ToString());
            
            NameTextBox.Text = Common.Utility.ConvertToString(ProductCategoryDataGridView.Rows[rowIndex].Cells[1].Value);
            DescriptionTextBox.Text = Common.Utility.ConvertToString(ProductCategoryDataGridView.Rows[rowIndex].Cells[2].Value);
            SubCategoryNameTextBox.Text = Common.Utility.ConvertToString(ProductCategoryDataGridView.Rows[rowIndex].Cells[3].Value);

            SetControls();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_productCategoryIdSelected != null)
            {
                if (!_productCategoryDAL.Delete((Guid)_productCategoryIdSelected, MDIParent._loggedInUser.UserId, out string errorMessage))
                {
                    MessageBox.Show(Common.STRINGS.DELETE_ERROR_MESSAGE, Common.STRINGS.DELETE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(NameTextBox.Text.Trim() + " has been deleted successfully.", Common.STRINGS.DELETED, MessageBoxButtons.OK, MessageBoxIcon.Information);

                InitForm();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchByNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowDataInGrid();
        }

        public void InitForm()
        {
            _productCategoryIdSelected = null; // Reset selected ID as null in order to perform Add operation.
            
            // Reset the form controls.
            Common.Utility.ResetControls(DataEntryPanel);
            Common.Utility.ResetControls(SearchPanel);
            SetControls();

            ShowDataInGrid();
            
            NameTextBox.Focus();
        }

        public void SetControls()
        {
            if (_productCategoryIdSelected == null) // This is Add operation only.
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
            ProductCategoryDataGridView.Rows.Clear();

            // Retrieve the available product categories.
            List<ProductCategory> productCategories = _productCategoryDAL.GetAll(SearchByNameTextBox.Text.Trim());

            foreach (ProductCategory productCategory in productCategories)
            {
                int rowIndex = ProductCategoryDataGridView.Rows.Add();
                DataGridViewRow row = ProductCategoryDataGridView.Rows[rowIndex];
                row.Cells["srNumber"].Value = (rowIndex + 1).ToString();
                row.Cells["name"].Value = productCategory.Name;
                row.Cells["description"].Value = productCategory.Description;
                row.Cells["subcategoryname"].Value = productCategory.SubCategoryName;
                row.Cells["id"].Value = productCategory.Id;
            }
        }

        public bool ValidateForm(out string errorMessage)
        {
            bool returnValue = true;
            errorMessage = string.Empty;

            if (!Common.Validation.IsNotEmpty(NameTextBox))
            {
                errorMessage = "Name cannot be blank.";
                returnValue = false;
            }

            return returnValue;
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
