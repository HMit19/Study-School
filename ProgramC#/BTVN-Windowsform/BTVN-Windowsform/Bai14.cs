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
    public partial class Bai14 : Form
    {
        private bool check;
        public Bai14()
        {
            InitializeComponent();
        }

        private void Bai14_Load(object sender, EventArgs e)
        {
            check = true;
            TimeBox.Start();
        }

        private void TimeBox_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                lbMove.Left += 5;
                if (lbMove.Left >= this.Width - lbMove.Width)
                {
                    check = false;
                }
            }
            else
            {
                lbMove.Left -= 5;
                if (lbMove.Left <= 0)
                {
                    check = true;
                }
            }
        }
    }
}
