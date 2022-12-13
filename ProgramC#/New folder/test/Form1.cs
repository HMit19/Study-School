using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySet.Add("1");
        }
        private void test(object sender, EventArgs e)
        {
        }

        HashSet<string> mySet = new HashSet<string>();
        int a = 0;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2NumericUpDown1.Text = "1";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            a = 0;
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("thay doi");
        }
    }
}
