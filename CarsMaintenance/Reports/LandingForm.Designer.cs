namespace CarsMaintenance.Reports
{
    partial class LandingForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.line3 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbIO = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.gbIO.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbMessage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbSummary, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbIO, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 523);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbMessage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbMessage, 2);
            this.gbMessage.Controls.Add(this.line3);
            this.gbMessage.Controls.Add(this.line2);
            this.gbMessage.Controls.Add(this.line1);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMessage.Location = new System.Drawing.Point(3, 3);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(796, 114);
            this.gbMessage.TabIndex = 0;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "公告栏";
            // 
            // line3
            // 
            this.line3.AutoSize = true;
            this.line3.Location = new System.Drawing.Point(29, 81);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(35, 12);
            this.line3.TabIndex = 2;
            this.line3.Text = "line3";
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Location = new System.Drawing.Point(29, 56);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(35, 12);
            this.line2.TabIndex = 1;
            this.line2.Text = "line2";
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(29, 30);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(35, 12);
            this.line1.TabIndex = 0;
            this.line1.Text = "line1";
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.lblOut);
            this.gbSummary.Controls.Add(this.lblStock);
            this.gbSummary.Controls.Add(this.lblTotal);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.label4);
            this.gbSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSummary.Location = new System.Drawing.Point(3, 123);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(395, 114);
            this.gbSummary.TabIndex = 1;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "工具属统计情况";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "总外借数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "总在库数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "总额定数:";
            // 
            // gbIO
            // 
            this.gbIO.Controls.Add(this.label9);
            this.gbIO.Controls.Add(this.label8);
            this.gbIO.Controls.Add(this.label7);
            this.gbIO.Controls.Add(this.label3);
            this.gbIO.Controls.Add(this.label2);
            this.gbIO.Controls.Add(this.label1);
            this.gbIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIO.Location = new System.Drawing.Point(3, 243);
            this.gbIO.Name = "gbIO";
            this.gbIO.Size = new System.Drawing.Size(395, 174);
            this.gbIO.TabIndex = 2;
            this.gbIO.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "报废";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "借还";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "当年累计:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "当月累计:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "第二班:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "第一班:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRoles);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(404, 123);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 294);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "今日当班";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(158, 40);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(47, 12);
            this.lblRoles.TabIndex = 1;
            this.lblRoles.Text = "label10";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(32, 40);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label10";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(115, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 12);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "label10";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(115, 60);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 12);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "label11";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(115, 86);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(47, 12);
            this.lblOut.TabIndex = 5;
            this.lblOut.Text = "label12";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 523);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LandingForm";
            this.Text = "工属具使用情况";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbIO.ResumeLayout(false);
            this.gbIO.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbIO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTotal;
    }
}