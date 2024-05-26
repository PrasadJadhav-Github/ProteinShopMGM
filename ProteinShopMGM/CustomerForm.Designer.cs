namespace ProteinShopMGM
{
    partial class CustomerForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerTypeLabel = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchByNameLabel = new System.Windows.Forms.Label();
            this.SearchByNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertypetext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.DataEntryPanel.SuspendLayout();
            this.DataGridPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.SlateGray;
            this.HeaderPanel.Controls.Add(this.ButtonsPanel);
            this.HeaderPanel.Location = new System.Drawing.Point(-1, -1);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1486, 57);
            this.HeaderPanel.TabIndex = 6;
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
            this.ButtonsPanel.Size = new System.Drawing.Size(280, 57);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightSalmon;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(95, 13);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 32);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(193, 13);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 32);
            this.ResetButton.TabIndex = 6;
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
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataEntryPanel
            // 
            this.DataEntryPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataEntryPanel.Controls.Add(this.label4);
            this.DataEntryPanel.Controls.Add(this.label3);
            this.DataEntryPanel.Controls.Add(this.label2);
            this.DataEntryPanel.Controls.Add(this.CustomerTypeComboBox);
            this.DataEntryPanel.Controls.Add(this.CustomerTypeLabel);
            this.DataEntryPanel.Controls.Add(this.ContactTextBox);
            this.DataEntryPanel.Controls.Add(this.ContactLabel);
            this.DataEntryPanel.Controls.Add(this.label1);
            this.DataEntryPanel.Controls.Add(this.AddressTextBox);
            this.DataEntryPanel.Controls.Add(this.AddressLabel);
            this.DataEntryPanel.Controls.Add(this.NameTextBox);
            this.DataEntryPanel.Controls.Add(this.NameLabel);
            this.DataEntryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEntryPanel.Location = new System.Drawing.Point(-1, 56);
            this.DataEntryPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataEntryPanel.Name = "DataEntryPanel";
            this.DataEntryPanel.Size = new System.Drawing.Size(401, 499);
            this.DataEntryPanel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(161, 381);
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
            this.label3.Location = new System.Drawing.Point(91, 281);
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
            this.label2.Location = new System.Drawing.Point(105, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // CustomerTypeComboBox
            // 
            this.CustomerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerTypeComboBox.FormattingEnabled = true;
            this.CustomerTypeComboBox.Location = new System.Drawing.Point(24, 428);
            this.CustomerTypeComboBox.Name = "CustomerTypeComboBox";
            this.CustomerTypeComboBox.Size = new System.Drawing.Size(353, 28);
            this.CustomerTypeComboBox.TabIndex = 3;
            // 
            // CustomerTypeLabel
            // 
            this.CustomerTypeLabel.AutoSize = true;
            this.CustomerTypeLabel.Location = new System.Drawing.Point(20, 381);
            this.CustomerTypeLabel.Name = "CustomerTypeLabel";
            this.CustomerTypeLabel.Size = new System.Drawing.Size(123, 20);
            this.CustomerTypeLabel.TabIndex = 7;
            this.CustomerTypeLabel.Text = "Customer Type";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactTextBox.Location = new System.Drawing.Point(24, 327);
            this.ContactTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContactTextBox.MaxLength = 10;
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(357, 27);
            this.ContactTextBox.TabIndex = 2;
            this.ContactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactTextBox_KeyPress);
            this.ContactTextBox.Leave += new System.EventHandler(this.ContactTextBox_Leave);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(20, 281);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(67, 20);
            this.ContactLabel.TabIndex = 5;
            this.ContactLabel.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTextBox.Location = new System.Drawing.Point(19, 168);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressTextBox.MaxLength = 1024;
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(357, 91);
            this.AddressTextBox.TabIndex = 1;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(15, 115);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(71, 20);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
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
            this.DataGridPanel.BackColor = System.Drawing.Color.White;
            this.DataGridPanel.Controls.Add(this.SearchPanel);
            this.DataGridPanel.Controls.Add(this.CustomerDataGridView);
            this.DataGridPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridPanel.Location = new System.Drawing.Point(398, 56);
            this.DataGridPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(1087, 498);
            this.DataGridPanel.TabIndex = 8;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SearchPanel.Controls.Add(this.SearchByNameLabel);
            this.SearchPanel.Controls.Add(this.SearchByNameTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(1, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1086, 37);
            this.SearchPanel.TabIndex = 3;
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
            this.SearchByNameTextBox.TabIndex = 7;
            this.SearchByNameTextBox.TextChanged += new System.EventHandler(this.SearchByNameTextBox_TextChanged);
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AllowUserToAddRows = false;
            this.CustomerDataGridView.AllowUserToDeleteRows = false;
            this.CustomerDataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.srNumber,
            this.name,
            this.address,
            this.contact,
            this.customertypetext,
            this.customertype});
            this.CustomerDataGridView.Location = new System.Drawing.Point(1, 38);
            this.CustomerDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.ReadOnly = true;
            this.CustomerDataGridView.RowHeadersWidth = 51;
            this.CustomerDataGridView.RowTemplate.Height = 24;
            this.CustomerDataGridView.Size = new System.Drawing.Size(1086, 460);
            this.CustomerDataGridView.TabIndex = 8;
            this.CustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellClick);
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
            this.srNumber.Width = 204;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 205;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 204;
            // 
            // contact
            // 
            this.contact.HeaderText = "Contact";
            this.contact.MinimumWidth = 6;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Width = 205;
            // 
            // customertypetext
            // 
            this.customertypetext.HeaderText = "Customer-Type";
            this.customertypetext.MinimumWidth = 6;
            this.customertypetext.Name = "customertypetext";
            this.customertypetext.ReadOnly = true;
            this.customertypetext.Width = 204;
            // 
            // customertype
            // 
            this.customertype.HeaderText = "";
            this.customertype.MinimumWidth = 6;
            this.customertype.Name = "customertype";
            this.customertype.ReadOnly = true;
            this.customertype.Visible = false;
            this.customertype.Width = 125;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 554);
            this.Controls.Add(this.DataGridPanel);
            this.Controls.Add(this.DataEntryPanel);
            this.Controls.Add(this.HeaderPanel);
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.Click += new System.EventHandler(this.CustomerForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            this.DataGridPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel DataEntryPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CustomerTypeComboBox;
        private System.Windows.Forms.Label CustomerTypeLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn customertypetext;
        private System.Windows.Forms.DataGridViewTextBoxColumn customertype;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label SearchByNameLabel;
        private System.Windows.Forms.TextBox SearchByNameTextBox;
    }
}