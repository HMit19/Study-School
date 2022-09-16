namespace Tuan2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTin = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.lBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sumTin = new System.Windows.Forms.TextBox();
            this.avg = new System.Windows.Forms.TextBox();
            this.sumDiem = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBox
            // 
            this.cbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBox.ForeColor = System.Drawing.Color.Black;
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Items.AddRange(new object[] {
            "Giải tích F1",
            "Tin học đại cương",
            "Tiếng anh A0",
            "Triết học Mác Lênin",
            "Vật lý F1"});
            this.cbBox.Location = new System.Drawing.Point(24, 69);
            this.cbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(246, 25);
            this.cbBox.TabIndex = 0;
            this.cbBox.SelectedIndexChanged += new System.EventHandler(this.cbBox_SelectedIndexChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtDiem);
            this.gb1.Controls.Add(this.txtSoTin);
            this.gb1.Controls.Add(this.btnThem);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.cbBox);
            this.gb1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb1.ForeColor = System.Drawing.Color.Black;
            this.gb1.Location = new System.Drawing.Point(21, 9);
            this.gb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb1.Size = new System.Drawing.Size(298, 350);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thông tin điểm sinh viên";
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiem.Location = new System.Drawing.Point(122, 170);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 25);
            this.txtDiem.TabIndex = 3;
            this.txtDiem.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            // 
            // txtSoTin
            // 
            this.txtSoTin.Enabled = false;
            this.txtSoTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoTin.ForeColor = System.Drawing.Color.Black;
            this.txtSoTin.Location = new System.Drawing.Point(122, 122);
            this.txtSoTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTin.Name = "txtSoTin";
            this.txtSoTin.Size = new System.Drawing.Size(148, 25);
            this.txtSoTin.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(63, 239);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 32);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm vào &DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn hoc";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.lBox);
            this.gb2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb2.ForeColor = System.Drawing.Color.Black;
            this.gb2.Location = new System.Drawing.Point(324, 9);
            this.gb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb2.Size = new System.Drawing.Size(472, 218);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            this.gb2.Text = "Danh sách các môn học";
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.ItemHeight = 17;
            this.lBox.Location = new System.Drawing.Point(20, 25);
            this.lBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(438, 174);
            this.lBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(324, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(578, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng số điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(324, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm trung bình";
            // 
            // sumTin
            // 
            this.sumTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumTin.ForeColor = System.Drawing.Color.Black;
            this.sumTin.Location = new System.Drawing.Point(433, 232);
            this.sumTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumTin.Name = "sumTin";
            this.sumTin.Size = new System.Drawing.Size(118, 23);
            this.sumTin.TabIndex = 5;
            // 
            // avg
            // 
            this.avg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avg.ForeColor = System.Drawing.Color.Black;
            this.avg.Location = new System.Drawing.Point(433, 268);
            this.avg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(177, 23);
            this.avg.TabIndex = 7;
            // 
            // sumDiem
            // 
            this.sumDiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumDiem.ForeColor = System.Drawing.Color.Black;
            this.sumDiem.Location = new System.Drawing.Point(684, 230);
            this.sumDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumDiem.Name = "sumDiem";
            this.sumDiem.Size = new System.Drawing.Size(112, 23);
            this.sumDiem.TabIndex = 6;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTinh.ForeColor = System.Drawing.Color.Black;
            this.btnTinh.Location = new System.Drawing.Point(402, 316);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(112, 32);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "&Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(645, 316);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 368);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.sumDiem);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.sumTin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbBox;
        private GroupBox gb1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gb2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDiem;
        private TextBox txtSoTin;
        private Button btnThem;
        private TextBox sumTin;
        private TextBox avg;
        private TextBox sumDiem;
        private Button btnTinh;
        private Button btnThoat;
        private ListBox lBox;
    }
}