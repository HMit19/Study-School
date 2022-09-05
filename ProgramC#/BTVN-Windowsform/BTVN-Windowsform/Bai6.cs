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
    public partial class Bai6 : Form
    {
        string res = "Bạn đã chọn các phần tử: ";
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            list.ColumnWidth = list.Width / 4;
            for (int i = 0; i < 100; i++)
            {
                list.Items.Add("Items " + i.ToString());
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach(string item in list.SelectedItems)
            {
                res += item + ", ";
            }
            res = res.Remove(res.Length - 2, 2);     // xoa tu vi tri leng - 2, va xoa 2 ky tu
            if(MessageBox.Show(res, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
