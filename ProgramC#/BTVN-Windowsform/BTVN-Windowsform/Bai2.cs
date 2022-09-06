using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Windowsform
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("Không được để trống!");
                txta.Focus();
                return;
            }
            else if (txtb.Text == "")
            {
                MessageBox.Show("Không được để trống!");
                txtb.Focus();
                return;
            }
            if (txtb.Text != "" && txta.Text != "")
            {
                int res = 0;
                for (int i = Convert.ToInt32(txta.Text); i <= Convert.ToInt32(txtb.Text); i++)
                {
                    res += i;
                }
                lbResult.Text = "Tổng từ " + txta.Text + " đến " + txtb.Text + " là: " + res;
            }
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txta.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txta.Text = txta.Text.Remove(txta.Text.Length - 1);
            }
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtb.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtb.Text = txtb.Text.Remove(txtb.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            txta.Text = "";
            txtb.Text = "";
            txta.Focus();
        }
    }
}
