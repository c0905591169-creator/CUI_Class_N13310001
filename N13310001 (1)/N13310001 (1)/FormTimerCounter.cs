using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N13310001__1_
{
    public partial class FormTimerCounter : Form
    {
        int sec = 0;

        public FormTimerCounter()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;

            lb1Time.Text = sec + "秒";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            sec = 0;

            lb1Time.Text = "0秒";
        }
    }
}
