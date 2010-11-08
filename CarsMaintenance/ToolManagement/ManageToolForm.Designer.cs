namespace CarsMaintenance.ToolManagement
{
    partial class ManageToolForm
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblDiaMeter = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLoad2 = new System.Windows.Forms.TextBox();
            this.lblLoad2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtRatedQuantity = new System.Windows.Forms.TextBox();
            this.lblRatedQuantity = new System.Windows.Forms.Label();
            this._operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(98, 12);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(196, 20);
            this.cbCategory.TabIndex = 1;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(98, 92);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(196, 21);
            this.txtUnit.TabIndex = 13;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(17, 95);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 12);
            this.lblUnit.TabIndex = 12;
            this.lblUnit.Text = "单位";
            // 
            // txtDimensions
            // 
            this.txtDimensions.Location = new System.Drawing.Point(98, 119);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.ReadOnly = true;
            this.txtDimensions.Size = new System.Drawing.Size(196, 21);
            this.txtDimensions.TabIndex = 17;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(347, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "工具编码";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(428, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(196, 21);
            this.txtCode.TabIndex = 3;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(17, 122);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(53, 12);
            this.lblDimensions.TabIndex = 16;
            this.lblDimensions.Text = "规格参数";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 21);
            this.txtName.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(17, 15);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(53, 12);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "所属类别";
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 247);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(641, 39);
            this._operationsPanel.TabIndex = 22;
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
            this.txtComment.Location = new System.Drawing.Point(428, 119);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(196, 105);
            this.txtComment.TabIndex = 19;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(347, 122);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(29, 12);
            this.lblComment.TabIndex = 18;
            this.lblComment.Text = "备注";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "工具名称";
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(98, 65);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(196, 21);
            this.txtDiameter.TabIndex = 9;
            // 
            // lblDiaMeter
            // 
            this.lblDiaMeter.AutoSize = true;
            this.lblDiaMeter.Location = new System.Drawing.Point(17, 68);
            this.lblDiaMeter.Name = "lblDiaMeter";
            this.lblDiaMeter.Size = new System.Drawing.Size(29, 12);
            this.lblDiaMeter.TabIndex = 8;
            this.lblDiaMeter.Text = "直径";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(428, 65);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(196, 21);
            this.txtLength.TabIndex = 11;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(347, 68);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(29, 12);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "长度";
            // 
            // txtLoad2
            // 
            this.txtLoad2.Location = new System.Drawing.Point(428, 38);
            this.txtLoad2.Name = "txtLoad2";
            this.txtLoad2.Size = new System.Drawing.Size(196, 21);
            this.txtLoad2.TabIndex = 7;
            // 
            // lblLoad2
            // 
            this.lblLoad2.AutoSize = true;
            this.lblLoad2.Location = new System.Drawing.Point(347, 41);
            this.lblLoad2.Name = "lblLoad2";
            this.lblLoad2.Size = new System.Drawing.Size(29, 12);
            this.lblLoad2.TabIndex = 6;
            this.lblLoad2.Text = "负载";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(428, 92);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 21);
            this.txtDescription.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(347, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(29, 12);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "描述";
            // 
            // txtRatedQuantity
            // 
            this.txtRatedQuantity.Location = new System.Drawing.Point(98, 146);
            this.txtRatedQuantity.Name = "txtRatedQuantity";
            this.txtRatedQuantity.Size = new System.Drawing.Size(196, 21);
            this.txtRatedQuantity.TabIndex = 21;
            // 
            // lblRatedQuantity
            // 
            this.lblRatedQuantity.AutoSize = true;
            this.lblRatedQuantity.Location = new System.Drawing.Point(17, 149);
            this.lblRatedQuantity.Name = "lblRatedQuantity";
            this.lblRatedQuantity.Size = new System.Drawing.Size(41, 12);
            this.lblRatedQuantity.TabIndex = 20;
            this.lblRatedQuantity.Text = "额定数";
            // 
            // ManageToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 286);
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
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblName);
            this.Name = "ManageToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工属具管理";
            this.Load += new System.EventHandler(this.ManageToolForm_Load);
            this._operationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblDiaMeter;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtLoad2;
        private System.Windows.Forms.Label lblLoad2;
        private System.Windows.Forms.TextBox txtRatedQuantity;
        private System.Windows.Forms.Label lblRatedQuantity;
    }
}