using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//Download by http://www.codefans.net
namespace ParkLottery
{
    public partial class ImportPerson : Form
    {
        public ImportPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel文件(*.xls)|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                this.textBox1.Text = filePath;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("请选择导入数据的Execl文件");
            }
            else
            {
                try
                {
                    
                    OleDbConnectionStringBuilder connectStringBuilder = new OleDbConnectionStringBuilder();
                    connectStringBuilder.DataSource = this.textBox1.Text.Trim();
                    connectStringBuilder.Provider = "Microsoft.Jet.OLEDB.4.0";
                    connectStringBuilder.Add("Extended Properties", "Excel 8.0");
                    using (OleDbConnection cn = new OleDbConnection(connectStringBuilder.ConnectionString))
                    {
                        DataSet ds = new DataSet();
                        string sql = "Select * from [Sheet1$]";
                        OleDbCommand cmdLiming = new OleDbCommand(sql, cn);
                        cn.Open();
                        using (OleDbDataReader drLiming = cmdLiming.ExecuteReader())
                        {
                            ds.Load(drLiming, LoadOption.OverwriteChanges, new string[] { "Sheet1" });
                            DataTable dt = ds.Tables["Sheet1"];
                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    
                                    //写入数据库数据
                                    string MySql = "insert into ClientInfo values('"+dt.Rows[i]["姓名"].ToString()+"','"+dt.Rows[i]["姓名"].ToString()+"','0','"+dt.Rows[i]["备注"].ToString()+"','0','"+i.ToString()+"')";
                                    new DataAccess().SQLExecute(MySql);
                                }
                                MessageBox.Show("数据导入成功！");
                            }
                            else
                            {
                                MessageBox.Show("请检查你的Excel中是否存在数据");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}