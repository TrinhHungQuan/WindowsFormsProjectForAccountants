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
    public partial class frmAgentManagement : Form
    {
        public frmAgentManagement()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(Program.strConn);
            con.Open();

            String sSQL = "Select * from Agent";
            SqlCommand cmd = new SqlCommand(sSQL, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridViewAgent.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            txtAgentID.Text = "";
            txtAgentName.Text = "";
            txtAgentEmail.Text = "";
            txtAgentPassword.Text = "";

        }

        private void frmAgentManagement_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT * FROM Agent ";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewAgent.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void dataGridViewAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridViewAgent.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridViewAgent.Rows[index];

                String AgentID = Convert.ToString(row.Cells[0].Value);
                String AgentName = Convert.ToString(row.Cells[1].Value);
                String AgentEmail = Convert.ToString(row.Cells[2].Value);
                String PasswordAgent = Convert.ToString(row.Cells[3].Value);


                txtAgentID.Text = AgentID;
                txtAgentName.Text = AgentName;
                txtAgentEmail.Text = AgentEmail;
                txtAgentPassword.Text = PasswordAgent;

               
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
            String sSQL = "INSERT INTO Agent (AgentID, AgentName, AgentEmail, PasswordAgent) VALUES(@AgentID, @AgentName, @AgentEmail, @PasswordAgent)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);

            cmd.Parameters.Add(new SqlParameter("@AgentID", txtAgentID.Text));
            cmd.Parameters.Add(new SqlParameter("@AgentName", txtAgentName.Text));
            cmd.Parameters.Add(new SqlParameter("@AgentEmail", txtAgentEmail.Text));
            cmd.Parameters.Add(new SqlParameter("@PasswordAgent", txtAgentPassword.Text));

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAgentID.Text != "" && txtAgentID.Text != "")
            {
                SqlConnection con = new SqlConnection(Program.strConn);
                con.Open();

                String sSQL = "UPDATE Agent SET AgentName = @AgentName, AgentEmail = @AgentEmail, PasswordAgent = @PasswordAgent WHERE AgentID = @AgentID";
                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.Parameters.Add(new SqlParameter("@AgentID", txtAgentID.Text));
                cmd.Parameters.Add(new SqlParameter("@AgentName", txtAgentName.Text));
                cmd.Parameters.Add(new SqlParameter("@AgentEmail", txtAgentEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@PasswordAgent", txtAgentPassword.Text));

                

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successful!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Choose the user to change data");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.strConn);
            con.Open();

            String sSQL = "DELETE FROM Agent WHERE AgentID = @AgentID";
            SqlCommand cmd = new SqlCommand(sSQL, con);
            cmd.Parameters.Add(new SqlParameter("@AgentID", txtAgentID.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete successfull!");
            DisplayData();
            ClearData();
        }
    }
}
