namespace BTVN_Windowsform
{
    partial class Bai9
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
            this.btnAgaint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.font4 = new System.Windows.Forms.RadioButton();
            this.font3 = new System.Windows.Forms.RadioButton();
            this.font2 = new System.Windows.Forms.RadioButton();
            this.font1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hu4 = new System.Windows.Forms.CheckBox();
            this.hu3 = new System.Windows.Forms.CheckBox();
            this.hu2 = new System.Windows.Forms.CheckBox();
            this.hu1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tim = new System.Windows.Forms.RadioButton();
            this.xanhla = new System.Windows.Forms.RadioButton();
            this.doo = new System.Windows.Forms.RadioButton();
            this.xanh = new System.Windows.Forms.RadioButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgaint
            // 
            this.btnAgaint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgaint.Location = new System.Drawing.Point(116, 311);
            this.btnAgaint.Name = "btnAgaint";
            this.btnAgaint.Size = new System.Drawing.Size(81, 35);
            this.btnAgaint.TabIndex = 0;
            this.btnAgaint.Text = "&Làm lại";
            this.btnAgaint.UseVisualStyleBackColor = true;
            this.btnAgaint.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(304, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.font4);
            this.groupBox1.Controls.Add(this.font3);
            this.groupBox1.Controls.Add(this.font2);
            this.groupBox1.Controls.Add(this.font1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(37, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu font";
            // 
            // font4
            // 
            this.font4.AutoSize = true;
            this.font4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.font4.Location = new System.Drawing.Point(24, 101);
            this.font4.Name = "font4";
            this.font4.Size = new System.Drawing.Size(72, 20);
            this.font4.TabIndex = 3;
            this.font4.TabStop = true;
            this.font4.Text = "Tahoma";
            this.font4.UseVisualStyleBackColor = true;
            this.font4.CheckedChanged += new System.EventHandler(this.font4_CheckedChanged);
            // 
            // font3
            // 
            this.font3.AutoSize = true;
            this.font3.Font = new System.Drawing.Font("Adobe Hebrew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.font3.Location = new System.Drawing.Point(24, 76);
            this.font3.Name = "font3";
            this.font3.Size = new System.Drawing.Size(81, 20);
            this.font3.TabIndex = 2;
            this.font3.TabStop = true;
            this.font3.Text = "VnVgogue";
            this.font3.UseVisualStyleBackColor = true;
            this.font3.CheckedChanged += new System.EventHandler(this.font3_CheckedChanged);
            // 
            // font2
            // 
            this.font2.AutoSize = true;
            this.font2.Font = new System.Drawing.Font("Adobe Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.font2.Location = new System.Drawing.Point(25, 51);
            this.font2.Name = "font2";
            this.font2.Size = new System.Drawing.Size(70, 18);
            this.font2.TabIndex = 1;
            this.font2.TabStop = true;
            this.font2.Text = "VnUniverse";
            this.font2.UseVisualStyleBackColor = true;
            this.font2.CheckedChanged += new System.EventHandler(this.font2_CheckedChanged);
            // 
            // font1
            // 
            this.font1.AutoSize = true;
            this.font1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.font1.Location = new System.Drawing.Point(24, 27);
            this.font1.Name = "font1";
            this.font1.Size = new System.Drawing.Size(66, 19);
            this.font1.TabIndex = 0;
            this.font1.TabStop = true;
            this.font1.Text = "VnTime";
            this.font1.UseVisualStyleBackColor = true;
            this.font1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hu4);
            this.groupBox2.Controls.Add(this.hu3);
            this.groupBox2.Controls.Add(this.hu2);
            this.groupBox2.Controls.Add(this.hu1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(194, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu ứng";
            // 
            // hu4
            // 
            this.hu4.AutoSize = true;
            this.hu4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.hu4.Location = new System.Drawing.Point(23, 101);
            this.hu4.Name = "hu4";
            this.hu4.Size = new System.Drawing.Size(83, 21);
            this.hu4.TabIndex = 3;
            this.hu4.Text = "Underline";
            this.hu4.UseVisualStyleBackColor = true;
            this.hu4.CheckedChanged += new System.EventHandler(this.hu4_CheckedChanged);
            // 
            // hu3
            // 
            this.hu3.AutoSize = true;
            this.hu3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.hu3.Location = new System.Drawing.Point(23, 76);
            this.hu3.Name = "hu3";
            this.hu3.Size = new System.Drawing.Size(79, 21);
            this.hu3.TabIndex = 2;
            this.hu3.Text = "Strikoout";
            this.hu3.UseVisualStyleBackColor = true;
            this.hu3.CheckedChanged += new System.EventHandler(this.hu3_CheckedChanged);
            // 
            // hu2
            // 
            this.hu2.AutoSize = true;
            this.hu2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.hu2.Location = new System.Drawing.Point(23, 51);
            this.hu2.Name = "hu2";
            this.hu2.Size = new System.Drawing.Size(53, 21);
            this.hu2.TabIndex = 1;
            this.hu2.Text = "Italic";
            this.hu2.UseVisualStyleBackColor = true;
            this.hu2.CheckedChanged += new System.EventHandler(this.hu2_CheckedChanged);
            // 
            // hu1
            // 
            this.hu1.AutoSize = true;
            this.hu1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hu1.Location = new System.Drawing.Point(23, 27);
            this.hu1.Name = "hu1";
            this.hu1.Size = new System.Drawing.Size(55, 21);
            this.hu1.TabIndex = 0;
            this.hu1.Text = "Bold";
            this.hu1.UseVisualStyleBackColor = true;
            this.hu1.CheckedChanged += new System.EventHandler(this.hu1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tim);
            this.groupBox3.Controls.Add(this.xanhla);
            this.groupBox3.Controls.Add(this.doo);
            this.groupBox3.Controls.Add(this.xanh);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(361, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 138);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Màu chữ";
            // 
            // tim
            // 
            this.tim.AutoSize = true;
            this.tim.ForeColor = System.Drawing.Color.Violet;
            this.tim.Location = new System.Drawing.Point(18, 101);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(47, 21);
            this.tim.TabIndex = 3;
            this.tim.TabStop = true;
            this.tim.Text = "Tím";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.CheckedChanged += new System.EventHandler(this.tim_CheckedChanged);
            // 
            // xanhla
            // 
            this.xanhla.AutoSize = true;
            this.xanhla.ForeColor = System.Drawing.Color.Green;
            this.xanhla.Location = new System.Drawing.Point(19, 75);
            this.xanhla.Name = "xanhla";
            this.xanhla.Size = new System.Drawing.Size(62, 21);
            this.xanhla.TabIndex = 2;
            this.xanhla.TabStop = true;
            this.xanhla.Text = "Lá cây";
            this.xanhla.UseVisualStyleBackColor = true;
            this.xanhla.CheckedChanged += new System.EventHandler(this.xanhla_CheckedChanged);
            // 
            // doo
            // 
            this.doo.AutoSize = true;
            this.doo.ForeColor = System.Drawing.Color.Red;
            this.doo.Location = new System.Drawing.Point(18, 51);
            this.doo.Name = "doo";
            this.doo.Size = new System.Drawing.Size(43, 21);
            this.doo.TabIndex = 1;
            this.doo.TabStop = true;
            this.doo.Text = "Đỏ";
            this.doo.UseVisualStyleBackColor = true;
            this.doo.CheckedChanged += new System.EventHandler(this.doo_CheckedChanged);
            // 
            // xanh
            // 
            this.xanh.AutoSize = true;
            this.xanh.ForeColor = System.Drawing.Color.Blue;
            this.xanh.Location = new System.Drawing.Point(18, 26);
            this.xanh.Name = "xanh";
            this.xanh.Size = new System.Drawing.Size(55, 21);
            this.xanh.TabIndex = 0;
            this.xanh.TabStop = true;
            this.xanh.Text = "Xanh";
            this.xanh.UseVisualStyleBackColor = true;
            this.xanh.CheckedChanged += new System.EventHandler(this.xanh_CheckedChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(88, 48);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(334, 33);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "Microsoft visual C#";
            this.txtResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(519, 373);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgaint);
            this.Name = "Bai9";
            this.Text = "Program of font";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgaint;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton font4;
        private RadioButton font3;
        private RadioButton font2;
        private RadioButton font1;
        private GroupBox groupBox2;
        private CheckBox hu4;
        private CheckBox hu3;
        private CheckBox hu2;
        private CheckBox hu1;
        private GroupBox groupBox3;
        private RadioButton tim;
        private RadioButton xanhla;
        private RadioButton doo;
        private RadioButton xanh;
        private TextBox txtResult;
    }
}