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
    public partial class FrmZJ : Form
    {
        public FrmZJ()
        {
            InitializeComponent();
            
        }

        private void FrmZJ_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}