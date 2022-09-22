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
            InitializeComponent();
            map = new Dictionary<string, float>();
            map.Add("Coca cola", 0.5f);
            map.Add("Pepsi", 0.8f);
            map.Add("Seven up", 1.0f);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtHoten.Text = "";
            txtGiaduythuyen.Text = "";
            txtGia.Text = "";
            cbDouong.Text = "";
            cbSoluong.Text = "";
            rdCangay.Checked = false;
            rdNuangay.Checked = false;
            //txtHoten.Focus();
        }

        private void cbDouong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //foreach (string index in map.Keys)
            //{
            //    listBox1.Items.Add("Tên đồ uống: " + index + " - Giá: " + map[index]);
            //    if (cbDouong.Text.Equals(index))
            //    {
            //        txtGia.Text = map[index].ToString();
            //    }
            //}
            //txtGia.Text = cbDouong.Text;
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            btnNew.Text = "bth";
        }
    }
}
