using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParkLottery
{
    public partial class frmNumber : Form
    {
        public frmNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MySql = "delete FROM ZiGeHao";
            new DataAccess().SQLExecute(MySql);
            for (int i = Convert.ToInt32(numericUpDown1.Value); i <= Convert.ToInt32(numericUpDown2.Value);i++ )
            {
                if (i < 10)
                {
                    string sql = "insert into ZiGeHao values('00000" + i.ToString() + "','0','0')";
                    new DataAccess().SQLExecute(sql);
                }
                if(i>=10 && i<100)
                {
                    string sql = "insert into ZiGeHao values('0000" + i.ToString() + "','0','0')";
                    new DataAccess().SQLExecute(sql);
                }
                if (i >100)
                {
                    string sql = "insert into ZiGeHao values('000" + i.ToString() + "','0','0')";
                    new DataAccess().SQLExecute(sql);
                }
            }
            MessageBox.Show("操作成功！");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Sql = "delete from ZiGeTable";
            new DataAccess().SQLExecute(Sql);
            button2.Enabled = false;
            string str = "Update ZiGeHao set State=0";
            new DataAccess().SQLExecute(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            string str = "Update ShunXuHao set State=0";
            new DataAccess().SQLExecute(str);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            string str = "Update ClientInfo set State=0";
            new DataAccess().SQLExecute(str);
        }
    }
}