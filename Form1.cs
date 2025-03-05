using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_03
{
    public partial class CalculatorForm: Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        int x = 0;
        int y = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            OutputBox.Text = OutputBox.Text + "0";
        }

        private void btnEquls_Click(object sender, EventArgs e)
        {
            y = int.Parse(OutputBox.Text);
            int sum = x + y;
            OutputBox.Text = sum.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            x = int.Parse(OutputBox.Text);
            OutputBox.Text = "";
        }
    }
}
