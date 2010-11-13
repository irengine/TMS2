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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._cancelButton = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._saveButton = new System.Windows.Forms.Button();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.btnTransferAll = new System.Windows.Forms.Button();
            this.btnReturnAll = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbSystemUser = new System.Windows.Forms.ComboBox();
            this.lblSystemUser = new System.Windows.Forms.Label();
            this.dtInboundDate = new System.Windows.Forms.DateTimePicker();
            this.lblInboundDate = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescrapQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapReason = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this._operationsPanel.SuspendLayout();
            this.panelMaster.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // _cancelButton
            // 
            this._cancelButton.CausesValidation = false;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(897, 3);
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
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(816, 3);
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
            this._operationsPanel.Location = new System.Drawing.Point(0, 423);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(984, 39);
            this._operationsPanel.TabIndex = 9;
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.btnTransferAll);
            this.panelMaster.Controls.Add(this.btnReturnAll);
            this.panelMaster.Controls.Add(this.lblCode);
            this.panelMaster.Controls.Add(this.cbCustomer);
            this.panelMaster.Controls.Add(this.lblCustomer);
            this.panelMaster.Controls.Add(this.cbSystemUser);
            this.panelMaster.Controls.Add(this.lblSystemUser);
            this.panelMaster.Controls.Add(this.dtInboundDate);
            this.panelMaster.Controls.Add(this.lblInboundDate);
            this.panelMaster.Controls.Add(this.txtCode);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(984, 80);
            this.panelMaster.TabIndex = 11;
            // 
            // btnTransferAll
            // 
            this.btnTransferAll.Location = new System.Drawing.Point(727, 38);
            this.btnTransferAll.Name = "btnTransferAll";
            this.btnTransferAll.Size = new System.Drawing.Size(75, 23);
            this.btnTransferAll.TabIndex = 21;
            this.btnTransferAll.Text = "全部转借";
            this.btnTransferAll.UseVisualStyleBackColor = true;
            this.btnTransferAll.Click += new System.EventHandler(this.btnTransferAll_Click);
            // 
            // btnReturnAll
            // 
            this.btnReturnAll.Location = new System.Drawing.Point(637, 38);
            this.btnReturnAll.Name = "btnReturnAll";
            this.btnReturnAll.Size = new System.Drawing.Size(75, 23);
            this.btnReturnAll.TabIndex = 20;
            this.btnReturnAll.Text = "全部归还";
            this.btnReturnAll.UseVisualStyleBackColor = true;
            this.btnReturnAll.Click += new System.EventHandler(this.btnReturnAll_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(19, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 11;
            this.lblCode.Text = "归还单号";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Enabled = false;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(87, 41);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(200, 20);
            this.cbCustomer.TabIndex = 16;
            this.cbCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.cbCustomer_Validating);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(19, 43);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(41, 12);
            this.lblCustomer.TabIndex = 15;
            this.lblCustomer.Text = "装卸组";
            // 
            // cbSystemUser
            // 
            this.cbSystemUser.FormattingEnabled = true;
            this.cbSystemUser.Location = new System.Drawing.Point(400, 40);
            this.cbSystemUser.Name = "cbSystemUser";
            this.cbSystemUser.Size = new System.Drawing.Size(200, 20);
            this.cbSystemUser.TabIndex = 18;
            this.cbSystemUser.Validating += new System.ComponentModel.CancelEventHandler(this.cbSystemUser_Validating);
            // 
            // lblSystemUser
            // 
            this.lblSystemUser.AutoSize = true;
            this.lblSystemUser.Location = new System.Drawing.Point(332, 44);
            this.lblSystemUser.Name = "lblSystemUser";
            this.lblSystemUser.Size = new System.Drawing.Size(41, 12);
            this.lblSystemUser.TabIndex = 17;
            this.lblSystemUser.Text = "收发工";
            // 
            // dtInboundDate
            // 
            this.dtInboundDate.Location = new System.Drawing.Point(400, 12);
            this.dtInboundDate.Name = "dtInboundDate";
            this.dtInboundDate.Size = new System.Drawing.Size(200, 21);
            this.dtInboundDate.TabIndex = 14;
            // 
            // lblInboundDate
            // 
            this.lblInboundDate.AutoSize = true;
            this.lblInboundDate.Location = new System.Drawing.Point(332, 18);
            this.lblInboundDate.Name = "lblInboundDate";
            this.lblInboundDate.Size = new System.Drawing.Size(29, 12);
            this.lblInboundDate.TabIndex = 13;
            this.lblInboundDate.Text = "日期";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(87, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 21);
            this.txtCode.TabIndex = 12;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.dataGridViewDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 80);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(984, 343);
            this.panelDetail.TabIndex = 12;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemCode,
            this.ItemQuantity,
            this.ItemName,
            this.ItemDimensions,
            this.ItemBalance,
            this.ItemUnitPrice,
            this.Quantity,
            this.TransferQuantity,
            this.PrescrapQuantity,
            this.ScrapReason});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDetail.RowTemplate.Height = 23;
            this.dataGridViewDetail.Size = new System.Drawing.Size(984, 343);
            this.dataGridViewDetail.TabIndex = 9;
            this.dataGridViewDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDetail_CellValidating);
            this.dataGridViewDetail.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewDetail_RowValidating);
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
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.ItemQuantity.DefaultCellStyle = dataGridViewCellStyle2;
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
            // ItemBalance
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.ItemBalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemBalance.HeaderText = "未归还数";
            this.ItemBalance.Name = "ItemBalance";
            this.ItemBalance.ReadOnly = true;
            // 
            // ItemUnitPrice
            // 
            this.ItemUnitPrice.HeaderText = "单价";
            this.ItemUnitPrice.Name = "ItemUnitPrice";
            this.ItemUnitPrice.Visible = false;
            // 
            // Quantity
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantity.HeaderText = "归还数";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 72;
            // 
            // TransferQuantity
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.TransferQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.TransferQuantity.HeaderText = "转借数";
            this.TransferQuantity.Name = "TransferQuantity";
            this.TransferQuantity.Width = 72;
            // 
            // PrescrapQuantity
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.PrescrapQuantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.PrescrapQuantity.HeaderText = "预报废数";
            this.PrescrapQuantity.Name = "PrescrapQuantity";
            this.PrescrapQuantity.Width = 96;
            // 
            // ScrapReason
            // 
            this.ScrapReason.HeaderText = "报废原因";
            this.ScrapReason.Name = "ScrapReason";
            // 
            // CreateInboundOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelMaster);
            this.Controls.Add(this._operationsPanel);
            this.Name = "CreateInboundOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "归还单管理";
            this.Load += new System.EventHandler(this.CreateInboundOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this._operationsPanel.ResumeLayout(false);
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbSystemUser;
        private System.Windows.Forms.Label lblSystemUser;
        private System.Windows.Forms.DateTimePicker dtInboundDate;
        private System.Windows.Forms.Label lblInboundDate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnTransferAll;
        private System.Windows.Forms.Button btnReturnAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescrapQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScrapReason;

    }
}