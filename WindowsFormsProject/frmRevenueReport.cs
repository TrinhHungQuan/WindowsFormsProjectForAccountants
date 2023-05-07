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
    public partial class frmRevenueReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(Program.strConn);
        public frmRevenueReport()
        {
            InitializeComponent();
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            string sqlString1 = "SELECT GoodsID, Selling_Price, SUM(Quantity) AS Quantity FROM OrderDetail GROUP BY GoodsID, Selling_Price";
            string sqlString2 = "SELECT SUM(Order_Total_Price) AS Order_Total_Price FROM Orders";

            SqlDataAdapter da1 = new SqlDataAdapter(sqlString1, conn);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlString2, conn);

            DataSet dataReport = new DataSet(); 

            da1.Fill(dataReport, "OrderDetail");
            da2.Fill(dataReport, "Orders");

            RevenueCrystalReport myDataReport = new RevenueCrystalReport();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;
        }
    }
}
