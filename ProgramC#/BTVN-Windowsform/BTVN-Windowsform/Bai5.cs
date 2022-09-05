namespace BTVN_Windowsform
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muộn thoát ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLanguage.Text == "")
            {
                MessageBox.Show("Tên ngôn ngữ không được để trống!");
                txtLanguage.Focus();
                return;
            }
            else
            {
                string language = txtLanguage.Text;
                for (int i = 0; i < list.Items.Count; i++)
                {
                    if ((list.Items[i].ToString()).Equals(language))
                    {
                        MessageBox.Show("Ngôn ngữ đã tồn tại!");
                        txtLanguage.Text = "";
                        return;
                    }
                }
                list.Items.Add(language);
                MessageBox.Show("Add Sucessfull!");
                txtLanguage.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 1)
            {
                for (int i = 0; i < list.SelectedItems.Count; i++)
                {
                    list.Items.Remove(list.SelectedItems[i]);
                }
            }
            if (list.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!");
                return;
            }
            else
            {
                list.Items.Remove(list.Text);
                MessageBox.Show("Delete Sucessfull!");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtLanguage.Text == "")
            {
                MessageBox.Show("Tên ngôn ngữ không được để trống!");
                txtLanguage.Focus();
                return;
            }
            else
            {
                string language = txtLanguage.Text;
                for (int i = 0; i < list.Items.Count; i++)
                {
                    if (list.Items[i].ToString() == (language))
                    {
                        MessageBox.Show("Ngôn ngữ đã tồn tại!");
                        txtLanguage.Text = "";
                        return;
                    }
                }
                txtLanguage.Text = "";
                MessageBox.Show("Không tồn tại " + language);
            }
        }
    }
}
