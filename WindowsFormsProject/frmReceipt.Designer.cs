namespace WindowsFormsProject
{
    partial class frmReceipt
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
            this.comboBoxReceivedID = new System.Windows.Forms.ComboBox();
            this.labelReceivedIDCombo = new System.Windows.Forms.Label();
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.txtReceivedID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labelGoodsID = new System.Windows.Forms.Label();
            this.labelReceivedID = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.groupBoxReceipt = new System.Windows.Forms.GroupBox();
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxReceivedID
            // 
            this.comboBoxReceivedID.FormattingEnabled = true;
            this.comboBoxReceivedID.Location = new System.Drawing.Point(273, 12);
            this.comboBoxReceivedID.Name = "comboBoxReceivedID";
            this.comboBoxReceivedID.Size = new System.Drawing.Size(271, 28);
            this.comboBoxReceivedID.TabIndex = 0;
            this.comboBoxReceivedID.SelectedIndexChanged += new System.EventHandler(this.comboBoxReceivedID_SelectedIndexChanged);
            // 
            // labelReceivedIDCombo
            // 
            this.labelReceivedIDCombo.AutoSize = true;
            this.labelReceivedIDCombo.Location = new System.Drawing.Point(130, 15);
            this.labelReceivedIDCombo.Name = "labelReceivedIDCombo";
            this.labelReceivedIDCombo.Size = new System.Drawing.Size(96, 20);
            this.labelReceivedIDCombo.TabIndex = 1;
            this.labelReceivedIDCombo.Text = "Received ID";
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(99, 91);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.Size = new System.Drawing.Size(140, 26);
            this.txtGoodsID.TabIndex = 2;
            // 
            // txtReceivedID
            // 
            this.txtReceivedID.Location = new System.Drawing.Point(371, 91);
            this.txtReceivedID.Name = "txtReceivedID";
            this.txtReceivedID.Size = new System.Drawing.Size(147, 26);
            this.txtReceivedID.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(631, 91);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(137, 26);
            this.txtQuantity.TabIndex = 4;
            // 
            // labelGoodsID
            // 
            this.labelGoodsID.AutoSize = true;
            this.labelGoodsID.Location = new System.Drawing.Point(11, 96);
            this.labelGoodsID.Name = "labelGoodsID";
            this.labelGoodsID.Size = new System.Drawing.Size(82, 20);
            this.labelGoodsID.TabIndex = 5;
            this.labelGoodsID.Text = "Goods ID:";
            // 
            // labelReceivedID
            // 
            this.labelReceivedID.AutoSize = true;
            this.labelReceivedID.Location = new System.Drawing.Point(255, 96);
            this.labelReceivedID.Name = "labelReceivedID";
            this.labelReceivedID.Size = new System.Drawing.Size(100, 20);
            this.labelReceivedID.TabIndex = 6;
            this.labelReceivedID.Text = "Received ID:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(557, 94);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(72, 20);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Quantity:";
            // 
            // groupBoxReceipt
            // 
            this.groupBoxReceipt.Controls.Add(this.dataGridViewReceipt);
            this.groupBoxReceipt.Location = new System.Drawing.Point(12, 218);
            this.groupBoxReceipt.Name = "groupBoxReceipt";
            this.groupBoxReceipt.Size = new System.Drawing.Size(776, 249);
            this.groupBoxReceipt.TabIndex = 8;
            this.groupBoxReceipt.TabStop = false;
            this.groupBoxReceipt.Text = "Receipt";
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(6, 39);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.RowHeadersWidth = 62;
            this.dataGridViewReceipt.RowTemplate.Height = 28;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(764, 210);
            this.dataGridViewReceipt.TabIndex = 0;
            this.dataGridViewReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceipt_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(7, 476);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(176, 25);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Quan Loi Co.,Ltd";
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxReceipt);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelReceivedID);
            this.Controls.Add(this.labelGoodsID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtReceivedID);
            this.Controls.Add(this.txtGoodsID);
            this.Controls.Add(this.labelReceivedIDCombo);
            this.Controls.Add(this.comboBoxReceivedID);
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.groupBoxReceipt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReceivedID;
        private System.Windows.Forms.Label labelReceivedIDCombo;
        private System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.TextBox txtReceivedID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labelGoodsID;
        private System.Windows.Forms.Label labelReceivedID;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.GroupBox groupBoxReceipt;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelName;
    }
}