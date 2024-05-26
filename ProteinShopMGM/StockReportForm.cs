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
    public partial class StockReportForm : Form
    {
        public StockReportForm()
        {
            InitializeComponent();
        }

        private void StockReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proteinShopDBDataSet.StockReportDataTable' table. You can move, or remove it, as needed.
            this.stockReportTableAdapter.Fill(this.proteinShopDBDataSet.StockReportDataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
