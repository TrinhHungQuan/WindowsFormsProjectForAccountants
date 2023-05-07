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
    public partial class frmBestSelling : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(Program.strConn);
        public frmBestSelling()
        {
            InitializeComponent();
        }

        private void frmBestSelling_Load(object sender, EventArgs e)
        {
            string sqlString = "SELECT TOP 1 GoodsID, SUM(Quantity) AS Quantity FROM OrderDetail GROUP BY GoodsID ORDER BY Quantity DESC";
            string sqlString1 = "SELECT g.GoodsName, od.Quantity FROM Goods g INNER JOIN (  SELECT TOP 1 GoodsID, SUM(Quantity) AS Quantity  FROM OrderDetail GROUP BY GoodsID  ORDER BY Quantity DESC) od ON g.GoodsID = od.GoodsID";
            SqlDataAdapter da = new SqlDataAdapter(sqlString, conn);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlString1, conn);
            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "OrderDetail");
            da1.Fill(dataReport, "Goods");

            BestSellingCrystalReport myDataReport = new BestSellingCrystalReport();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;
        }
    }
}
