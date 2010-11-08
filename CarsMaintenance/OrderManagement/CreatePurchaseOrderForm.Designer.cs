namespace CarsMaintenance.OrderManagement
{
    partial class CreatePurchaseOrderForm
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
            this.cbSupply = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblTool = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this.lblSupply = new System.Windows.Forms.Label();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this._cancelButton = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.cbTool = new System.Windows.Forms.ComboBox();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSupply
            // 
            this.cbSupply.FormattingEnabled = true;
            this.cbSupply.Location = new System.Drawing.Point(97, 44);
            this.cbSupply.Name = "cbSupply";
            this.cbSupply.Size = new System.Drawing.Size(196, 20);
            this.cbSupply.TabIndex = 5;
            this.cbSupply.Validating += new System.ComponentModel.CancelEventHandler(this.cbSupply_Validating);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(97, 71);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(196, 21);
            this.txtQuantity.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 75);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(29, 12);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "数量";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(423, 71);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(196, 21);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Location = new System.Drawing.Point(342, 47);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(41, 12);
            this.lblTool.TabIndex = 6;
            this.lblTool.Text = "工属具";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(342, 75);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 12);
            this.lblUnitPrice.TabIndex = 10;
            this.lblUnitPrice.Text = "单价";
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
            // lblSupply
            // 
            this.lblSupply.AutoSize = true;
            this.lblSupply.Location = new System.Drawing.Point(16, 49);
            this.lblSupply.Name = "lblSupply";
            this.lblSupply.Size = new System.Drawing.Size(41, 12);
            this.lblSupply.TabIndex = 4;
            this.lblSupply.Text = "供应商";
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 215);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(647, 39);
            this._operationsPanel.TabIndex = 14;
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
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(97, 99);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(196, 105);
            this.txtComment.TabIndex = 13;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(16, 102);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(29, 12);
            this.lblComment.TabIndex = 12;
            this.lblComment.Text = "备注";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(342, 20);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(53, 12);
            this.lblPurchaseDate.TabIndex = 2;
            this.lblPurchaseDate.Text = "采购日期";
            // 
            // cbTool
            // 
            this.cbTool.FormattingEnabled = true;
            this.cbTool.Location = new System.Drawing.Point(423, 44);
            this.cbTool.Name = "cbTool";
            this.cbTool.Size = new System.Drawing.Size(196, 20);
            this.cbTool.TabIndex = 7;
            this.cbTool.Validating += new System.ComponentModel.CancelEventHandler(this.cbTool_Validating);
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.Location = new System.Drawing.Point(423, 16);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(196, 21);
            this.dtPurchaseDate.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(97, 16);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(196, 21);
            this.txtCode.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(16, 20);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "采购单号";
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // CreatePurchaseOrderForm
            // 
            this.AcceptButton = this._saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(647, 254);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dtPurchaseDate);
            this.Controls.Add(this.cbTool);
            this.Controls.Add(this.cbSupply);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblTool);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblSupply);
            this.Controls.Add(this._operationsPanel);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblPurchaseDate);
            this.Name = "CreatePurchaseOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "采购单管理";
            this.Load += new System.EventHandler(this.CreatePurchaseOrderForm_Load);
            this._operationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSupply;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Label lblSupply;
        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.ComboBox cbTool;
        private System.Windows.Forms.DateTimePicker dtPurchaseDate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}