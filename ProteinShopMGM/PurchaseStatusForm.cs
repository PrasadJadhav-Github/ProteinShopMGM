using ProteinShopMGM.DAL;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProteinShopMGM
{
    public partial class PurchaseStatusForm : Form
    {
        private readonly IPurchaseDAL _purchaseDAL = new PurchaseDAL();
        private readonly IPurchaseDetailsDAL _purchaseDetailsDAL = new PurchaseDetailsDAL();
        private readonly IStockDAL _stockDAL = new StockDAL();
        private Guid? _purchaseIdSelected = null;
        private int? _purchaseStatusEx = null;

        public PurchaseStatusForm()
        {
            InitializeComponent();
        }

        private void PurchaseStatusForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_purchaseIdSelected != null)
            {
                int purchaseStatusNew = int.Parse(PurchaseStatusComboBox.SelectedValue.ToString());
                if (_purchaseStatusEx != Common.PURCHASESTATUS.INPROCESS)
                {
                    return;
                }

                if (!_purchaseDAL.UpdateStatus((Guid)_purchaseIdSelected, purchaseStatusNew, MDIParent._loggedInUser.UserId, out string errorMessage)) 
                {
                    MessageBox.Show(Common.STRINGS.SAVE_ERROR_MESSAGE, Common.STRINGS.SAVE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Purchase status has been updated successfully.", Common.STRINGS.SAVED, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (purchaseStatusNew == Common.PURCHASESTATUS.RECEIVED)
                {
                    foreach (DataGridViewRow row in ProductDataGridView.Rows)
                    {
                        Guid productId = Guid.Parse(row.Cells[0].Value.ToString());
                        int quantity = int.Parse(row.Cells[5].Value.ToString());

                        _stockDAL.Save(productId, quantity, MDIParent._loggedInUser.UserId, out errorMessage);
                    }
                }

                InitForm();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InitForm();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            ShowPurchaseDataInGrid();
        }

        private void PurchaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = PurchaseDataGridView.Rows[rowIndex];
            _purchaseIdSelected = Guid.Parse(row.Cells[0].Value.ToString());
            SupplierLabel.Text = "Supplier : " + row.Cells[3].Value.ToString();
            PurchaseDateLabel.Text = "Date : " + DateTime.Parse(row.Cells[4].Value.ToString()).ToString("dd-MM-yyyy");
            _purchaseStatusEx = int.Parse(row.Cells[5].Value.ToString());
            PurchaseStatusComboBox.SelectedValue = int.Parse(row.Cells[5].Value.ToString());

            LoadPurchaseDetails();

            if (_purchaseStatusEx == Common.PURCHASESTATUS.INPROCESS)
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
        }

        public void InitForm()
        {
            // Reset the form controls.
            Common.Utility.ResetControls(DataEntryPanel);
            LoadPurchaseStatus();
            ShowPurchaseDataInGrid();

            _purchaseIdSelected = null;
            _purchaseStatusEx = null;

            SupplierLabel.Text = "Supplier : <Value>";
            PurchaseDateLabel.Text = "Date : <Value>";
            ProductDataGridView.Rows.Clear();

            SaveButton.Enabled = false;

            FromDTPicker.Focus();
        }

        public void LoadPurchaseStatus()
        {
            List<KeyValuePair<int, string>> list = Common.PURCHASESTATUS.GetList();

            PurchaseStatusComboBox.DataSource = new BindingSource(list, null);
            PurchaseStatusComboBox.DisplayMember = "Value";
            PurchaseStatusComboBox.ValueMember = "Key";

            PurchaseStatusFilterComboBox.DataSource = new BindingSource(list, null);
            PurchaseStatusFilterComboBox.DisplayMember = "Value";
            PurchaseStatusFilterComboBox.ValueMember = "Key";
        }

        public void ShowPurchaseDataInGrid()
        {
            // Clear.
            PurchaseDataGridView.Rows.Clear();

            // Retrieve the available purchases.
            int purchaseStatus = ((KeyValuePair<int, string>)PurchaseStatusFilterComboBox.SelectedItem).Key;
            List<Purchase> purchases = _purchaseDAL.GetAll(purchaseStatus, FromDTPicker.Value.Date, ToDTPicker.Value.Date);

            foreach (Purchase purchase in purchases)
            {
                int rowIndex = PurchaseDataGridView.Rows.Add();
                DataGridViewRow row = PurchaseDataGridView.Rows[rowIndex];
                row.Cells["purchaseid"].Value = purchase.Id;
                row.Cells["srNumberPurchase"].Value = (rowIndex + 1).ToString();
                row.Cells["supplierid"].Value = purchase.SupplierId;
                row.Cells["suppliername"].Value = purchase.SupplierName;
                row.Cells["purchasedate"].Value = purchase.PurchaseDate;
                row.Cells["purchasestatus"].Value = purchase.PurchaseStatus;
                row.Cells["purchasestatustext"].Value = purchase.PurchaseStatusText;
            }
        }

        public void LoadPurchaseDetails()
        {
            ProductDataGridView.Rows.Clear();

            if (_purchaseIdSelected != null)
            {
                List<PurchaseDetails> purchaseDetails = _purchaseDetailsDAL.GetAllByPurchaseId((Guid)_purchaseIdSelected);
                if (purchaseDetails != null)
                {
                    foreach (PurchaseDetails purchaseDetail in purchaseDetails)
                    {
                        int rowIndex = ProductDataGridView.Rows.Add();
                        DataGridViewRow row = ProductDataGridView.Rows[rowIndex];
                        row.Cells["productid"].Value = purchaseDetail.ProductId;
                        row.Cells["srNumber"].Value = (rowIndex + 1).ToString();
                        row.Cells["productcode"].Value = purchaseDetail.ProductCode;
                        row.Cells["productname"].Value = purchaseDetail.ProductName;
                        row.Cells["description"].Value = "Quantity : " + purchaseDetail.Quantity  
                            + " Rate : Rs. " + purchaseDetail.Rate;
                        row.Cells["quantity"].Value = purchaseDetail.Quantity;
                    }
                }
            }
        }
    }
}
