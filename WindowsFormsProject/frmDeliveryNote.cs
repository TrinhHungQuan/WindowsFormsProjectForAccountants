using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class frmDeliveryNote : Form
    {
        public static string SetValueOrderID = "";
        public frmDeliveryNote()
        {
            InitializeComponent();
        }

        private void DisplayData1()
        {
            SqlConnection con = new SqlConnection(Program.strConn);
            con.Open();

            String sSQL = "Select * from Orders";
            SqlCommand cmd = new SqlCommand(sSQL, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewOrders.DataSource = dt;
            con.Close();
        }

        private void DisplayData2()
        {
            SqlConnection con = new SqlConnection(Program.strConn);
            con.Open();

            String sSQL = "Select * from DeliveryNote";
            SqlCommand cmd = new SqlCommand(sSQL, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewDeliveryNote.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            txtOrderID.Text = "";
            txtDeliveryNoteID.Text = "";
            txtStatus.Text = "";
            txtPaymentStatus.Text = "";
            txtDeliveryNoteID.Text = "";
           

        }

        private void frmDeliveryNote_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);

            conn.Open();
            String sSQL = "SELECT * FROM Orders ";
            String sSQL1 = "SELECT * FROM DeliveryNote";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlCommand cmd1 = new SqlCommand(sSQL1, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();    
            da.Fill(dt);
            da1.Fill(dt1);
            if (dt.Rows.Count > 0 || dt1.Rows.Count>0)
            {
                dataGridViewOrders.DataSource = dt;
                dataGridViewDeliveryNote.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewOrders.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridViewOrders.Rows[index];
                
                String OrderID = Convert.ToString(row.Cells[0].Value);
                String Status = Convert.ToString(row.Cells[2].Value);
                String PaymentStatus = Convert.ToString(row.Cells[6].Value);
                

                txtOrderID.Text = OrderID;

                txtStatus.Text = Status;
                txtPaymentStatus.Text = PaymentStatus;
                
                SetValueOrderID = txtOrderID.Text;

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void btnAddDeliveryNote_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "INSERT INTO DeliveryNote VALUES(@DeliveryNoteID, @AccountantID, @OrderID, @Date)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);

            

            cmd.Parameters.Add(new SqlParameter("@DeliveryNoteID", txtDeliveryNoteID.Text));
            cmd.Parameters.Add(new SqlParameter("@AccountantID", frmLogin.AccountantID));
            cmd.Parameters.Add(new SqlParameter("@OrderID", txtOrderID.Text));
            cmd.Parameters.Add(new SqlParameter("@Date", DateTime.Now));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            MessageBox.Show("Save Successfully!");
            DisplayData2();
            ClearData();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text != "" && txtOrderID.Text != "")
            {
                SqlConnection con = new SqlConnection(Program.strConn);
                con.Open();

                String sSQL = "UPDATE Orders SET Status = @Status, PaymentStatus = @PaymentStatus WHERE OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.Parameters.Add(new SqlParameter("@OrderID", txtOrderID.Text));
                cmd.Parameters.Add(new SqlParameter("@Status", txtStatus.Text));
                cmd.Parameters.Add(new SqlParameter("@PaymentStatus", txtPaymentStatus.Text));
               



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successful!");
                DisplayData1();
                ClearData();
            }
            else
            {
                MessageBox.Show("Choose the user to change data");
            }
        }

        private void btnPrintDeliveryNoteNote_Click(object sender, EventArgs e)
        {
            frmPrintDeliverySlip frm = new frmPrintDeliverySlip();
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Please choose the Delivery Note to print Slip");
            }
            else
            {
                frm.Show();
            }   
            
        }

        private void dataGridViewDeliveryNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewDeliveryNote.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridViewDeliveryNote.Rows[index];

                String DeliveryNoteID = Convert.ToString(row.Cells[0].Value);
                String OrderID = Convert.ToString(row.Cells[2].Value);
               

                txtDeliveryNoteID.Text = DeliveryNoteID;
                txtOrderID.Text = OrderID;

                SetValueOrderID = txtOrderID.Text;

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
