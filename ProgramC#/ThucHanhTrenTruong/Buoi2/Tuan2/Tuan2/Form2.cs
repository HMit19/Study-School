using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2
{
    public partial class Form2 : Form
    {
        Dictionary<string, float> map;
        public Form2()
        {
            InitializeComponent();
            map = new Dictionary<string, float>();
            map.Add("Coca cola", 0.5f);
            map.Add("Pepsi", 0.8f);
            map.Add("Seven up", 1.0f);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbDouong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSoluong.Enabled = true;
            foreach (string i in map.Keys)
            {
                if (i.Equals(cbDouong.Text))
                {
                    txtGia.Text = map[i].ToString();
                }
            }
            if(cbSoluong.Text != "")
            {
                string doUong = cbDouong.Text;
                int soLuong = int.Parse(cbSoluong.Text);
                txtGia.Text = (map[doUong] * soLuong).ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtHoten.Text = "";
            txtGiaduythuyen.Text = "";
            rdCangay.Checked = false;
            rdNuangay.Checked = false;
            cbDouong.Text = "";
            cbSoluong.Text = "";
            txtHoten.Focus();
            txtGia.Text = "";
        }

        private void cbSoluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doUong = cbDouong.Text;
            if (cbSoluong.Text != "")
            {
                int soLuong = int.Parse(cbSoluong.Text);
                txtGia.Text = (map[doUong] * soLuong).ToString();
            }
        }

        private void cbDouong_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbDouong.Text == "")
            {
                cbSoluong.Enabled = false;
            }
        }

        private void rdCangay_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaduythuyen.Text = "200";
        }

        private void rdNuangay_CheckedChanged(object sender, EventArgs e)
        {
            txtGiaduythuyen.Text = "100";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = txtHoten.Text + "|";
            float gia = float.Parse(txtGia.Text);
            if (rdCangay.Checked)
            {
                item += rdCangay.Text;
                gia += 200;
            }
            else
            {
                gia += 100;
                item += rdNuangay.Text;
            }
            item += "|" + "Đồ uống " + txtGia.Text + "$|" + "Tổng " + gia.ToString();
            listBox1.Items.Add(item);
        }
    }
}
