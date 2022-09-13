namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dlgOpen.FileName = "C:\\Users\\maiva\\OneDrive\\Hình ảnh";
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif) |*.gif|Allfiles(*.*) | *.* ";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(dlgOpen.FileName);
            }
        }
    }
}