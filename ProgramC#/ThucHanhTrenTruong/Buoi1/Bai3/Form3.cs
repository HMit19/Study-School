using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public bool checkValid(TextBox textBox)
        {
            if (textBox.Text == "" || !double.TryParse(textBox.Text, out double a)) { return false; }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkValid(textBox1) && checkValid(textBox2) && checkValid(textBox3))
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            textBox4.Text = "Phương trình vô số nghiệm";
                        }
                        else
                            textBox4.Text = "Phuơng trình luôn sai";
                    }
                    else
                    {
                        double d = (double)-c / b;
                        textBox4.Text = "Phương trình có nghiệm duy nhất " + d.ToString();
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        textBox4.Text = "Phuong trinh vo nghiem";
                    }
                    else if (delta > 0)
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        textBox4.Text = "Phuong trinh co 2 nghiem la: \n" + $"x1 = {Math.Round(x1, 2)} \n x2 = {Math.Round(x2, 2)}";
                    }
                    else {
                         double x = -b / (2 * a);
                        textBox4.Text = $"Phuong trinh co nghiem kep x = {Math.Round(x, 2)}";
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
