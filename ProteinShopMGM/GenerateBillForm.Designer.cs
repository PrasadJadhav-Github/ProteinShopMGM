namespace ProteinShopMGM
{
    partial class GenerateBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateBillForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DataEntrySelectionPanel = new System.Windows.Forms.Panel();
            this.RefreshCustomersButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.BillDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BillDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.DataEntryPanel = new System.Windows.Forms.Panel();
            this.StockInfoLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTotalPanel = new System.Windows.Forms.Panel();
            this.NetTotalLabel = new System.Windows.Forms.Label();
            this.DiscountPercentlabel = new System.Windows.Forms.Label();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.DataEntrySelectionPanel.SuspendLayout();
            this.DataEntryPanel.SuspendLayout();
            this.DataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.BillTotalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.SlateGray;
            this.HeaderPanel.Controls.Add(this.ButtonsPanel);
            this.HeaderPanel.Location = new System.Drawing.Point(-1, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1311, 57);
            this.HeaderPanel.TabIndex = 4;
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
            // DataEntrySelectionPanel
            // 
            this.DataEntrySelectionPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataEntrySelectionPanel.Controls.Add(this.RefreshCustomersButton);
            this.DataEntrySelectionPanel.Controls.Add(this.AddCustomerButton);
            this.DataEntrySelectionPanel.Controls.Add(this.BillDateDTPicker);
            this.DataEntrySelectionPanel.Controls.Add(this.label7);
            this.DataEntrySelectionPanel.Controls.Add(this.BillDateLabel);
            this.DataEntrySelectionPanel.Controls.Add(this.label5);
            this.DataEntrySelectionPanel.Controls.Add(this.CustomerComboBox);
            this.DataEntrySelectionPanel.Controls.Add(this.CustomerLabel);
            this.DataEntrySelectionPanel.Location = new System.Drawing.Point(-1, 56);
            this.DataEntrySelectionPanel.Name = "DataEntrySelectionPanel";
            this.DataEntrySelectionPanel.Size = new System.Drawing.Size(1311, 77);
            this.DataEntrySelectionPanel.TabIndex = 10;
            // 
            // RefreshCustomersButton
            // 
            this.RefreshCustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshCustomersButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshCustomersButton.Image")));
            this.RefreshCustomersButton.Location = new System.Drawing.Point(419, 38);
            this.RefreshCustomersButton.Name = "RefreshCustomersButton";
            this.RefreshCustomersButton.Size = new System.Drawing.Size(51, 28);
            this.RefreshCustomersButton.TabIndex = 2;
            this.RefreshCustomersButton.UseVisualStyleBackColor = true;
            this.RefreshCustomersButton.Click += new System.EventHandler(this.RefreshCustomersButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(367, 38);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(51, 28);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // BillDateDTPicker
            // 
            this.BillDateDTPicker.Location = new System.Drawing.Point(494, 38);
            this.BillDateDTPicker.Name = "BillDateDTPicker";
            this.BillDateDTPicker.Size = new System.Drawing.Size(354, 27);
            this.BillDateDTPicker.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(565, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // BillDateLabel
            // 
            this.BillDateLabel.AutoSize = true;
            this.BillDateLabel.Location = new System.Drawing.Point(490, 9);
            this.BillDateLabel.Name = "BillDateLabel";
            this.BillDateLabel.Size = new System.Drawing.Size(45, 20);
            this.BillDateLabel.TabIndex = 15;
            this.BillDateLabel.Text = "Date";
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
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(16, 38);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(349, 28);
            this.CustomerComboBox.TabIndex = 0;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(12, 9);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(82, 20);
            this.CustomerLabel.TabIndex = 13;
            this.CustomerLabel.Text = "Customer";
            // 
            // DataEntryPanel
            // 
            this.DataEntryPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataEntryPanel.Controls.Add(this.StockInfoLabel);
            this.DataEntryPanel.Controls.Add(this.DeleteButton);
            this.DataEntryPanel.Controls.Add(this.UpdateButton);
            this.DataEntryPanel.Controls.Add(this.AddButton);
            this.DataEntryPanel.Controls.Add(this.PriceTextBox);
            this.DataEntryPanel.Controls.Add(this.label4);
            this.DataEntryPanel.Controls.Add(this.label3);
            this.DataEntryPanel.Controls.Add(this.ProductComboBox);
            this.DataEntryPanel.Controls.Add(this.PriceLabel);
            this.DataEntryPanel.Controls.Add(this.QuantityTextBox);
            this.DataEntryPanel.Controls.Add(this.QuantityLabel);
            this.DataEntryPanel.Controls.Add(this.label1);
            this.DataEntryPanel.Controls.Add(this.ProductLabel);
            this.DataEntryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEntryPanel.Location = new System.Drawing.Point(-1, 132);
            this.DataEntryPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataEntryPanel.Name = "DataEntryPanel";
            this.DataEntryPanel.Size = new System.Drawing.Size(401, 359);
            this.DataEntryPanel.TabIndex = 11;
            // 
            // StockInfoLabel
            // 
            this.StockInfoLabel.AutoSize = true;
            this.StockInfoLabel.Location = new System.Drawing.Point(16, 97);
            this.StockInfoLabel.Name = "StockInfoLabel";
            this.StockInfoLabel.Size = new System.Drawing.Size(69, 20);
            this.StockInfoLabel.TabIndex = 12;
            this.StockInfoLabel.Text = "In Stock";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(304, 303);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 29);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(222, 303);
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
            this.AddButton.Location = new System.Drawing.Point(141, 303);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 29);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTextBox.Location = new System.Drawing.Point(19, 164);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceTextBox.MaxLength = 12;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(357, 27);
            this.PriceTextBox.TabIndex = 5;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(81, 133);
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
            this.label3.Location = new System.Drawing.Point(100, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "*";
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(20, 51);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(357, 28);
            this.ProductComboBox.TabIndex = 4;
            this.ProductComboBox.SelectedValueChanged += new System.EventHandler(this.ProductComboBox_SelectedValueChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(17, 134);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(48, 20);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "Price";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityTextBox.Location = new System.Drawing.Point(19, 249);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityTextBox.MaxLength = 3;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(357, 27);
            this.QuantityTextBox.TabIndex = 6;
            this.QuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
            this.QuantityTextBox.Leave += new System.EventHandler(this.QuantityTextBox_Leave);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(15, 218);
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
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(13, 21);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(67, 20);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Product";
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.BackColor = System.Drawing.Color.White;
            this.DataGridPanel.Controls.Add(this.ProductDataGridView);
            this.DataGridPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridPanel.Location = new System.Drawing.Point(399, 132);
            this.DataGridPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(911, 359);
            this.DataGridPanel.TabIndex = 12;
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
            this.price});
            this.ProductDataGridView.Location = new System.Drawing.Point(1, 1);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersWidth = 51;
            this.ProductDataGridView.RowTemplate.Height = 24;
            this.ProductDataGridView.Size = new System.Drawing.Size(907, 358);
            this.ProductDataGridView.TabIndex = 13;
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
            this.srNumber.Width = 125;
            // 
            // code
            // 
            this.code.HeaderText = "Product Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 200;
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // BillTotalPanel
            // 
            this.BillTotalPanel.Controls.Add(this.NetTotalLabel);
            this.BillTotalPanel.Controls.Add(this.DiscountPercentlabel);
            this.BillTotalPanel.Controls.Add(this.DiscountTextBox);
            this.BillTotalPanel.Controls.Add(this.DiscountLabel);
            this.BillTotalPanel.Controls.Add(this.TotalLabel);
            this.BillTotalPanel.Location = new System.Drawing.Point(-1, 494);
            this.BillTotalPanel.Name = "BillTotalPanel";
            this.BillTotalPanel.Size = new System.Drawing.Size(1311, 77);
            this.BillTotalPanel.TabIndex = 13;
            // 
            // NetTotalLabel
            // 
            this.NetTotalLabel.AutoSize = true;
            this.NetTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetTotalLabel.Location = new System.Drawing.Point(494, 19);
            this.NetTotalLabel.Name = "NetTotalLabel";
            this.NetTotalLabel.Size = new System.Drawing.Size(98, 20);
            this.NetTotalLabel.TabIndex = 4;
            this.NetTotalLabel.Text = "Net Total :";
            // 
            // DiscountPercentlabel
            // 
            this.DiscountPercentlabel.AutoSize = true;
            this.DiscountPercentlabel.Location = new System.Drawing.Point(406, 20);
            this.DiscountPercentlabel.Name = "DiscountPercentlabel";
            this.DiscountPercentlabel.Size = new System.Drawing.Size(24, 20);
            this.DiscountPercentlabel.TabIndex = 3;
            this.DiscountPercentlabel.Text = "%";
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(334, 17);
            this.DiscountTextBox.MaxLength = 2;
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(67, 27);
            this.DiscountTextBox.TabIndex = 10;
            this.DiscountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscountTextBox_KeyPress);
            this.DiscountTextBox.Leave += new System.EventHandler(this.DiscountTextBox_Leave);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(242, 19);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(86, 20);
            this.DiscountLabel.TabIndex = 1;
            this.DiscountLabel.Text = "Discount :";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(24, 20);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(61, 20);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total : ";
            // 
            // GenerateBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 575);
            this.Controls.Add(this.BillTotalPanel);
            this.Controls.Add(this.DataGridPanel);
            this.Controls.Add(this.DataEntryPanel);
            this.Controls.Add(this.DataEntrySelectionPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerateBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generate Bill";
            this.Load += new System.EventHandler(this.GenerateBillForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.DataEntrySelectionPanel.ResumeLayout(false);
            this.DataEntrySelectionPanel.PerformLayout();
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            this.DataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.BillTotalPanel.ResumeLayout(false);
            this.BillTotalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel DataEntrySelectionPanel;
        private System.Windows.Forms.DateTimePicker BillDateDTPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BillDateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button RefreshCustomersButton;
        private System.Windows.Forms.Panel DataEntryPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Panel BillTotalPanel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label NetTotalLabel;
        private System.Windows.Forms.Label DiscountPercentlabel;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label StockInfoLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}