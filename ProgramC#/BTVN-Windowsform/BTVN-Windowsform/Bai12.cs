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
    public partial class Bai12 : Form
    {
        public Bai12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            float x;
            string str = "A= " + nudA.Value.ToString() + ", B=" + nubB.Value.ToString();
            a = Convert.ToInt16(nudA.Value);
            b = Convert.ToInt16(nubB.Value);
            if (a == 0)
            {
                if (b == 0)
                    str = str + ". Phương trình vô số nghiệm";
                else
                    str = str + ". Phương trình vô nghiệm";
            }
            else
            {
                x = (float)-b / a;
                str = str + ". Phương trình có một nghiệm là: x=" + x.ToString();
            }
            txtKetQua.Text = str;
        }
        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
