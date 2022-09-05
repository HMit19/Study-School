using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Windowsform
{
    public partial class Bai9 : Form
    {
        Font fontDefault;
        public Bai9()
        {
            InitializeComponent();
            fontDefault = new Font("Segoe UI", txtResult.Font.Size, txtResult.Font.Style);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hu1.Checked = false;
            hu2.Checked = false;
            hu3.Checked = false;
            hu4.Checked = false;
            xanh.Checked = false;
            doo.Checked = false;
            xanhla.Checked = false;
            tim.Checked = false;
            font1.Checked = false;
            font2.Checked = false;
            font3.Checked = false;
            font4.Checked = false;
            txtResult.ForeColor = Color.Black;
            txtResult.Font = fontDefault;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Font = new Font("Times New Roman", txtResult.Font.Size, txtResult.Font.Style);
        }

        private void font2_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Font = new Font("Adobe Arabic", txtResult.Font.Size, txtResult.Font.Style);
        }

        private void font3_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Font = new Font("Adobe Hebrew", txtResult.Font.Size, txtResult.Font.Style);
        }

        private void hu1_CheckedChanged(object sender, EventArgs e)
        {
            if (hu1.Checked)
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size, txtResult.Font.Style ^ FontStyle.Bold);
            else
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size, txtResult.Font.Style ^ FontStyle.Bold);
        }

        private void hu2_CheckedChanged(object sender, EventArgs e)
        {
            if (hu2.Checked)
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size, txtResult.Font.Style ^ FontStyle.Italic);
            else
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size, txtResult.Font.Style ^ FontStyle.Italic);
        }

        private void hu3_CheckedChanged(object sender, EventArgs e)
        {
            if (hu3.Checked)
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size, txtResult.Font.Style ^ FontStyle.Strikeout);
            else
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size, txtResult.Font.Style ^ FontStyle.Strikeout);
        }

        private void hu4_CheckedChanged(object sender, EventArgs e)
        {
            if (hu4.Checked)
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size, txtResult.Font.Style ^ FontStyle.Underline);
            else
                txtResult.Font = new Font(txtResult.Font.FontFamily, txtResult.Font.Size, txtResult.Font.Style ^ FontStyle.Underline);
        }

        private void font4_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Font = new Font("Tahoma", txtResult.Font.Size, txtResult.Font.Style);
        }

        private void xanh_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.ForeColor = Color.Blue;
        }

        private void doo_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.ForeColor = Color.Red;
        }

        private void xanhla_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.ForeColor = Color.Green;
        }

        private void tim_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.ForeColor = Color.Violet;
        }
    }
}

