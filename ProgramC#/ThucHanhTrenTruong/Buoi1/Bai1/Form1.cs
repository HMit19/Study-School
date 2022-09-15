namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool checkValid()
        {
            if (!double.TryParse(textBox1.Text, out double a))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkValid() == false)
            {
                MessageBox.Show("Đầu vào chưa hợp lệ");
            }
            else
            {
                double a = double.Parse(textBox1.Text);
                double perimeter = Math.Round((2 * Math.PI * a), 2);
                double area = Math.Round((Math.PI * a * a), 2);
                textBox2.Text = perimeter.ToString();
                textBox3.Text = area.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}