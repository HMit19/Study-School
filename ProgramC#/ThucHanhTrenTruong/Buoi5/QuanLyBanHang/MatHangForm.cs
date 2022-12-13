using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class MatHangForm : Form
    {
        public MatHangForm(string Username)
        {
            InitializeComponent();
            lbInfo.Text = "Xin chào: " + Username;
        }
    }
}
