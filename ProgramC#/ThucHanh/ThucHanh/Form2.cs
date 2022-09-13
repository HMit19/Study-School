using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dlgOpen.InitialDirectory = "C:\\Users\\maiva\\OneDrive";
            dlgOpen.Title = "Chọn ảnh để hiển thị";
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif) |*.gif|All files(*.*) | *.* ";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                img.Image = Image.FromFile(dlgOpen.FileName);
            else
                MessageBox.Show("You clicked Cancel", "Open Dialog",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
