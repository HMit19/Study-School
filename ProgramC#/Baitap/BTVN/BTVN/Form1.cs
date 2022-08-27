namespace BTVN
{
    public partial class Form1 : Form
    {
        private List<SachNew> listSach;
        public Form1()
        {
            InitializeComponent();
            listSach = new List<SachNew>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            int quan = 0;
            if (txtID.Text == "")
            {
                txtID.Focus();
            }
            string name = txtName.Text;
            if (txtName.Text == "")
            {
                txtName.Focus();
            }
            string author = txtAuthor.Text;
            if (txtAuthor.Text == "")
            {
                txtAuthor.Focus();
            }
            string quantity = txtQuantity.Text;
            if (txtQuantity.Text == "")
            {
                txtQuantity.Focus();
            }
            else
            {
                quan = int.Parse(quantity);

            }
            string qrCode = txtQR.Text;
            if (txtQR.Text == "")
            {
                txtQR.Focus();
            }
            if (id != "" && name != "" && author != "" && quan != 0 && qrCode != "")
            {
                SachNew sach = new SachNew(id, name, author, quan, qrCode);
                txtID.Text = "";
                txtName.Text = "";
                txtAuthor.Text = "";
                txtQuantity.Text = "";
                txtQR.Text = "";
                listSach.Add(sach);
                lbRES.Text = "Add successull!";
            }
        }
    }
}