using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace מספר_ראשוני_או_פריק
{
    public partial class Form1 : Form
    {
        int i;
        int num;
        int flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text);

            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                label2.Text = "The number is composite";
            }
            else
            {
                label2.Text = "The number is prime";
            }
               
        }

        private void cmdcear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
            label1.Text = "";
        }

        private void cmdbegin_Click(object sender, EventArgs e)
        {
            label1.Text = "Put a number and youll see if its a prime number or a composite number";
        }

        private void Cmdexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}