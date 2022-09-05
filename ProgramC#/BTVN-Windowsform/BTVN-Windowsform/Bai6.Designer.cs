namespace BTVN_Windowsform
{
    partial class Bai6
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
            this.list = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.ColumnWidth = 4;
            this.list.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 23;
            this.list.Items.AddRange(new object[] {
            "Item1"});
            this.list.Location = new System.Drawing.Point(71, 45);
            this.list.MultiColumn = true;
            this.list.Name = "list";
            this.list.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list.Size = new System.Drawing.Size(486, 349);
            this.list.TabIndex = 0;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(260, 427);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 490);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.list);
            this.Name = "Bai6";
            this.Text = "Ví dụ minh họa List Box";
            this.Load += new System.EventHandler(this.Bai6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox list;
        private Button btnOk;
    }
}