using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Collections;

namespace ParkLottery
{
    public partial class FrmMain : Form
    {
        private ArrayList ArrayName = new ArrayList();
        int randomdata, Datanum1;
        string[] Goupdata1 = new string[15];
        string[] Goupdata2 = new string[15];
        private System.Random RandomNumber;
        private System.Data.DataTable dTable;
        private int DataTotal; //记录数
        private ArrayList ArrayMsg = new ArrayList();
        private ArrayList ArraySys = new ArrayList();
       
        public FrmMain()
        {
            InitializeComponent();
            
           
        }
        private void initfrm()
        {
           //绑定数据
            string Sql = "select * from ClientInfo where state=0";
            DataTable dt = new DataAccess().GetDataSet(Sql).Tables[0];
            if(dt!=null && dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    domainUpDown1.Items.Add(dt.Rows[i]["ID"].ToString());
                }
            }
            domainUpDown1.DownButton();
            UserName = domainUpDown1.Text.ToString();
            lblName.Text = "摇号人:"+ UserName;
            if(domainUpDown1.SelectedIndex>-1)
            {
                domainUpDown1.Items.Remove(domainUpDown1.Text.ToString().Trim());
                domainUpDown1.DownButton();
                lblNextName.Text = "准备人:"+ domainUpDown1.Text;
                domainUpDown1.Visible = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = "";
            if (dTable != null && dTable.Rows.Count > 0)
            {
                DataTotal = dTable.Rows.Count;
                RandomNumber = new Random((int)DateTime.Now.Ticks);
                randomdata = RandomNumber.Next(DataTotal);
                //label5.Text = RandomNumber.Next(DataTotal).ToString();
                //GroupBaseData.Add(dTable.Rows[randomdata].ItemArray.GetValue(0));
                GroupData(1, dTable.Rows[randomdata].ItemArray.GetValue(0).ToString(), dTable.Rows[randomdata].ItemArray.GetValue(1).ToString());

                label6.Text = dTable.Rows[randomdata].ItemArray.GetValue(0).ToString();
            }
            else
            {
                mytime.Stop();
                
                MessageBox.Show("顺序号已全部摇完");
                
            }
        }
        private void GroupData(int DataNum, string SigData, string NameData)
        {

            if (!ArrayMsg.Contains(SigData))
            {
                if (ArrayMsg.Count < DataNum)
                {
                    ArrayMsg.Add(SigData);
                    ArrayName.Add(NameData);
                }
                else
                {
                    //GroupBaseData.Clear();
                    Datanum1 = ArrayMsg.Count;

                    ArrayMsg.CopyTo(0, Goupdata1, 0, DataNum);
                    ArrayName.CopyTo(0, Goupdata2, 0, DataNum);
                    ArrayMsg.Clear();
                    ArrayName.Clear();
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mytime.Start();
            mytime.Tick += new EventHandler(timer1_Tick);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(domainUpDown1.Text!="请选择姓名")
            {
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                new PublicClass().MusicPlayer(0);
                string Mysql = "Select * from ZiGeHao where state=0 ORDER BY Rnd(id)";
                dTable =new DataAccess().GetDataSet(Mysql).Tables[0];
                mytime.Start();
                mytime.Tick += new EventHandler(timer1_Tick);
           }
        }
        private string UserName = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {   
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            mytime.Stop();
         
            new PublicClass().MusicPlayer(1);
            //初始化摇号人员信息
            button2.Enabled = false;
            //停止播放音乐
           
            MessageBox.Show("恭喜您！您所抽取的资格号是："+label6.Text.ToString());

            if (domainUpDown1.SelectedIndex >= -1)
            {
                string ID = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss");
                string MySql = "insert into ZiGeTable values('" + ID + "','" + label6.Text.ToString().Trim() + "','" + UserName + "')";
                bool i = new DataAccess().SQLExecute(MySql);
                if (i)
                {
                    string sql = "Update ZiGeHao set State=1 where ID='" + label6.Text.ToString().Trim() + "'";
                    new DataAccess().SQLExecute(sql);
                    string sql1 = "Update ClientInfo set State=1 where ID='" + UserName + "'";
                    new DataAccess().SQLExecute(sql1);
                    UserName = domainUpDown1.Text.ToString();
                    lblName.Text = "摇号人：" + UserName;
                    if(domainUpDown1.SelectedIndex>-1)
                    {
                        domainUpDown1.Items.Remove(domainUpDown1.Text.ToString().Trim());
                        domainUpDown1.DownButton();
                        lblNextName.Text = "准备人：" + domainUpDown1.Text;
                    }
                }

            }
        }

        private void 添加业主信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoAdd frm = new UserInfoAdd();
            frm.ShowDialog();
        }

        private void 顺序号管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXH frm = new FrmXH();
            frm.ShowDialog();
        }

        private void 顺序号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 资格号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXH frm = new FrmXH();
            frm.ShowDialog();
        }

        private void 打印资格号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Rept.frmPrintXH frm = new ParkLottery.Rept.frmPrintXH();
            //frm.Show();
        }

        private void 初始化信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNumber frm = new frmNumber();
            frm.ShowDialog();
        }

        private void 人员信息导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportPerson frm = new ImportPerson();
            frm.Show();
        }

        private void 顺序号抽取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShunXuHao frm = new FrmShunXuHao();
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            initfrm();
        }

        private void 人员信息登记表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDJ frm = new frmDJ();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblNextName.Text = "准备人：" + domainUpDown1.Text.Trim();
            domainUpDown1.UpButton();
            lblName.Text = "摇号人："+domainUpDown1.Text.Trim();
            UserName = domainUpDown1.Text.Trim();
    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //domainUpDown1.DownButton();
            lblName.Text = "摇号人：" + domainUpDown1.Text.Trim();
            UserName = domainUpDown1.Text.Trim();
            domainUpDown1.DownButton();
            lblNextName.Text = "准备人：" + domainUpDown1.Text.Trim();
        }

    }
}