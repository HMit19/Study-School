using System.Text.RegularExpressions;

namespace Tuan2
{
    public partial class Form1 : Form
    {
        Dictionary<int, int> map;
        public Form1()
        {
            InitializeComponent();
            map = new Dictionary<int, int>();
            map.Add(0, 2);
            map.Add(1, 3);
            map.Add(2, 3);
            map.Add(3, 2);
            map.Add(4, 3);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void cbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choose = cbBox.SelectedIndex;
            txtSoTin.Text = map.ElementAt(choose).Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string nameSub = cbBox.Text; ;
            string number = txtSoTin.Text; ;
            string diem = "";
            if (txtDiem.Text == diem)
            {
                MessageBox.Show("Vui lòng nhập điểm!");
            }
            else
            {
                foreach(string item in lBox.Items)
                {
                    if ((item.Split("-")[0]).Equals(nameSub))
                    {
                        MessageBox.Show("Môn học đã có trong danh sách!");
                        txtDiem.Text = "";
                        return;
                    }
                }
                diem = txtDiem.Text;
                lBox.Items.Add(nameSub + "-" + number + "-" + diem);
                txtDiem.Text = "";
            }
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtDiem.Text, "[^0-9]"))
            {
                MessageBox.Show("Điểm phải là một số");
                txtDiem.Text = txtDiem.Text.Remove(txtDiem.Text.Length - 1);
                return;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (lBox.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm môn học vào danh sách!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double sum = 0;
            int count = 0;
            foreach(string item in lBox.Items)
            {
                int st = Convert.ToInt32(item.Split("-")[1]);
                int diem = Convert.ToInt32(item.Split("-")[2]);
                count += st;
                sum += (st * diem);
            }
            sumTin.Text = count.ToString();
            sumDiem.Text = sum.ToString();
            avg.Text = Math.Round((double)(sum / count), 2).ToString();
        }
    }
}