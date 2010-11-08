namespace CarsMaintenance.OrderManagement
{
    partial class CreateScrapOrderForm
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
            this._saveButton = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this._cancelButton = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbSystemUser = new System.Windows.Forms.ComboBox();
            this.lblSystemUser = new System.Windows.Forms.Label();
            this.dtScrapDate = new System.Windows.Forms.DateTimePicker();
            this.lblScrapDate = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this._operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(23, 7);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 11;
            this.lblCode.Text = "报废单号";
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
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Enabled = false;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(91, 33);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(200, 20);
            this.cbCustomer.TabIndex = 16;
            this.cbCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.cbCustomer_Validating);
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 272);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(741, 39);
            this._operationsPanel.TabIndex = 20;
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
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(23, 35);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(41, 12);
            this.lblCustomer.TabIndex = 15;
            this.lblCustomer.Text = "装卸组";
            // 
            // cbSystemUser
            // 
            this.cbSystemUser.FormattingEnabled = true;
            this.cbSystemUser.Location = new System.Drawing.Point(414, 32);
            this.cbSystemUser.Name = "cbSystemUser";
            this.cbSystemUser.Size = new System.Drawing.Size(200, 20);
            this.cbSystemUser.TabIndex = 18;
            this.cbSystemUser.Validating += new System.ComponentModel.CancelEventHandler(this.cbSystemUser_Validating);
            // 
            // lblSystemUser
            // 
            this.lblSystemUser.AutoSize = true;
            this.lblSystemUser.Location = new System.Drawing.Point(346, 36);
            this.lblSystemUser.Name = "lblSystemUser";
            this.lblSystemUser.Size = new System.Drawing.Size(41, 12);
            this.lblSystemUser.TabIndex = 17;
            this.lblSystemUser.Text = "收发工";
            // 
            // dtScrapDate
            // 
            this.dtScrapDate.Location = new System.Drawing.Point(414, 4);
            this.dtScrapDate.Name = "dtScrapDate";
            this.dtScrapDate.Size = new System.Drawing.Size(200, 21);
            this.dtScrapDate.TabIndex = 14;
            // 
            // lblScrapDate
            // 
            this.lblScrapDate.AutoSize = true;
            this.lblScrapDate.Location = new System.Drawing.Point(346, 10);
            this.lblScrapDate.Name = "lblScrapDate";
            this.lblScrapDate.Size = new System.Drawing.Size(29, 12);
            this.lblScrapDate.TabIndex = 13;
            this.lblScrapDate.Text = "日期";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(91, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 21);
            this.txtCode.TabIndex = 12;
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
            this.RepairQuantity,
            this.ScrapQuantity,
            this.ScrapReason});
            this.dataGridViewDetail.Location = new System.Drawing.Point(25, 79);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 23;
            this.dataGridViewDetail.Size = new System.Drawing.Size(692, 181);
            this.dataGridViewDetail.TabIndex = 19;
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
            this.ItemQuantity.HeaderText = "预报废数量";
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
            // RepairQuantity
            // 
            this.RepairQuantity.HeaderText = "修理数";
            this.RepairQuantity.Name = "RepairQuantity";
            this.RepairQuantity.Width = 96;
            // 
            // ScrapQuantity
            // 
            this.ScrapQuantity.HeaderText = "报废数";
            this.ScrapQuantity.Name = "ScrapQuantity";
            this.ScrapQuantity.Width = 72;
            // 
            // ScrapReason
            // 
            this.ScrapReason.HeaderText = "报废原因";
            this.ScrapReason.Name = "ScrapReason";
            // 
            // CreateScrapOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 311);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this._operationsPanel);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cbSystemUser);
            this.Controls.Add(this.lblSystemUser);
            this.Controls.Add(this.dtScrapDate);
            this.Controls.Add(this.lblScrapDate);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dataGridViewDetail);
            this.Name = "CreateScrapOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报废单管理";
            this.Load += new System.EventHandler(this.CreateScrapOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this._operationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbSystemUser;
        private System.Windows.Forms.Label lblSystemUser;
        private System.Windows.Forms.DateTimePicker dtScrapDate;
        private System.Windows.Forms.Label lblScrapDate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapReason;
    }
}