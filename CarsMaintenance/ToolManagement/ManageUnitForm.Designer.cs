namespace CarsMaintenance.ToolManagement
{
    partial class ManageUnitForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this._saveButton = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this._cancelButton = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblParentUnit = new System.Windows.Forms.Label();
            this.txtParentUnit = new System.Windows.Forms.TextBox();
            this._operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 21);
            this.txtName.TabIndex = 5;
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(235, 3);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 33);
            this._saveButton.TabIndex = 0;
            this._saveButton.Text = "保存";
            this._saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 42);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "组织编码";
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 223);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(403, 39);
            this._operationsPanel.TabIndex = 8;
            // 
            // _cancelButton
            // 
            this._cancelButton.CausesValidation = false;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(316, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 33);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "取消";
            this._cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(124, 97);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(196, 105);
            this.txtComment.TabIndex = 7;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(124, 39);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(196, 21);
            this.txtCode.TabIndex = 3;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(20, 100);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(29, 12);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "备注";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "组织名称";
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // lblParentUnit
            // 
            this.lblParentUnit.AutoSize = true;
            this.lblParentUnit.Location = new System.Drawing.Point(20, 15);
            this.lblParentUnit.Name = "lblParentUnit";
            this.lblParentUnit.Size = new System.Drawing.Size(53, 12);
            this.lblParentUnit.TabIndex = 0;
            this.lblParentUnit.Text = "上级组织";
            // 
            // txtParentUnit
            // 
            this.txtParentUnit.Enabled = false;
            this.txtParentUnit.Location = new System.Drawing.Point(124, 11);
            this.txtParentUnit.Name = "txtParentUnit";
            this.txtParentUnit.Size = new System.Drawing.Size(196, 21);
            this.txtParentUnit.TabIndex = 1;
            // 
            // ManageUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.lblParentUnit);
            this.Controls.Add(this.txtParentUnit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this._operationsPanel);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblName);
            this.Name = "ManageUnitForm";
            this.Text = "组织管理";
            this.Load += new System.EventHandler(this.ManageUnitForm_Load);
            this._operationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Label lblParentUnit;
        private System.Windows.Forms.TextBox txtParentUnit;
    }
}