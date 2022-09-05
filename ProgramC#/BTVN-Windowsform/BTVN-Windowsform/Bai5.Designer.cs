namespace BTVN_Windowsform
{
    partial class Bai5
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên ngoại ngữ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách các ngoại ngữ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(308, 469);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 29);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(448, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(245, 55);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(274, 30);
            this.txtLanguage.TabIndex = 1;
            this.txtLanguage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 23;
            this.list.Items.AddRange(new object[] {
            "Tiếnh Anh",
            "Tiếng Pháp"});
            this.list.Location = new System.Drawing.Point(64, 174);
            this.list.Name = "list";
            this.list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list.Size = new System.Drawing.Size(433, 257);
            this.list.TabIndex = 7;
            this.list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(579, 522);
            this.Controls.Add(this.list);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Bai5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình minh họa List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private Button btnExit;
        private TextBox txtLanguage;
        private ListBox list;
    }
}