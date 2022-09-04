namespace pratice
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBlue = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbRed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pnMain = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBlue);
            this.groupBox1.Controls.Add(this.lbGreen);
            this.groupBox1.Controls.Add(this.lbRed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hScrollBar3);
            this.groupBox1.Controls.Add(this.hScrollBar2);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(89, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Color for Panel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lbBlue
            // 
            this.lbBlue.AutoSize = true;
            this.lbBlue.ForeColor = System.Drawing.Color.Blue;
            this.lbBlue.Location = new System.Drawing.Point(552, 138);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(38, 20);
            this.lbBlue.TabIndex = 8;
            this.lbBlue.Text = "blue";
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.ForeColor = System.Drawing.Color.Green;
            this.lbGreen.Location = new System.Drawing.Point(552, 96);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(42, 20);
            this.lbGreen.TabIndex = 7;
            this.lbGreen.Text = "geen";
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.ForeColor = System.Drawing.Color.Red;
            this.lbRed.Location = new System.Drawing.Point(552, 56);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(31, 20);
            this.lbRed.TabIndex = 6;
            this.lbRed.Text = "red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "BLUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "GREEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "RED";
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.LargeChange = 15;
            this.hScrollBar3.Location = new System.Drawing.Point(70, 132);
            this.hScrollBar3.Maximum = 255;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(466, 26);
            this.hScrollBar3.TabIndex = 2;
            this.hScrollBar3.ValueChanged += new System.EventHandler(this.hScrollBar3_ValueChanged);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 15;
            this.hScrollBar2.Location = new System.Drawing.Point(70, 90);
            this.hScrollBar2.Maximum = 255;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(466, 26);
            this.hScrollBar2.TabIndex = 1;
            this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 15;
            this.hScrollBar1.Location = new System.Drawing.Point(70, 48);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(466, 26);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(89, 32);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(619, 190);
            this.pnMain.TabIndex = 1;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lbBlue;
        private Label lbGreen;
        private Label lbRed;
        private Label label3;
        private Label label2;
        private Label label1;
        private HScrollBar hScrollBar3;
        private HScrollBar hScrollBar2;
        private HScrollBar hScrollBar1;
        private Panel pnMain;
    }
}