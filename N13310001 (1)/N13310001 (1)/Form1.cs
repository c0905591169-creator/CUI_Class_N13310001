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
    public partial class Form1 : Form
    {
        int sec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ClickMe_Click(object sender, EventArgs e)
        {
            if (btn_ClickMe.Text=="按我一下")
                btn_ClickMe.Text ="我已經被點擊過了";
            else if (btn_ClickMe.Text=="我已經被點擊過了")
                btn_ClickMe.Text ="按我一下";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChangeLabel_Click(object sender, EventArgs e)
        {
            lab_ChangeLabel.Text="按鈕被按過了";
        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            String count = lab_Counter.Text;
            int sum = Int32.Parse(count)+1;
            lab_Counter.Text = sum.ToString();
        }

        private void btnBigger_Click(object sender, EventArgs e)
        {
            new FormBtnBigger().Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            label2.Text = str;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            new FormCalculator().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            String count = label3.Text;
            int sum = Int32.Parse(count)+1;
            label3.Text = sum.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String count = label3.Text;
            int sum = Int32.Parse(count)+1;
            label3.Text = sum.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            String count = label3.Text;
            int sum = Int32.Parse(count)-1;
            label3.Text = sum.ToString();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormTimer().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormCheckBox3().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FormLayout().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormTimerCounter().Show();
        }

        private void btnOderMenu_Click(object sender, EventArgs e)
        {
            new FormOderMenu().Show();
        }
    }
    }
