﻿using System;
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
            try
            {
                y = int.Parse(OutputBox.Text);
                int sum = x + y;
                OutputBox.Text = sum.ToString();
            } catch (Exception ex)
            {
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                x = int.Parse(OutputBox.Text);
                OutputBox.Text = "";
            } catch (Exception ex)
            {
            }
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            OutputBox.Text = "";
        }
    }
}
