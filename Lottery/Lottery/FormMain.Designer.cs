namespace Lottery
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butLot = new Glass.GlassButton();
            this.labxs = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.Controls.Add(this.labxs);
            this.pnlBackground.Controls.Add(this.butLot);
            this.pnlBackground.Size = new System.Drawing.Size(980, 410);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butLot
            // 
            this.butLot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butLot.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butLot.InnerBorderColor = System.Drawing.Color.Gray;
            this.butLot.Location = new System.Drawing.Point(434, 274);
            this.butLot.Name = "butLot";
            this.butLot.Size = new System.Drawing.Size(102, 30);
            this.butLot.TabIndex = 8;
            this.butLot.Text = "开始抽奖";
            this.butLot.Click += new System.EventHandler(this.butLot_Click_1);
            // 
            // labxs
            // 
            this.labxs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labxs.AutoSize = true;
            this.labxs.BackColor = System.Drawing.Color.Transparent;
            this.labxs.Font = new System.Drawing.Font("SimSun", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labxs.Location = new System.Drawing.Point(355, 90);
            this.labxs.Name = "labxs";
            this.labxs.Size = new System.Drawing.Size(261, 134);
            this.labxs.TabIndex = 9;
            this.labxs.Text = "000";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 514);
            this.Controls.Add(this.pnlBackground);
            this.Name = "FormMain";
            this.Text = "抽奖系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Controls.SetChildIndex(this.pnlBackground, 0);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1; 
        private Glass.GlassButton butLot;
        private System.Windows.Forms.Label labxs;
    }
}

