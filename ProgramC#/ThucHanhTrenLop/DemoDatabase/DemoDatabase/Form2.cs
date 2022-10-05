using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDatabase
{
    public partial class Form2 : Form
    {
        Dictionary<string, float> coupons;
        public Form2()
        {
            InitializeComponent();
            coupons = new Dictionary<string, float>();
            coupons.Add("ma1", 50);
            coupons.Add("ma2", 60);
            coupons.Add("ma3", 70);
            coupons.Add("ma4", 80);
            coupons.Add("ma5", 90);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // regex txtQuantity không cho phép nhập chữ và ký tự đặt biệt
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 1);
            //}
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn phải nhập số nguyên!");
                e.Handled = true;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int quantity = 0;
            //try
            //{
            quantity = Convert.ToInt32(txtQuantity);
            //}
            //catch ()
            //{

            ////}
            //foreach (string item in coupons.Keys)
            //{
            //    if (txtCoupouns.Text.Equals(item) && txtQuantity)
            //    {

            //    }
            //}
        }
    }
}
