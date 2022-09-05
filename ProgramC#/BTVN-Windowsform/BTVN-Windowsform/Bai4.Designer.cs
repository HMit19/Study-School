namespace BTVN_Windowsform
{
    partial class Bai4
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
            this.txtRes = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChia = new System.Windows.Forms.RadioButton();
            this.btnNhan = new System.Windows.Forms.RadioButton();
            this.btnTru = new System.Windows.Forms.RadioButton();
            this.btnCong = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMin = new System.Windows.Forms.CheckBox();
            this.btnMax = new System.Windows.Forms.CheckBox();
            this.btnAgaint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRes);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(127, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(451, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.HideSelection = false;
            this.txtRes.Location = new System.Drawing.Point(228, 126);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(125, 30);
            this.txtRes.TabIndex = 100;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(228, 81);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(125, 30);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(228, 34);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(125, 30);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết Quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b = ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a = ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChia);
            this.groupBox2.Controls.Add(this.btnNhan);
            this.groupBox2.Controls.Add(this.btnTru);
            this.groupBox2.Controls.Add(this.btnCong);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(83, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(189, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phép tính";
            // 
            // btnChia
            // 
            this.btnChia.AutoSize = true;
            this.btnChia.Location = new System.Drawing.Point(44, 154);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(65, 27);
            this.btnChia.TabIndex = 8;
            this.btnChia.TabStop = true;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.CheckedChanged += new System.EventHandler(this.btnChia_CheckedChanged);
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.AutoSize = true;
            this.btnNhan.Location = new System.Drawing.Point(44, 115);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(73, 27);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.TabStop = true;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnTru
            // 
            this.btnTru.AutoSize = true;
            this.btnTru.Location = new System.Drawing.Point(44, 71);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(56, 27);
            this.btnTru.TabIndex = 4;
            this.btnTru.TabStop = true;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.CheckedChanged += new System.EventHandler(this.btnTru_CheckedChanged);
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnCong
            // 
            this.btnCong.AutoSize = true;
            this.btnCong.Location = new System.Drawing.Point(44, 29);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(77, 27);
            this.btnCong.TabIndex = 3;
            this.btnCong.TabStop = true;
            this.btnCong.Text = "Cộng ";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.CheckedChanged += new System.EventHandler(this.btnCong_CheckedChanged);
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMin);
            this.groupBox3.Controls.Add(this.btnMax);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(432, 245);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(185, 197);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "So sánh";
            // 
            // btnMin
            // 
            this.btnMin.AutoSize = true;
            this.btnMin.Location = new System.Drawing.Point(26, 130);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(84, 27);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "Min = ";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.CheckedChanged += new System.EventHandler(this.btnMin_CheckedChanged);
            // 
            // btnMax
            // 
            this.btnMax.AutoSize = true;
            this.btnMax.Location = new System.Drawing.Point(26, 57);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(88, 27);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "Max = ";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAgaint
            // 
            this.btnAgaint.Location = new System.Drawing.Point(211, 464);
            this.btnAgaint.Name = "btnAgaint";
            this.btnAgaint.Size = new System.Drawing.Size(94, 41);
            this.btnAgaint.TabIndex = 9;
            this.btnAgaint.Text = "Làm lại";
            this.btnAgaint.UseVisualStyleBackColor = true;
            this.btnAgaint.Click += new System.EventHandler(this.btnAgaint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(386, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(677, 517);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgaint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình tính toán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRes;
        private TextBox txtB;
        private TextBox txtA;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton btnChia;
        private RadioButton btnNhan;
        private RadioButton btnTru;
        private RadioButton btnCong;
        private CheckBox btnMax;
        private CheckBox btnMin;
        private Button btnAgaint;
        private Button btnExit;
    }
}