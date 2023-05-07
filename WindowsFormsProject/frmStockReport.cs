using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsProject
{
    public partial class frmStockReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(Program.strConn);
        public frmStockReport()
        {
            InitializeComponent();
        }

        private void frmStockReport_Load(object sender, EventArgs e)
        {
            string sqlString1 = "SELECT GoodsID, SUM(Quantity) AS Quantity FROM OrderDetail GROUP BY GoodsID";
            string sqlString2 = "SELECT GoodsID, SUM(Quantity) AS Quantity FROM Receipt GROUP BY GoodsID";
            
            SqlDataAdapter da1 = new SqlDataAdapter(sqlString1, conn);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlString2, conn);

            DataSet dataReport = new DataSet();
            
            da1.Fill(dataReport, "OrderDetail");
            da2.Fill(dataReport, "Receipt");

            StockCrystalReport myDataReport = new StockCrystalReport();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;
        }
    }
}
