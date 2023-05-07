namespace WindowsFormsProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRoles = new System.Windows.Forms.Label();
            this.btnAgentManage = new System.Windows.Forms.Button();
            this.btnCreateGoodsReceived = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnDeliveryNote = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.btnBestSelling = new System.Windows.Forms.Button();
            this.btnRevenueReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoles.Location = new System.Drawing.Point(12, 9);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(79, 29);
            this.labelRoles.TabIndex = 0;
            this.labelRoles.Text = "label1";
            // 
            // btnAgentManage
            // 
            this.btnAgentManage.Location = new System.Drawing.Point(12, 57);
            this.btnAgentManage.Name = "btnAgentManage";
            this.btnAgentManage.Size = new System.Drawing.Size(177, 51);
            this.btnAgentManage.TabIndex = 1;
            this.btnAgentManage.Text = "Agent Management";
            this.btnAgentManage.UseVisualStyleBackColor = true;
            this.btnAgentManage.Click += new System.EventHandler(this.btnAgentManage_Click);
            // 
            // btnCreateGoodsReceived
            // 
            this.btnCreateGoodsReceived.Location = new System.Drawing.Point(12, 210);
            this.btnCreateGoodsReceived.Name = "btnCreateGoodsReceived";
            this.btnCreateGoodsReceived.Size = new System.Drawing.Size(177, 51);
            this.btnCreateGoodsReceived.TabIndex = 2;
            this.btnCreateGoodsReceived.Text = "Goods Received";
            this.btnCreateGoodsReceived.UseVisualStyleBackColor = true;
            this.btnCreateGoodsReceived.Click += new System.EventHandler(this.btnCreateGoodsReceived_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.Location = new System.Drawing.Point(12, 130);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(177, 51);
            this.btnGoods.TabIndex = 3;
            this.btnGoods.Text = "Goods";
            this.btnGoods.UseVisualStyleBackColor = true;
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnDeliveryNote
            // 
            this.btnDeliveryNote.Location = new System.Drawing.Point(12, 288);
            this.btnDeliveryNote.Name = "btnDeliveryNote";
            this.btnDeliveryNote.Size = new System.Drawing.Size(177, 51);
            this.btnDeliveryNote.TabIndex = 4;
            this.btnDeliveryNote.Text = "Delivery Note";
            this.btnDeliveryNote.UseVisualStyleBackColor = true;
            this.btnDeliveryNote.Click += new System.EventHandler(this.btnDeliveryNote_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 405);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(176, 25);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Quan Loi Co.,Ltd";
            // 
            // btnStockReport
            // 
            this.btnStockReport.Location = new System.Drawing.Point(566, 57);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(177, 51);
            this.btnStockReport.TabIndex = 6;
            this.btnStockReport.Text = "Stock Report";
            this.btnStockReport.UseVisualStyleBackColor = true;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // btnBestSelling
            // 
            this.btnBestSelling.Location = new System.Drawing.Point(566, 130);
            this.btnBestSelling.Name = "btnBestSelling";
            this.btnBestSelling.Size = new System.Drawing.Size(177, 51);
            this.btnBestSelling.TabIndex = 7;
            this.btnBestSelling.Text = "Best-Selling Report";
            this.btnBestSelling.UseVisualStyleBackColor = true;
            this.btnBestSelling.Click += new System.EventHandler(this.btnBestSelling_Click);
            // 
            // btnRevenueReport
            // 
            this.btnRevenueReport.Location = new System.Drawing.Point(566, 210);
            this.btnRevenueReport.Name = "btnRevenueReport";
            this.btnRevenueReport.Size = new System.Drawing.Size(177, 51);
            this.btnRevenueReport.TabIndex = 8;
            this.btnRevenueReport.Text = "Revenue Report";
            this.btnRevenueReport.UseVisualStyleBackColor = true;
            this.btnRevenueReport.Click += new System.EventHandler(this.btnRevenueReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 446);
            this.Controls.Add(this.btnRevenueReport);
            this.Controls.Add(this.btnBestSelling);
            this.Controls.Add(this.btnStockReport);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnDeliveryNote);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnCreateGoodsReceived);
            this.Controls.Add(this.btnAgentManage);
            this.Controls.Add(this.labelRoles);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoles;
        private System.Windows.Forms.Button btnAgentManage;
        private System.Windows.Forms.Button btnCreateGoodsReceived;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnDeliveryNote;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnBestSelling;
        private System.Windows.Forms.Button btnRevenueReport;
    }
}