using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
//Download by http://www.codefans.net
namespace ParkLottery
{
    public partial class FrmShunXuHao : Form
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
        public FrmShunXuHao()
        {
            InitializeComponent();
            initfrm();
        }
        private void initfrm()
        {
            //绑定数据
            string Sql = "SELECT  ClientInfoID FROM ZiGeTable where ShunXuHao>0 and ShunXuHao<45 order by ShunXuHao ASC ";
            DataTable dt = new DataAccess().GetDataSet(Sql).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    domainUpDown1.Items.Add(dt.Rows[i]["ClientInfoID"].ToString());
                }
            }
            domainUpDown1.Sorted = false;
            domainUpDown1.DownButton();
            UserName = domainUpDown1.Text.ToString();
            if (domainUpDown1.SelectedIndex > -1)
            {
                lblName.Text = "摇号人:" + UserName;
                domainUpDown1.Items.Remove(domainUpDown1.Text.ToString().Trim());
                domainUpDown1.DownButton();
                lblNextName.Text = "准备人:" + domainUpDown1.Text;
                domainUpDown1.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (domainUpDown1.Text != "请选择姓名")
            {
                button2.Enabled = true;
                new PublicClass().MusicPlayer(0);
                string Mysql = "Select * from ShunXuHao where state=0 ORDER BY Rnd(id)";
                dTable = new DataAccess().GetDataSet(Mysql).Tables[0];
                mytime.Start();
                mytime.Tick += new EventHandler(timer1_Tick);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (dTable != null && dTable.Rows.Count > 0)
            {
                DataTotal = dTable.Rows.Count;
                RandomNumber = new Random((int)DateTime.Now.Ticks);
                randomdata = RandomNumber.Next(DataTotal);
                //label5.Text = RandomNumber.Next(DataTotal).ToString();
                //GroupBaseData.Add(dTable.Rows[randomdata].ItemArray.GetValue(0));
                GroupData(1, dTable.Rows[randomdata].ItemArray.GetValue(0).ToString(), dTable.Rows[randomdata].ItemArray.GetValue(1).ToString());

                this.lblNumber.Text = dTable.Rows[randomdata].ItemArray.GetValue(0).ToString();
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
        private string UserName = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
          //  button1.Enabled = true;
           
        }

        private void FrmShunXuHao_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
            char ch=e.KeyChar;
            MessageBox.Show(ch.ToString());
            mytime.Stop();
            domainUpDown1.Enabled = true;
            new PublicClass().MusicPlayer(1);
            //初始化摇号人员信息
            button2.Enabled = false;
            domainUpDown1.Enabled = false;
            //停止播放音乐

            MessageBox.Show("恭喜您，您抽取的顺序号是：" + lblNumber.Text.ToString());

            if (domainUpDown1.SelectedIndex >= 0)
            {

                string sql = "Update ClientInfo set HomeNumber='"+Convert.ToInt32(lblNumber.Text)+"' where ID='" + this.UserName.Trim() + "'";
                new DataAccess().SQLExecute(sql);
                string mysql = "Update ShunXuHao set state=1 where ID='"+lblNumber.Text+"'";
                new DataAccess().SQLExecute(mysql);
                
                lblName.Text = "摇号人：" + UserName;
                domainUpDown1.Items.Remove(domainUpDown1.Text.ToString().Trim());
                domainUpDown1.DownButton();
                lblNextName.Text = "准备人:" + domainUpDown1.Text;
                //}

            }
        }

        private void FrmShunXuHao_KeyDown(object sender, KeyEventArgs e)
        {
           
            
        }

        private void FrmShunXuHao_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            mytime.Stop();
            domainUpDown1.Enabled = true;
            new PublicClass().MusicPlayer(1);
            //初始化摇号人员信息
            button2.Enabled = false;
            domainUpDown1.Enabled = false;
            //停止播放音乐

            MessageBox.Show("恭喜您，您抽取的顺序号是：" + lblNumber.Text.ToString());
            //Rept.frmRept frm = new ParkLottery.Rept.frmRept();
            //frm.UserName = lblName.Text.Trim();
            //frm.Number = lblNumber.Text.Trim();
            //frm.ShowDialog();
           
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show(e.KeyCode.ToString());
            mytime.Stop();
            domainUpDown1.Enabled = true;
            new PublicClass().MusicPlayer(1);
            //初始化摇号人员信息
            button2.Enabled = false;
            domainUpDown1.Enabled = false;
            //停止播放音乐

            MessageBox.Show("恭喜您，您抽取的顺序号是：" + lblNumber.Text.ToString());
            //Rept.frmRept frm = new Rept.frmRept();
            //frm.UserName = UserName;
            //frm.Number = Convert.ToInt32(lblNumber.Text.Trim()).ToString();
            //frm.ShowDialog();
            if (domainUpDown1.SelectedIndex >= 0)
            {

                string sql = "Update ClientInfo set HomeNumber='" + Convert.ToInt32(lblNumber.Text) + "' where ID='" + this.UserName.Trim() + "'";
                bool a= new DataAccess().SQLExecute(sql);
                string mysql = "Update ShunXuHao set state=1 where ID='" + lblNumber.Text + "'";
                new DataAccess().SQLExecute(mysql);
                UserName = domainUpDown1.Text.ToString();
                lblName.Text = "摇号人：" + UserName;
                if (domainUpDown1.SelectedIndex > -1)
                {
                    domainUpDown1.Items.Remove(domainUpDown1.Text.ToString().Trim());
                    domainUpDown1.DownButton();
                    lblNextName.Text = "准备人:" + domainUpDown1.Text;
                }
                

            }
        }
    }
}