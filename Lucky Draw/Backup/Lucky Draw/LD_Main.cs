/*版权声明
 * 
 * 由于学院需要本随机抽奖系统由 
 * 河北大学管理学院05信息管理与信息系统 朱胜贤 
 * 根据黑闪(http://blog.csdn.net/fjp813/)幸运999软件改编
 * 功能基本上全部重写，借用了原软件的界面
 * 
 * 如有任何疑问请联系开发人员
 * 
 * 开发者：神在人间(Zagelover)
 * Email：zagelover@163.com   QQ:214535911
 * http://hi.baidu.com/zagelover
 * http://www.cnblogs.com/zagelover/
 * 
 * CopyRight (c) 河北大学管理学院05信管神仙 2008~2010
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lucky_Draw
{
    public partial class LD_Main : Form
    {

        DataAccess DA = new DataAccess();//实例化数据库操作类
        private DataTable DT_stu;//学生表
        private DataTable DT_awa;//获奖表
        private DataTable DT_sys;//系统表
        private int stuCount;//学生总数
        private string strGrade;//奖项等级
        private Random RanNum;//随机数

        public LD_Main()
        {
            InitializeComponent();
        }

        /// <summary>窗体加载事件
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void LD_Main_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from SystemInfo";
            DT_sys = DA.GetDataTable(strSQL);
            lblG1.Text = DT_sys.Rows[0]["sys_Grade1"].ToString();
            lblG2.Text = DT_sys.Rows[0]["sys_Grade2"].ToString();
            lblG3.Text = DT_sys.Rows[0]["sys_Grade3"].ToString();
            lblGL.Text = DT_sys.Rows[0]["sys_GradeL"].ToString();
            lblTopLeft.Text = DT_sys.Rows[0]["sys_TopLeft"].ToString();
            lblTitle.Text = DT_sys.Rows[0]["sys_Title"].ToString();
            lblTitle2.Text = DT_sys.Rows[0]["sys_Title2"].ToString();
            strGrade = "幸运奖";
            Set_StuCount();
            Awa_View();
            btnOpen.Enabled = false;
        }
        
        /// <summary>自定义事件——提取学生人数
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void Set_StuCount()
        {
            string strSQL = "select * from StuInfo";
            DT_stu = DA.GetDataTable(strSQL);
            stuCount = DT_stu.Rows.Count;
            DataAccess.DataIsChange = false;
        }

        /// <summary>自定义事件——浏览获奖情况
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void Awa_View()
        {
            lsbAwaList.Items.Clear();
            string strSQL = "select * from AwardsInfo where awaGrade='" + strGrade + "'";
            DT_awa = DA.GetDataTable(strSQL);
            for (int i = 0; i < DT_awa.Rows.Count; i++)
            {
                lsbAwaList.Items.Add(DT_awa.Rows[i]["stuID"].ToString() + "    " + DT_awa.Rows[i]["stuName"].ToString() + "    " + DT_awa.Rows[i]["stuClass"].ToString() + "   " + DT_awa.Rows[i]["awaGrade"].ToString());
            }
        }

        /// <summary>自定义事件——检查此人是否已中奖
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private bool Awa_Chk()
        {
            string strSQL = "select stuID from AwardsInfo";
            DataTable DT_check = DA.GetDataTable(strSQL);
            for (int i = 0; i < DT_check.Rows.Count; i++)
            {
                if (DT_check.Rows[i]["stuID"].ToString() == lblID.Text.Trim())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>自定义事件——添加中奖信息
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void Awa_Save(string stuID, string stuName,string stuClass, string awaGrade)
        {
            StringBuilder sbSQL = new StringBuilder("insert into AwardsInfo(stuID,stuName,stuClass,awaGrade) values('");
            sbSQL.Append(stuID + "','" + stuName + "','" + stuClass + "','" + awaGrade + "')");
            DA.ExecuteSQL(sbSQL.ToString());
        }

        /// <summary>响应顶部按钮事件——关闭窗体
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void tol_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>响应顶部按钮事件——最小化窗体
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void tol_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>响应顶部按钮事件——最大化/正常化窗体
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void tol_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>计时器事件
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void timLD_Tick(object sender, EventArgs e)
        {
            int randata;
            RanNum = new Random((int)DateTime.Now.Ticks);
            randata = RanNum.Next(stuCount);
            lblRan.Text = RanNum.Next(stuCount).ToString();
            lblID.Text = DT_stu.Rows[randata]["stuID"].ToString();
            lblName.Text = DT_stu.Rows[randata]["stuName"].ToString();
            lblClass.Text = DT_stu.Rows[randata]["stuClass"].ToString();
        }

        /// <summary>响应单击按钮事件——摇奖
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnBegin_Click(object sender, EventArgs e)
        {
            //检查学生的数据有变化
            if (DataAccess.DataIsChange)
            {
                Set_StuCount();
            }
            if (stuCount <= 0)
            {
                MessageBox.Show("对不起，还没有学生信息，不能进行抽奖！", "没有记录", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblID.ForeColor = Color.White;
            timLD.Start();
            btnOpen.Enabled = true;
            btnOpen.Focus();
        }

        /// <summary>响应单击按钮事件——开奖
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string strSQL = "select stuID from AwardsInfo";
            DataTable DT_temp = DA.GetDataTable(strSQL);
            if (DT_temp.Rows.Count >= stuCount)
            {
                timLD.Stop();
                lblID.ForeColor = Color.Red;
                lblID.Text = "所有人都已经获奖了!";
                return;
            }
            while (!Awa_Chk())
            {
                int randata;
                RanNum = new Random((int)DateTime.Now.Ticks);
                randata = RanNum.Next(stuCount);
                lblRan.Text = RanNum.Next(stuCount).ToString();
                lblID.Text = DT_stu.Rows[randata]["stuID"].ToString();
                lblName.Text = DT_stu.Rows[randata]["stuName"].ToString();
                lblClass.Text = DT_stu.Rows[randata]["stuClass"].ToString();
            }
            int awaCount, awaGCount = 0, i;
            timLD.Stop();
            btnOpen.Enabled = false;
            awaCount = lsbAwaList.Items.Count;
            lblID.ForeColor = Color.Red;
            if (rdb1.Checked == true)
            {
                for (i = 0; i < awaCount; i++)
                {
                    if (lsbAwaList.Items[i].ToString().EndsWith("一等奖"))
                    {
                        awaGCount++;
                    }
                }
                if (awaGCount >= Convert.ToInt32(lblG1.Text.Trim()))
                {
                    MessageBox.Show("一等奖已经抽取完毕，请抽取其它奖项！！");
                }
                else
                {
                    Awa_Save(lblID.Text.Trim(), lblName.Text.Trim(), lblClass.Text.Trim(), lblGrade.Text.Trim());
                    strGrade = "一等奖";
                }
            }
            else if (rdb2.Checked == true)
            {
                for (i = 0; i < awaCount; i++)
                {
                    if (lsbAwaList.Items[i].ToString().EndsWith("二等奖"))
                    {
                        awaGCount++;
                    }
                }
                if (awaGCount >= Convert.ToInt32(lblG2.Text.Trim()))
                {
                    MessageBox.Show("二等奖已经抽取完毕，请抽取其它奖项！！");
                }
                else
                {
                    Awa_Save(lblID.Text.Trim(), lblName.Text.Trim(), lblClass.Text.Trim(), lblGrade.Text.Trim());
                    strGrade = "二等奖";
                }
            }
            else if (rdb3.Checked == true)
            {
                for (i = 0; i < awaCount; i++)
                {
                    if (lsbAwaList.Items[i].ToString().EndsWith("三等奖"))
                    {
                        awaGCount++;
                    }

                }
                if (awaGCount >= Convert.ToInt32(lblG3.Text.Trim()))
                {
                    MessageBox.Show("三等奖已经抽取完毕，请抽取其它奖项！！");
                }
                else
                {
                    Awa_Save(lblID.Text.Trim(), lblName.Text.Trim(), lblClass.Text.Trim(), lblGrade.Text.Trim());
                    strGrade = "三等奖";
                }
            }
            else if (rdbL.Checked == true)
            {
                for (i = 0; i < awaCount; i++)
                {
                    if (lsbAwaList.Items[i].ToString().EndsWith("幸运奖"))
                    {
                        awaGCount++;
                    }

                }
                if (awaGCount >= Convert.ToInt32(lblGL.Text.Trim()))
                {
                    MessageBox.Show("幸运奖已经抽取完毕，请抽取其它奖项！！");
                }
                else
                {
                    Awa_Save(lblID.Text.Trim(), lblName.Text.Trim(), lblClass.Text.Trim(), lblGrade.Text.Trim());
                    strGrade = "幸运奖";
                }
            }
            Awa_View();
            btnBegin.Focus();
        }

        /// <summary>单选按钮选中事件——一等奖
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "一等奖";
            strGrade = "一等奖";
            Awa_View();
            btnBegin.Focus();
        }

        /// <summary>单选按钮选中事件——二等奖
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "二等奖";
            strGrade = "二等奖";
            Awa_View();
            btnBegin.Focus();
        }

        /// <summary>单选按钮选中事件——三等奖
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "三等奖";
            strGrade = "三等奖";
            Awa_View();
            btnBegin.Focus();
        }

        /// <summary>单选按钮选中事件——幸运奖
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void rdbL_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = "幸运奖";
            strGrade = "幸运奖";
            Awa_View();
            btnBegin.Focus();
        }

        /// <summary>单选按钮选中事件——系统设置
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnSysSet_Click(object sender, EventArgs e)
        {
            if (pnlSysSet.Visible)
            {
                pnlSysSet.Visible = false;
            }
            else
            {
                pnlSysSet.Visible = true;
            }
        }

        /// <summary>单选按钮选中事件——重新开始
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnSysReStart_Click(object sender, EventArgs e)
        {
            string strSQL = "delete from AwardsInfo";
            DA.ExecuteSQL(strSQL);
            Awa_View();
        }

        /// <summary>单选按钮选中事件——基本设置
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            LD_Setting LDst = new LD_Setting();
            LDst.Show();
        }

        /// <summary>单选按钮选中事件——数据管理
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnSysData_Click(object sender, EventArgs e)
        {
            LD_DataManage LDDM = new LD_DataManage();
            LDDM.Show();
        }

        /// <summary>单选按钮选中事件——帮助
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnSysHelp_Click(object sender, EventArgs e)
        {
            StringBuilder sbHelp = new StringBuilder("*帮助\n*\n* 摇奖：开始摇奖\n");
            sbHelp.Append("* 开奖：开始开奖\n*\n");
            sbHelp.Append("* 系统设置\n* \n");
            sbHelp.Append("* 重新开始：重新开始摇奖\n");
            sbHelp.Append("* 基本设置：设置系统基本信息\n");
            sbHelp.Append("* 数据管理：管理学生基本信息\n");
            sbHelp.Append("* 帮　　助：帮助信息\n");
            sbHelp.Append("* 关　　于：关于本系统\n");
            sbHelp.Append("* 退　　出：退出本系统\n");
            sbHelp.Append("*\n*\n* CopyRight (c) 河北大学管理学院05信管神在人间 2008~2010\n*");
            MessageBox.Show(sbHelp.ToString(), "帮助", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>单选按钮选中事件——关于
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnSysAbout_Click(object sender, EventArgs e)
        {
            StringBuilder sbAbout = new StringBuilder("*************************************\n*\n");
            sbAbout.Append("* 版权声明\n*\n* 本随机抽奖系统由\n");
            sbAbout.Append("* 河北大学管理学院05信息管理与信息系统 神在人间(Zagelover)\n");
            sbAbout.Append("* 制作开发\n* \n* 如有任何疑问请联系开发人员\n*\n");
            sbAbout.Append("* 作者：神在人间(Zagelover)\n* Email：zagelover@163.com   QQ:214535911\n*\n");
            sbAbout.Append("* CopyRight (c) 河北大学管理学院05信管神在人间 2008~2010\n*\n*");
            sbAbout.Append("*************************************\n");
            MessageBox.Show(sbAbout.ToString(), "关于神在人间抽奖系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>窗体事件——单击窗体
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void LD_Main_Click(object sender, EventArgs e)
        {
            pnlSysSet.Visible = false;
            btnBegin.Focus();
        }

        /// <summary>窗体事件——键按下时
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void LD_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btnBegin.Focus();
            }
        }

        

    }
}