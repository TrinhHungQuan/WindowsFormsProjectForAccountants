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
    public partial class frmGoodsReceived : Form
    {
        public frmGoodsReceived()
        {
            InitializeComponent();
        }

        private void labelReceivedID_Click(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(Program.strConn);
            
            con.Open();

            String sSQL = "Select * from GoodsReceived";
            SqlCommand cmd = new SqlCommand(sSQL, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewGoodsReceived.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            txtReceivedID.Text = "";
        }

        private void frmGoodsReceived_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            
            conn.Open();
            String sSQL = "SELECT * FROM GoodsReceived ";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewGoodsReceived.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            //conn.ConnectionString = @"Data Source=LAPTOP-SJ19AVB1\SQLEXPRESS; Initial Catalog=LabDB; Integrated Security=True";
            conn.Open();
            String sSQL = "INSERT INTO GoodsReceived (ReceivedID, Date) VALUES(@ReceivedID, @Date)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);

            cmd.Parameters.Add(new SqlParameter("@ReceivedID", txtReceivedID.Text));
            cmd.Parameters.Add(new SqlParameter("@Date", dateTimePicker1.Value));
           

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            MessageBox.Show("Save Successfully!");
            DisplayData();
            ClearData();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            frmReceipt frm = new frmReceipt();
            frm.Show();
        }

        private void dataGridViewGoodsReceived_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewGoodsReceived.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridViewGoodsReceived.Rows[index];

                String ReceivedID = Convert.ToString(row.Cells[0].Value);
                DateTime date = DateTime.Parse(row.Cells[1].Value.ToString());



                txtReceivedID.Text = ReceivedID;

                dateTimePicker1.Value = date;

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
