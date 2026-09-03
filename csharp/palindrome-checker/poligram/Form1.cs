using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace poligram
{
    public partial class Form1 : Form
    {
        int i, flag = 0;
        string data;
        char[] arr = new char[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdbegin_Click(object sender, EventArgs e)
        {
            label1.Text = "Put 9 numbers and youll see if its a poligram";

        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            label2.Text = "";
            flag = 0;

        }

        private void cmdexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdcalculate_Click(object sender, EventArgs e)
        {
            data = textBox1.Text;
            arr = data.ToCharArray();

            if (arr.Length != 9)
            {
                label2.Text = "Put a number with 9 lettters";
            }
            else
            {
                for (i = 0; i < (arr.Length) / 2; i++)
                {
                    if (arr[i] != arr[(arr.Length - 1) - i])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    label2.Text = "The string is a polidram" + " " + "(" + data + ")"; 
                }
                else
                {
                    label2.Text = "The string is not a polidram" + " " + "(" + data +")";
                }

            }
        }
    }
}
