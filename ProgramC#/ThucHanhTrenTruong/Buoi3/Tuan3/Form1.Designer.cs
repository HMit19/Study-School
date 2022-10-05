namespace Tuan3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbThuMuc = new System.Windows.Forms.ComboBox();
            this.lBox = new System.Windows.Forms.ListBox();
            this.rBox = new System.Windows.Forms.RichTextBox();
            this.cbODia = new System.Windows.Forms.ComboBox();
            this.axMedia = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tập tin";
            // 
            // cbThuMuc
            // 
            this.cbThuMuc.FormattingEnabled = true;
            this.cbThuMuc.Location = new System.Drawing.Point(78, 81);
            this.cbThuMuc.Name = "cbThuMuc";
            this.cbThuMuc.Size = new System.Drawing.Size(202, 21);
            this.cbThuMuc.TabIndex = 2;
            this.cbThuMuc.SelectedIndexChanged += new System.EventHandler(this.cbThuMuc_SelectedIndexChanged);
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(12, 148);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(268, 95);
            this.lBox.TabIndex = 4;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.lBox_SelectedIndexChanged);
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(302, 12);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(367, 426);
            this.rBox.TabIndex = 6;
            this.rBox.Text = "";
            // 
            // cbODia
            // 
            this.cbODia.FormattingEnabled = true;
            this.cbODia.Location = new System.Drawing.Point(78, 31);
            this.cbODia.Name = "cbODia";
            this.cbODia.Size = new System.Drawing.Size(202, 21);
            this.cbODia.TabIndex = 1;
            this.cbODia.SelectedIndexChanged += new System.EventHandler(this.cbODia_SelectedIndexChanged);
            // 
            // axMedia
            // 
            this.axMedia.Enabled = true;
            this.axMedia.Location = new System.Drawing.Point(12, 249);
            this.axMedia.Name = "axMedia";
            this.axMedia.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMedia.OcxState")));
            this.axMedia.Size = new System.Drawing.Size(268, 189);
            this.axMedia.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.cbODia);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.axMedia);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.cbThuMuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbThuMuc;
        private System.Windows.Forms.ListBox lBox;
        private AxWMPLib.AxWindowsMediaPlayer axMedia;
        private System.Windows.Forms.RichTextBox rBox;
        private System.Windows.Forms.ComboBox cbODia;
    }
}

