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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Currently_Time = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbScrap = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Gv_type = new System.Windows.Forms.DataGridView();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Lb_Time = new System.Windows.Forms.Label();
            this.Lb_Date = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRoles = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.line3 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.gbIO = new System.Windows.Forms.GroupBox();
            this.lblYearScrap = new System.Windows.Forms.Label();
            this.lblYearOut = new System.Windows.Forms.Label();
            this.lblMonthScrap = new System.Windows.Forms.Label();
            this.lblMonthOut = new System.Windows.Forms.Label();
            this.lblDay2Out = new System.Windows.Forms.Label();
            this.lblDayScrap = new System.Windows.Forms.Label();
            this.lblDay1Out = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_type)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.gbIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // Currently_Time
            // 
            this.Currently_Time.Enabled = true;
            this.Currently_Time.Interval = 1000;
            this.Currently_Time.Tick += new System.EventHandler(this.Currently_Time_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.gbMessage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbIO, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.lbScrap);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.Gv_type);
            this.groupBox3.Controls.Add(this.lblOut);
            this.groupBox3.Controls.Add(this.lblStock);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(895, 170);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "工属具统计情况";
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(17, 128);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(1203, 1);
            this.label27.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(151, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 12);
            this.label24.TabIndex = 21;
            this.label24.Text = "件";
            // 
            // lbScrap
            // 
            this.lbScrap.AutoSize = true;
            this.lbScrap.Location = new System.Drawing.Point(98, 110);
            this.lbScrap.Name = "lbScrap";
            this.lbScrap.Size = new System.Drawing.Size(47, 12);
            this.lbScrap.TabIndex = 20;
            this.lbScrap.Text = "label12";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 110);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 12);
            this.label26.TabIndex = 19;
            this.label26.Text = "总报废数:";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(17, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1203, 1);
            this.label23.TabIndex = 18;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(17, 76);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1203, 1);
            this.label22.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(17, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1203, 1);
            this.label21.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(151, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 15;
            this.label18.Text = "件";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(151, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 14;
            this.label19.Text = "件";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(151, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 13;
            this.label20.Text = "件";
            // 
            // Gv_type
            // 
            this.Gv_type.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gv_type.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Gv_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gv_type.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Gv_type.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Gv_type.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_type.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gv_type.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gv_type.Enabled = false;
            this.Gv_type.EnableHeadersVisualStyles = false;
            this.Gv_type.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.Gv_type.Location = new System.Drawing.Point(200, 14);
            this.Gv_type.MultiSelect = false;
            this.Gv_type.Name = "Gv_type";
            this.Gv_type.ReadOnly = true;
            this.Gv_type.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_type.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Gv_type.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.Gv_type.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Gv_type.RowTemplate.Height = 25;
            this.Gv_type.ShowCellErrors = false;
            this.Gv_type.ShowCellToolTips = false;
            this.Gv_type.ShowEditingIcon = false;
            this.Gv_type.ShowRowErrors = false;
            this.Gv_type.Size = new System.Drawing.Size(943, 140);
            this.Gv_type.TabIndex = 12;
            this.Gv_type.Visible = false;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(98, 82);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(47, 12);
            this.lblOut.TabIndex = 11;
            this.lblOut.Text = "label12";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(98, 58);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 12);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "label11";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(98, 33);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 12);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "label10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "总外借数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "总在库数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "总额定数:";
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.Lb_Time);
            this.groupBox2.Controls.Add(this.Lb_Date);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(512, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "工属具使用情况";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(523, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 14);
            this.label16.TabIndex = 6;
            this.label16.Text = "工属具管理应用系统";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(425, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(315, 14);
            this.label15.TabIndex = 5;
            this.label15.Text = "上港国际港务（集团）股份有限公司军工路分公司";
            // 
            // Lb_Time
            // 
            this.Lb_Time.AutoSize = true;
            this.Lb_Time.Location = new System.Drawing.Point(226, 92);
            this.Lb_Time.Name = "Lb_Time";
            this.Lb_Time.Size = new System.Drawing.Size(47, 12);
            this.Lb_Time.TabIndex = 4;
            this.Lb_Time.Text = "label15";
            // 
            // Lb_Date
            // 
            this.Lb_Date.AutoSize = true;
            this.Lb_Date.Location = new System.Drawing.Point(130, 92);
            this.Lb_Date.Name = "Lb_Date";
            this.Lb_Date.Size = new System.Drawing.Size(47, 12);
            this.Lb_Date.TabIndex = 3;
            this.Lb_Date.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(201, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "[";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "现在是：北京时间";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblRoles);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(453, 419);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(445, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "今日当班";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "岗位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "姓名";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(172, 53);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(47, 12);
            this.lblRoles.TabIndex = 1;
            this.lblRoles.Text = "label10";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(46, 53);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label10";
            // 
            // gbMessage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbMessage, 2);
            this.gbMessage.Controls.Add(this.line3);
            this.gbMessage.Controls.Add(this.line2);
            this.gbMessage.Controls.Add(this.line1);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMessage.Location = new System.Drawing.Point(3, 123);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(895, 114);
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
            // gbIO
            // 
            this.gbIO.Controls.Add(this.lblYearScrap);
            this.gbIO.Controls.Add(this.lblYearOut);
            this.gbIO.Controls.Add(this.lblMonthScrap);
            this.gbIO.Controls.Add(this.lblMonthOut);
            this.gbIO.Controls.Add(this.lblDay2Out);
            this.gbIO.Controls.Add(this.lblDayScrap);
            this.gbIO.Controls.Add(this.lblDay1Out);
            this.gbIO.Controls.Add(this.label9);
            this.gbIO.Controls.Add(this.label8);
            this.gbIO.Controls.Add(this.label7);
            this.gbIO.Controls.Add(this.label3);
            this.gbIO.Controls.Add(this.label2);
            this.gbIO.Controls.Add(this.label1);
            this.gbIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIO.Location = new System.Drawing.Point(3, 419);
            this.gbIO.Name = "gbIO";
            this.gbIO.Size = new System.Drawing.Size(444, 230);
            this.gbIO.TabIndex = 2;
            this.gbIO.TabStop = false;
            // 
            // lblYearScrap
            // 
            this.lblYearScrap.AutoSize = true;
            this.lblYearScrap.Location = new System.Drawing.Point(269, 133);
            this.lblYearScrap.Name = "lblYearScrap";
            this.lblYearScrap.Size = new System.Drawing.Size(47, 12);
            this.lblYearScrap.TabIndex = 20;
            this.lblYearScrap.Text = "label17";
            // 
            // lblYearOut
            // 
            this.lblYearOut.AutoSize = true;
            this.lblYearOut.Location = new System.Drawing.Point(138, 133);
            this.lblYearOut.Name = "lblYearOut";
            this.lblYearOut.Size = new System.Drawing.Size(47, 12);
            this.lblYearOut.TabIndex = 19;
            this.lblYearOut.Text = "label16";
            // 
            // lblMonthScrap
            // 
            this.lblMonthScrap.AutoSize = true;
            this.lblMonthScrap.Location = new System.Drawing.Point(269, 106);
            this.lblMonthScrap.Name = "lblMonthScrap";
            this.lblMonthScrap.Size = new System.Drawing.Size(47, 12);
            this.lblMonthScrap.TabIndex = 18;
            this.lblMonthScrap.Text = "label15";
            // 
            // lblMonthOut
            // 
            this.lblMonthOut.AutoSize = true;
            this.lblMonthOut.Location = new System.Drawing.Point(138, 106);
            this.lblMonthOut.Name = "lblMonthOut";
            this.lblMonthOut.Size = new System.Drawing.Size(47, 12);
            this.lblMonthOut.TabIndex = 17;
            this.lblMonthOut.Text = "label14";
            // 
            // lblDay2Out
            // 
            this.lblDay2Out.AutoSize = true;
            this.lblDay2Out.Location = new System.Drawing.Point(138, 79);
            this.lblDay2Out.Name = "lblDay2Out";
            this.lblDay2Out.Size = new System.Drawing.Size(47, 12);
            this.lblDay2Out.TabIndex = 15;
            this.lblDay2Out.Text = "label12";
            // 
            // lblDayScrap
            // 
            this.lblDayScrap.AutoSize = true;
            this.lblDayScrap.Location = new System.Drawing.Point(269, 66);
            this.lblDayScrap.Name = "lblDayScrap";
            this.lblDayScrap.Size = new System.Drawing.Size(47, 12);
            this.lblDayScrap.TabIndex = 14;
            this.lblDayScrap.Text = "label11";
            // 
            // lblDay1Out
            // 
            this.lblDay1Out.AutoSize = true;
            this.lblDay1Out.Location = new System.Drawing.Point(138, 52);
            this.lblDay1Out.Name = "lblDay1Out";
            this.lblDay1Out.Size = new System.Drawing.Size(47, 12);
            this.lblDay1Out.TabIndex = 13;
            this.lblDay1Out.Text = "label10";
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
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LandingForm";
            this.Text = "工属具使用情况";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_type)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.gbIO.ResumeLayout(false);
            this.gbIO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.GroupBox gbIO;
        private System.Windows.Forms.Label lblYearScrap;
        private System.Windows.Forms.Label lblYearOut;
        private System.Windows.Forms.Label lblMonthScrap;
        private System.Windows.Forms.Label lblMonthOut;
        private System.Windows.Forms.Label lblDay2Out;
        private System.Windows.Forms.Label lblDayScrap;
        private System.Windows.Forms.Label lblDay1Out;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lb_Time;
        private System.Windows.Forms.Label Lb_Date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer Currently_Time;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView Gv_type;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbScrap;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;

    }
}