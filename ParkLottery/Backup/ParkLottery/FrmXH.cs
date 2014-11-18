using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Download by http://www.codefans.net
namespace ParkLottery
{
    public partial class FrmXH : Form
    {
        public FrmXH()
        {
            InitializeComponent();
            string MySql = "SELECT * from ZiGeTable order by ShunXuHao asc";
            DataTable dt = new DataAccess().GetDataSet(MySql).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = row["ID"];
                item.Text = row["ClientInfoID"].ToString();
                item.SubItems.Add(row["ShunXuHao"].ToString());
                this.listView1.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string MySql = "SELECT * from ZiGeTable where ClientInfoID like '%"+textBox1.Text.Trim()+"%'";
            DataTable dt = new DataAccess().GetDataSet(MySql).Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = row["ID"];
                item.Text = row["ClientInfoID"].ToString();
                item.SubItems.Add(row["ShunXuHao"].ToString());
                this.listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rept.frmPrintXH frm = new ParkLottery.Rept.frmPrintXH();
            frm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.Items)
            {
                item.Checked = this.checkBox1.Checked;
            }
        }
    }
}