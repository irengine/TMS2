namespace CarsMaintenance.UserManagement
{
    partial class ManageSystemUserForm
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
            this._operationsPanel = new System.Windows.Forms.Panel();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbRoles = new System.Windows.Forms.ListBox();
            this.gbRoles = new System.Windows.Forms.GroupBox();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._operationsPanel.SuspendLayout();
            this.gbRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 315);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(331, 39);
            this._operationsPanel.TabIndex = 7;
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(170, 3);
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
            this._cancelButton.Location = new System.Drawing.Point(251, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 33);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "取消";
            this._cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(25, 25);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "用户编码";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 12);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "密码";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(106, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(196, 21);
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 21);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbRoles
            // 
            this.lbRoles.FormattingEnabled = true;
            this.lbRoles.ItemHeight = 12;
            this.lbRoles.Location = new System.Drawing.Point(6, 20);
            this.lbRoles.Name = "lbRoles";
            this.lbRoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRoles.Size = new System.Drawing.Size(263, 124);
            this.lbRoles.TabIndex = 0;
            // 
            // gbRoles
            // 
            this.gbRoles.Controls.Add(this.lbRoles);
            this.gbRoles.Location = new System.Drawing.Point(27, 128);
            this.gbRoles.Name = "gbRoles";
            this.gbRoles.Size = new System.Drawing.Size(275, 159);
            this.gbRoles.TabIndex = 6;
            this.gbRoles.TabStop = false;
            this.gbRoles.Text = "角色";
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // ManageSystemUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 354);
            this.Controls.Add(this.gbRoles);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this._operationsPanel);
            this.Name = "ManageSystemUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统用户信息";
            this.Load += new System.EventHandler(this.ManageSystemUserForm_Load);
            this._operationsPanel.ResumeLayout(false);
            this.gbRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ListBox lbRoles;
        private System.Windows.Forms.GroupBox gbRoles;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}