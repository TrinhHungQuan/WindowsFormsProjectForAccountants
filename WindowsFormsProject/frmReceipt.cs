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
    public partial class frmReceipt : Form
    {
        SqlConnection conn = new SqlConnection(Program.strConn);
        public frmReceipt()
        {
            InitializeComponent();
        }


        private void ClearData()
        {
            txtGoodsID.Text = "";

            txtReceivedID.Text = "";
            txtQuantity.Text = "";

        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ReceivedID FROM GoodsReceived", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                comboBoxReceivedID.DataSource = dt;
                comboBoxReceivedID.DisplayMember = "ReceivedID";
                comboBoxReceivedID.ValueMember = "ReceivedID";
                LoadData();
            }
            else
            {
                MessageBox.Show("No Data");
            }
            adapter.Dispose();
        }

        private void LoadData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Receipt WHERE ReceivedID='" + comboBoxReceivedID.SelectedValue + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewReceipt.DataSource = dt;
                }
                
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void comboBoxReceivedID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewReceipt.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridViewReceipt.Rows[index];

                String GoodsID = Convert.ToString(row.Cells[0].Value);
                String ReceivedID = Convert.ToString(row.Cells[1].Value);
                String Quantity = Convert.ToString(row.Cells[2].Value);
                


                txtGoodsID.Text = GoodsID;

                txtReceivedID.Text = ReceivedID;
                txtQuantity.Text = Quantity;

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);

            conn.Open();
            String sSQL = "INSERT INTO Receipt (GoodsID, ReceivedID, Quantity, AccountantID) VALUES(@GoodsID, @ReceivedID, @Quantity, @AccountantID)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);

            cmd.Parameters.Add(new SqlParameter("@GoodsID", txtGoodsID.Text));
            cmd.Parameters.Add(new SqlParameter("@ReceivedID", txtReceivedID.Text));
            cmd.Parameters.Add(new SqlParameter("@Quantity", txtQuantity.Text));
            cmd.Parameters.Add(new SqlParameter("@AccountantID", frmLogin.AccountantID));


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            MessageBox.Show("Save Successfully!");
            LoadData();
            ClearData();
            
        }
    }
}
