namespace CarsMaintenance.OrderManagement
{
    partial class CreateInboundOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.lblCode = new System.Windows.Forms.Label();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescrapQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._cancelButton = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this._saveButton = new System.Windows.Forms.Button();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbSystemUser = new System.Windows.Forms.ComboBox();
            this.lblSystemUser = new System.Windows.Forms.Label();
            this.dtInboundDate = new System.Windows.Forms.DateTimePicker();
            this.lblInboundDate = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this._operationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(23, 11);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "归还单号";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemCode,
            this.ItemQuantity,
            this.ItemName,
            this.ItemDimensions,
            this.Quantity,
            this.PrescrapQuantity,
            this.TransferQuantity});
            this.dataGridViewDetail.Location = new System.Drawing.Point(25, 83);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 23;
            this.dataGridViewDetail.Size = new System.Drawing.Size(692, 181);
            this.dataGridViewDetail.TabIndex = 8;
            this.dataGridViewDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDetail_CellValidating);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "工属具编码";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 90;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "数量";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            this.ItemQuantity.Width = 90;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 90;
            // 
            // ItemDimensions
            // 
            this.ItemDimensions.HeaderText = "规格";
            this.ItemDimensions.Name = "ItemDimensions";
            this.ItemDimensions.ReadOnly = true;
            this.ItemDimensions.Width = 90;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "归还数";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 72;
            // 
            // PrescrapQuantity
            // 
            this.PrescrapQuantity.HeaderText = "预报废数";
            this.PrescrapQuantity.Name = "PrescrapQuantity";
            this.PrescrapQuantity.Width = 96;
            // 
            // TransferQuantity
            // 
            this.TransferQuantity.HeaderText = "转借数";
            this.TransferQuantity.Name = "TransferQuantity";
            this.TransferQuantity.Width = 72;
            // 
            // _cancelButton
            // 
            this._cancelButton.CausesValidation = false;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(642, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 33);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "取消";
            this._cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Enabled = false;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(91, 37);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(200, 20);
            this.cbCustomer.TabIndex = 5;
            this.cbCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.cbCustomer_Validating);
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(561, 3);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 33);
            this._saveButton.TabIndex = 0;
            this._saveButton.Text = "保存";
            this._saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 272);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(741, 39);
            this._operationsPanel.TabIndex = 9;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(23, 39);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(41, 12);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "装卸组";
            // 
            // cbSystemUser
            // 
            this.cbSystemUser.FormattingEnabled = true;
            this.cbSystemUser.Location = new System.Drawing.Point(414, 36);
            this.cbSystemUser.Name = "cbSystemUser";
            this.cbSystemUser.Size = new System.Drawing.Size(200, 20);
            this.cbSystemUser.TabIndex = 7;
            this.cbSystemUser.Validating += new System.ComponentModel.CancelEventHandler(this.cbSystemUser_Validating);
            // 
            // lblSystemUser
            // 
            this.lblSystemUser.AutoSize = true;
            this.lblSystemUser.Location = new System.Drawing.Point(346, 40);
            this.lblSystemUser.Name = "lblSystemUser";
            this.lblSystemUser.Size = new System.Drawing.Size(41, 12);
            this.lblSystemUser.TabIndex = 6;
            this.lblSystemUser.Text = "收发工";
            // 
            // dtInboundDate
            // 
            this.dtInboundDate.Location = new System.Drawing.Point(414, 8);
            this.dtInboundDate.Name = "dtInboundDate";
            this.dtInboundDate.Size = new System.Drawing.Size(200, 21);
            this.dtInboundDate.TabIndex = 3;
            // 
            // lblInboundDate
            // 
            this.lblInboundDate.AutoSize = true;
            this.lblInboundDate.Location = new System.Drawing.Point(346, 14);
            this.lblInboundDate.Name = "lblInboundDate";
            this.lblInboundDate.Size = new System.Drawing.Size(29, 12);
            this.lblInboundDate.TabIndex = 2;
            this.lblInboundDate.Text = "日期";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(91, 8);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 21);
            this.txtCode.TabIndex = 1;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(642, 54);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 10;
            this.btnTransfer.Text = "转借信息";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // CreateInboundOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(741, 311);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dataGridViewDetail);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this._operationsPanel);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cbSystemUser);
            this.Controls.Add(this.lblSystemUser);
            this.Controls.Add(this.dtInboundDate);
            this.Controls.Add(this.lblInboundDate);
            this.Controls.Add(this.txtCode);
            this.Name = "CreateInboundOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "归还单管理";
            this.Load += new System.EventHandler(this.CreateInboundOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this._operationsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbSystemUser;
        private System.Windows.Forms.Label lblSystemUser;
        private System.Windows.Forms.DateTimePicker dtInboundDate;
        private System.Windows.Forms.Label lblInboundDate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescrapQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferQuantity;
        private System.Windows.Forms.Button btnTransfer;

    }
}