namespace set
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmdbegin
            // 
            this.cmdbegin.Location = new System.Drawing.Point(891, 12);
            this.cmdbegin.Name = "cmdbegin";
            this.cmdbegin.Size = new System.Drawing.Size(75, 56);
            this.cmdbegin.TabIndex = 0;
            this.cmdbegin.Text = "Start";
            this.cmdbegin.UseVisualStyleBackColor = true;
            this.cmdbegin.Click += new System.EventHandler(this.cmdbegin_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(891, 265);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 56);
            this.cmdclear.TabIndex = 1;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdcalculate
            // 
            this.cmdcalculate.Location = new System.Drawing.Point(891, 499);
            this.cmdcalculate.Name = "cmdcalculate";
            this.cmdcalculate.Size = new System.Drawing.Size(75, 56);
            this.cmdcalculate.TabIndex = 2;
            this.cmdcalculate.Text = "Calculate";
            this.cmdcalculate.UseVisualStyleBackColor = true;
            this.cmdcalculate.Click += new System.EventHandler(this.cmdcalculate_Click);
            // 
            // cmdexit
            // 
            this.cmdexit.Location = new System.Drawing.Point(891, 703);
            this.cmdexit.Name = "cmdexit";
            this.cmdexit.Size = new System.Drawing.Size(75, 56);
            this.cmdexit.TabIndex = 3;
            this.cmdexit.Text = "Exit";
            this.cmdexit.UseVisualStyleBackColor = true;
            this.cmdexit.Click += new System.EventHandler(this.cmdexit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 164);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 268);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(889, 501);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 771);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdexit);
            this.Controls.Add(this.cmdcalculate);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdbegin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdbegin;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdcalculate;
        private System.Windows.Forms.Button cmdexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}

