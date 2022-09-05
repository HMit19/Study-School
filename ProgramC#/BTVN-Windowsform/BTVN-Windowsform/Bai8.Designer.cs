namespace BTVN_Windowsform
{
    partial class Bai8
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
            this.btnDone = new System.Windows.Forms.Button();
            this.clbFood = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn món ăn:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(303, 376);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(141, 37);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Hoàn thành";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // clbFood
            // 
            this.clbFood.FormattingEnabled = true;
            this.clbFood.Location = new System.Drawing.Point(80, 94);
            this.clbFood.Name = "clbFood";
            this.clbFood.Size = new System.Drawing.Size(604, 246);
            this.clbFood.TabIndex = 2;
            this.clbFood.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbFood_ItemCheck);
            this.clbFood.SelectedIndexChanged += new System.EventHandler(this.clbFood_SelectedIndexChanged);
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(775, 442);
            this.Controls.Add(this.clbFood);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai8";
            this.Text = "Minh hoạ CheckedListBox";
            this.Load += new System.EventHandler(this.Bai8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnDone;
        private CheckedListBox clbFood;
    }
}