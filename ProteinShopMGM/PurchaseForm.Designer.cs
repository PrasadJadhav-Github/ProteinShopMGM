namespace ProteinShopMGM
{
    partial class PurchaseForm
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
            this.MRPTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MRPLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.ExpiryDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.PackingDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.RateLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PackingDateLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.DataEntrySelectionPanel = new System.Windows.Forms.Panel();
            this.PurchaseDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.PurchaseDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.DataEntryPanel.SuspendLayout();
            this.DataEntrySelectionPanel.SuspendLayout();
            this.DataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.SlateGray;
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.ButtonsPanel);
            this.HeaderPanel.Location = new System.Drawing.Point(-1, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1434, 57);
            this.HeaderPanel.TabIndex = 3;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.ResetButton);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(186, 57);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(96, 13);
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
            this.DataEntryPanel.Controls.Add(this.MRPTextBox);
            this.DataEntryPanel.Controls.Add(this.label8);
            this.DataEntryPanel.Controls.Add(this.MRPLabel);
            this.DataEntryPanel.Controls.Add(this.DeleteButton);
            this.DataEntryPanel.Controls.Add(this.UpdateButton);
            this.DataEntryPanel.Controls.Add(this.AddButton);
            this.DataEntryPanel.Controls.Add(this.RateTextBox);
            this.DataEntryPanel.Controls.Add(this.ExpiryDateDTPicker);
            this.DataEntryPanel.Controls.Add(this.label6);
            this.DataEntryPanel.Controls.Add(this.ExpiryDateLabel);
            this.DataEntryPanel.Controls.Add(this.PackingDateDTPicker);
            this.DataEntryPanel.Controls.Add(this.label4);
            this.DataEntryPanel.Controls.Add(this.label3);
            this.DataEntryPanel.Controls.Add(this.label2);
            this.DataEntryPanel.Controls.Add(this.ProductComboBox);
            this.DataEntryPanel.Controls.Add(this.RateLabel);
            this.DataEntryPanel.Controls.Add(this.QuantityTextBox);
            this.DataEntryPanel.Controls.Add(this.QuantityLabel);
            this.DataEntryPanel.Controls.Add(this.label1);
            this.DataEntryPanel.Controls.Add(this.PackingDateLabel);
            this.DataEntryPanel.Controls.Add(this.ProductLabel);
            this.DataEntryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEntryPanel.Location = new System.Drawing.Point(-1, 132);
            this.DataEntryPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataEntryPanel.Name = "DataEntryPanel";
            this.DataEntryPanel.Size = new System.Drawing.Size(401, 503);
            this.DataEntryPanel.TabIndex = 8;
            // 
            // MRPTextBox
            // 
            this.MRPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MRPTextBox.Location = new System.Drawing.Point(22, 411);
            this.MRPTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MRPTextBox.MaxLength = 16;
            this.MRPTextBox.Name = "MRPTextBox";
            this.MRPTextBox.Size = new System.Drawing.Size(357, 27);
            this.MRPTextBox.TabIndex = 15;
            this.MRPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MRPTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(84, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "*";
            // 
            // MRPLabel
            // 
            this.MRPLabel.AutoSize = true;
            this.MRPLabel.Location = new System.Drawing.Point(20, 381);
            this.MRPLabel.Name = "MRPLabel";
            this.MRPLabel.Size = new System.Drawing.Size(46, 20);
            this.MRPLabel.TabIndex = 16;
            this.MRPLabel.Text = "MRP";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(305, 457);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 29);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(223, 457);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 29);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddButton.Location = new System.Drawing.Point(142, 457);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 29);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RateTextBox
            // 
            this.RateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RateTextBox.Location = new System.Drawing.Point(22, 337);
            this.RateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RateTextBox.MaxLength = 16;
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(357, 27);
            this.RateTextBox.TabIndex = 6;
            this.RateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RateTextBox_KeyPress);
            // 
            // ExpiryDateDTPicker
            // 
            this.ExpiryDateDTPicker.Location = new System.Drawing.Point(20, 195);
            this.ExpiryDateDTPicker.Name = "ExpiryDateDTPicker";
            this.ExpiryDateDTPicker.Size = new System.Drawing.Size(357, 27);
            this.ExpiryDateDTPicker.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(136, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "*";
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.AutoSize = true;
            this.ExpiryDateLabel.Location = new System.Drawing.Point(15, 165);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.Size = new System.Drawing.Size(96, 20);
            this.ExpiryDateLabel.TabIndex = 13;
            this.ExpiryDateLabel.Text = "Expiry Date";
            // 
            // PackingDateDTPicker
            // 
            this.PackingDateDTPicker.Location = new System.Drawing.Point(20, 122);
            this.PackingDateDTPicker.Name = "PackingDateDTPicker";
            this.PackingDateDTPicker.Size = new System.Drawing.Size(357, 27);
            this.PackingDateDTPicker.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(84, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(101, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(136, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(20, 51);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(357, 28);
            this.ProductComboBox.TabIndex = 2;
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(20, 307);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(44, 20);
            this.RateLabel.TabIndex = 7;
            this.RateLabel.Text = "Rate";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityTextBox.Location = new System.Drawing.Point(20, 266);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityTextBox.MaxLength = 16;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(357, 27);
            this.QuantityTextBox.TabIndex = 5;
            this.QuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(16, 235);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(71, 20);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // PackingDateLabel
            // 
            this.PackingDateLabel.AutoSize = true;
            this.PackingDateLabel.Location = new System.Drawing.Point(15, 92);
            this.PackingDateLabel.Name = "PackingDateLabel";
            this.PackingDateLabel.Size = new System.Drawing.Size(109, 20);
            this.PackingDateLabel.TabIndex = 2;
            this.PackingDateLabel.Text = "Packing Date";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(13, 21);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(67, 20);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Product";
            // 
            // DataEntrySelectionPanel
            // 
            this.DataEntrySelectionPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataEntrySelectionPanel.Controls.Add(this.PurchaseDateDTPicker);
            this.DataEntrySelectionPanel.Controls.Add(this.label7);
            this.DataEntrySelectionPanel.Controls.Add(this.PurchaseDateLabel);
            this.DataEntrySelectionPanel.Controls.Add(this.label5);
            this.DataEntrySelectionPanel.Controls.Add(this.SupplierComboBox);
            this.DataEntrySelectionPanel.Controls.Add(this.SupplierLabel);
            this.DataEntrySelectionPanel.Location = new System.Drawing.Point(0, 56);
            this.DataEntrySelectionPanel.Name = "DataEntrySelectionPanel";
            this.DataEntrySelectionPanel.Size = new System.Drawing.Size(1433, 77);
            this.DataEntrySelectionPanel.TabIndex = 9;
            // 
            // PurchaseDateDTPicker
            // 
            this.PurchaseDateDTPicker.Location = new System.Drawing.Point(407, 38);
            this.PurchaseDateDTPicker.Name = "PurchaseDateDTPicker";
            this.PurchaseDateDTPicker.Size = new System.Drawing.Size(354, 27);
            this.PurchaseDateDTPicker.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(549, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // PurchaseDateLabel
            // 
            this.PurchaseDateLabel.AutoSize = true;
            this.PurchaseDateLabel.Location = new System.Drawing.Point(403, 9);
            this.PurchaseDateLabel.Name = "PurchaseDateLabel";
            this.PurchaseDateLabel.Size = new System.Drawing.Size(121, 20);
            this.PurchaseDateLabel.TabIndex = 15;
            this.PurchaseDateLabel.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(112, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(16, 38);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(353, 28);
            this.SupplierComboBox.TabIndex = 0;
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Location = new System.Drawing.Point(12, 9);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(70, 20);
            this.SupplierLabel.TabIndex = 13;
            this.SupplierLabel.Text = "Supplier";
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.BackColor = System.Drawing.Color.White;
            this.DataGridPanel.Controls.Add(this.ProductDataGridView);
            this.DataGridPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridPanel.Location = new System.Drawing.Point(402, 132);
            this.DataGridPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(1031, 503);
            this.DataGridPanel.TabIndex = 10;
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
            this.code,
            this.name,
            this.quantity,
            this.rate,
            this.packingdate,
            this.expirydate,
            this.mrp});
            this.ProductDataGridView.Location = new System.Drawing.Point(-1, 0);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersWidth = 51;
            this.ProductDataGridView.RowTemplate.Height = 24;
            this.ProductDataGridView.Size = new System.Drawing.Size(1032, 503);
            this.ProductDataGridView.TabIndex = 10;
            this.ProductDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellClick);
            // 
            // productid
            // 
            this.productid.HeaderText = "ID";
            this.productid.MinimumWidth = 6;
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Visible = false;
            this.productid.Width = 125;
            // 
            // srNumber
            // 
            this.srNumber.HeaderText = "Sr. No.";
            this.srNumber.MinimumWidth = 6;
            this.srNumber.Name = "srNumber";
            this.srNumber.ReadOnly = true;
            this.srNumber.Width = 110;
            // 
            // code
            // 
            this.code.HeaderText = "Product Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 110;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.MinimumWidth = 6;
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.Width = 110;
            // 
            // packingdate
            // 
            this.packingdate.HeaderText = "Packing Date";
            this.packingdate.MinimumWidth = 6;
            this.packingdate.Name = "packingdate";
            this.packingdate.ReadOnly = true;
            this.packingdate.Width = 150;
            // 
            // expirydate
            // 
            this.expirydate.HeaderText = "Expiry Date";
            this.expirydate.MinimumWidth = 6;
            this.expirydate.Name = "expirydate";
            this.expirydate.ReadOnly = true;
            this.expirydate.Width = 125;
            // 
            // mrp
            // 
            this.mrp.HeaderText = "MRP";
            this.mrp.MinimumWidth = 6;
            this.mrp.Name = "mrp";
            this.mrp.ReadOnly = true;
            this.mrp.Width = 115;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 638);
            this.Controls.Add(this.DataGridPanel);
            this.Controls.Add(this.DataEntrySelectionPanel);
            this.Controls.Add(this.DataEntryPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New Purchase Entry";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            this.DataEntrySelectionPanel.ResumeLayout(false);
            this.DataEntrySelectionPanel.PerformLayout();
            this.DataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel DataEntryPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PackingDateLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Panel DataEntrySelectionPanel;
        private System.Windows.Forms.DateTimePicker PurchaseDateDTPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PurchaseDateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.DateTimePicker PackingDateDTPicker;
        private System.Windows.Forms.DateTimePicker ExpiryDateDTPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ExpiryDateLabel;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox MRPTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MRPLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrp;
    }
}