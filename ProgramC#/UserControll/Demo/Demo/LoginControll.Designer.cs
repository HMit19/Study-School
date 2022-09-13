using System.ComponentModel;

namespace Demo
{
    partial class LoginControll
    {
        /// <summary> 
        /// Required designer variable.
        /// private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textStateProvince;
        private System.Windows.Forms.TextBox textPostal;
        private System.Windows.Forms.TextBox textCountryRegion;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCityStateProvincePostal;
        private System.Windows.Forms.Label labelCountryRegion;
        private System.Windows.Forms.Label labelEmail;
        // private System.ComponentModel.IContainer components;
        /// </summary>
        /// 
        private IContainer components = null;

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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            components = new System.ComponentModel.Container();
         textName = new System.Windows.Forms.TextBox();
         textAddress = new System.Windows.Forms.TextBox();
         textCity = new System.Windows.Forms.TextBox();
         textStateProvince = new System.Windows.Forms.TextBox();
         textPostal = new System.Windows.Forms.TextBox();
         textCountryRegion = new System.Windows.Forms.TextBox();
         textEmail = new System.Windows.Forms.TextBox();
         labelName = new System.Windows.Forms.Label();
         labelAddress = new System.Windows.Forms.Label();
         labelCityStateProvincePostal = new System.Windows.Forms.Label();
         labelCountryRegion = new System.Windows.Forms.Label();
         labelEmail = new System.Windows.Forms.Label();

         // Set the tab order, text alignment, size, and location of the controls.
         textName.Location = new System.Drawing.Point(120, 8);
         textName.Size = new System.Drawing.Size(232, 20);
         textName.TabIndex = 0;

         textAddress.Location = new System.Drawing.Point(120, 32);
         textAddress.Size = new System.Drawing.Size(232, 20);
         textAddress.TabIndex = 1;

         textCity.Location = new System.Drawing.Point(120, 56);
         textCity.Size = new System.Drawing.Size(96, 20);
         textCity.TabIndex = 2;

         textStateProvince.Location = new System.Drawing.Point(216, 56);
         textStateProvince.Size = new System.Drawing.Size(56, 20);
         textStateProvince.TabIndex = 3;

         textPostal.Location = new System.Drawing.Point(272, 56);
         textPostal.Size = new System.Drawing.Size(80, 20);
         textPostal.TabIndex = 4;

         textCountryRegion.Location = new System.Drawing.Point(120, 80);
         textCountryRegion.Size = new System.Drawing.Size(232, 20);
         textCountryRegion.TabIndex = 5;

         textEmail.Location = new System.Drawing.Point(120, 104);
         textEmail.Size = new System.Drawing.Size(232, 20);
         textEmail.TabIndex = 6;

         labelName.Location = new System.Drawing.Point(8, 8);
         labelName.Size = new System.Drawing.Size(112, 23);
         labelName.Text = "Name:";
         labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

         labelAddress.Location = new System.Drawing.Point(8, 32);
         labelAddress.Size = new System.Drawing.Size(112, 23);
         labelAddress.Text = "Address:";
         labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

         labelCityStateProvincePostal.Location = new System.Drawing.Point(8, 56);
         labelCityStateProvincePostal.Size = new System.Drawing.Size(112, 23);
         labelCityStateProvincePostal.Text = "City, St/Prov. Postal:";
         labelCityStateProvincePostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

         labelCountryRegion.Location = new System.Drawing.Point(8, 80);
         labelCountryRegion.Size = new System.Drawing.Size(112, 23);
         labelCountryRegion.Text = "Country/Region:";
         labelCountryRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

         labelEmail.Location = new System.Drawing.Point(8, 104);
         labelEmail.Size = new System.Drawing.Size(112, 23);
         labelEmail.Text = "email:";
         labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

         // Add the Validating and Validated handlers for textEmail.

         // Add the controls to the user control.
         Controls.AddRange(new System.Windows.Forms.Control[] 
         {
            labelName,
            labelAddress,
            labelCityStateProvincePostal,
            labelCountryRegion,
            labelEmail,
            textName,
            textAddress,
            textCity,
            textStateProvince,
            textPostal,
            textCountryRegion,
            textEmail
         });  

         // Size the user control.
         Size = new System.Drawing.Size(375, 150);
        }

        #endregion
    }
}