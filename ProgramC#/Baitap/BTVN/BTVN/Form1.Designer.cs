namespace BTVN
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
            this.newBook = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCheckQR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbRES = new System.Windows.Forms.Label();
            this.newBook.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newBook
            // 
            this.newBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newBook.Controls.Add(this.label5);
            this.newBook.Controls.Add(this.label4);
            this.newBook.Controls.Add(this.label3);
            this.newBook.Controls.Add(this.label2);
            this.newBook.Controls.Add(this.label1);
            this.newBook.Controls.Add(this.txtQuantity);
            this.newBook.Controls.Add(this.txtQR);
            this.newBook.Controls.Add(this.txtName);
            this.newBook.Controls.Add(this.txtAuthor);
            this.newBook.Controls.Add(this.txtID);
            this.newBook.Controls.Add(this.btnAdd);
            this.newBook.Location = new System.Drawing.Point(103, 32);
            this.newBook.Name = "newBook";
            this.newBook.Size = new System.Drawing.Size(250, 338);
            this.newBook.TabIndex = 0;
            this.newBook.Paint += new System.Windows.Forms.PaintEventHandler(this.newBook_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "QR Code:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(100, 180);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 27);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(100, 236);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(125, 27);
            this.txtQR.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(100, 130);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(125, 27);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCheckQR);
            this.panel1.Location = new System.Drawing.Point(17, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 108);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(80, 68);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(94, 29);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "QR Code:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCheckQR
            // 
            this.txtCheckQR.Location = new System.Drawing.Point(110, 22);
            this.txtCheckQR.Name = "txtCheckQR";
            this.txtCheckQR.Size = new System.Drawing.Size(106, 27);
            this.txtCheckQR.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(81, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Check book";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbResult.Location = new System.Drawing.Point(97, 255);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(76, 35);
            this.lbResult.TabIndex = 12;
            this.lbResult.Text = "result";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbResult);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(439, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 341);
            this.panel2.TabIndex = 13;
            // 
            // lbRES
            // 
            this.lbRES.AutoSize = true;
            this.lbRES.Location = new System.Drawing.Point(369, 390);
            this.lbRES.Name = "lbRES";
            this.lbRES.Size = new System.Drawing.Size(0, 20);
            this.lbRES.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbRES);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.newBook);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newBook.ResumeLayout(false);
            this.newBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel newBook;
        private Label label1;
        private TextBox txtQuantity;
        private TextBox txtQR;
        private TextBox txtName;
        private TextBox txtAuthor;
        private TextBox txtID;
        private Button btnAdd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label6;
        private TextBox txtCheckQR;
        private Button btnCheck;
        private Label label7;
        private Label lbResult;
        private Panel panel2;
        private Label lbRES;
    }
}