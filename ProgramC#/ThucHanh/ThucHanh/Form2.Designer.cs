namespace ThucHanh
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
            System.Windows.Forms.TextBox txtMonth;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAgaint = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            txtMonth = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMonth
            // 
            txtMonth.Location = new System.Drawing.Point(185, 49);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new System.Drawing.Size(265, 27);
            txtMonth.TabIndex = 1;
            txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(txtMonth);
            this.panel1.Controls.Add(this.lbYear);
            this.panel1.Controls.Add(this.lbMonth);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAgaint);
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Location = new System.Drawing.Point(144, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 261);
            this.panel1.TabIndex = 0;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(185, 107);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(265, 27);
            this.txtYear.TabIndex = 2;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(77, 110);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(78, 20);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "Enter Year:";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(77, 56);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(100, 20);
            this.lbMonth.TabIndex = 3;
            this.lbMonth.Text = "Enten Month: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(373, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "$Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAgaint
            // 
            this.btnAgaint.Location = new System.Drawing.Point(214, 182);
            this.btnAgaint.Name = "btnAgaint";
            this.btnAgaint.Size = new System.Drawing.Size(108, 48);
            this.btnAgaint.TabIndex = 4;
            this.btnAgaint.Text = "&Againt";
            this.btnAgaint.UseVisualStyleBackColor = true;
            this.btnAgaint.Click += new System.EventHandler(this.btnAgaint_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(43, 182);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(112, 48);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "&Result";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtYear;
        private TextBox txtMonth;
        private Label lbYear;
        private Label lbMonth;
        private Button btnExit;
        private Button btnAgaint;
        private Button btnResult;
    }
}