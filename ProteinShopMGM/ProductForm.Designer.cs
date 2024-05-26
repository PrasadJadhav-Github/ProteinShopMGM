namespace ProteinShopMGM
{
    partial class ProductForm
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DataEntryPanel = new System.Windows.Forms.Panel();
            this.UOMComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.ReorderLevelLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProductCodeTextBox = new System.Windows.Forms.TextBox();
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchByCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByCategoryLabel = new System.Windows.Forms.Label();
            this.SearchByNameLabel = new System.Windows.Forms.Label();
            this.SearchByNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.DataEntryPanel.SuspendLayout();
            this.DataGridPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.SlateGray;
            this.HeaderPanel.Controls.Add(this.ButtonsPanel);
            this.HeaderPanel.Location = new System.Drawing.Point(-1, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1491, 57);
            this.HeaderPanel.TabIndex = 7;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.DeleteButton);
            this.ButtonsPanel.Controls.Add(this.ResetButton);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(281, 57);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightSalmon;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(95, 14);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(92, 32);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(195, 14);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 32);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightBlue;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(12, 14);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 32);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataEntryPanel
            // 
            this.DataEntryPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataEntryPanel.Controls.Add(this.UOMComboBox);
            this.DataEntryPanel.Controls.Add(this.label4);
            this.DataEntryPanel.Controls.Add(this.ReorderLevelTextBox);
            this.DataEntryPanel.Controls.Add(this.ReorderLevelLabel);
            this.DataEntryPanel.Controls.Add(this.DescriptionTextBox);
            this.DataEntryPanel.Controls.Add(this.DescriptionLabel);
            this.DataEntryPanel.Controls.Add(this.label7);
            this.DataEntryPanel.Controls.Add(this.SizeTextBox);
            this.DataEntryPanel.Controls.Add(this.SizeLabel);
            this.DataEntryPanel.Controls.Add(this.label6);
            this.DataEntryPanel.Controls.Add(this.PriceTextBox);
            this.DataEntryPanel.Controls.Add(this.PriceLabel);
            this.DataEntryPanel.Controls.Add(this.label3);
            this.DataEntryPanel.Controls.Add(this.label2);
            this.DataEntryPanel.Controls.Add(this.ProductCategoryComboBox);
            this.DataEntryPanel.Controls.Add(this.ProductCategoryLabel);
            this.DataEntryPanel.Controls.Add(this.label1);
            this.DataEntryPanel.Controls.Add(this.NameTextBox);
            this.DataEntryPanel.Controls.Add(this.NameLabel);
            this.DataEntryPanel.Controls.Add(this.ProductCodeTextBox);
            this.DataEntryPanel.Controls.Add(this.ProductCodeLabel);
            this.DataEntryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEntryPanel.Location = new System.Drawing.Point(-1, 56);
            this.DataEntryPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataEntryPanel.Name = "DataEntryPanel";
            this.DataEntryPanel.Size = new System.Drawing.Size(403, 767);
            this.DataEntryPanel.TabIndex = 8;
            // 
            // UOMComboBox
            // 
            this.UOMComboBox.FormattingEnabled = true;
            this.UOMComboBox.Items.AddRange(new object[] {
            "Kg.",
            "gm."});
            this.UOMComboBox.Location = new System.Drawing.Point(313, 429);
            this.UOMComboBox.Name = "UOMComboBox";
            this.UOMComboBox.Size = new System.Drawing.Size(61, 28);
            this.UOMComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(145, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "*";
            // 
            // ReorderLevelTextBox
            // 
            this.ReorderLevelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReorderLevelTextBox.Location = new System.Drawing.Point(20, 708);
            this.ReorderLevelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReorderLevelTextBox.MaxLength = 10;
            this.ReorderLevelTextBox.Name = "ReorderLevelTextBox";
            this.ReorderLevelTextBox.Size = new System.Drawing.Size(357, 27);
            this.ReorderLevelTextBox.TabIndex = 7;
            this.ReorderLevelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReorderLevelTextBox_KeyPress);
            // 
            // ReorderLevelLabel
            // 
            this.ReorderLevelLabel.AutoSize = true;
            this.ReorderLevelLabel.Location = new System.Drawing.Point(16, 670);
            this.ReorderLevelLabel.Name = "ReorderLevelLabel";
            this.ReorderLevelLabel.Size = new System.Drawing.Size(114, 20);
            this.ReorderLevelLabel.TabIndex = 27;
            this.ReorderLevelLabel.Text = "Reorder Level";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.Location = new System.Drawing.Point(17, 527);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionTextBox.MaxLength = 512;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(357, 119);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 489);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(95, 20);
            this.DescriptionLabel.TabIndex = 25;
            this.DescriptionLabel.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(72, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "*";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SizeTextBox.Location = new System.Drawing.Point(18, 430);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeTextBox.MaxLength = 10;
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(289, 27);
            this.SizeTextBox.TabIndex = 4;
            this.SizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeTextBox_KeyPress);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(15, 394);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(42, 20);
            this.SizeLabel.TabIndex = 22;
            this.SizeLabel.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(88, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "*";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTextBox.Location = new System.Drawing.Point(18, 343);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceTextBox.MaxLength = 10;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(357, 27);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(16, 299);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(48, 20);
            this.PriceLabel.TabIndex = 19;
            this.PriceLabel.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(172, 198);
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
            this.label2.Location = new System.Drawing.Point(88, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(17, 245);
            this.ProductCategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(353, 28);
            this.ProductCategoryComboBox.TabIndex = 2;
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Location = new System.Drawing.Point(15, 198);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(139, 20);
            this.ProductCategoryLabel.TabIndex = 7;
            this.ProductCategoryLabel.Text = "Product Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(143, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(17, 148);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.MaxLength = 256;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(357, 27);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(16, 105);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCodeTextBox.Location = new System.Drawing.Point(17, 61);
            this.ProductCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductCodeTextBox.MaxLength = 64;
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(357, 27);
            this.ProductCodeTextBox.TabIndex = 0;
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.AutoSize = true;
            this.ProductCodeLabel.Location = new System.Drawing.Point(13, 21);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(111, 20);
            this.ProductCodeLabel.TabIndex = 0;
            this.ProductCodeLabel.Text = "Product Code";
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.BackColor = System.Drawing.Color.White;
            this.DataGridPanel.Controls.Add(this.SearchPanel);
            this.DataGridPanel.Controls.Add(this.ProductDataGridView);
            this.DataGridPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridPanel.Location = new System.Drawing.Point(401, 56);
            this.DataGridPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(1089, 767);
            this.DataGridPanel.TabIndex = 9;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SearchPanel.Controls.Add(this.SearchByCategoryComboBox);
            this.SearchPanel.Controls.Add(this.SearchByCategoryLabel);
            this.SearchPanel.Controls.Add(this.SearchByNameLabel);
            this.SearchPanel.Controls.Add(this.SearchByNameTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(-2, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1091, 43);
            this.SearchPanel.TabIndex = 10;
            // 
            // SearchByCategoryComboBox
            // 
            this.SearchByCategoryComboBox.FormattingEnabled = true;
            this.SearchByCategoryComboBox.Location = new System.Drawing.Point(639, 5);
            this.SearchByCategoryComboBox.Name = "SearchByCategoryComboBox";
            this.SearchByCategoryComboBox.Size = new System.Drawing.Size(282, 28);
            this.SearchByCategoryComboBox.TabIndex = 12;
            this.SearchByCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchByCategoryComboBox_SelectedIndexChanged);
            // 
            // SearchByCategoryLabel
            // 
            this.SearchByCategoryLabel.AutoSize = true;
            this.SearchByCategoryLabel.Location = new System.Drawing.Point(451, 8);
            this.SearchByCategoryLabel.Name = "SearchByCategoryLabel";
            this.SearchByCategoryLabel.Size = new System.Drawing.Size(156, 20);
            this.SearchByCategoryLabel.TabIndex = 2;
            this.SearchByCategoryLabel.Text = "Search by Category";
            // 
            // SearchByNameLabel
            // 
            this.SearchByNameLabel.AutoSize = true;
            this.SearchByNameLabel.Location = new System.Drawing.Point(0, 9);
            this.SearchByNameLabel.Name = "SearchByNameLabel";
            this.SearchByNameLabel.Size = new System.Drawing.Size(133, 20);
            this.SearchByNameLabel.TabIndex = 1;
            this.SearchByNameLabel.Text = "Search by Name";
            // 
            // SearchByNameTextBox
            // 
            this.SearchByNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByNameTextBox.Location = new System.Drawing.Point(169, 5);
            this.SearchByNameTextBox.Name = "SearchByNameTextBox";
            this.SearchByNameTextBox.Size = new System.Drawing.Size(253, 27);
            this.SearchByNameTextBox.TabIndex = 11;
            this.SearchByNameTextBox.TextChanged += new System.EventHandler(this.SearchByNameTextBox_TextChanged);
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.srNumber,
            this.code,
            this.name,
            this.productcategoryname,
            this.price,
            this.size,
            this.description,
            this.productcategoryid,
            this.reorderlevel});
            this.ProductDataGridView.Location = new System.Drawing.Point(0, 43);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersWidth = 51;
            this.ProductDataGridView.RowTemplate.Height = 24;
            this.ProductDataGridView.Size = new System.Drawing.Size(1087, 724);
            this.ProductDataGridView.TabIndex = 9;
            this.ProductDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // srNumber
            // 
            this.srNumber.HeaderText = "Sr. No.";
            this.srNumber.MinimumWidth = 6;
            this.srNumber.Name = "srNumber";
            this.srNumber.ReadOnly = true;
            this.srNumber.Width = 80;
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // productcategoryname
            // 
            this.productcategoryname.HeaderText = "Product-Category";
            this.productcategoryname.MinimumWidth = 6;
            this.productcategoryname.Name = "productcategoryname";
            this.productcategoryname.ReadOnly = true;
            this.productcategoryname.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 50;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // productcategoryid
            // 
            this.productcategoryid.HeaderText = "";
            this.productcategoryid.MinimumWidth = 6;
            this.productcategoryid.Name = "productcategoryid";
            this.productcategoryid.ReadOnly = true;
            this.productcategoryid.Visible = false;
            this.productcategoryid.Width = 125;
            // 
            // reorderlevel
            // 
            this.reorderlevel.HeaderText = "Reorder Level";
            this.reorderlevel.MinimumWidth = 6;
            this.reorderlevel.Name = "reorderlevel";
            this.reorderlevel.ReadOnly = true;
            this.reorderlevel.Width = 125;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 831);
            this.Controls.Add(this.DataGridPanel);
            this.Controls.Add(this.DataEntryPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Click += new System.EventHandler(this.ProductForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            this.DataGridPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel DataEntryPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ProductCodeTextBox;
        private System.Windows.Forms.Label ProductCodeLabel;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReorderLevelTextBox;
        private System.Windows.Forms.Label ReorderLevelLabel;
        private System.Windows.Forms.ComboBox UOMComboBox;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label SearchByNameLabel;
        private System.Windows.Forms.TextBox SearchByNameTextBox;
        private System.Windows.Forms.Label SearchByCategoryLabel;
        private System.Windows.Forms.ComboBox SearchByCategoryComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcategoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcategoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderlevel;
    }
}