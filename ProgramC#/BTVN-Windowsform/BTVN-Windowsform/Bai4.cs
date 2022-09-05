using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Windowsform
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        public void showMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtB.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtB.Text = txtB.Text.Remove(txtB.Text.Length - 1);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //double a = 0, b = 0;
            //if (txtA.Text != "")
            //{
            //    a = Convert.ToDouble(txtA.Text);
            //}
            //else if (txtA.Text == "")
            //{
            //    showMessage("Vui lòng nhập a!");
            //    btnCong.Checked = false;
            //    txtA.Focus();
            //    return;
            //}
            //if (txtB.Text != "")
            //{
            //    b = Convert.ToDouble(txtB.Text);
            //}
            //else if (txtB.Text == "")
            //{
            //    showMessage("Vui lòng nhập b!");
            //    btnCong.Checked = false;
            //    txtB.Focus();
            //}
            //if (txtA.Text != "" && txtB.Text != "")
            //{
            //    txtRes.Text = Convert.ToString(a * b);
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMax.Checked)
            {
                double a = 0, b = 0;
                if (txtA.Text != "")
                {
                    a = Convert.ToDouble(txtA.Text);
                }
                else if (txtA.Text == "")
                {
                    showMessage("Vui lòng nhập a!");
                    btnMax.Checked = false;
                    txtA.Focus();
                    return;
                }
                if (txtB.Text != "")
                {
                    b = Convert.ToDouble(txtB.Text);
                }
                else if (txtB.Text == "")
                {
                    showMessage("Vui lòng nhập b!");
                    btnMax.Checked = false;
                    txtB.Focus();
                }
                if (txtA.Text != "" && txtB.Text != "")
                {
                    btnMax.Text += Convert.ToString(a > b ? a : b);
                }
            }
            else
            {
                btnMax.Text = "Max = ";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muộn thoát ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtA.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtA.Text = txtA.Text.Remove(txtA.Text.Length - 1);
            }
        }

        private void btnCong_CheckedChanged(object sender, EventArgs e)
        {
            //double a = 0, b = 0;
            //if (txtA.Text != "")
            //{
            //    a = Convert.ToDouble(txtA.Text);
            //}
            //else if (txtA.Text == "")
            //{
            //    showMessage("Vui lòng nhập a!");
            //    txtA.Focus();
            //    return;
            //}
            //if (txtB.Text != "")
            //{
            //    b = Convert.ToDouble(txtB.Text);
            //    //btnCong.Checked = false;
            //}
            //else if (txtB.Text == "")
            //{
            //    showMessage("Vui lòng nhập b!");
            //    txtB.Focus();
            //}
            //if (txtA.Text != "" && txtB.Text != "")
            //{
            //    txtRes.Text = Convert.ToString(a + b);
            //}
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            if (txtA.Text != "")
            {
                a = Convert.ToDouble(txtA.Text);
            }
            else if (txtA.Text == "")
            {
                showMessage("Vui lòng nhập a!");
                btnCong.Checked = false;
                txtA.Focus();
                return;
            }
            if (txtB.Text != "")
            {
                b = Convert.ToDouble(txtB.Text);
            }
            else if (txtB.Text == "")
            {
                showMessage("Vui lòng nhập b!");
                btnCong.Checked = false;
                txtB.Focus();
            }
            if (txtA.Text != "" && txtB.Text != "")
            {
                txtRes.Text = Convert.ToString(a + b);
            }
        }

        private void btnAgaint_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtRes.Text = "";
            btnCong.Checked = false;
            btnTru.Checked = false;
            btnNhan.Checked = false;
            btnChia.Checked = false;
            btnMax.Checked = false;
            btnMin.Checked = false;
        }

        private void btnTru_CheckedChanged(object sender, EventArgs e)
        {
            //double a = 0, b = 0;
            //if (txtA.Text != "")
            //{
            //    a = Convert.ToDouble(txtA.Text);
            //}
            //else if (txtA.Text == "")
            //{
            //    showMessage("Vui lòng nhập a!");
            //    btnCong.Checked = false;
            //    txtA.Focus();
            //    return;
            //}
            //if (txtB.Text != "")
            //{
            //    b = Convert.ToDouble(txtB.Text);
            //}
            //else if (txtB.Text == "")
            //{
            //    showMessage("Vui lòng nhập b!");
            //    btnCong.Checked = false;
            //    txtB.Focus();
            //}
            //if (txtA.Text != "" && txtB.Text != "")
            //{
            //    txtRes.Text = Convert.ToString(a - b);
            //}
        }

        private void btnChia_CheckedChanged(object sender, EventArgs e)
        {
            //double a = 0, b = 0;
            //if (txtA.Text != "")
            //{
            //    a = Convert.ToDouble(txtA.Text);
            //}
            //else if (txtA.Text == "")
            //{
            //    showMessage("Vui lòng nhập a!");
            //    btnCong.Checked = false;
            //    txtA.Focus();
            //    return;
            //}
            //if (txtB.Text != "")
            //{
            //    if (txtB.Text == "0")
            //    {
            //        txtRes.Text = "Mẫu = 0";
            //    }
            //    b = Convert.ToDouble(txtB.Text);
            //}
            //else if (txtB.Text == "")
            //{
            //    showMessage("Vui lòng nhập b!");
            //    btnCong.Checked = false;
            //    txtB.Focus();
            //}
            //if (txtA.Text != "" && txtB.Text != "" && txtB.Text != "0")
            //{
            //    txtRes.Text = Convert.ToString(a / b);
            //}
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            if (txtA.Text != "")
            {
                a = Convert.ToDouble(txtA.Text);
            }
            else if (txtA.Text == "")
            {
                showMessage("Vui lòng nhập a!");
                btnTru.Checked = false;
                txtA.Focus();
                return;
            }
            if (txtB.Text != "")
            {
                b = Convert.ToDouble(txtB.Text);
            }
            else if (txtB.Text == "")
            {
                showMessage("Vui lòng nhập b!");
                btnTru.Checked = false;
                txtB.Focus();
            }
            if (txtA.Text != "" && txtB.Text != "")
            {
                txtRes.Text = Convert.ToString(a - b);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            if (txtA.Text != "")
            {
                a = Convert.ToDouble(txtA.Text);
            }
            else if (txtA.Text == "")
            {
                showMessage("Vui lòng nhập a!");
                btnChia.Checked = false;
                txtA.Focus();
                return;
            }
            if (txtB.Text != "")
            {
                if (txtB.Text == "0")
                {
                    txtRes.Text = "Mẫu = 0";
                }
                b = Convert.ToDouble(txtB.Text);
            }
            else if (txtB.Text == "")
            {
                showMessage("Vui lòng nhập b!");
                btnChia.Checked = false;
                txtB.Focus();
            }
            if (txtA.Text != "" && txtB.Text != "" && txtB.Text != "0")
            {
                txtRes.Text = Convert.ToString(a / b);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            if (txtA.Text != "")
            {
                a = Convert.ToDouble(txtA.Text);
            }
            else if (txtA.Text == "")
            {
                showMessage("Vui lòng nhập a!");
                btnNhan.Checked = false;
                txtA.Focus();
                return;
            }
            if (txtB.Text != "")
            {
                b = Convert.ToDouble(txtB.Text);
            }
            else if (txtB.Text == "")
            {
                showMessage("Vui lòng nhập b!");
                btnNhan.Checked = false;
                txtB.Focus();
            }
            if (txtA.Text != "" && txtB.Text != "")
            {
                txtRes.Text = Convert.ToString(a * b);
            }
        }

        private void btnMin_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMin.Checked)
            {
                double a = 0, b = 0;
                if (txtA.Text != "")
                {
                    a = Convert.ToDouble(txtA.Text);
                }
                else if (txtA.Text == "")
                {
                    showMessage("Vui lòng nhập a!");
                    btnMin.Checked = false;
                    txtA.Focus();
                    return;
                }
                if (txtB.Text != "")
                {
                    b = Convert.ToDouble(txtB.Text);
                }
                else if (txtB.Text == "")
                {
                    showMessage("Vui lòng nhập b!");
                    btnMin.Checked = false;
                    txtB.Focus();
                }
                if (txtA.Text != "" && txtB.Text != "")
                {
                    btnMin.Text += Convert.ToString(a < b ? a : b);
                }
            }
            else
            {
                btnMin.Text = "Min = ";
            }
        }
    }
}
