using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            setColor();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            setColor();
            lbRed.Text = Convert.ToString(hScrollBar1.Value);
        }
        private void setColor()
        {
            int red = hScrollBar1.Value;
            int green = hScrollBar2.Value;
            int blue = hScrollBar3.Value;
            pnMain.BackColor = Color.FromArgb(red, green, blue);
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            setColor();
            lbGreen.Text = Convert.ToString(hScrollBar2.Value);
            
        }

        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            setColor();
            lbBlue.Text = Convert.ToString(hScrollBar3.Value);
            
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
