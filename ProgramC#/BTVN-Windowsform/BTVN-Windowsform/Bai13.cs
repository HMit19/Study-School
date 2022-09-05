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
    public partial class Bai13 : Form
    {
        public Bai13()
        {
            InitializeComponent();
            setBackgroundTextBox();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Bai13_Load(object sender, EventArgs e)
        {

        }
        public void setBackgroundTextBox()
        {
            int red = Convert.ToInt32(hScrollBar1.Value);
            int green = Convert.ToInt32(hScrollBar2.Value);
            int blue = Convert.ToInt32(hScrollBar3.Value);
            textBox1.BackColor = Color.FromArgb(red, green, blue);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            setBackgroundTextBox();
            lbRed.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            setBackgroundTextBox();
            lbGreen.Text = Convert.ToString(hScrollBar2.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            setBackgroundTextBox();
            lbBlue.Text = Convert.ToString(hScrollBar3.Value);
        }
    }
}
