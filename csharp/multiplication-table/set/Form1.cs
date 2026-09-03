using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace set
{
    public partial class Form1 : Form
    {
        int i, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdbegin_Click(object sender, EventArgs e)
        {
            label1.Text = "Click calculate and youl see the calculate board";
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            listView1.Clear();
        }

        private void cmdcalculate_Click(object sender, EventArgs e)
        {
            for (i = 1; i <= 20; i++)
            {
                for (j = 1; j <= 20; j++)
                {
                    listView1.Items.Add(Convert.ToString(i * j));
                }
            }
        }

        private void cmdexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
