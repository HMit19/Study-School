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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            string[] folder;
            folder = System.IO.Directory.GetDirectories("D:\\");
            cbFolder.DataSource = folder;
        }

        private void cbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
