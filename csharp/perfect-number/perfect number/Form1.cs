using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace perfect_number
{
    public partial class Form1 : Form
    {
        int sum=0;
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
            listView1.Clear();
        }

        private void cmdcalculate_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text);
            for (int i = 2; i <= num; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == i)
                {
                    listView1.Items.Add(Convert.ToString(i));
                }
                sum = 0;
            }
           

        }
    }
}
