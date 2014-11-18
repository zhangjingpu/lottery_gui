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
    public partial class LD_DataManage : Form
    {
        DataAccess DA = new DataAccess();
        StringBuilder sbSQL = new StringBuilder();

        public LD_DataManage()
        {
            InitializeComponent();
        }

        /// <summary>窗体加载事件
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void LD_DataManage_Load(object sender, EventArgs e)
        {
            Bind_DG();
        }

        /// <summary>自定义事件——为DataGrid绑定数据
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void Bind_DG()
        {
            string strSQL = "select stuID as 学号,stuName as 姓名,stuClass as 班级 from StuInfo";
            DataTable DT = DA.GetDataTable(strSQL);
            DG.DataSource = DT;
            DG.Refresh();
            if (DG.Rows.Count < 1)
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                btnDeleteAll.Enabled = false;
            }
            else
            {
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
            }
        }

        /// <summary>单选按钮事件——打开文件
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofdExcel.FileName;
            }
        }

        /// <summary>单选按钮事件——导入数据
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnLendIN_Click(object sender, EventArgs e)
        {
            DataTable DT = DA.LendInDT(txtFile.Text.Trim());
            int j = 0;
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                sbSQL = new StringBuilder("insert into StuInfo(stuID,stuName,stuClass) values('");
                sbSQL.Append(DT.Rows[i]["学号"].ToString() + "','" + DT.Rows[i]["姓名"].ToString() + "','");
                sbSQL.Append(DT.Rows[i]["班级"].ToString() + "')");
                if (DA.ExecuteSQL(sbSQL.ToString()))
                {
                    j++;
                }
            }
            MessageBox.Show("导入数据成功，共导入" + j.ToString() + "条记录！");
            DataAccess.DataIsChange = true;
            Bind_DG();
        }

        /// <summary>DataGrid事件——单击事件
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void DG_Click(object sender, EventArgs e)
        {
            if (DG.Rows.Count >= 1)
            {
                DataGridViewRow DGrow = DG.CurrentRow;
                txtID.Text = DGrow.Cells[0].Value.ToString();
                txtName.Text = DGrow.Cells[1].Value.ToString();
                txtClass.Text = DGrow.Cells[2].Value.ToString();
            }
        }

        /// <summary>响应单击按钮事件——清空
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtClass.Text = "";
        }

        /// <summary>响应单击按钮事件——添加
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sbSQL = new StringBuilder("insert into StuInfo(stuID,stuName,stuClass) values('");
            sbSQL.Append(txtID.Text.Trim() + "','" + txtName.Text.Trim() + "','" + txtClass.Text.Trim() + "')");
            if (DA.ExecuteSQL(sbSQL.ToString()))
            {
                lblMessage.Text = "添加数据成功！";
                DataAccess.DataIsChange = true;
                Bind_DG();
            }
            else
            {
                lblMessage.Text = "添加数据失败，请重试！";
            }
        }

        /// <summary>响应单击按钮事件——修改
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            sbSQL = new StringBuilder("update StuInfo set stuID='" + txtID.Text.Trim()+"',stuName='");
            sbSQL.Append(txtName.Text.Trim() + "',stuClass='" + txtClass.Text.Trim() + "'");
            sbSQL.Append(" where stuID='" + DG.CurrentRow.Cells[0].Value.ToString()+ "'");
            if (DA.ExecuteSQL(sbSQL.ToString()))
            {
                lblMessage.Text = "修改数据成功！";
                DataAccess.DataIsChange = true;
                Bind_DG();
            }
            else
            {
                lblMessage.Text = "修改数据失败，请重试！";
            }
        }

        /// <summary>响应单击按钮事件——删除
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            sbSQL = new StringBuilder("delete from StuInfo where stuID='");
            sbSQL.Append(DG.CurrentRow.Cells[0].Value.ToString() + "'");
            if (DA.ExecuteSQL(sbSQL.ToString()))
            {
                lblMessage.Text = "修改数据成功！";
                DataAccess.DataIsChange = true;
                Bind_DG();
            }
            else
            {
                lblMessage.Text = "修改数据失败，请重试！";
            }
        }

        /// <summary>响应单击按钮事件——删除所有数据
        ///     <remarks>神在人间(Zagelover) 2008-10-17</remarks>
        /// </summary>
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除所有数据吗？", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                sbSQL = new StringBuilder("delete from StuInfo");
                if (DA.ExecuteSQL(sbSQL.ToString()))
                {
                    lblMessage.Text = "删除所有数据成功！";
                    DataAccess.DataIsChange = true;
                    Bind_DG();
                }
                else
                {
                    lblMessage.Text = "删除所有数据失败，请重试！";
                }
            }
        }


    }
}