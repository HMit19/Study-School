namespace Tuan2
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
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cbSoluong = new System.Windows.Forms.ComboBox();
            this.cbDouong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGiaduythuyen = new System.Windows.Forms.TextBox();
            this.rdNuangay = new System.Windows.Forms.RadioButton();
            this.rdCangay = new System.Windows.Forms.RadioButton();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gr2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gr1.SuspendLayout();
            this.gr2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.label7);
            this.gr1.Controls.Add(this.txtGia);
            this.gr1.Controls.Add(this.cbSoluong);
            this.gr1.Controls.Add(this.cbDouong);
            this.gr1.Controls.Add(this.label6);
            this.gr1.Controls.Add(this.btnNew);
            this.gr1.Controls.Add(this.button1);
            this.gr1.Controls.Add(this.txtGiaduythuyen);
            this.gr1.Controls.Add(this.rdNuangay);
            this.gr1.Controls.Add(this.rdCangay);
            this.gr1.Controls.Add(this.txtHoten);
            this.gr1.Controls.Add(this.label5);
            this.gr1.Controls.Add(this.label4);
            this.gr1.Controls.Add(this.label3);
            this.gr1.Controls.Add(this.label2);
            this.gr1.Controls.Add(this.label1);
            this.gr1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gr1.Location = new System.Drawing.Point(27, 59);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(422, 373);
            this.gr1.TabIndex = 0;
            this.gr1.TabStop = false;
            this.gr1.Text = "Nhập Thông Tin Khách Hàng Đặt Tour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "$";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(295, 251);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(94, 27);
            this.txtGia.TabIndex = 14;
            this.txtGia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbSoluong
            // 
            this.cbSoluong.FormattingEnabled = true;
            this.cbSoluong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbSoluong.Location = new System.Drawing.Point(187, 251);
            this.cbSoluong.Name = "cbSoluong";
            this.cbSoluong.Size = new System.Drawing.Size(71, 28);
            this.cbSoluong.TabIndex = 13;
            // 
            // cbDouong
            // 
            this.cbDouong.FormattingEnabled = true;
            this.cbDouong.Items.AddRange(new object[] {
            "Coca cola",
            "Pepsi",
            "Seven up"});
            this.cbDouong.Location = new System.Drawing.Point(30, 251);
            this.cbDouong.Name = "cbDouong";
            this.cbDouong.Size = new System.Drawing.Size(127, 28);
            this.cbDouong.TabIndex = 12;
            this.cbDouong.SelectedIndexChanged += new System.EventHandler(this.cbDouong_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "$";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(233, 312);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(137, 40);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Thêm &mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm vào DS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGiaduythuyen
            // 
            this.txtGiaduythuyen.Location = new System.Drawing.Point(145, 133);
            this.txtGiaduythuyen.Name = "txtGiaduythuyen";
            this.txtGiaduythuyen.Size = new System.Drawing.Size(186, 27);
            this.txtGiaduythuyen.TabIndex = 8;
            // 
            // rdNuangay
            // 
            this.rdNuangay.AutoSize = true;
            this.rdNuangay.Location = new System.Drawing.Point(207, 85);
            this.rdNuangay.Name = "rdNuangay";
            this.rdNuangay.Size = new System.Drawing.Size(98, 24);
            this.rdNuangay.TabIndex = 7;
            this.rdNuangay.TabStop = true;
            this.rdNuangay.Text = "Nửa ngày";
            this.rdNuangay.UseVisualStyleBackColor = true;
            // 
            // rdCangay
            // 
            this.rdCangay.AutoSize = true;
            this.rdCangay.Location = new System.Drawing.Point(30, 85);
            this.rdCangay.Name = "rdCangay";
            this.rdCangay.Size = new System.Drawing.Size(85, 24);
            this.rdCangay.TabIndex = 6;
            this.rdCangay.TabStop = true;
            this.rdCangay.Text = "Cả ngày";
            this.rdCangay.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(145, 37);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(185, 27);
            this.txtHoten.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gía du thuyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // gr2
            // 
            this.gr2.Controls.Add(this.listBox1);
            this.gr2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gr2.Location = new System.Drawing.Point(479, 72);
            this.gr2.Name = "gr2";
            this.gr2.Size = new System.Drawing.Size(407, 360);
            this.gr2.TabIndex = 1;
            this.gr2.TabStop = false;
            this.gr2.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(21, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 324);
            this.listBox1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(792, 453);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 504);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gr2);
            this.Controls.Add(this.gr1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Công Ty Du Thuyền Hồ Tây";
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            this.gr2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gr1;
        private TextBox txtGia;
        private ComboBox cbSoluong;
        private ComboBox cbDouong;
        private Label label6;
        private Button btnNew;
        private Button button1;
        private TextBox txtGiaduythuyen;
        private RadioButton rdNuangay;
        private RadioButton rdCangay;
        private TextBox txtHoten;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gr2;
        private ListBox listBox1;
        private Button btnThoat;
        private Label label7;
    }
}