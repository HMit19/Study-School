namespace BTVN_Windowsform
{
    partial class Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(289, 211);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 25);
            this.lbResult.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tính tổng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Làm lại";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(424, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(168, 45);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(365, 27);
            this.txta.TabIndex = 6;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(168, 137);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(365, 27);
            this.txtb.TabIndex = 7;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(581, 391);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Chương trình tính tổng";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txta;
        private TextBox txtb;
    }
}