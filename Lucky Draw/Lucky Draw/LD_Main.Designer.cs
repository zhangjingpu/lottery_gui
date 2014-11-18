namespace Lucky_Draw
{
    partial class LD_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LD_Main));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.lblGrade = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbAwaList = new System.Windows.Forms.ListBox();
            this.lblG2 = new System.Windows.Forms.Label();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.lblG1 = new System.Windows.Forms.Label();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.lblG3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSysSet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRan = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.timLD = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSysSet = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSysClose = new System.Windows.Forms.Button();
            this.btnSysAbout = new System.Windows.Forms.Button();
            this.btnSysHelp = new System.Windows.Forms.Button();
            this.btnSysData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSysReStart = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.rdbL = new System.Windows.Forms.RadioButton();
            this.lblTopLeft = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tol_min = new System.Windows.Forms.Button();
            this.tol_max = new System.Windows.Forms.Button();
            this.tol_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlSysSet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 36);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // rdb1
            // 
            this.rdb1.BackColor = System.Drawing.Color.Transparent;
            this.rdb1.Location = new System.Drawing.Point(702, 286);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(104, 24);
            this.rdb1.TabIndex = 60;
            this.rdb1.Text = "一等奖";
            this.rdb1.UseVisualStyleBackColor = false;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblGrade.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGrade.Location = new System.Drawing.Point(495, 303);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(181, 56);
            this.lblGrade.TabIndex = 59;
            this.lblGrade.Text = "幸运奖";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.groupBox1.Controls.Add(this.lsbAwaList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(412, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 215);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 获 奖 名 单";
            // 
            // lsbAwaList
            // 
            this.lsbAwaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lsbAwaList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbAwaList.ForeColor = System.Drawing.Color.Purple;
            this.lsbAwaList.ItemHeight = 14;
            this.lsbAwaList.Location = new System.Drawing.Point(7, 14);
            this.lsbAwaList.Name = "lsbAwaList";
            this.lsbAwaList.Size = new System.Drawing.Size(367, 186);
            this.lsbAwaList.TabIndex = 30;
            // 
            // lblG2
            // 
            this.lblG2.AutoSize = true;
            this.lblG2.Location = new System.Drawing.Point(226, 71);
            this.lblG2.Name = "lblG2";
            this.lblG2.Size = new System.Drawing.Size(11, 12);
            this.lblG2.TabIndex = 19;
            this.lblG2.Text = "0";
            // 
            // rdb2
            // 
            this.rdb2.BackColor = System.Drawing.Color.Transparent;
            this.rdb2.Location = new System.Drawing.Point(701, 309);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(104, 24);
            this.rdb2.TabIndex = 62;
            this.rdb2.Text = "二等奖";
            this.rdb2.UseVisualStyleBackColor = false;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // lblG1
            // 
            this.lblG1.AutoSize = true;
            this.lblG1.Location = new System.Drawing.Point(145, 70);
            this.lblG1.Name = "lblG1";
            this.lblG1.Size = new System.Drawing.Size(11, 12);
            this.lblG1.TabIndex = 18;
            this.lblG1.Text = "0";
            // 
            // rdb3
            // 
            this.rdb3.BackColor = System.Drawing.Color.Transparent;
            this.rdb3.Location = new System.Drawing.Point(701, 332);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(104, 24);
            this.rdb3.TabIndex = 61;
            this.rdb3.Text = "三等奖";
            this.rdb3.UseVisualStyleBackColor = false;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // lblG3
            // 
            this.lblG3.AutoSize = true;
            this.lblG3.Location = new System.Drawing.Point(310, 70);
            this.lblG3.Name = "lblG3";
            this.lblG3.Size = new System.Drawing.Size(11, 12);
            this.lblG3.TabIndex = 20;
            this.lblG3.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(258, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "三等奖：";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblGL);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblG3);
            this.panel3.Controls.Add(this.lblG2);
            this.panel3.Controls.Add(this.lblG1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnSysSet);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblRan);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-7, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 108);
            this.panel3.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(258, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "Made By：05信管 神在人间";
            // 
            // lblGL
            // 
            this.lblGL.AutoSize = true;
            this.lblGL.Location = new System.Drawing.Point(396, 70);
            this.lblGL.Name = "lblGL";
            this.lblGL.Size = new System.Drawing.Size(11, 12);
            this.lblGL.TabIndex = 22;
            this.lblGL.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(344, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "幸运奖：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(173, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "二等奖：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "一等奖：";
            // 
            // btnSysSet
            // 
            this.btnSysSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSysSet.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSysSet.Location = new System.Drawing.Point(1, 85);
            this.btnSysSet.Name = "btnSysSet";
            this.btnSysSet.Size = new System.Drawing.Size(65, 22);
            this.btnSysSet.TabIndex = 14;
            this.btnSysSet.Text = "系统设置";
            this.btnSysSet.UseVisualStyleBackColor = false;
            this.btnSysSet.Click += new System.EventHandler(this.btnSysSet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "总记录数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(184, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "随机数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            // 
            // lblRan
            // 
            this.lblRan.AutoSize = true;
            this.lblRan.BackColor = System.Drawing.Color.Transparent;
            this.lblRan.ForeColor = System.Drawing.Color.White;
            this.lblRan.Location = new System.Drawing.Point(240, 90);
            this.lblRan.Name = "lblRan";
            this.lblRan.Size = new System.Drawing.Size(11, 12);
            this.lblRan.TabIndex = 12;
            this.lblRan.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.lblID);
            this.panel4.Location = new System.Drawing.Point(132, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 76);
            this.panel4.TabIndex = 55;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("黑体", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(17, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(498, 59);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "开　奖　区";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.Transparent;
            this.btnBegin.ForeColor = System.Drawing.Color.Transparent;
            this.btnBegin.Image = ((System.Drawing.Image)(resources.GetObject("btnBegin.Image")));
            this.btnBegin.Location = new System.Drawing.Point(118, 286);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBegin.Size = new System.Drawing.Size(216, 40);
            this.btnBegin.TabIndex = 51;
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(118, 338);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(216, 40);
            this.btnOpen.TabIndex = 52;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // timLD
            // 
            this.timLD.Tick += new System.EventHandler(this.timLD_Tick);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(25, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 54;
            this.lblName.Visible = false;
            // 
            // pnlSysSet
            // 
            this.pnlSysSet.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlSysSet.Controls.Add(this.groupBox2);
            this.pnlSysSet.Location = new System.Drawing.Point(36, 440);
            this.pnlSysSet.Name = "pnlSysSet";
            this.pnlSysSet.Size = new System.Drawing.Size(80, 139);
            this.pnlSysSet.TabIndex = 64;
            this.pnlSysSet.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Controls.Add(this.btnSysClose);
            this.groupBox2.Controls.Add(this.btnSysAbout);
            this.groupBox2.Controls.Add(this.btnSysHelp);
            this.groupBox2.Controls.Add(this.btnSysData);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSysReStart);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(71, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSysClose
            // 
            this.btnSysClose.Location = new System.Drawing.Point(3, 114);
            this.btnSysClose.Name = "btnSysClose";
            this.btnSysClose.Size = new System.Drawing.Size(65, 22);
            this.btnSysClose.TabIndex = 4;
            this.btnSysClose.Text = "退　出";
            this.btnSysClose.Click += new System.EventHandler(this.tol_close_Click);
            // 
            // btnSysAbout
            // 
            this.btnSysAbout.Location = new System.Drawing.Point(3, 93);
            this.btnSysAbout.Name = "btnSysAbout";
            this.btnSysAbout.Size = new System.Drawing.Size(65, 22);
            this.btnSysAbout.TabIndex = 3;
            this.btnSysAbout.Text = "关　于";
            this.btnSysAbout.Click += new System.EventHandler(this.btnSysAbout_Click);
            // 
            // btnSysHelp
            // 
            this.btnSysHelp.Location = new System.Drawing.Point(3, 72);
            this.btnSysHelp.Name = "btnSysHelp";
            this.btnSysHelp.Size = new System.Drawing.Size(65, 22);
            this.btnSysHelp.TabIndex = 2;
            this.btnSysHelp.Text = "帮　助";
            this.btnSysHelp.Click += new System.EventHandler(this.btnSysHelp_Click);
            // 
            // btnSysData
            // 
            this.btnSysData.Location = new System.Drawing.Point(3, 51);
            this.btnSysData.Name = "btnSysData";
            this.btnSysData.Size = new System.Drawing.Size(65, 22);
            this.btnSysData.TabIndex = 1;
            this.btnSysData.Text = "数据管理";
            this.btnSysData.Click += new System.EventHandler(this.btnSysData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "基本设置";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSysReStart
            // 
            this.btnSysReStart.Location = new System.Drawing.Point(3, 9);
            this.btnSysReStart.Name = "btnSysReStart";
            this.btnSysReStart.Size = new System.Drawing.Size(65, 22);
            this.btnSysReStart.TabIndex = 1;
            this.btnSysReStart.Text = "重新开始";
            this.btnSysReStart.Click += new System.EventHandler(this.btnSysReStart_Click);
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(25, 213);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(100, 23);
            this.lblClass.TabIndex = 65;
            this.lblClass.Visible = false;
            // 
            // rdbL
            // 
            this.rdbL.BackColor = System.Drawing.Color.Transparent;
            this.rdbL.Checked = true;
            this.rdbL.Location = new System.Drawing.Point(701, 356);
            this.rdbL.Name = "rdbL";
            this.rdbL.Size = new System.Drawing.Size(104, 24);
            this.rdbL.TabIndex = 66;
            this.rdbL.TabStop = true;
            this.rdbL.Text = "幸运奖";
            this.rdbL.UseVisualStyleBackColor = false;
            this.rdbL.CheckedChanged += new System.EventHandler(this.rdbL_CheckedChanged);
            // 
            // lblTopLeft
            // 
            this.lblTopLeft.AutoSize = true;
            this.lblTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTopLeft.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTopLeft.ForeColor = System.Drawing.Color.White;
            this.lblTopLeft.Location = new System.Drawing.Point(50, 15);
            this.lblTopLeft.Name = "lblTopLeft";
            this.lblTopLeft.Size = new System.Drawing.Size(75, 19);
            this.lblTopLeft.TabIndex = 67;
            this.lblTopLeft.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(793, 46);
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblTopLeft);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 36);
            this.panel1.TabIndex = 69;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle2.Location = new System.Drawing.Point(0, 106);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(793, 46);
            this.lblTitle2.TabIndex = 70;
            this.lblTitle2.Text = "label1";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.tol_min);
            this.panel2.Controls.Add(this.tol_max);
            this.panel2.Controls.Add(this.tol_close);
            this.panel2.Location = new System.Drawing.Point(702, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 36);
            this.panel2.TabIndex = 71;
            // 
            // tol_min
            // 
            this.tol_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tol_min.BackColor = System.Drawing.Color.Transparent;
            this.tol_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tol_min.BackgroundImage")));
            this.tol_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tol_min.Location = new System.Drawing.Point(10, 14);
            this.tol_min.Name = "tol_min";
            this.tol_min.Size = new System.Drawing.Size(15, 15);
            this.tol_min.TabIndex = 26;
            this.tol_min.UseVisualStyleBackColor = false;
            this.tol_min.Click += new System.EventHandler(this.tol_min_Click);
            // 
            // tol_max
            // 
            this.tol_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tol_max.BackColor = System.Drawing.Color.Transparent;
            this.tol_max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tol_max.BackgroundImage")));
            this.tol_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tol_max.Location = new System.Drawing.Point(36, 15);
            this.tol_max.Name = "tol_max";
            this.tol_max.Size = new System.Drawing.Size(15, 15);
            this.tol_max.TabIndex = 34;
            this.tol_max.UseVisualStyleBackColor = false;
            this.tol_max.Click += new System.EventHandler(this.tol_max_Click);
            // 
            // tol_close
            // 
            this.tol_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tol_close.BackColor = System.Drawing.Color.Transparent;
            this.tol_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tol_close.BackgroundImage")));
            this.tol_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tol_close.Location = new System.Drawing.Point(60, 15);
            this.tol_close.Name = "tol_close";
            this.tol_close.Size = new System.Drawing.Size(15, 15);
            this.tol_close.TabIndex = 25;
            this.tol_close.UseVisualStyleBackColor = false;
            this.tol_close.Click += new System.EventHandler(this.tol_close_Click);
            // 
            // LD_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rdbL);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.pnlSysSet);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LD_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "神在人间抽奖程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.LD_Main_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LD_Main_KeyUp);
            this.Load += new System.EventHandler(this.LD_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlSysSet.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbAwaList;
        private System.Windows.Forms.Label lblG2;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.Label lblG1;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.Label lblG3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSysSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Timer timLD;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSysSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSysClose;
        private System.Windows.Forms.Button btnSysAbout;
        private System.Windows.Forms.Button btnSysHelp;
        private System.Windows.Forms.Button btnSysData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSysReStart;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.RadioButton rdbL;
        private System.Windows.Forms.Label lblGL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTopLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tol_min;
        private System.Windows.Forms.Button tol_max;
        private System.Windows.Forms.Button tol_close;
        private System.Windows.Forms.Label label1;
    }
}