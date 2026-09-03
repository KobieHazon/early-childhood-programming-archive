namespace מספר_ראשוני_או_פריק
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
            this.Calculate = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.Cmdexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdbegin
            // 
            this.cmdbegin.Location = new System.Drawing.Point(335, 12);
            this.cmdbegin.Name = "cmdbegin";
            this.cmdbegin.Size = new System.Drawing.Size(83, 61);
            this.cmdbegin.TabIndex = 0;
            this.cmdbegin.Text = "Start";
            this.cmdbegin.UseVisualStyleBackColor = true;
            this.cmdbegin.Click += new System.EventHandler(this.cmdbegin_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(335, 249);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(83, 61);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(335, 121);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(83, 61);
            this.cmdclear.TabIndex = 2;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdcear_Click);
            // 
            // Cmdexit
            // 
            this.Cmdexit.Location = new System.Drawing.Point(335, 359);
            this.Cmdexit.Name = "Cmdexit";
            this.Cmdexit.Size = new System.Drawing.Size(83, 61);
            this.Cmdexit.TabIndex = 3;
            this.Cmdexit.Text = "Exit";
            this.Cmdexit.UseVisualStyleBackColor = true;
            this.Cmdexit.Click += new System.EventHandler(this.Cmdexit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 112);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(32, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 112);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmdexit);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.cmdbegin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdbegin;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button Cmdexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

