namespace WindowsFormsProject
{
    partial class frmGoods
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
            this.groupBoxGoods = new System.Windows.Forms.GroupBox();
            this.dataGridViewGoods = new System.Windows.Forms.DataGridView();
            this.labelGoodsID = new System.Windows.Forms.Label();
            this.labelGoodsName = new System.Windows.Forms.Label();
            this.labelCostPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSellingPrice = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtCost_Price = new System.Windows.Forms.TextBox();
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSelling_Price = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBoxGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGoods
            // 
            this.groupBoxGoods.Controls.Add(this.dataGridViewGoods);
            this.groupBoxGoods.Location = new System.Drawing.Point(12, 149);
            this.groupBoxGoods.Name = "groupBoxGoods";
            this.groupBoxGoods.Size = new System.Drawing.Size(776, 289);
            this.groupBoxGoods.TabIndex = 0;
            this.groupBoxGoods.TabStop = false;
            this.groupBoxGoods.Text = "Goods";
            // 
            // dataGridViewGoods
            // 
            this.dataGridViewGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoods.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.RowHeadersWidth = 62;
            this.dataGridViewGoods.RowTemplate.Height = 28;
            this.dataGridViewGoods.Size = new System.Drawing.Size(764, 258);
            this.dataGridViewGoods.TabIndex = 0;
            this.dataGridViewGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGoods_CellContentClick);
            // 
            // labelGoodsID
            // 
            this.labelGoodsID.AutoSize = true;
            this.labelGoodsID.Location = new System.Drawing.Point(67, 13);
            this.labelGoodsID.Name = "labelGoodsID";
            this.labelGoodsID.Size = new System.Drawing.Size(78, 20);
            this.labelGoodsID.TabIndex = 1;
            this.labelGoodsID.Text = "Goods ID";
            // 
            // labelGoodsName
            // 
            this.labelGoodsName.AutoSize = true;
            this.labelGoodsName.Location = new System.Drawing.Point(42, 60);
            this.labelGoodsName.Name = "labelGoodsName";
            this.labelGoodsName.Size = new System.Drawing.Size(103, 20);
            this.labelGoodsName.TabIndex = 2;
            this.labelGoodsName.Text = "Goods Name";
            // 
            // labelCostPrice
            // 
            this.labelCostPrice.AutoSize = true;
            this.labelCostPrice.Location = new System.Drawing.Point(64, 108);
            this.labelCostPrice.Name = "labelCostPrice";
            this.labelCostPrice.Size = new System.Drawing.Size(81, 20);
            this.labelCostPrice.TabIndex = 3;
            this.labelCostPrice.Text = "Cost Price";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(447, 13);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 20);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelSellingPrice
            // 
            this.labelSellingPrice.AutoSize = true;
            this.labelSellingPrice.Location = new System.Drawing.Point(424, 60);
            this.labelSellingPrice.Name = "labelSellingPrice";
            this.labelSellingPrice.Size = new System.Drawing.Size(95, 20);
            this.labelSellingPrice.TabIndex = 5;
            this.labelSellingPrice.Text = "Selling Price";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(152, 60);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(213, 26);
            this.txtGoodsName.TabIndex = 7;
            // 
            // txtCost_Price
            // 
            this.txtCost_Price.Location = new System.Drawing.Point(152, 101);
            this.txtCost_Price.Name = "txtCost_Price";
            this.txtCost_Price.Size = new System.Drawing.Size(213, 26);
            this.txtCost_Price.TabIndex = 8;
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(152, 13);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.Size = new System.Drawing.Size(213, 26);
            this.txtGoodsID.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(521, 10);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(213, 26);
            this.txtQuantity.TabIndex = 10;
            // 
            // txtSelling_Price
            // 
            this.txtSelling_Price.Location = new System.Drawing.Point(525, 60);
            this.txtSelling_Price.Name = "txtSelling_Price";
            this.txtSelling_Price.Size = new System.Drawing.Size(213, 26);
            this.txtSelling_Price.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(525, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(7, 441);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(176, 25);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Quan Loi Co.,Ltd";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(645, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 35);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSelling_Price);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtGoodsID);
            this.Controls.Add(this.txtCost_Price);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.labelSellingPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelCostPrice);
            this.Controls.Add(this.labelGoodsName);
            this.Controls.Add(this.labelGoodsID);
            this.Controls.Add(this.groupBoxGoods);
            this.Name = "frmGoods";
            this.Text = "frmGoods";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            this.groupBoxGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGoods;
        private System.Windows.Forms.DataGridView dataGridViewGoods;
        private System.Windows.Forms.Label labelGoodsID;
        private System.Windows.Forms.Label labelGoodsName;
        private System.Windows.Forms.Label labelCostPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSellingPrice;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.TextBox txtCost_Price;
        private System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSelling_Price;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnUpdate;
    }
}