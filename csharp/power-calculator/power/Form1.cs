using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace power
{
    public partial class Form1 : Form
    {
        int num1;
        int pow;
        int res = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdbeginmessage_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculate the power";
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void cmdcalculate_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox2.Text);
           pow = Convert.ToInt32(textBox1.Text);
           if (num1 == 0 && pow == 0)
           {
               label2.Text = "it equals zero";
           }
           else if (num1 > 0 && pow == 0)
           {
               label2.Text = "it equals one";
           }
           else while (pow >= 1)
               {
                   res = res * num1;
                   label2.Text = Convert.ToString(res);
                   pow = pow - 1;
               }
          }

        private void cmdexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
