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
    public partial class Bai10 : Form
    {
        string res = "";
        public Bai10()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton2.Checked = true;
        }
        public void EmptyOption()
        {
            rd1.Checked = false;
            rd2.Checked = false;
            rd3.Checked = false;
            rd4.Checked = false;
            rd5.Checked = false;
            rd6.Checked = false;
            rd7.Checked = false;
            rd8.Checked = false;
            tp1.Checked = false;
            tp2.Checked = false;
            tp3.Checked = false;
            tp4.Checked = false;
            tp5.Checked = false;
            tp6.Checked = false;
            tp7.Checked = false;
            tp8.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            res = rd1.Text;
            selectedCountry(rd1.Checked);
        }
        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            res = rd2.Text;
            selectedCountry(rd2.Checked);
        }

        private void tp2_CheckedChanged(object sender, EventArgs e)
        {
            selectedCapital(res == rd2.Text, tp2.Text);
        }

        private void tp8_CheckedChanged(object sender, EventArgs e)
        {

            selectedCapital(res == rd1.Text, tp8.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void selectedCountry(bool check)
        {
            if (check)
                lbResult.Text = "Bạn hãy chọn thành phố cho " + res;
            else
                res = "";
        }

        public void selectedCapital(bool check, string capital)
        {
            if (check)
            {
                MessageBox.Show("Chúc mừng bạn, thủ đô của " + res + " là " + capital);
                lbResult.Text = "";
            }
            else if (res == "") { }
            else
            {
                MessageBox.Show("Bạn sai rồi, thủ đô của " + res + " không phải là " + capital);
                lbResult.Text = "";
            }
            EmptyOption();
        }
        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            res = rd3.Text;
            selectedCountry(rd3.Checked);
        }

        private void tp7_CheckedChanged(object sender, EventArgs e)
        {
            selectedCapital(res == rd3.Text, tp7.Text);
        }

        private void rd4_CheckedChanged(object sender, EventArgs e)
        {
            res = rd4.Text;
            selectedCountry(rd4.Checked);
        }

        private void tp4_CheckedChanged(object sender, EventArgs e)
        {
            selectedCapital(res == rd4.Text, tp4.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
