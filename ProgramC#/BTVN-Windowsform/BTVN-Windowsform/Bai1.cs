using System;
using System.Text.RegularExpressions;
namespace BTVN_Windowsform
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? month = null;
            int? year = null;
            if (txtMonth.Text == "")
            {
                txtMonth.Focus();
                showMessage("Vui lòng nhập tháng!");
            }
            else if (txtYear.Text == "")
            {
                txtYear.Focus();
                showMessage("Vui lòng nhập năm!");
            }
            else
            {
                int mon = Convert.ToInt32(txtMonth.Text);
                int yea = Convert.ToInt32(txtYear.Text);
                int day = DateTime.DaysInMonth(yea, mon);
                lbResult.Text = "Tháng " + mon + " Năm " + yea + " có " + day + " Ngày";
                btnAgaint.Focus();
            }
        }
        public void showMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgaint_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            txtMonth.Focus();
            txtMonth.Text = "";
            txtYear.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtMonth.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtMonth.Text = txtMonth.Text.Remove(txtMonth.Text.Length - 1);
            }
            if (Regex.IsMatch(txtMonth.Text, "[0-9]{3}"))
            {
                MessageBox.Show("Vui lòng nhập tháng 1 - 12!");
                txtMonth.Text = "";
            }
            string month = txtMonth.Text;
            if (month.Length == 2)
            {
                if (month[0] == '0' && month[1] <= '0')
                {
                    MessageBox.Show("Vui lòng nhập tháng 1 - 12!");
                    txtMonth.Text = "";
                }
                else if (month[0] == '1' && month[1] > '2')
                {
                    MessageBox.Show("Vui lòng nhập tháng 1 - 12!");
                    txtMonth.Text = "";
                }
                else if (month[0] > '1')
                {
                    MessageBox.Show("Vui lòng nhập tháng 1 - 12!");
                    txtMonth.Text = "";
                }
                else
                {
                    txtYear.Focus();
                }
            }
        }

        private void txtMonth_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue.ToString());
            // lay ma ascii cua ky tu nhap vap txt
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtYear.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtYear.Text = txtYear.Text.Remove(txtYear.Text.Length - 1);
            }
            if (txtYear.Text.Length == 4)
            {
                btnResult.Focus();
            }
            if (Regex.IsMatch(txtYear.Text, "[0-9]{5}"))
            {
                MessageBox.Show("Vui lòng nhập năm có 4 chữ số!");
                txtYear.Text = "";
            }
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
