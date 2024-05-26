namespace ProteinShopMGM
{
    partial class PurchaseStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DataEntryPanel = new System.Windows.Forms.Panel();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.PurchaseDateLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.PurchaseDetailsLabel = new System.Windows.Forms.Label();
            this.PurchaseStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToDTPicker = new System.Windows.Forms.DateTimePicker();
            this.FromDTPicker = new System.Windows.Forms.DateTimePicker();
            this.PurchaseStatusFilterComboBox = new System.Windows.Forms.ComboBox();
            this.PurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.purchaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNumberPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasestatustext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.DataEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.DataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.SlateGray;
            this.HeaderPanel.Controls.Add(this.ButtonsPanel);
            this.HeaderPanel.Location = new System.Drawing.Point(-1, -1);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1347, 57);
            this.HeaderPanel.TabIndex = 4;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.ResetButton);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(183, 57);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(95, 13);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 32);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightBlue;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(12, 13);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 32);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataEntryPanel
            // 
            this.DataEntryPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataEntryPanel.Controls.Add(this.ProductDataGridView);
            this.DataEntryPanel.Controls.Add(this.PurchaseDateLabel);
            this.DataEntryPanel.Controls.Add(this.SupplierLabel);
            this.DataEntryPanel.Controls.Add(this.PurchaseDetailsLabel);
            this.DataEntryPanel.Controls.Add(this.PurchaseStatusComboBox);
            this.DataEntryPanel.Controls.Add(this.label1);
            this.DataEntryPanel.Controls.Add(this.NameLabel);
            this.DataEntryPanel.Location = new System.Drawing.Point(-1, 55);
            this.DataEntryPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataEntryPanel.Name = "DataEntryPanel";
            this.DataEntryPanel.Size = new System.Drawing.Size(676, 687);
            this.DataEntryPanel.TabIndex = 5;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.srNumber,
            this.productcode,
            this.productname,
            this.description,
            this.quantity});
            this.ProductDataGridView.Location = new System.Drawing.Point(18, 200);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersWidth = 51;
            this.ProductDataGridView.RowTemplate.Height = 24;
            this.ProductDataGridView.Size = new System.Drawing.Size(643, 473);
            this.ProductDataGridView.TabIndex = 12;
            // 
            // PurchaseDateLabel
            // 
            this.PurchaseDateLabel.AutoSize = true;
            this.PurchaseDateLabel.Location = new System.Drawing.Point(17, 168);
            this.PurchaseDateLabel.Name = "PurchaseDateLabel";
            this.PurchaseDateLabel.Size = new System.Drawing.Size(122, 20);
            this.PurchaseDateLabel.TabIndex = 11;
            this.PurchaseDateLabel.Text = "Date : <Value>";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Location = new System.Drawing.Point(16, 133);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(147, 20);
            this.SupplierLabel.TabIndex = 10;
            this.SupplierLabel.Text = "Supplier : <Value>";
            // 
            // PurchaseDetailsLabel
            // 
            this.PurchaseDetailsLabel.AutoSize = true;
            this.PurchaseDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDetailsLabel.Location = new System.Drawing.Point(15, 98);
            this.PurchaseDetailsLabel.Name = "PurchaseDetailsLabel";
            this.PurchaseDetailsLabel.Size = new System.Drawing.Size(154, 20);
            this.PurchaseDetailsLabel.TabIndex = 9;
            this.PurchaseDetailsLabel.Text = "Purchase Details";
            // 
            // PurchaseStatusComboBox
            // 
            this.PurchaseStatusComboBox.FormattingEnabled = true;
            this.PurchaseStatusComboBox.Location = new System.Drawing.Point(18, 49);
            this.PurchaseStatusComboBox.Name = "PurchaseStatusComboBox";
            this.PurchaseStatusComboBox.Size = new System.Drawing.Size(406, 28);
            this.PurchaseStatusComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Status";
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataGridPanel.Controls.Add(this.FilterButton);
            this.DataGridPanel.Controls.Add(this.ToLabel);
            this.DataGridPanel.Controls.Add(this.FromLabel);
            this.DataGridPanel.Controls.Add(this.ToDTPicker);
            this.DataGridPanel.Controls.Add(this.FromDTPicker);
            this.DataGridPanel.Controls.Add(this.PurchaseStatusFilterComboBox);
            this.DataGridPanel.Controls.Add(this.PurchaseDataGridView);
            this.DataGridPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridPanel.Location = new System.Drawing.Point(675, 55);
            this.DataGridPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(671, 687);
            this.DataGridPanel.TabIndex = 11;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(596, 9);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(70, 33);
            this.FilterButton.TabIndex = 17;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(234, 15);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(28, 20);
            this.ToLabel.TabIndex = 16;
            this.ToLabel.Text = "To";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(4, 15);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(48, 20);
            this.FromLabel.TabIndex = 15;
            this.FromLabel.Text = "From";
            // 
            // ToDTPicker
            // 
            this.ToDTPicker.Location = new System.Drawing.Point(270, 12);
            this.ToDTPicker.Name = "ToDTPicker";
            this.ToDTPicker.Size = new System.Drawing.Size(172, 27);
            this.ToDTPicker.TabIndex = 14;
            // 
            // FromDTPicker
            // 
            this.FromDTPicker.Location = new System.Drawing.Point(57, 12);
            this.FromDTPicker.Name = "FromDTPicker";
            this.FromDTPicker.Size = new System.Drawing.Size(173, 27);
            this.FromDTPicker.TabIndex = 13;
            // 
            // PurchaseStatusFilterComboBox
            // 
            this.PurchaseStatusFilterComboBox.FormattingEnabled = true;
            this.PurchaseStatusFilterComboBox.Location = new System.Drawing.Point(449, 12);
            this.PurchaseStatusFilterComboBox.Name = "PurchaseStatusFilterComboBox";
            this.PurchaseStatusFilterComboBox.Size = new System.Drawing.Size(143, 28);
            this.PurchaseStatusFilterComboBox.TabIndex = 12;
            // 
            // PurchaseDataGridView
            // 
            this.PurchaseDataGridView.AllowUserToAddRows = false;
            this.PurchaseDataGridView.AllowUserToDeleteRows = false;
            this.PurchaseDataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseid,
            this.srNumberPurchase,
            this.supplierid,
            this.suppliername,
            this.purchasedate,
            this.purchasestatus,
            this.purchasestatustext});
            this.PurchaseDataGridView.Location = new System.Drawing.Point(7, 49);
            this.PurchaseDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PurchaseDataGridView.Name = "PurchaseDataGridView";
            this.PurchaseDataGridView.ReadOnly = true;
            this.PurchaseDataGridView.RowHeadersWidth = 51;
            this.PurchaseDataGridView.RowTemplate.Height = 24;
            this.PurchaseDataGridView.Size = new System.Drawing.Size(661, 624);
            this.PurchaseDataGridView.TabIndex = 10;
            this.PurchaseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseDataGridView_CellClick);
            // 
            // purchaseid
            // 
            this.purchaseid.HeaderText = "ID";
            this.purchaseid.MinimumWidth = 6;
            this.purchaseid.Name = "purchaseid";
            this.purchaseid.ReadOnly = true;
            this.purchaseid.Visible = false;
            this.purchaseid.Width = 125;
            // 
            // srNumberPurchase
            // 
            this.srNumberPurchase.HeaderText = "Sr. No.";
            this.srNumberPurchase.MinimumWidth = 6;
            this.srNumberPurchase.Name = "srNumberPurchase";
            this.srNumberPurchase.ReadOnly = true;
            this.srNumberPurchase.Width = 125;
            // 
            // supplierid
            // 
            this.supplierid.HeaderText = "";
            this.supplierid.MinimumWidth = 6;
            this.supplierid.Name = "supplierid";
            this.supplierid.ReadOnly = true;
            this.supplierid.Visible = false;
            this.supplierid.Width = 125;
            // 
            // suppliername
            // 
            this.suppliername.HeaderText = "Supplier";
            this.suppliername.MinimumWidth = 6;
            this.suppliername.Name = "suppliername";
            this.suppliername.ReadOnly = true;
            this.suppliername.Width = 125;
            // 
            // purchasedate
            // 
            this.purchasedate.HeaderText = "Purchase Date";
            this.purchasedate.MinimumWidth = 6;
            this.purchasedate.Name = "purchasedate";
            this.purchasedate.ReadOnly = true;
            this.purchasedate.Width = 125;
            // 
            // purchasestatus
            // 
            this.purchasestatus.HeaderText = "";
            this.purchasestatus.MinimumWidth = 6;
            this.purchasestatus.Name = "purchasestatus";
            this.purchasestatus.ReadOnly = true;
            this.purchasestatus.Visible = false;
            this.purchasestatus.Width = 200;
            // 
            // purchasestatustext
            // 
            this.purchasestatustext.HeaderText = "Purchase Status";
            this.purchasestatustext.MinimumWidth = 6;
            this.purchasestatustext.Name = "purchasestatustext";
            this.purchasestatustext.ReadOnly = true;
            this.purchasestatustext.Width = 125;
            // 
            // productid
            // 
            this.productid.HeaderText = "ID";
            this.productid.MinimumWidth = 6;
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Visible = false;
            this.productid.Width = 110;
            // 
            // srNumber
            // 
            this.srNumber.HeaderText = "Sr. No.";
            this.srNumber.MinimumWidth = 6;
            this.srNumber.Name = "srNumber";
            this.srNumber.ReadOnly = true;
            // 
            // productcode
            // 
            this.productcode.HeaderText = "Product Code";
            this.productcode.MinimumWidth = 6;
            this.productcode.Name = "productcode";
            this.productcode.ReadOnly = true;
            this.productcode.Width = 110;
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 150;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // PurchaseStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 746);
            this.Controls.Add(this.DataGridPanel);
            this.Controls.Add(this.DataEntryPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(-1, -1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Set Purchase Status";
            this.Load += new System.EventHandler(this.PurchaseStatusForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.DataGridPanel.ResumeLayout(false);
            this.DataGridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel DataEntryPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox PurchaseStatusComboBox;
        private System.Windows.Forms.Label PurchaseDetailsLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Label PurchaseDateLabel;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.DataGridView PurchaseDataGridView;
        private System.Windows.Forms.ComboBox PurchaseStatusFilterComboBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.DateTimePicker ToDTPicker;
        private System.Windows.Forms.DateTimePicker FromDTPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNumberPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliername;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasestatustext;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}