namespace ParkLottery
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员信息导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员信息登记表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.抽奖管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.资格号查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印资格号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顺序号抽取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mytime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNextName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.文件ToolStripMenuItem,
            this.抽奖管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初始化信息ToolStripMenuItem,
            this.人员信息导入ToolStripMenuItem,
            this.人员信息登记表ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 初始化信息ToolStripMenuItem
            // 
            this.初始化信息ToolStripMenuItem.Name = "初始化信息ToolStripMenuItem";
            this.初始化信息ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.初始化信息ToolStripMenuItem.Text = "初始化信息";
            this.初始化信息ToolStripMenuItem.Click += new System.EventHandler(this.初始化信息ToolStripMenuItem_Click);
            // 
            // 人员信息导入ToolStripMenuItem
            // 
            this.人员信息导入ToolStripMenuItem.Name = "人员信息导入ToolStripMenuItem";
            this.人员信息导入ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.人员信息导入ToolStripMenuItem.Text = "人员信息导入";
            this.人员信息导入ToolStripMenuItem.Click += new System.EventHandler(this.人员信息导入ToolStripMenuItem_Click);
            // 
            // 人员信息登记表ToolStripMenuItem
            // 
            this.人员信息登记表ToolStripMenuItem.Name = "人员信息登记表ToolStripMenuItem";
            this.人员信息登记表ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.人员信息登记表ToolStripMenuItem.Text = "人员信息登记表";
            this.人员信息登记表ToolStripMenuItem.Click += new System.EventHandler(this.人员信息登记表ToolStripMenuItem_Click);
            // 
            // 抽奖管理ToolStripMenuItem
            // 
            this.抽奖管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.资格号查询ToolStripMenuItem,
            this.打印资格号ToolStripMenuItem,
            this.顺序号抽取ToolStripMenuItem});
            this.抽奖管理ToolStripMenuItem.Name = "抽奖管理ToolStripMenuItem";
            this.抽奖管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.抽奖管理ToolStripMenuItem.Text = "抽号管理(&L)";
            // 
            // 资格号查询ToolStripMenuItem
            // 
            this.资格号查询ToolStripMenuItem.Name = "资格号查询ToolStripMenuItem";
            this.资格号查询ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.资格号查询ToolStripMenuItem.Text = "资格号查询";
            this.资格号查询ToolStripMenuItem.Click += new System.EventHandler(this.资格号查询ToolStripMenuItem_Click);
            // 
            // 打印资格号ToolStripMenuItem
            // 
            this.打印资格号ToolStripMenuItem.Name = "打印资格号ToolStripMenuItem";
            this.打印资格号ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.打印资格号ToolStripMenuItem.Text = "打印资格号";
            this.打印资格号ToolStripMenuItem.Click += new System.EventHandler(this.打印资格号ToolStripMenuItem_Click);
            // 
            // 顺序号抽取ToolStripMenuItem
            // 
            this.顺序号抽取ToolStripMenuItem.Name = "顺序号抽取ToolStripMenuItem";
            this.顺序号抽取ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.顺序号抽取ToolStripMenuItem.Text = "顺序号抽取";
            this.顺序号抽取ToolStripMenuItem.Click += new System.EventHandler(this.顺序号抽取ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // mytime
            // 
            this.mytime.Interval = 16;
            this.mytime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ParkLottery.Properties.Resources._1024_09;
            this.button1.Location = new System.Drawing.Point(238, 575);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 65);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ParkLottery.Properties.Resources._1024;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lblNextName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.domainUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 717);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(645, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "技术支持：甘肃同兴智能科技发展有限责任公司";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::ParkLottery.Properties.Resources._1024_11;
            this.button2.Location = new System.Drawing.Point(504, 575);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 65);
            this.button2.TabIndex = 15;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = global::ParkLottery.Properties.Resources._1024_06;
            this.button4.Location = new System.Drawing.Point(528, 479);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 37);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::ParkLottery.Properties.Resources._1024_03;
            this.button3.Location = new System.Drawing.Point(528, 435);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 35);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblNextName
            // 
            this.lblNextName.AutoSize = true;
            this.lblNextName.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNextName.ForeColor = System.Drawing.Color.Transparent;
            this.lblNextName.Location = new System.Drawing.Point(277, 483);
            this.lblNextName.Name = "lblNextName";
            this.lblNextName.Size = new System.Drawing.Size(32, 33);
            this.lblNextName.TabIndex = 12;
            this.lblNextName.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体_GB2312", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(347, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "祝：各位业主摇号幸运";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("黑体", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(120, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(804, 63);
            this.label2.TabIndex = 10;
            this.label2.Text = "金雨大厦地下停车位转让摇号系统";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(277, 437);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 33);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "1";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domainUpDown1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.domainUpDown1.Location = new System.Drawing.Point(171, 665);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(167, 25);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.Text = "请选择姓名";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 60F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(219, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 122);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(214, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 71);
            this.label5.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "金雨大厦地下停车位转让摇号系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 抽奖管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer mytime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNextName;
        private System.Windows.Forms.ToolStripMenuItem 资格号查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印资格号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 初始化信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员信息导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顺序号抽取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员信息登记表ToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

