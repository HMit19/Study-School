using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3
{
    public partial class Form3 : Form
    {
        BaiTapDienTu BT;
        public Form3(BaiTapDienTu bt)
        {
            BT = new BaiTapDienTu(bt);
            InitializeComponent();
            textBox1.Text = bt.Debai;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (rs == DialogResult.OK)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int point = 0;
            if (txt1.Text.Replace(" ", "") == "one")
            {
                point++;
                txt1.BackColor = Color.Green;
            }
            else if (txt1.Text.Replace(" ", "") != "one")
            {
                txt1.BackColor = Color.Tomato;
            }
            if (txt2.Text.Replace(" ", "") == "on")
            {
                point++;
                txt2.BackColor = Color.Green;
            }
            else if (txt2.Text.Replace(" ", "") != "on")
            {
                txt2.BackColor = Color.Tomato;
            }
            if (txt3.Text.Replace(" ", "") == "left")
            {
                point++;
                txt3.BackColor = Color.Green;
            }
            else if (txt3.Text.Replace(" ", "") != "left")
            {
                txt3.BackColor = Color.Tomato;
            }
            if (txt4.Text.Replace(" ", "") == "then")
            {
                point++;
                txt4.BackColor = Color.Green;
            }
            else if (txt4.Text.Replace(" ", "") != "then")
            {
                txt4.BackColor = Color.Tomato;
            }
            if (txt5.Text.Replace(" ", "") == "as")
            {
                point++;
                txt5.BackColor = Color.Green;
            }
            else if (txt5.Text.Replace(" ", "") != "as")
            {
                txt5.BackColor = Color.Tomato;
            }
            if (txt6.Text.Replace(" ", "") == "married")
            {
                point++;
                txt6.BackColor = Color.Green;
            }
            else if (txt6.Text.Replace(" ", "") != "married")
            {
                txt6.BackColor = Color.Tomato;
            }
            if (txt7.Text.Replace(" ", "") == "the")
            {
                point++;
                txt7.BackColor = Color.Green;
            }
            else if (txt7.Text.Replace(" ", "") != "the")
            {
                txt7.BackColor = Color.Tomato;
            }
            if (txt8.Text.Replace(" ", "") == "but")
            {
                point++;
                txt8.BackColor = Color.Green;
            }
            else if (txt8.Text.Replace(" ", "") != "but")
            {
                txt8.BackColor = Color.Tomato;
            }
            if (txt9.Text.Replace(" ", "") == "that")
            {
                point++;
                txt9.BackColor = Color.Green;
            }
            else if (txt9.Text.Replace(" ", "") != "that")
            {
                txt9.BackColor = Color.Tomato;
            }
            if (txt10.Text.Replace(" ", "") == "watches")
            {
                point++;
                txt10.BackColor = Color.Green;
            }
            else if (txt10.Text.Replace(" ", "") != "watches")
            {
                txt10.BackColor = Color.Tomato;
            }
            MessageBox.Show( "Diem cua ban la " + point.ToString(), "Ket qua");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = BT.Dapan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Control i in grb.Controls)
            {
                if(i is TextBox)
                {
                    i.Text = "";
                    i.BackColor = Color.White;
                }
            }
            txt1.Focus();
            textBox1.Text = BT.Debai;
        }
    }
}
