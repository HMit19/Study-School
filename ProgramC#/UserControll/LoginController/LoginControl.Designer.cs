namespace LoginController
{
    partial class LoginControl<T>
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.lbForgot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbNoti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN NOW";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteCustomSource.AddRange(new string[] {
            "demo",
            "maivanhieu",
            "nguyenvanan",
            "tranvanbe",
            "nguyenvance",
            "phamthide"});
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(21, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "USERNAME";
            this.txtUsername.Size = new System.Drawing.Size(260, 29);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(21, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "PASSWORD";
            this.txtPassword.Size = new System.Drawing.Size(260, 29);
            this.txtPassword.TabIndex = 2;
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRemember.Location = new System.Drawing.Point(21, 182);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(105, 18);
            this.cbRemember.TabIndex = 3;
            this.cbRemember.Text = "Remember Me";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // lbForgot
            // 
            this.lbForgot.AutoSize = true;
            this.lbForgot.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbForgot.Location = new System.Drawing.Point(181, 183);
            this.lbForgot.Name = "lbForgot";
            this.lbForgot.Size = new System.Drawing.Size(100, 14);
            this.lbForgot.TabIndex = 4;
            this.lbForgot.Text = "ForgotPassword?";
            this.lbForgot.Click += new System.EventHandler(this.lbForgot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t have an Account?";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbRegister.ForeColor = System.Drawing.Color.Tomato;
            this.lbRegister.Location = new System.Drawing.Point(197, 290);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(56, 17);
            this.lbRegister.TabIndex = 6;
            this.lbRegister.Text = "Register";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignIn.Location = new System.Drawing.Point(104, 228);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(87, 35);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Enabled = false;
            this.lbNoti.ForeColor = System.Drawing.Color.Red;
            this.lbNoti.Location = new System.Drawing.Point(21, 164);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(164, 15);
            this.lbNoti.TabIndex = 8;
            this.lbNoti.Text = "Invalid username or password";
            this.lbNoti.Visible = false;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbForgot);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(300, 337);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox cbRemember;
        private Label lbForgot;
        private Label label3;
        private Label lbRegister;
        private Button btnSignIn;
        private Label lbNoti;
    }
}
