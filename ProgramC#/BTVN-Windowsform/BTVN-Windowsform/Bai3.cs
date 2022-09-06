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
    public partial class Bai3 : Form
    {
        List<int> list;
        Boolean kt = false;
        public Bai3()
        {
            InitializeComponent();
            list = new List<int>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            lbSum.Text = "Tổng dãy số là:  " + sum.ToString();
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSize.Text, "[^0-9]"))
            {
                showMessage("Vui lòng nhập số!");
                txtSize.Text = txtSize.Text.Remove(txtSize.Text.Length - 1);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            btnSort.Enabled = true;
            list.Clear();
            if (txtSize.Text == "")
            {
                MessageBox.Show("Vui lòng nhập n!");
                txtSize.Focus();
                return;
            }
            int n = Convert.ToInt32(txtSize.Text);
            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                list.Add(rd.Next(1, 100));
            }
            string res = "Dãy số:  ";
            foreach (int i in list)
            {
                res += (Convert.ToString(i) + "   ");
            }
            lbArray.Text = res;
            kt = true;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (!kt)
            {
                showMessage("Vui lòng nhập n!");
                txtSize.Focus();
            }
            else
            {
                list.Sort();
                string res = "Dãy số:  ";
                foreach (int i in list)
                {
                    res += (Convert.ToString(i) + "   ");
                }
                lbArraySort.Text = "Dãy số sắp xếp giảm dần là:  " + res.ToString();
            }
        }

        private void lbArraySort_Click(object sender, EventArgs e)
        {

        }

        private void lbSum_Click(object sender, EventArgs e)
        {

        }

        private void btnAgaint_Click(object sender, EventArgs e)
        {
            btnSort.Enabled = false;
            lbArray.Text = "Dãy số: ";
            lbArraySort.Text = "Dãy số sắp xếp giảm dần là: ";
            lbSum.Text = "Tổng dãy số là: ";
            txtSize.Text = "";
            txtSize.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muộn thoát ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
