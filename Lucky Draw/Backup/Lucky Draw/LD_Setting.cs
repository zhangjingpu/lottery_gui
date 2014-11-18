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

namespace Lucky_Draw
{
    public partial class LD_Setting : Form
    {
        DataAccess DA = new DataAccess();

        public LD_Setting()
        {
            InitializeComponent();
        }

        /// <summary>窗体加载事件
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void LD_Setting_Load(object sender, EventArgs e)
        {
            Ini_Txt();
        }

        /// <summary>自定义事件——初始化文本框
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void Ini_Txt()
        {
            string strSQL = "select * from SystemInfo";
            DataTable DT_sys = DA.GetDataTable(strSQL);
            txtTopLeft.Text = DT_sys.Rows[0]["sys_TopLeft"].ToString();
            txtTitle.Text = DT_sys.Rows[0]["sys_Title"].ToString();
            txtTitle2.Text = DT_sys.Rows[0]["sys_Title2"].ToString();
            txtG1.Text = DT_sys.Rows[0]["sys_Grade1"].ToString();
            txtG2.Text = DT_sys.Rows[0]["sys_Grade2"].ToString();
            txtG3.Text = DT_sys.Rows[0]["sys_Grade3"].ToString();
            txtGL.Text = DT_sys.Rows[0]["sys_GradeL"].ToString();
        }

        /// <summary>响应单击按钮事件——重置
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnIni_Click(object sender, EventArgs e)
        {
            Ini_Txt();
        }

        /// <summary>响应单击按钮事件——修改
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            StringBuilder sbSQL = new StringBuilder("update SystemInfo set sys_TopLeft='");
            sbSQL.Append(txtTopLeft.Text + "',sys_Title='" + txtTitle.Text + "',sys_Title2='" + txtTitle2.Text);
            sbSQL.Append("',sys_Grade1='" + txtG1.Text + "',sys_Grade2='" + txtG2.Text + "',sys_Grade3='" );
            sbSQL.Append( txtG3.Text+"',sys_GradeL='" + txtGL.Text+"'");
            if (DA.ExecuteSQL(sbSQL.ToString()))
            {
                MessageBox.Show("修改系统基本设置成功！");
            }
            else
            {
                MessageBox.Show("修改系统基本设置失败！");
            }
        }
    }
}