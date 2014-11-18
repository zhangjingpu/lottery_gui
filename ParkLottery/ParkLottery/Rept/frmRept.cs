using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ParkLottery.Rept
{
    public partial class frmRept : Form
    {
        public frmRept()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; 
        }
        public string UserName = string.Empty;
        public string Number = string.Empty;
        private void InitRept()
        {
            try
            {
                DataTable dt = new DataTable("PZhTable");
                dt.Columns.Add("Name");
                dt.Columns.Add("Number");
                dt.Columns.Add("Name1");
                dt.Columns.Add("Number1");

                DataRow NewRow = dt.NewRow();
                NewRow["Name"] = UserName;
                NewRow["Number"] = Number;
                NewRow["Name1"] = UserName;
                NewRow["Number1"] = Number;
                dt.Rows.Add(NewRow);
                ReportDocument rptc = new ReportDocument();
                string rptFile = Application.StartupPath +
                    "\\Rept.rpt";
                rptc.Load(rptFile);
                //rptc.Database.Tables[0].ApplyLogOnInfo(logOnInfo);
                rptc.Database.Tables[0].SetDataSource(dt);
                this.crystalReportViewer1.ReportSource = rptc;
                crystalReportViewer1.PrintReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void frmRept_Load(object sender, EventArgs e)
        {
            InitRept();
            
        }
    }
}