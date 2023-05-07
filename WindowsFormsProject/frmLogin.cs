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
    public partial class frmLogin : Form
    {
        public static string RoleText = "";
        public static string AccountantID = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "SELECT Accountant.AccountantID, Accountant.PasswordAccountant, Accountant.Roles FROM Accountant " +
                          "WHERE Accountant.AccountantID='" + txtUserID.Text + "' and Accountant.PasswordAccountant= '" + txtPassword.Text + "' ";
                         

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AccountantID = txtUserID.Text; 
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Roles"].ToString() == "Accountant")
                {
                    RoleText = "Accountant: " + txtUserID.Text ;
                }
                

                MessageBox.Show("Login Successful!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong UserID or Password!");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
