namespace ProteinShopMGM
{
    partial class SalesReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.salesReportDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proteinShopDBDataSet = new ProteinShopMGM.ProteinShopDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salesReportTableAdapter = new ProteinShopMGM.ProteinShopDBDataSetTableAdapters.SalesReportTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ToDTPicker = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromDTPicker = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinShopDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesReportDataTableBindingSource
            // 
            this.salesReportDataTableBindingSource.DataMember = "SalesReportDataTable";
            this.salesReportDataTableBindingSource.DataSource = this.proteinShopDBDataSet;
            this.salesReportDataTableBindingSource.CurrentChanged += new System.EventHandler(this.salesReportDataTableBindingSource_CurrentChanged);
            // 
            // proteinShopDBDataSet
            // 
            this.proteinShopDBDataSet.DataSetName = "ProteinShopDBDataSet";
            this.proteinShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.LightSteelBlue;
            reportDataSource1.Name = "SalesReportDataSet";
            reportDataSource1.Value = this.salesReportDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProteinShopMGM.Reports.SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 92);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1339, 530);
            this.reportViewer1.TabIndex = 0;
            // 
            // salesReportTableAdapter
            // 
            this.salesReportTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.GenerateButton);
            this.panel1.Controls.Add(this.ToDTPicker);
            this.panel1.Controls.Add(this.ToLabel);
            this.panel1.Controls.Add(this.FromDTPicker);
            this.panel1.Controls.Add(this.FromLabel);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 84);
            this.panel1.TabIndex = 1;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(475, 43);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(103, 29);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ToDTPicker
            // 
            this.ToDTPicker.Location = new System.Drawing.Point(259, 43);
            this.ToDTPicker.Name = "ToDTPicker";
            this.ToDTPicker.Size = new System.Drawing.Size(200, 27);
            this.ToDTPicker.TabIndex = 3;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(255, 14);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(28, 20);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "To";
            // 
            // FromDTPicker
            // 
            this.FromDTPicker.Location = new System.Drawing.Point(19, 45);
            this.FromDTPicker.Name = "FromDTPicker";
            this.FromDTPicker.Size = new System.Drawing.Size(200, 27);
            this.FromDTPicker.TabIndex = 1;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(15, 16);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(48, 20);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "From";
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinShopDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource salesReportDataTableBindingSource;
        private ProteinShopDBDataSet proteinShopDBDataSet;
        private ProteinShopDBDataSetTableAdapters.SalesReportTableAdapter salesReportTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.DateTimePicker FromDTPicker;
        private System.Windows.Forms.DateTimePicker ToDTPicker;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Button GenerateButton;
    }
}