namespace power
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
            this.cmdexit = new System.Windows.Forms.Button();
            this.cmdbeginmessage = new System.Windows.Forms.Button();
            this.cmdcalculate = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdexit
            // 
            this.cmdexit.Location = new System.Drawing.Point(458, 456);
            this.cmdexit.Name = "cmdexit";
            this.cmdexit.Size = new System.Drawing.Size(81, 56);
            this.cmdexit.TabIndex = 0;
            this.cmdexit.Text = "Exit";
            this.cmdexit.UseVisualStyleBackColor = true;
            this.cmdexit.Click += new System.EventHandler(this.cmdexit_Click);
            // 
            // cmdbeginmessage
            // 
            this.cmdbeginmessage.Location = new System.Drawing.Point(458, 12);
            this.cmdbeginmessage.Name = "cmdbeginmessage";
            this.cmdbeginmessage.Size = new System.Drawing.Size(81, 56);
            this.cmdbeginmessage.TabIndex = 1;
            this.cmdbeginmessage.Text = "Start";
            this.cmdbeginmessage.UseVisualStyleBackColor = true;
            this.cmdbeginmessage.Click += new System.EventHandler(this.cmdbeginmessage_Click);
            // 
            // cmdcalculate
            // 
            this.cmdcalculate.Location = new System.Drawing.Point(458, 302);
            this.cmdcalculate.Name = "cmdcalculate";
            this.cmdcalculate.Size = new System.Drawing.Size(81, 56);
            this.cmdcalculate.TabIndex = 2;
            this.cmdcalculate.Text = "Calculate";
            this.cmdcalculate.UseVisualStyleBackColor = true;
            this.cmdcalculate.Click += new System.EventHandler(this.cmdcalculate_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(458, 143);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(81, 56);
            this.cmdclear.TabIndex = 3;
            this.cmdclear.Text = "Clean";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 56);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(154, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 56);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdcalculate);
            this.Controls.Add(this.cmdbeginmessage);
            this.Controls.Add(this.cmdexit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdexit;
        private System.Windows.Forms.Button cmdbeginmessage;
        private System.Windows.Forms.Button cmdcalculate;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

