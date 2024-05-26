namespace ProteinShopMGM
{
    partial class ProductCategoryForm
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
            this.SubCategoryNameHelpLabel = new System.Windows.Forms.Label();
            this.SubCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.SubCategoryNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchByNameLabel = new System.Windows.Forms.Label();
            this.SearchByNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.srNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.DataEntryPanel.SuspendLayout();
            this.DataGridPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.SlateGray;
            this.HeaderPanel.Controls.Add(this.ButtonsPanel);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1076, 57);
            this.HeaderPanel.TabIndex = 2;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.DeleteButton);
            this.ButtonsPanel.Controls.Add(this.ResetButton);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(269, 57);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightSalmon;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(97, 13);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(181, 13);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 32);
            this.ResetButton.TabIndex = 5;
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
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataEntryPanel
            // 
            this.DataEntryPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataEntryPanel.Controls.Add(this.SubCategoryNameHelpLabel);
            this.DataEntryPanel.Controls.Add(this.SubCategoryNameTextBox);
            this.DataEntryPanel.Controls.Add(this.SubCategoryNameLabel);
            this.DataEntryPanel.Controls.Add(this.label1);
            this.DataEntryPanel.Controls.Add(this.DescriptionTextBox);
            this.DataEntryPanel.Controls.Add(this.DescriptionLabel);
            this.DataEntryPanel.Controls.Add(this.NameTextBox);
            this.DataEntryPanel.Controls.Add(this.NameLabel);
            this.DataEntryPanel.Location = new System.Drawing.Point(0, 56);
            this.DataEntryPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataEntryPanel.Name = "DataEntryPanel";
            this.DataEntryPanel.Size = new System.Drawing.Size(401, 395);
            this.DataEntryPanel.TabIndex = 3;
            // 
            // SubCategoryNameHelpLabel
            // 
            this.SubCategoryNameHelpLabel.AutoSize = true;
            this.SubCategoryNameHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCategoryNameHelpLabel.ForeColor = System.Drawing.Color.Red;
            this.SubCategoryNameHelpLabel.Location = new System.Drawing.Point(17, 353);
            this.SubCategoryNameHelpLabel.Name = "SubCategoryNameHelpLabel";
            this.SubCategoryNameHelpLabel.Size = new System.Drawing.Size(209, 16);
            this.SubCategoryNameHelpLabel.TabIndex = 7;
            this.SubCategoryNameHelpLabel.Text = "If it has a sub-category then fill this.";
            // 
            // SubCategoryNameTextBox
            // 
            this.SubCategoryNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubCategoryNameTextBox.Location = new System.Drawing.Point(19, 306);
            this.SubCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubCategoryNameTextBox.MaxLength = 64;
            this.SubCategoryNameTextBox.Name = "SubCategoryNameTextBox";
            this.SubCategoryNameTextBox.Size = new System.Drawing.Size(357, 27);
            this.SubCategoryNameTextBox.TabIndex = 2;
            // 
            // SubCategoryNameLabel
            // 
            this.SubCategoryNameLabel.AutoSize = true;
            this.SubCategoryNameLabel.Location = new System.Drawing.Point(16, 269);
            this.SubCategoryNameLabel.Name = "SubCategoryNameLabel";
            this.SubCategoryNameLabel.Size = new System.Drawing.Size(160, 20);
            this.SubCategoryNameLabel.TabIndex = 5;
            this.SubCategoryNameLabel.Text = "Sub-Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.Location = new System.Drawing.Point(20, 124);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionTextBox.MaxLength = 1024;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(357, 122);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(15, 92);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(95, 20);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(17, 52);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.MaxLength = 64;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(357, 27);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.Controls.Add(this.SearchPanel);
            this.DataGridPanel.Controls.Add(this.ProductCategoryDataGridView);
            this.DataGridPanel.Location = new System.Drawing.Point(399, 56);
            this.DataGridPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(677, 395);
            this.DataGridPanel.TabIndex = 4;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SearchPanel.Controls.Add(this.SearchByNameLabel);
            this.SearchPanel.Controls.Add(this.SearchByNameTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(677, 46);
            this.SearchPanel.TabIndex = 1;
            // 
            // SearchByNameLabel
            // 
            this.SearchByNameLabel.AutoSize = true;
            this.SearchByNameLabel.Location = new System.Drawing.Point(0, 8);
            this.SearchByNameLabel.Name = "SearchByNameLabel";
            this.SearchByNameLabel.Size = new System.Drawing.Size(133, 20);
            this.SearchByNameLabel.TabIndex = 1;
            this.SearchByNameLabel.Text = "Search by Name";
            // 
            // SearchByNameTextBox
            // 
            this.SearchByNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByNameTextBox.Location = new System.Drawing.Point(139, 5);
            this.SearchByNameTextBox.Name = "SearchByNameTextBox";
            this.SearchByNameTextBox.Size = new System.Drawing.Size(253, 27);
            this.SearchByNameTextBox.TabIndex = 6;
            this.SearchByNameTextBox.TextChanged += new System.EventHandler(this.SearchByNameTextBox_TextChanged);
            // 
            // ProductCategoryDataGridView
            // 
            this.ProductCategoryDataGridView.AllowUserToAddRows = false;
            this.ProductCategoryDataGridView.AllowUserToDeleteRows = false;
            this.ProductCategoryDataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.ProductCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srNumber,
            this.name,
            this.description,
            this.subcategoryname,
            this.id});
            this.ProductCategoryDataGridView.Location = new System.Drawing.Point(1, 46);
            this.ProductCategoryDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductCategoryDataGridView.Name = "ProductCategoryDataGridView";
            this.ProductCategoryDataGridView.ReadOnly = true;
            this.ProductCategoryDataGridView.RowHeadersWidth = 51;
            this.ProductCategoryDataGridView.RowTemplate.Height = 24;
            this.ProductCategoryDataGridView.Size = new System.Drawing.Size(676, 349);
            this.ProductCategoryDataGridView.TabIndex = 7;
            this.ProductCategoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductCategoryDataGridView_CellClick);
            // 
            // srNumber
            // 
            this.srNumber.HeaderText = "Sr. No.";
            this.srNumber.MinimumWidth = 6;
            this.srNumber.Name = "srNumber";
            this.srNumber.ReadOnly = true;
            this.srNumber.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 175;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 175;
            // 
            // subcategoryname
            // 
            this.subcategoryname.HeaderText = "Sub-Category";
            this.subcategoryname.MinimumWidth = 6;
            this.subcategoryname.Name = "subcategoryname";
            this.subcategoryname.ReadOnly = true;
            this.subcategoryname.Width = 175;
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
            // ProductCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 456);
            this.Controls.Add(this.DataGridPanel);
            this.Controls.Add(this.DataEntryPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Product Category";
            this.Load += new System.EventHandler(this.ProductCategoryForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            this.DataGridPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCategoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel DataEntryPanel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.DataGridView ProductCategoryDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubCategoryNameTextBox;
        private System.Windows.Forms.Label SubCategoryNameLabel;
        private System.Windows.Forms.Label SubCategoryNameHelpLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label SearchByNameLabel;
        private System.Windows.Forms.TextBox SearchByNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}