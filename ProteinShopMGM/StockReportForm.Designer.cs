namespace ProteinShopMGM
{
    partial class StockReportForm
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
            this.stockReportDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proteinShopDBDataSet = new ProteinShopMGM.ProteinShopDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.stockReportTableAdapter = new ProteinShopMGM.ProteinShopDBDataSetTableAdapters.StockReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinShopDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // stockReportDataTableBindingSource
            // 
            this.stockReportDataTableBindingSource.DataMember = "StockReportDataTable";
            this.stockReportDataTableBindingSource.DataSource = this.proteinShopDBDataSet;
            // 
            // proteinShopDBDataSet
            // 
            this.proteinShopDBDataSet.DataSetName = "ProteinShopDBDataSet";
            this.proteinShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.LightSteelBlue;
            reportDataSource1.Name = "StockReportDataSet";
            reportDataSource1.Value = this.stockReportDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProteinShopMGM.Reports.StockReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1086, 556);
            this.reportViewer1.TabIndex = 0;
            // 
            // stockReportTableAdapter
            // 
            this.stockReportTableAdapter.ClearBeforeFill = true;
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 581);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StockReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockReportDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinShopDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProteinShopDBDataSet proteinShopDBDataSet;
        private System.Windows.Forms.BindingSource stockReportDataTableBindingSource;
        private ProteinShopDBDataSetTableAdapters.StockReportTableAdapter stockReportTableAdapter;
    }
}