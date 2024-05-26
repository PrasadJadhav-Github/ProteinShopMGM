using Microsoft.Reporting.WinForms;
using ProteinShopMGM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProteinShopMGM
{
    public partial class SalesReportForm : Form
    {
        private readonly ISellDAL _sellDAL = new SellDAL();

        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            salesReportTableAdapter.Fill(proteinShopDBDataSet.SalesReportDataTable, FromDTPicker.Value.Date, ToDTPicker.Value.Date);
            this.reportViewer1.RefreshReport();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            salesReportTableAdapter.Fill(proteinShopDBDataSet.SalesReportDataTable, FromDTPicker.Value.Date, ToDTPicker.Value.Date);

            // Calculate total sell.
            double totalSell = _sellDAL.GetTotalSell(FromDTPicker.Value.Date, ToDTPicker.Value.Date);
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("TotalSell", "Rs. " + totalSell.ToString(), true);

            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }

        private void salesReportDataTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
