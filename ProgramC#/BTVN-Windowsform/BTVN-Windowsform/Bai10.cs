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
            if (rd1.Checked)
            {
                res = rd1.Text;
                lbResult.Text = "Bạn hãy chọn thành phố cho " + rd1.Text;
            }
            else
            {
                res = "";
            }
        }
        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2.Checked)
            {
                res = rd2.Text;
                lbResult.Text = "Bạn hãy chọn thành phố cho " + rd2.Text;
            }
            else
            {
                res = "";
            }
        }

        private void tp2_CheckedChanged(object sender, EventArgs e)
        {
            if (res == rd2.Text)
            {
                MessageBox.Show("Chúc mừng bạn, thủ đô của Japan là " + tp2.Text);
                lbResult.Text = "";
            }
            else if (res == "") { }
            else
            {
                MessageBox.Show("Bạn sai rồi, thủ đô của " + res + " không phải là " + tp2.Text);
                lbResult.Text = "";
            }
            EmptyOption();
        }

        private void tp8_CheckedChanged(object sender, EventArgs e)
        {

            if (res == rd1.Text)
            {
                MessageBox.Show("Chúc mừng bạn, thủ đô của France là " + tp8.Text);
                lbResult.Text = "";
            }
            else if (res == "") { }
            else
            {
                MessageBox.Show("Bạn sai rồi, thủ đô của " + res + " không phải là " + tp8.Text);
                lbResult.Text = "";
            }
            EmptyOption();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            if (rd3.Checked)
            {
                res = rd3.Text;
                lbResult.Text = "Bạn hãy chọn thành phố cho " + rd3.Text;
            }
            else
            {
                res = "";
            }
        }

        private void tp7_CheckedChanged(object sender, EventArgs e)
        {
            if (res == rd3.Text)
            {
                MessageBox.Show("Chúc mừng bạn, thủ đô của " + rd3.Text + " là " + tp7.Text);
                lbResult.Text = "";
            }
            else if (res == "") { }
            else
            {
                MessageBox.Show("Bạn sai rồi, thủ đô của " + res + " không phải là " + tp7.Text);
                lbResult.Text = "";
            }
            EmptyOption();
        }

        private void rd4_CheckedChanged(object sender, EventArgs e)
        {
            if (rd4.Checked)
            {
                res = rd4.Text;
                lbResult.Text = "Bạn hãy chọn thành phố cho " + rd4.Text;
            }
            else
            {
                res = "";
            }
        }

        private void tp4_CheckedChanged(object sender, EventArgs e)
        {
            if (res == rd4.Text)
            {
                MessageBox.Show("Chúc mừng bạn, thủ đô của " + rd4.Text + " là " + tp4.Text);
                lbResult.Text = "";
            }
            else if (res == "") { }
            else
            {
                MessageBox.Show("Bạn sai rồi, thủ đô của " + res + " không phải là " + tp4.Text);
                lbResult.Text = "";
            }
            EmptyOption();
        }
    }
}
