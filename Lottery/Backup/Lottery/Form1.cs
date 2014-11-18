using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CRD.WinUI.Forms;
namespace Lottery
{
    public partial class Form1 : CRD.WinUI.Forms.MainForm
    {
        //CRD.WinUI.Forms.MainForm
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        const int AW_CENTER = 0x0010;
        const int AW_ACTIVATE = 0x20000;

        private static string _Number = "";
        private static int _Speed = 0;
        private  List<Model> _list = new List<Model>();
        public Form1()
        {
            //刷新当前的皮肤
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
            
            AnimateWindow(this.Handle, 500, AW_CENTER | AW_ACTIVATE);
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 读取配置文件
            IniFile file = new IniFile(System.IO.Directory.GetCurrentDirectory()+"/Lottery.ini");
            if (file.ExistINIFile())
            {
                _Number = file.IniReadValue("TestIni", "number");
                _Speed = int.Parse(file.IniReadValue("TestIni", "speed"));
            }
            #endregion

            #region 初始化
            string[] _StrAvg = _Number.Split(',');
            timer1.Interval = _Speed;           
            for (int i = 0; i < _StrAvg.Length; i++)
            { 
                Model _model = new Model();
                _model.Nunber = _StrAvg[i].ToString();
                _list.Add(_model);
            }
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 随即抽奖
            System.Random r = new Random();
            if (_list.Count > 1)
            {
                int i = r.Next(1, _list.Count);
                labxs.Text = _list[i].Nunber;
            }
            else
            {
                labxs.Text = "抽奖完毕";
            }
            #endregion            
        }

        private void butLot_Click_1(object sender, EventArgs e)
        {
            #region 抽奖
            if (butLot.Text == "开始抽奖")
            {
                butLot.Text = "停止";
                timer1.Enabled = true;
            }
            else
            {
                //从列表中删除中将号码
                Model _models = new Model();
                _models.Nunber = labxs.Text;
                for (int k = 0; k < _list.Count(); k++)
                {
                    if (_list[k].Nunber == labxs.Text)
                    {
                        _list.RemoveAt(k);
                    }
                }
                butLot.Text = "开始抽奖";
                timer1.Stop();
                timer1.Enabled = false;
            }
            #endregion
        }
    }
}
