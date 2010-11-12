namespace CarsMaintenance.ToolManagement
{
    partial class ManageToolGroupForm
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
            this.txtRatedQuantity = new System.Windows.Forms.TextBox();
            this.lblRatedQuantity = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLoad2 = new System.Windows.Forms.TextBox();
            this.lblLoad2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblDiaMeter = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblDimensions = new System.Windows.Forms.Label();
            this._cancelButton = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this._saveButton = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this._operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRatedQuantity
            // 
            this.txtRatedQuantity.Location = new System.Drawing.Point(98, 142);
            this.txtRatedQuantity.Name = "txtRatedQuantity";
            this.txtRatedQuantity.Size = new System.Drawing.Size(196, 21);
            this.txtRatedQuantity.TabIndex = 44;
            // 
            // lblRatedQuantity
            // 
            this.lblRatedQuantity.AutoSize = true;
            this.lblRatedQuantity.Location = new System.Drawing.Point(17, 145);
            this.lblRatedQuantity.Name = "lblRatedQuantity";
            this.lblRatedQuantity.Size = new System.Drawing.Size(41, 12);
            this.lblRatedQuantity.TabIndex = 43;
            this.lblRatedQuantity.Text = "额定数";
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(428, 88);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 21);
            this.txtDescription.TabIndex = 38;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(347, 91);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(29, 12);
            this.lblDescription.TabIndex = 37;
            this.lblDescription.Text = "描述";
            // 
            // txtLoad2
            // 
            this.txtLoad2.Location = new System.Drawing.Point(428, 34);
            this.txtLoad2.Name = "txtLoad2";
            this.txtLoad2.Size = new System.Drawing.Size(196, 21);
            this.txtLoad2.TabIndex = 30;
            // 
            // lblLoad2
            // 
            this.lblLoad2.AutoSize = true;
            this.lblLoad2.Location = new System.Drawing.Point(347, 37);
            this.lblLoad2.Name = "lblLoad2";
            this.lblLoad2.Size = new System.Drawing.Size(29, 12);
            this.lblLoad2.TabIndex = 29;
            this.lblLoad2.Text = "负载";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(428, 61);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(196, 21);
            this.txtLength.TabIndex = 34;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(347, 64);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(29, 12);
            this.lblLength.TabIndex = 33;
            this.lblLength.Text = "长度";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(98, 61);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(196, 21);
            this.txtDiameter.TabIndex = 32;
            // 
            // lblDiaMeter
            // 
            this.lblDiaMeter.AutoSize = true;
            this.lblDiaMeter.Location = new System.Drawing.Point(17, 64);
            this.lblDiaMeter.Name = "lblDiaMeter";
            this.lblDiaMeter.Size = new System.Drawing.Size(29, 12);
            this.lblDiaMeter.TabIndex = 31;
            this.lblDiaMeter.Text = "直径";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(98, 8);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(196, 20);
            this.cbCategory.TabIndex = 24;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(98, 88);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(196, 21);
            this.txtUnit.TabIndex = 36;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(17, 91);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 12);
            this.lblUnit.TabIndex = 35;
            this.lblUnit.Text = "单位";
            // 
            // txtDimensions
            // 
            this.txtDimensions.Location = new System.Drawing.Point(98, 115);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.ReadOnly = true;
            this.txtDimensions.Size = new System.Drawing.Size(196, 21);
            this.txtDimensions.TabIndex = 40;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(347, 11);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 25;
            this.lblCode.Text = "工具编码";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(428, 8);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(196, 21);
            this.txtCode.TabIndex = 26;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(17, 118);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(53, 12);
            this.lblDimensions.TabIndex = 39;
            this.lblDimensions.Text = "规格参数";
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 21);
            this.txtName.TabIndex = 28;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(17, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(53, 12);
            this.lblCategory.TabIndex = 23;
            this.lblCategory.Text = "所属类别";
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 452);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(646, 39);
            this._operationsPanel.TabIndex = 45;
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
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(428, 115);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(196, 105);
            this.txtComment.TabIndex = 42;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "工具名称";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(347, 118);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(29, 12);
            this.lblComment.TabIndex = 41;
            this.lblComment.Text = "备注";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemQuantity,
            this.ItemName,
            this.ItemDimensions});
            this.dataGridViewDetail.Location = new System.Drawing.Point(19, 245);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 23;
            this.dataGridViewDetail.Size = new System.Drawing.Size(605, 181);
            this.dataGridViewDetail.TabIndex = 46;
            this.dataGridViewDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDetail_CellValidating);
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "工属具编码";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 90;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "数量";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Width = 90;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 90;
            // 
            // ItemDimensions
            // 
            this.ItemDimensions.HeaderText = "规格";
            this.ItemDimensions.Name = "ItemDimensions";
            this.ItemDimensions.Width = 90;
            // 
            // ManageToolGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 491);
            this.Controls.Add(this.dataGridViewDetail);
            this.Controls.Add(this.txtRatedQuantity);
            this.Controls.Add(this.lblRatedQuantity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtLoad2);
            this.Controls.Add(this.lblLoad2);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblDiaMeter);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtDimensions);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this._operationsPanel);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblComment);
            this.Name = "ManageToolGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工属具组合管理";
            this.Load += new System.EventHandler(this.ManageToolGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this._operationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRatedQuantity;
        private System.Windows.Forms.Label lblRatedQuantity;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtLoad2;
        private System.Windows.Forms.Label lblLoad2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblDiaMeter;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDimensions;
    }
}