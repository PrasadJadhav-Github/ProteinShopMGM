using ProteinShopMGM.DAL;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProteinShopMGM
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerDAL _customerDAL = new CustomerDAL();
        private Guid? _customerIdSelected = null; // Specifies selected ID of Product Category in case of Edit / Delete operation.
        private string _formTitle;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            _formTitle = "Customer";
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

            if(ContactTextBox.Text.Length< 11)
            {
                MessageBox.Show("Mobile number must be 10 digit", Common.STRINGS.VALIDATION_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactTextBox.SelectionStart= ContactTextBox.Text.Length;
                return;
            }

            // Input data.
            string name = NameTextBox.Text.Trim();
            string address = AddressTextBox.Text.Trim();
            string contact = ContactTextBox.Text.Trim();           
            int customerType = ((KeyValuePair<int, string>)CustomerTypeComboBox.SelectedItem).Key;

            if (!_customerDAL.Save(_customerIdSelected, name, contact, address, customerType, MDIParent._loggedInUser.UserId, out errorMessage))
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

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }

            _customerIdSelected = Guid.Parse(CustomerDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
            NameTextBox.Text = Common.Utility.ConvertToString(CustomerDataGridView.Rows[rowIndex].Cells[2].Value);
            AddressTextBox.Text = Common.Utility.ConvertToString(CustomerDataGridView.Rows[rowIndex].Cells[3].Value);
            ContactTextBox.Text = Common.Utility.ConvertToString(CustomerDataGridView.Rows[rowIndex].Cells[4].Value);
            CustomerTypeComboBox.SelectedValue = Common.Utility.ConvertToInt(CustomerDataGridView.Rows[rowIndex].Cells[6].Value);

            SetControls();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_customerIdSelected != null)
            {
                if (!_customerDAL.Delete((Guid)_customerIdSelected, MDIParent._loggedInUser.UserId, out string errorMessage))
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

        private void ContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and delete keys
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits in the contact number field.", Common.STRINGS.DELETED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Validate that the contact number is not less than 10 digits
            if (ContactTextBox.Text.Length < 10 && (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return))
            {
                e.Handled = true;
                MessageBox.Show("Contact number should be at least 10 digits long.", Common.STRINGS.DELETED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void InitForm()
        {
            _customerIdSelected = null; // Reset selected ID as null in order to perform Add operation.

            // Reset the form controls.
            Common.Utility.ResetControls(DataEntryPanel);
            Common.Utility.ResetControls(SearchPanel);
            SetControls();
            LoadCustomerTypes();

            ShowDataInGrid();

            NameTextBox.Focus();
        }

        public void SetControls()
        {
            if (_customerIdSelected == null) // This is Add operation only.
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
            CustomerDataGridView.Rows.Clear();

            // Retrieve the available product categories.
            List<Customer> customers = _customerDAL.GetAll(SearchByNameTextBox.Text.Trim());

            foreach (Customer customer in customers)
            {
                int rowIndex = CustomerDataGridView.Rows.Add();
                DataGridViewRow row = CustomerDataGridView.Rows[rowIndex];
                row.Cells["id"].Value = customer.Id;
                row.Cells["srNumber"].Value = (rowIndex + 1).ToString();
                row.Cells["name"].Value = customer.Name;
                row.Cells["contact"].Value = customer.Contact;
                row.Cells["address"].Value = customer.Address;                
                row.Cells["customertypetext"].Value = customer.CustomerTypeText;
                row.Cells["customertype"].Value = customer.CustomerType;
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

            if (CustomerTypeComboBox.SelectedIndex < 0)
            {
                errorMessage += "Please select Customer Type.";
                returnValue = false;
            }

            return returnValue;
        }

        public void LoadCustomerTypes()
        {
            List<KeyValuePair<int, string>> list = Common.CUSTOMERTYPES.GetList();
            CustomerTypeComboBox.DataSource = new BindingSource(list, null);
            CustomerTypeComboBox.DisplayMember = "Value";
            CustomerTypeComboBox.ValueMember = "Key";
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
