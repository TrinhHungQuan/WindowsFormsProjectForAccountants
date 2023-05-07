using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            labelRoles.Text = frmLogin.RoleText;
            
        }

        private void btnAgentManage_Click(object sender, EventArgs e)
        {
            frmAgentManagement frm = new frmAgentManagement();
            frm.Show();
        }

        private void btnCreateGoodsReceived_Click(object sender, EventArgs e)
        {
            frmGoodsReceived frm = new frmGoodsReceived();
            frm.Show();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            frmGoods frm = new frmGoods();
            frm.Show();
        }

        private void btnDeliveryNote_Click(object sender, EventArgs e)
        {
            frmDeliveryNote frm = new frmDeliveryNote();
            frm.Show();
        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            frmStockReport frm = new frmStockReport();
            frm.Show(); 
        }

        private void btnBestSelling_Click(object sender, EventArgs e)
        {
            frmBestSelling frm = new frmBestSelling();
            frm.Show();
        }

        private void btnRevenueReport_Click(object sender, EventArgs e)
        {
            frmRevenueReport frm = new frmRevenueReport();  
            frm.Show();
        }
    }
}
