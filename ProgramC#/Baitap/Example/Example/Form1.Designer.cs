namespace Example
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDiemThietKeWeb = new System.Windows.Forms.TextBox();
            this.txtDiemCSDL = new System.Windows.Forms.TextBox();
            this.txtDiemLapTrinh = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Cofirm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.them_Click);
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.btnCancel);
            this.addPanel.Controls.Add(this.txtDiemThietKeWeb);
            this.addPanel.Controls.Add(this.txtDiemCSDL);
            this.addPanel.Controls.Add(this.txtDiemLapTrinh);
            this.addPanel.Controls.Add(this.txtBirth);
            this.addPanel.Controls.Add(this.txtName);
            this.addPanel.Controls.Add(this.label6);
            this.addPanel.Controls.Add(this.label5);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.btnAdd);
            this.addPanel.Location = new System.Drawing.Point(21, 75);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(306, 302);
            this.addPanel.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtDiemThietKeWeb
            // 
            this.txtDiemThietKeWeb.Location = new System.Drawing.Point(151, 204);
            this.txtDiemThietKeWeb.Name = "txtDiemThietKeWeb";
            this.txtDiemThietKeWeb.Size = new System.Drawing.Size(141, 27);
            this.txtDiemThietKeWeb.TabIndex = 8;
            // 
            // txtDiemCSDL
            // 
            this.txtDiemCSDL.Location = new System.Drawing.Point(151, 161);
            this.txtDiemCSDL.Name = "txtDiemCSDL";
            this.txtDiemCSDL.Size = new System.Drawing.Size(141, 27);
            this.txtDiemCSDL.TabIndex = 8;
            // 
            // txtDiemLapTrinh
            // 
            this.txtDiemLapTrinh.Location = new System.Drawing.Point(151, 120);
            this.txtDiemLapTrinh.Name = "txtDiemLapTrinh";
            this.txtDiemLapTrinh.Size = new System.Drawing.Size(141, 27);
            this.txtDiemLapTrinh.TabIndex = 8;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(151, 73);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(141, 27);
            this.txtBirth.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 27);
            this.txtName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "diem thiet ke web";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "diem csdl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "diem lap trinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ngay sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ten: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(357, 405);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(58, 20);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "ket qua";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(357, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 302);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Panel addPanel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDiemThietKeWeb;
        private TextBox txtDiemCSDL;
        private TextBox txtDiemLapTrinh;
        private TextBox txtBirth;
        private TextBox txtName;
        private Button btnCancel;
        private Label lbResult;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}