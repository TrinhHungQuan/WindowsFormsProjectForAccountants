namespace WindowsFormsProject
{
    partial class frmAgentManagement
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
            this.groupBoxAgent = new System.Windows.Forms.GroupBox();
            this.dataGridViewAgent = new System.Windows.Forms.DataGridView();
            this.labelAgentID = new System.Windows.Forms.Label();
            this.labelAgentName = new System.Windows.Forms.Label();
            this.labelPasswordAgent = new System.Windows.Forms.Label();
            this.labelAgentEmail = new System.Windows.Forms.Label();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.txtAgentPassword = new System.Windows.Forms.TextBox();
            this.txtAgentEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAgent
            // 
            this.groupBoxAgent.Controls.Add(this.dataGridViewAgent);
            this.groupBoxAgent.Location = new System.Drawing.Point(12, 149);
            this.groupBoxAgent.Name = "groupBoxAgent";
            this.groupBoxAgent.Size = new System.Drawing.Size(776, 289);
            this.groupBoxAgent.TabIndex = 0;
            this.groupBoxAgent.TabStop = false;
            this.groupBoxAgent.Text = "Agent";
            // 
            // dataGridViewAgent
            // 
            this.dataGridViewAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgent.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewAgent.Name = "dataGridViewAgent";
            this.dataGridViewAgent.RowHeadersWidth = 62;
            this.dataGridViewAgent.RowTemplate.Height = 28;
            this.dataGridViewAgent.Size = new System.Drawing.Size(764, 258);
            this.dataGridViewAgent.TabIndex = 0;
            this.dataGridViewAgent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgent_CellContentClick);
            // 
            // labelAgentID
            // 
            this.labelAgentID.AutoSize = true;
            this.labelAgentID.Location = new System.Drawing.Point(43, 13);
            this.labelAgentID.Name = "labelAgentID";
            this.labelAgentID.Size = new System.Drawing.Size(73, 20);
            this.labelAgentID.TabIndex = 1;
            this.labelAgentID.Text = "Agent ID";
            // 
            // labelAgentName
            // 
            this.labelAgentName.AutoSize = true;
            this.labelAgentName.Location = new System.Drawing.Point(18, 54);
            this.labelAgentName.Name = "labelAgentName";
            this.labelAgentName.Size = new System.Drawing.Size(98, 20);
            this.labelAgentName.TabIndex = 2;
            this.labelAgentName.Text = "Agent Name";
            // 
            // labelPasswordAgent
            // 
            this.labelPasswordAgent.AutoSize = true;
            this.labelPasswordAgent.Location = new System.Drawing.Point(390, 13);
            this.labelPasswordAgent.Name = "labelPasswordAgent";
            this.labelPasswordAgent.Size = new System.Drawing.Size(125, 20);
            this.labelPasswordAgent.TabIndex = 3;
            this.labelPasswordAgent.Text = "Agent Password";
            // 
            // labelAgentEmail
            // 
            this.labelAgentEmail.AutoSize = true;
            this.labelAgentEmail.Location = new System.Drawing.Point(420, 54);
            this.labelAgentEmail.Name = "labelAgentEmail";
            this.labelAgentEmail.Size = new System.Drawing.Size(95, 20);
            this.labelAgentEmail.TabIndex = 5;
            this.labelAgentEmail.Text = "Agent Email";
            // 
            // txtAgentID
            // 
            this.txtAgentID.Location = new System.Drawing.Point(122, 10);
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.Size = new System.Drawing.Size(192, 26);
            this.txtAgentID.TabIndex = 6;
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(122, 54);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(192, 26);
            this.txtAgentName.TabIndex = 7;
            // 
            // txtAgentPassword
            // 
            this.txtAgentPassword.Location = new System.Drawing.Point(521, 10);
            this.txtAgentPassword.Name = "txtAgentPassword";
            this.txtAgentPassword.Size = new System.Drawing.Size(192, 26);
            this.txtAgentPassword.TabIndex = 8;
            // 
            // txtAgentEmail
            // 
            this.txtAgentEmail.Location = new System.Drawing.Point(521, 48);
            this.txtAgentEmail.Name = "txtAgentEmail";
            this.txtAgentEmail.Size = new System.Drawing.Size(192, 26);
            this.txtAgentEmail.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(332, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 42);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(551, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 42);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 42);
            this.btnAdd.TabIndex = 13;
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
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Quan Loi Co.,Ltd";
            // 
            // frmAgentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAgentEmail);
            this.Controls.Add(this.txtAgentPassword);
            this.Controls.Add(this.txtAgentName);
            this.Controls.Add(this.txtAgentID);
            this.Controls.Add(this.labelAgentEmail);
            this.Controls.Add(this.labelPasswordAgent);
            this.Controls.Add(this.labelAgentName);
            this.Controls.Add(this.labelAgentID);
            this.Controls.Add(this.groupBoxAgent);
            this.Name = "frmAgentManagement";
            this.Text = "frmAgentManagement";
            this.Load += new System.EventHandler(this.frmAgentManagement_Load);
            this.groupBoxAgent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAgent;
        private System.Windows.Forms.DataGridView dataGridViewAgent;
        private System.Windows.Forms.Label labelAgentID;
        private System.Windows.Forms.Label labelAgentName;
        private System.Windows.Forms.Label labelPasswordAgent;
        private System.Windows.Forms.Label labelAgentEmail;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.TextBox txtAgentPassword;
        private System.Windows.Forms.TextBox txtAgentEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelName;
    }
}