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
    public partial class frmDJ : Form
    {
        public frmDJ()
        {
            InitializeComponent();
            init();
           // this.FormBorderStyle = FormBorderStyle.None; 
            this.WindowState = FormWindowState.Maximized; 
        }
        private void init()
        {
            string MySql = "select XuHao,ID,Type from ClientInfo";
            DataTable st = new DataAccess().GetDataSet(MySql).Tables[0];
            dataGridView1.DataSource = st;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}