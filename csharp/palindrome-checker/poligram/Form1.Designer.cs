namespace poligram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdbegin = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdcalculate = new System.Windows.Forms.Button();
            this.cmdexit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdbegin
            // 
            this.cmdbegin.Location = new System.Drawing.Point(363, 12);
            this.cmdbegin.Name = "cmdbegin";
            this.cmdbegin.Size = new System.Drawing.Size(97, 62);
            this.cmdbegin.TabIndex = 0;
            this.cmdbegin.Text = "Start";
            this.cmdbegin.UseVisualStyleBackColor = true;
            this.cmdbegin.Click += new System.EventHandler(this.cmdbegin_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(363, 136);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(97, 62);
            this.cmdclear.TabIndex = 1;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdcalculate
            // 
            this.cmdcalculate.Location = new System.Drawing.Point(363, 292);
            this.cmdcalculate.Name = "cmdcalculate";
            this.cmdcalculate.Size = new System.Drawing.Size(97, 62);
            this.cmdcalculate.TabIndex = 2;
            this.cmdcalculate.Text = "Calculate";
            this.cmdcalculate.UseVisualStyleBackColor = true;
            this.cmdcalculate.Click += new System.EventHandler(this.cmdcalculate_Click);
            // 
            // cmdexit
            // 
            this.cmdexit.Location = new System.Drawing.Point(363, 459);
            this.cmdexit.Name = "cmdexit";
            this.cmdexit.Size = new System.Drawing.Size(97, 62);
            this.cmdexit.TabIndex = 3;
            this.cmdexit.Text = "Exit";
            this.cmdexit.UseVisualStyleBackColor = true;
            this.cmdexit.Click += new System.EventHandler(this.cmdexit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 112);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(42, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 112);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdexit);
            this.Controls.Add(this.cmdcalculate);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdbegin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdbegin;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdcalculate;
        private System.Windows.Forms.Button cmdexit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

