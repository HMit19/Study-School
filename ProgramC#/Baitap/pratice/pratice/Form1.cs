using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace pratice
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int leng = Convert.ToInt32(txtSize.Text);
            Random rd = new Random();
            for (int i = 0; i < leng; i++)
            {
                int k = rd.Next(1, 10);
                list.Add(k);
            }
            String res = "Array:  ";
            foreach (int item in list)
            {
                sum += item;
                res += (item + " ");
            }
            lb1.Text = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }
            lb2.Text = ("Sum array: " + sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Sort();
            string res = "Sort array: ";
            foreach (int item in list)
            {
                res += (item + " ");
            }
            lb3.Text = res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}