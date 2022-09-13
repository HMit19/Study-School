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
            this.lbPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMove
            // 
            this.lbMove.AutoSize = true;
            this.lbMove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMove.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbMove.Location = new System.Drawing.Point(31, 207);
            this.lbMove.Name = "lbMove";
            this.lbMove.Size = new System.Drawing.Size(151, 32);
            this.lbMove.TabIndex = 0;
            this.lbMove.Text = "Hello World";
            // 
            // TimeBox
            // 
            this.TimeBox.Enabled = true;
            this.TimeBox.Interval = 1;
            this.TimeBox.Tick += new System.EventHandler(this.TimeBox_Tick);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(320, 351);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(0, 20);
            this.lbPosition.TabIndex = 1;
            // 
            // Bai14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(682, 457);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbMove);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai14";
            this.Text = "Dòng chữ chuyển động";
            this.Load += new System.EventHandler(this.Bai14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMove;
        private System.Windows.Forms.Timer TimeBox;
        private Label lbPosition;
    }
}