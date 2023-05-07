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
    public partial class frmGoods : Form
    {
        public frmGoods()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(Program.strConn);
            con.Open();

            String sSQL = "Select * from Goods";
            SqlCommand cmd = new SqlCommand(sSQL, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewGoods.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            txtGoodsID.Text = "";
            txtGoodsName.Text = "";
            txtCost_Price.Text = "";
            txtQuantity.Text = "";
            txtSelling_Price.Text = "";

        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
           
            conn.Open();
            String sSQL = "SELECT * FROM Goods ";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewGoods.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void dataGridViewGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewGoods.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridViewGoods.Rows[index];

                String GoodsID = Convert.ToString(row.Cells[0].Value);
                String GoodsName = Convert.ToString(row.Cells[1].Value);
                String Cost_Price = Convert.ToString(row.Cells[2].Value);
                String Quantity = Convert.ToString(row.Cells[3].Value);
                String Selling_Price = Convert.ToString(row.Cells[4].Value);

                txtGoodsID.Text = GoodsID;

                txtGoodsName.Text = GoodsName;
                txtCost_Price.Text = Cost_Price;
                txtQuantity.Text = Quantity;
                txtSelling_Price.Text = Selling_Price;


            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "INSERT INTO Goods (GoodsID, GoodsName, Cost_Price, Quantity, Selling_Price) VALUES(@GoodsID, @GoodsName, @Cost_Price, @Quantity, @Selling_Price)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);

            cmd.Parameters.Add(new SqlParameter("@GoodsID", txtGoodsID.Text));
            cmd.Parameters.Add(new SqlParameter("@GoodsName", txtGoodsName.Text));
            cmd.Parameters.Add(new SqlParameter("@Cost_Price", txtCost_Price.Text));
            cmd.Parameters.Add(new SqlParameter("@Quantity", txtQuantity.Text));
            cmd.Parameters.Add(new SqlParameter("@Selling_Price", txtSelling_Price.Text));
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

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtGoodsID.Text != "" && txtGoodsID.Text != "")
            {
                SqlConnection con = new SqlConnection(Program.strConn);
               
                con.Open();

                String sSQL = "UPDATE Goods SET GoodsName = @GoodsName, Cost_Price = @Cost_Price, Quantity = @Quantity, Selling_Price = @Selling_Price WHERE GoodsID = @GoodsID";
                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.Parameters.Add(new SqlParameter("@GoodsID", txtGoodsID.Text));
                cmd.Parameters.Add(new SqlParameter("@GoodsName", txtGoodsName.Text));
                cmd.Parameters.Add(new SqlParameter("@Cost_Price", txtCost_Price.Text));
                cmd.Parameters.Add(new SqlParameter("@Quantity", txtQuantity.Text));
                cmd.Parameters.Add(new SqlParameter("@Selling_Price", txtSelling_Price.Text));
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successful!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Choose the student to change data");
            }
        }
    }
}
