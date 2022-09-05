namespace BTVN_Windowsform
{
    partial class Bai3
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
            this.lbArray = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbArraySort = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnAgaint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n:";
            // 
            // lbArray
            // 
            this.lbArray.AutoSize = true;
            this.lbArray.Location = new System.Drawing.Point(41, 93);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(77, 25);
            this.lbArray.TabIndex = 1;
            this.lbArray.Text = "Dãy số: ";
            this.lbArray.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(41, 144);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(138, 25);
            this.lbSum.TabIndex = 2;
            this.lbSum.Text = "Tổng dãy số là:";
            this.lbSum.Click += new System.EventHandler(this.lbSum_Click);
            // 
            // lbArraySort
            // 
            this.lbArraySort.AutoSize = true;
            this.lbArraySort.Location = new System.Drawing.Point(41, 193);
            this.lbArraySort.Name = "lbArraySort";
            this.lbArraySort.Size = new System.Drawing.Size(245, 25);
            this.lbArraySort.TabIndex = 3;
            this.lbArraySort.Text = "Dãy số sắp xếp giảm dần là:";
            this.lbArraySort.Click += new System.EventHandler(this.lbArraySort_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnInput.Location = new System.Drawing.Point(55, 248);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(80, 33);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Nhập";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSum.Location = new System.Drawing.Point(162, 247);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(84, 34);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Tính tổng";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSort.Location = new System.Drawing.Point(273, 246);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(87, 35);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAgaint
            // 
            this.btnAgaint.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAgaint.Location = new System.Drawing.Point(386, 246);
            this.btnAgaint.Name = "btnAgaint";
            this.btnAgaint.Size = new System.Drawing.Size(83, 35);
            this.btnAgaint.TabIndex = 5;
            this.btnAgaint.Text = "Làm lại";
            this.btnAgaint.UseVisualStyleBackColor = false;
            this.btnAgaint.Click += new System.EventHandler(this.btnAgaint_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.Location = new System.Drawing.Point(501, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(137, 37);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(210, 32);
            this.txtSize.TabIndex = 1;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(624, 293);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgaint);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lbArraySort);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.lbArray);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai3";
            this.Text = "Tính toán trên dãy số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbArray;
        private Label lbSum;
        private Label lbArraySort;
        private Button btnInput;
        private Button btnSum;
        private Button btnSort;
        private Button btnAgaint;
        private Button btnExit;
        private TextBox txtSize;
    }
}