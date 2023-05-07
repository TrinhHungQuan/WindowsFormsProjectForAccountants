namespace WindowsFormsProject
{
    partial class frmGoodsReceived
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
            this.groupBoxGoodsReceived = new System.Windows.Forms.GroupBox();
            this.dataGridViewGoodsReceived = new System.Windows.Forms.DataGridView();
            this.txtReceivedID = new System.Windows.Forms.TextBox();
            this.labelReceivedID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxGoodsReceived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoodsReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGoodsReceived
            // 
            this.groupBoxGoodsReceived.Controls.Add(this.dataGridViewGoodsReceived);
            this.groupBoxGoodsReceived.Location = new System.Drawing.Point(12, 169);
            this.groupBoxGoodsReceived.Name = "groupBoxGoodsReceived";
            this.groupBoxGoodsReceived.Size = new System.Drawing.Size(776, 269);
            this.groupBoxGoodsReceived.TabIndex = 0;
            this.groupBoxGoodsReceived.TabStop = false;
            this.groupBoxGoodsReceived.Text = "Goods Received";
            // 
            // dataGridViewGoodsReceived
            // 
            this.dataGridViewGoodsReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoodsReceived.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewGoodsReceived.Name = "dataGridViewGoodsReceived";
            this.dataGridViewGoodsReceived.RowHeadersWidth = 62;
            this.dataGridViewGoodsReceived.RowTemplate.Height = 28;
            this.dataGridViewGoodsReceived.Size = new System.Drawing.Size(770, 238);
            this.dataGridViewGoodsReceived.TabIndex = 0;
            this.dataGridViewGoodsReceived.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGoodsReceived_CellContentClick);
            // 
            // txtReceivedID
            // 
            this.txtReceivedID.Location = new System.Drawing.Point(141, 41);
            this.txtReceivedID.Name = "txtReceivedID";
            this.txtReceivedID.Size = new System.Drawing.Size(188, 26);
            this.txtReceivedID.TabIndex = 1;
            // 
            // labelReceivedID
            // 
            this.labelReceivedID.AutoSize = true;
            this.labelReceivedID.Location = new System.Drawing.Point(30, 44);
            this.labelReceivedID.Name = "labelReceivedID";
            this.labelReceivedID.Size = new System.Drawing.Size(96, 20);
            this.labelReceivedID.TabIndex = 3;
            this.labelReceivedID.Text = "Received ID";
            this.labelReceivedID.Click += new System.EventHandler(this.labelReceivedID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 59);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Received Goods";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(440, 92);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(199, 59);
            this.btnReceipt.TabIndex = 7;
            this.btnReceipt.Text = "Details Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 441);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(176, 25);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Quan Loi Co.,Ltd";
            // 
            // frmGoodsReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelReceivedID);
            this.Controls.Add(this.txtReceivedID);
            this.Controls.Add(this.groupBoxGoodsReceived);
            this.Name = "frmGoodsReceived";
            this.Text = "Goods Received";
            this.Load += new System.EventHandler(this.frmGoodsReceived_Load);
            this.groupBoxGoodsReceived.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoodsReceived)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGoodsReceived;
        private System.Windows.Forms.TextBox txtReceivedID;
        private System.Windows.Forms.Label labelReceivedID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.DataGridView dataGridViewGoodsReceived;
        private System.Windows.Forms.Label labelName;
    }
}