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
    public partial class frmPrintXH : Form
    {
        public frmPrintXH()
        {
            InitializeComponent();
            InitRept();
        }
        private void InitRept()
        {
            try
            {
                DataTable dt = new DataTable("ZiGeTable");
                dt.Columns.Add("Name");
                dt.Columns.Add("ZiGeHao");
                dt.Columns.Add("Name1");
                dt.Columns.Add("ZiGeHao1");
                dt.Columns.Add("Name2");
                dt.Columns.Add("ZiGeHao2");
                string MySql = "SELECT * from ZiGeTable order by ShunXuHao asc";
                DataTable newdt = new DataAccess().GetDataSet(MySql).Tables[0];
                if (newdt != null && newdt.Rows.Count > 0)
                {
                    for (int i = 0; i < newdt.Rows.Count; i++)
                    {
                        DataRow NewRow = dt.NewRow();
                        if (i < newdt.Rows.Count - 1)
                        {
                            NewRow["Name"] = newdt.Rows[i]["ClientInfoID"].ToString();
                            NewRow["ZiGeHao"] = newdt.Rows[i]["ShunXuHao"].ToString();
                        }
                        if (i < newdt.Rows.Count - 1)
                        {
                            NewRow["Name1"] = newdt.Rows[i + 1]["ClientInfoID"].ToString();
                            NewRow["ZiGeHao1"] = newdt.Rows[i + 1]["ShunXuHao"].ToString();
                        }
                        if (i < newdt.Rows.Count - 2)
                        {
                            NewRow["Name2"] = newdt.Rows[i + 2]["ClientInfoID"].ToString();
                            NewRow["ZiGeHao2"] = newdt.Rows[i + 2]["ShunXuHao"].ToString();
                        }
                        i = i + 2;
                        dt.Rows.Add(NewRow);
                    }

                    ReportDocument rptc = new ReportDocument();
                    string rptFile = Application.StartupPath +
                        "\\ReptXH.rpt";
                    rptc.Load(rptFile);
                    //rptc.Database.Tables[0].ApplyLogOnInfo(logOnInfo);
                    rptc.Database.Tables[0].SetDataSource(dt);
                    this.crystalReportViewer1.ReportSource = rptc;

                }
                else
                {
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }
    }
}