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
    public partial class frmPrintDeliverySlip : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(Program.strConn);
        public frmPrintDeliverySlip()
        {
            InitializeComponent();
        }

        private void frmPrintDeliverySlip_Load(object sender, EventArgs e)
        {
            string sqlString1 = "SELECT * FROM DeliveryNote WHERE OrderID = '" + frmDeliveryNote.SetValueOrderID + "'";
            string sqlString2 = "SELECT * FROM Orders WHERE OrderID = '" + frmDeliveryNote.SetValueOrderID + "'";

            SqlDataAdapter da1 = new SqlDataAdapter(sqlString1, conn);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlString2, conn);

            DataSet dataReport = new DataSet();
            da1.Fill(dataReport, "DeliveryNote");
            da2.Fill(dataReport, "Orders");

            // Establish a relationship between the DeliveryNote and Orders tables
            DataRelation dr = new DataRelation("DeliveryNote_Orders", dataReport.Tables["Orders"].Columns["OrderID"], dataReport.Tables["DeliveryNote"].Columns["OrderID"]);
            dataReport.Relations.Add(dr);


            CrystalReport1 myDataReport = new CrystalReport1();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;
        }
    }
}
