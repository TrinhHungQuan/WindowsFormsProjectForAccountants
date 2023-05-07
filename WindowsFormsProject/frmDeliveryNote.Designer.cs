namespace WindowsFormsProject
{
    partial class frmDeliveryNote
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
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.groupBoxDeliveryNote = new System.Windows.Forms.GroupBox();
            this.dataGridViewDeliveryNote = new System.Windows.Forms.DataGridView();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.txtDeliveryNoteID = new System.Windows.Forms.TextBox();
            this.labelDeliveryID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.btnAddDeliveryNote = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnPrintDeliveryNoteNote = new System.Windows.Forms.Button();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.groupBoxDeliveryNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveryNote)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.dataGridViewOrders);
            this.groupBoxOrder.Location = new System.Drawing.Point(12, 165);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(520, 348);
            this.groupBoxOrder.TabIndex = 1;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Order";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.Size = new System.Drawing.Size(508, 317);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // groupBoxDeliveryNote
            // 
            this.groupBoxDeliveryNote.Controls.Add(this.dataGridViewDeliveryNote);
            this.groupBoxDeliveryNote.Location = new System.Drawing.Point(542, 165);
            this.groupBoxDeliveryNote.Name = "groupBoxDeliveryNote";
            this.groupBoxDeliveryNote.Size = new System.Drawing.Size(516, 348);
            this.groupBoxDeliveryNote.TabIndex = 2;
            this.groupBoxDeliveryNote.TabStop = false;
            this.groupBoxDeliveryNote.Text = "Delivery Note";
            // 
            // dataGridViewDeliveryNote
            // 
            this.dataGridViewDeliveryNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeliveryNote.Location = new System.Drawing.Point(13, 26);
            this.dataGridViewDeliveryNote.Name = "dataGridViewDeliveryNote";
            this.dataGridViewDeliveryNote.RowHeadersWidth = 62;
            this.dataGridViewDeliveryNote.RowTemplate.Height = 28;
            this.dataGridViewDeliveryNote.Size = new System.Drawing.Size(497, 316);
            this.dataGridViewDeliveryNote.TabIndex = 0;
            this.dataGridViewDeliveryNote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeliveryNote_CellContentClick);
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(74, 27);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(66, 20);
            this.labelOrderID.TabIndex = 3;
            this.labelOrderID.Text = "OrderID";
            // 
            // txtDeliveryNoteID
            // 
            this.txtDeliveryNoteID.Location = new System.Drawing.Point(698, 24);
            this.txtDeliveryNoteID.Name = "txtDeliveryNoteID";
            this.txtDeliveryNoteID.Size = new System.Drawing.Size(209, 26);
            this.txtDeliveryNoteID.TabIndex = 4;
            // 
            // labelDeliveryID
            // 
            this.labelDeliveryID.AutoSize = true;
            this.labelDeliveryID.Location = new System.Drawing.Point(551, 28);
            this.labelDeliveryID.Name = "labelDeliveryID";
            this.labelDeliveryID.Size = new System.Drawing.Size(123, 20);
            this.labelDeliveryID.TabIndex = 5;
            this.labelDeliveryID.Text = "Delivery Note ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "PaymentStatus";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(147, 66);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(172, 26);
            this.txtStatus.TabIndex = 8;
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.Location = new System.Drawing.Point(146, 108);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.Size = new System.Drawing.Size(173, 26);
            this.txtPaymentStatus.TabIndex = 9;
            // 
            // btnAddDeliveryNote
            // 
            this.btnAddDeliveryNote.Location = new System.Drawing.Point(725, 59);
            this.btnAddDeliveryNote.Name = "btnAddDeliveryNote";
            this.btnAddDeliveryNote.Size = new System.Drawing.Size(161, 41);
            this.btnAddDeliveryNote.TabIndex = 10;
            this.btnAddDeliveryNote.Text = "Add Delivery Note";
            this.btnAddDeliveryNote.UseMnemonic = false;
            this.btnAddDeliveryNote.UseVisualStyleBackColor = true;
            this.btnAddDeliveryNote.Click += new System.EventHandler(this.btnAddDeliveryNote_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(347, 72);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(145, 41);
            this.btnUpdateStatus.TabIndex = 11;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(146, 24);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(173, 26);
            this.txtOrderID.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(7, 518);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(176, 25);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Quan Loi Co.,Ltd";
            // 
            // btnPrintDeliveryNoteNote
            // 
            this.btnPrintDeliveryNoteNote.Location = new System.Drawing.Point(725, 115);
            this.btnPrintDeliveryNoteNote.Name = "btnPrintDeliveryNoteNote";
            this.btnPrintDeliveryNoteNote.Size = new System.Drawing.Size(161, 44);
            this.btnPrintDeliveryNoteNote.TabIndex = 14;
            this.btnPrintDeliveryNoteNote.Text = "Print Delivery Slip";
            this.btnPrintDeliveryNoteNote.UseVisualStyleBackColor = true;
            this.btnPrintDeliveryNoteNote.Click += new System.EventHandler(this.btnPrintDeliveryNoteNote_Click);
            // 
            // frmDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 552);
            this.Controls.Add(this.btnPrintDeliveryNoteNote);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnAddDeliveryNote);
            this.Controls.Add(this.txtPaymentStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDeliveryID);
            this.Controls.Add(this.txtDeliveryNoteID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.groupBoxDeliveryNote);
            this.Controls.Add(this.groupBoxOrder);
            this.Name = "frmDeliveryNote";
            this.Text = "Delivery Note";
            this.Load += new System.EventHandler(this.frmDeliveryNote_Load);
            this.groupBoxOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.groupBoxDeliveryNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveryNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.GroupBox groupBoxDeliveryNote;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewDeliveryNote;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.TextBox txtDeliveryNoteID;
        private System.Windows.Forms.Label labelDeliveryID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPaymentStatus;
        private System.Windows.Forms.Button btnAddDeliveryNote;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnPrintDeliveryNoteNote;
    }
}