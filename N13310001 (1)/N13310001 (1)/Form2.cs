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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            double f = c*(9 / 5.0) + 32;
            labelResult.Text = f.ToString()+ "F";
        }
    }
}
