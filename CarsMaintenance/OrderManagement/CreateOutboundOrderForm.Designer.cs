namespace CarsMaintenance.OrderManagement
{
    partial class CreateOutboundOrderForm
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
            this._cancelButton = new System.Windows.Forms.Button();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.cbSystemUser = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSystemUser = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.gbJob = new System.Windows.Forms.GroupBox();
            this.cbJobType = new System.Windows.Forms.ComboBox();
            this.cbJobPosition = new System.Windows.Forms.ComboBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.lblJobType = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblJobPosition = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtHatch = new System.Windows.Forms.TextBox();
            this.lblHatch = new System.Windows.Forms.Label();
            this.txtShip = new System.Windows.Forms.TextBox();
            this.lblShip = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.txtBerth = new System.Windows.Forms.TextBox();
            this.lblBerth = new System.Windows.Forms.Label();
            this.rbNight = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.lblGroup = new System.Windows.Forms.Label();
            this.dtOutboundDate = new System.Windows.Forms.DateTimePicker();
            this.lblOutboundDate = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this._saveButton = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.panelMaster.SuspendLayout();
            this.gbJob.SuspendLayout();
            this._operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _cancelButton
            // 
            this._cancelButton.CausesValidation = false;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(557, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 33);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "取消";
            this._cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.dataGridViewDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 301);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(683, 333);
            this.panelDetail.TabIndex = 1;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemQuantity,
            this.ItemBalance,
            this.ItemName,
            this.ItemDimensions});
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 23;
            this.dataGridViewDetail.Size = new System.Drawing.Size(683, 333);
            this.dataGridViewDetail.TabIndex = 0;
            this.dataGridViewDetail.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetail_CellEnter);
            this.dataGridViewDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDetail_CellValidating);
            this.dataGridViewDetail.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetail_RowValidated);
            this.dataGridViewDetail.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewDetail_UserDeletingRow);
            this.dataGridViewDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDetail_KeyDown);
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.cbSystemUser);
            this.panelMaster.Controls.Add(this.cbCustomer);
            this.panelMaster.Controls.Add(this.txtVersion);
            this.panelMaster.Controls.Add(this.lblVersion);
            this.panelMaster.Controls.Add(this.lblSystemUser);
            this.panelMaster.Controls.Add(this.lblCustomer);
            this.panelMaster.Controls.Add(this.txtJob);
            this.panelMaster.Controls.Add(this.lblJob);
            this.panelMaster.Controls.Add(this.gbJob);
            this.panelMaster.Controls.Add(this.rbNight);
            this.panelMaster.Controls.Add(this.rbDay);
            this.panelMaster.Controls.Add(this.lblGroup);
            this.panelMaster.Controls.Add(this.dtOutboundDate);
            this.panelMaster.Controls.Add(this.lblOutboundDate);
            this.panelMaster.Controls.Add(this.txtCode);
            this.panelMaster.Controls.Add(this.lblCode);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(683, 301);
            this.panelMaster.TabIndex = 0;
            // 
            // cbSystemUser
            // 
            this.cbSystemUser.FormattingEnabled = true;
            this.cbSystemUser.Location = new System.Drawing.Point(423, 269);
            this.cbSystemUser.Name = "cbSystemUser";
            this.cbSystemUser.Size = new System.Drawing.Size(200, 20);
            this.cbSystemUser.TabIndex = 15;
            this.cbSystemUser.Validating += new System.ComponentModel.CancelEventHandler(this.cbSystemUser_Validating);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(100, 270);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(200, 20);
            this.cbCustomer.TabIndex = 13;
            this.cbCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.cbCustomer_Validating);
            // 
            // txtVersion
            // 
            this.txtVersion.Enabled = false;
            this.txtVersion.Location = new System.Drawing.Point(446, 17);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(200, 21);
            this.txtVersion.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(378, 20);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(53, 12);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "补借次数";
            // 
            // lblSystemUser
            // 
            this.lblSystemUser.AutoSize = true;
            this.lblSystemUser.Location = new System.Drawing.Point(375, 271);
            this.lblSystemUser.Name = "lblSystemUser";
            this.lblSystemUser.Size = new System.Drawing.Size(41, 12);
            this.lblSystemUser.TabIndex = 14;
            this.lblSystemUser.Text = "收发工";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(32, 271);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(41, 12);
            this.lblCustomer.TabIndex = 12;
            this.lblCustomer.Text = "装卸组";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(100, 70);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(200, 21);
            this.txtJob.TabIndex = 10;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(32, 73);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(65, 12);
            this.lblJob.TabIndex = 9;
            this.lblJob.Text = "作业工单号";
            // 
            // gbJob
            // 
            this.gbJob.Controls.Add(this.cbJobType);
            this.gbJob.Controls.Add(this.cbJobPosition);
            this.gbJob.Controls.Add(this.txtProcess);
            this.gbJob.Controls.Add(this.lblJobType);
            this.gbJob.Controls.Add(this.lblProcess);
            this.gbJob.Controls.Add(this.lblJobPosition);
            this.gbJob.Controls.Add(this.txtQuantity);
            this.gbJob.Controls.Add(this.lblQuantity);
            this.gbJob.Controls.Add(this.txtCargo);
            this.gbJob.Controls.Add(this.lblCargo);
            this.gbJob.Controls.Add(this.txtHatch);
            this.gbJob.Controls.Add(this.lblHatch);
            this.gbJob.Controls.Add(this.txtShip);
            this.gbJob.Controls.Add(this.lblShip);
            this.gbJob.Controls.Add(this.txtMachine);
            this.gbJob.Controls.Add(this.lblMachine);
            this.gbJob.Controls.Add(this.txtBerth);
            this.gbJob.Controls.Add(this.lblBerth);
            this.gbJob.Location = new System.Drawing.Point(21, 106);
            this.gbJob.Name = "gbJob";
            this.gbJob.Size = new System.Drawing.Size(634, 155);
            this.gbJob.TabIndex = 11;
            this.gbJob.TabStop = false;
            this.gbJob.Text = "作业信息";
            // 
            // cbJobType
            // 
            this.cbJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobType.FormattingEnabled = true;
            this.cbJobType.Location = new System.Drawing.Point(403, 20);
            this.cbJobType.Name = "cbJobType";
            this.cbJobType.Size = new System.Drawing.Size(200, 20);
            this.cbJobType.TabIndex = 3;
            // 
            // cbJobPosition
            // 
            this.cbJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobPosition.FormattingEnabled = true;
            this.cbJobPosition.Location = new System.Drawing.Point(79, 18);
            this.cbJobPosition.Name = "cbJobPosition";
            this.cbJobPosition.Size = new System.Drawing.Size(200, 20);
            this.cbJobPosition.TabIndex = 1;
            // 
            // txtProcess
            // 
            this.txtProcess.Enabled = false;
            this.txtProcess.Location = new System.Drawing.Point(79, 126);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(200, 21);
            this.txtProcess.TabIndex = 17;
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new System.Drawing.Point(334, 23);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(29, 12);
            this.lblJobType.TabIndex = 2;
            this.lblJobType.Text = "类型";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(11, 129);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(53, 12);
            this.lblProcess.TabIndex = 16;
            this.lblProcess.Text = "操作过程";
            // 
            // lblJobPosition
            // 
            this.lblJobPosition.AutoSize = true;
            this.lblJobPosition.Location = new System.Drawing.Point(11, 20);
            this.lblJobPosition.Name = "lblJobPosition";
            this.lblJobPosition.Size = new System.Drawing.Size(53, 12);
            this.lblJobPosition.TabIndex = 0;
            this.lblJobPosition.Text = "作业位置";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(402, 102);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 21);
            this.txtQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(334, 105);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(29, 12);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "数量";
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(79, 99);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(200, 21);
            this.txtCargo.TabIndex = 13;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(11, 102);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(29, 12);
            this.lblCargo.TabIndex = 12;
            this.lblCargo.Text = "货种";
            // 
            // txtHatch
            // 
            this.txtHatch.Enabled = false;
            this.txtHatch.Location = new System.Drawing.Point(402, 75);
            this.txtHatch.Name = "txtHatch";
            this.txtHatch.Size = new System.Drawing.Size(200, 21);
            this.txtHatch.TabIndex = 11;
            // 
            // lblHatch
            // 
            this.lblHatch.AutoSize = true;
            this.lblHatch.Location = new System.Drawing.Point(334, 78);
            this.lblHatch.Name = "lblHatch";
            this.lblHatch.Size = new System.Drawing.Size(29, 12);
            this.lblHatch.TabIndex = 10;
            this.lblHatch.Text = "舱口";
            // 
            // txtShip
            // 
            this.txtShip.Enabled = false;
            this.txtShip.Location = new System.Drawing.Point(79, 72);
            this.txtShip.Name = "txtShip";
            this.txtShip.Size = new System.Drawing.Size(200, 21);
            this.txtShip.TabIndex = 9;
            // 
            // lblShip
            // 
            this.lblShip.AutoSize = true;
            this.lblShip.Location = new System.Drawing.Point(11, 75);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(29, 12);
            this.lblShip.TabIndex = 8;
            this.lblShip.Text = "船名";
            // 
            // txtMachine
            // 
            this.txtMachine.Enabled = false;
            this.txtMachine.Location = new System.Drawing.Point(402, 48);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(200, 21);
            this.txtMachine.TabIndex = 7;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(334, 51);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(53, 12);
            this.lblMachine.TabIndex = 6;
            this.lblMachine.Text = "使用机械";
            // 
            // txtBerth
            // 
            this.txtBerth.Enabled = false;
            this.txtBerth.Location = new System.Drawing.Point(79, 45);
            this.txtBerth.Name = "txtBerth";
            this.txtBerth.Size = new System.Drawing.Size(200, 21);
            this.txtBerth.TabIndex = 5;
            // 
            // lblBerth
            // 
            this.lblBerth.AutoSize = true;
            this.lblBerth.Location = new System.Drawing.Point(11, 48);
            this.lblBerth.Name = "lblBerth";
            this.lblBerth.Size = new System.Drawing.Size(53, 12);
            this.lblBerth.TabIndex = 4;
            this.lblBerth.Text = "码头泊位";
            // 
            // rbNight
            // 
            this.rbNight.AutoSize = true;
            this.rbNight.Enabled = false;
            this.rbNight.Location = new System.Drawing.Point(492, 49);
            this.rbNight.Name = "rbNight";
            this.rbNight.Size = new System.Drawing.Size(47, 16);
            this.rbNight.TabIndex = 8;
            this.rbNight.Text = "夜班";
            this.rbNight.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Checked = true;
            this.rbDay.Enabled = false;
            this.rbDay.Location = new System.Drawing.Point(423, 49);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(47, 16);
            this.rbDay.TabIndex = 7;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "日班";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(375, 49);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(29, 12);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "班别";
            // 
            // dtOutboundDate
            // 
            this.dtOutboundDate.Location = new System.Drawing.Point(100, 43);
            this.dtOutboundDate.Name = "dtOutboundDate";
            this.dtOutboundDate.Size = new System.Drawing.Size(200, 21);
            this.dtOutboundDate.TabIndex = 5;
            // 
            // lblOutboundDate
            // 
            this.lblOutboundDate.AutoSize = true;
            this.lblOutboundDate.Location = new System.Drawing.Point(32, 49);
            this.lblOutboundDate.Name = "lblOutboundDate";
            this.lblOutboundDate.Size = new System.Drawing.Size(29, 12);
            this.lblOutboundDate.TabIndex = 4;
            this.lblOutboundDate.Text = "日期";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(100, 17);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 21);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(32, 20);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "借用单号";
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 634);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(683, 39);
            this._operationsPanel.TabIndex = 2;
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(476, 3);
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
            // ItemCode
            // 
            this.ItemCode.HeaderText = "工属具编码";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 120;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "数量";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Width = 120;
            // 
            // ItemBalance
            // 
            this.ItemBalance.HeaderText = "未归还数";
            this.ItemBalance.Name = "ItemBalance";
            this.ItemBalance.ReadOnly = true;
            this.ItemBalance.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 120;
            // 
            // ItemDimensions
            // 
            this.ItemDimensions.HeaderText = "规格";
            this.ItemDimensions.Name = "ItemDimensions";
            this.ItemDimensions.ReadOnly = true;
            this.ItemDimensions.Width = 120;
            // 
            // CreateOutboundOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(683, 673);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelMaster);
            this.Controls.Add(this._operationsPanel);
            this.Name = "CreateOutboundOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "借用单管理";
            this.Load += new System.EventHandler(this.CreateOutboundOrderForm_Load);
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            this.gbJob.ResumeLayout(false);
            this.gbJob.PerformLayout();
            this._operationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.ComboBox cbSystemUser;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSystemUser;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.GroupBox gbJob;
        private System.Windows.Forms.ComboBox cbJobType;
        private System.Windows.Forms.ComboBox cbJobPosition;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblJobPosition;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtHatch;
        private System.Windows.Forms.Label lblHatch;
        private System.Windows.Forms.TextBox txtShip;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.TextBox txtBerth;
        private System.Windows.Forms.Label lblBerth;
        private System.Windows.Forms.RadioButton rbNight;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.DateTimePicker dtOutboundDate;
        private System.Windows.Forms.Label lblOutboundDate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDimensions;
    }
}