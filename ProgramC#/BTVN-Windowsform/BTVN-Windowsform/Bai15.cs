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
    public partial class Bai15 : Form
    {
        public Bai15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clock.Start();
        }

        public void run()
        {
            int second = Convert.ToInt32(txtSecond.Text);
            int minute = Convert.ToInt32(txtMinute.Text);
            second--;
            if (second == -1)
            {
                if (minute > 0)
                {
                    minute--;
                    second = 59;
                }
                else
                {
                    clock.Stop();
                    clock.Enabled = false;
                }
            }
            txtMinute.Text = minute.ToString();
            txtSecond.Text = second.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSecond.Text = "00";
            txtMinute.Text = "00";
            clock.Stop();
            clock.Enabled = false;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            run();
        }

        private void Bai15_Load(object sender, EventArgs e)
        {
            clock.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clock.Stop();
        }
    }
}
