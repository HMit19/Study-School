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
    public partial class Bai11 : Form
    {
        private List<string> listSelected;
        public Bai11()
        {
            InitializeComponent();
            listSelected = new List<string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Bai11_Load(object sender, EventArgs e)
        {
            cbPhone.Checked = true;
            cbFax.Checked = true;
            for (int i = 0; i < 20; i++)
            {
                listBook.Items.Add("Item " + i.ToString());
            }
        }

        private void listBook_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                foreach (string item in listSelected)
                {
                    if (listBook.SelectedItem == item)
                    {
                        MessageBox.Show("Bạn đã chọn mua cuốn " + listBook.SelectedItem.ToString() + " rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                listBuy.Items.Add(listBook.SelectedItem);
                listSelected.Add(listBook.SelectedItem.ToString());
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xoá " + listBook.SelectedItem.ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    listSelected.Remove(listBook.SelectedItem.ToString());
                    listBuy.Items.Remove(listBook.SelectedItem);
                }
                else
                {
                    e.NewValue = CheckState.Checked;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Không được để trống tên!");
                txtName.Focus();
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Không được để trống số điện thoại!");
                txtPhone.Focus();
                return;
            }
            if (!Regex.IsMatch(txtPhone.Text, "[0, 9]{10}"))
            {
                MessageBox.Show("Số điện thoại gồm 10 chữ số!");
                txtPhone.Focus();
                return;
            }
            if (!cbPhone.Checked && !cbFax.Checked && !cbEmail.Checked)
            {
                MessageBox.Show("Vui lòng chọn hình thức liên lạc!");
                return;
            }
            string res = "Họ tên khách hàng: " + txtName.Text
                + "\nĐiện thoại: " + txtPhone.Text
                + "\nDanh sách đặt mua: ";
            foreach (string item in listBuy.Items)
            {
                res += "\n - " + item;
            }
            string check = "Họ tên khách hàng: " + txtName.Text
                + "\nĐiện thoại: " + txtPhone.Text
                + "\nDanh sách đặt mua: ";
            if (res == check)
            {
                MessageBox.Show("Bạn chưa chọn mua cuốn nào!");
                return;
            }
            MessageBox.Show(res, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Số điện thoại không tồn tại chữ cái!");
                txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1, 1);
            }

        }

        private void listBuy_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá " + listBook.SelectedItem.ToString() + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                listSelected.Remove(listBook.SelectedItem.ToString());
                listBuy.Items.Remove(listBook.SelectedItem);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
