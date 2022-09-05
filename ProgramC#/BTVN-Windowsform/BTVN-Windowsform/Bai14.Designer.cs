namespace BTVN_Windowsform
{
    partial class Bai14
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
            this.components = new System.ComponentModel.Container();
            this.lbMove = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbMove
            // 
            this.lbMove.AutoSize = true;
            this.lbMove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMove.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbMove.Location = new System.Drawing.Point(27, 155);
            this.lbMove.Name = "lbMove";
            this.lbMove.Size = new System.Drawing.Size(119, 25);
            this.lbMove.TabIndex = 0;
            this.lbMove.Text = "Hello World";
            // 
            // TimeBox
            // 
            this.TimeBox.Enabled = true;
            this.TimeBox.Interval = 30;
            this.TimeBox.Tick += new System.EventHandler(this.TimeBox_Tick);
            // 
            // Bai14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(597, 343);
            this.Controls.Add(this.lbMove);
            this.Name = "Bai14";
            this.Text = "Dòng chữ chuyển động";
            this.Load += new System.EventHandler(this.Bai14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMove;
        private System.Windows.Forms.Timer TimeBox;
    }
}