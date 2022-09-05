namespace BTVN_Windowsform
{
    partial class Bai7
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
            this.cbFolder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbFolder
            // 
            this.cbFolder.FormattingEnabled = true;
            this.cbFolder.Location = new System.Drawing.Point(179, 77);
            this.cbFolder.Name = "cbFolder";
            this.cbFolder.Size = new System.Drawing.Size(324, 31);
            this.cbFolder.TabIndex = 0;
            this.cbFolder.SelectedIndexChanged += new System.EventHandler(this.cbFolder_SelectedIndexChanged);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(650, 486);
            this.Controls.Add(this.cbFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbFolder;
    }
}