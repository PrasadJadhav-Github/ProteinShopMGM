using ProteinShopMGM.DAL;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProteinShopMGM
{
    public partial class SupplierForm : Form
    {
        private readonly ISupplierDAL _supplierDAL = new SupplierDAL();
        private Guid? _supplierIdSelected = null; // Specifies selected ID of Product Category in case of Edit / Delete operation.
        private string _formTitle;

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            _formTitle = "Supplier";
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


            if (ContactTextBox.Text.Length < 11)
            {
                MessageBox.Show("Mobile number must be 10 digit", Common.STRINGS.VALIDATION_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactTextBox.SelectionStart = ContactTextBox.Text.Length;
                return;
            }

            // Input data.
            string name = NameTextBox.Text.Trim();
            string address = AddressTextBox.Text.Trim();
            string contact = ContactTextBox.Text.Trim();
            int supplierType = ((KeyValuePair<int, string>)SupplierTypeComboBox.SelectedItem).Key;

            if (!_supplierDAL.Save(_supplierIdSelected, name, address, contact, supplierType, MDIParent._loggedInUser.UserId, out errorMessage))
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

        private void SupplierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }

            _supplierIdSelected = Guid.Parse(SupplierDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
            NameTextBox.Text = Common.Utility.ConvertToString(SupplierDataGridView.Rows[rowIndex].Cells[2].Value);
            AddressTextBox.Text = Common.Utility.ConvertToString(SupplierDataGridView.Rows[rowIndex].Cells[3].Value);
            ContactTextBox.Text = Common.Utility.ConvertToString(SupplierDataGridView.Rows[rowIndex].Cells[4].Value);
            SupplierTypeComboBox.SelectedValue = Common.Utility.ConvertToInt(SupplierDataGridView.Rows[rowIndex].Cells[6].Value);

            SetControls();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_supplierIdSelected != null)
            {
                if (!_supplierDAL.Delete((Guid)_supplierIdSelected, MDIParent._loggedInUser.UserId, out string errorMessage))
                {
                    MessageBox.Show(Common.STRINGS.DELETE_ERROR_MESSAGE, Common.STRINGS.DELETE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(NameTextBox.Text.Trim() + " has been deleted successfully.", Common.STRINGS.DELETED, MessageBoxButtons.OK, MessageBoxIcon.Information);

                InitForm();
            }
        }

        private void ContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)||e.KeyChar == (char)Keys.Back);
        }

        private void SearchByNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowDataInGrid();
        }

        public void InitForm()
        {
            _supplierIdSelected = null; // Reset selected ID as null in order to perform Add operation.

            // Reset the form controls.
            Common.Utility.ResetControls(DataEntryPanel);
            Common.Utility.ResetControls(SearchPanel);
            SetControls();
            LoadSupplierTypes();

            ShowDataInGrid();

            NameTextBox.Focus();
        }

        public void SetControls()
        {
            if (_supplierIdSelected == null) // This is Add operation only.
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
            SupplierDataGridView.Rows.Clear();

            // Retrieve the available product categories.
            List<Supplier> suppliers = _supplierDAL.GetAll(SearchByNameTextBox.Text.Trim());

            foreach (Supplier supplier in suppliers)
            {
                int rowIndex = SupplierDataGridView.Rows.Add();
                DataGridViewRow row = SupplierDataGridView.Rows[rowIndex];
                row.Cells["id"].Value = supplier.Id;
                row.Cells["srNumber"].Value = (rowIndex + 1).ToString();
                row.Cells["name"].Value = supplier.Name;
                row.Cells["address"].Value = supplier.Address;
                row.Cells["contact"].Value = supplier.Contact;                
                row.Cells["suppliertypetext"].Value = supplier.SupplierTypeText;
                row.Cells["suppliertype"].Value = supplier.SupplierType;
            }
        }

        public bool ValidateForm(out string errorMessage)
        {
            bool returnValue = true;
            errorMessage = string.Empty;

            if (!Common.Validation.IsNotEmpty(NameTextBox))
            {
                errorMessage = "Name cannot be blank." + Environment.NewLine;
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(AddressTextBox))
            {
                errorMessage += "Address cannot be blank." + Environment.NewLine;
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(ContactTextBox))
            {
                errorMessage += "Contact cannot be blank." + Environment.NewLine;
                returnValue = false;
            }

            if (SupplierTypeComboBox.SelectedIndex < 0)
            {
                errorMessage += "Please select Supplier Type.";
                returnValue = false;
            }

            return returnValue;
        }

        public void LoadSupplierTypes()
        {
            List<KeyValuePair<int, string>> list = Common.SUPPLIERTYPES.GetList();

            SupplierTypeComboBox.DataSource = new BindingSource(list, null);
            SupplierTypeComboBox.DisplayMember = "Value";
            SupplierTypeComboBox.ValueMember = "Key";
        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true; // Block the input
                MessageBox.Show("Please enter only letters in the name field.", Common.STRINGS.DELETED, MessageBoxButtons.OK, MessageBoxIcon.Information); // Show a message to the user
            }
        }

        private void ContactTextBox_Leave(object sender, EventArgs e)
        {
            if (ContactTextBox.Text.Length < 10)
            {
                MessageBox.Show("Contact number should be at least 10 digits long.", Common.STRINGS.DELETED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

    

