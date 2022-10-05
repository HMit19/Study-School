using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDatabase
{
    public partial class Form1 : Form
    {
        private object functions;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // tao ma hoa mat khau

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = txtUsername.Text;
            string mk = txtPassword.Text;
            // ma hoa mat khau 
            string password = GetMD5(mk);
            string username = GetMD5(tk);
            txtMk.Text = password;
            txtTK.Text = username;
            //txtTK.Text = functions.autoCode(username);
        }

        // phương thức mã hóa mật khẩu
        public static string GetMD5(string str)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bHash = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in bHash)
            {
                sbHash.Append(String.Format("{0:x2}", b));
            }
            return sbHash.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // phương thức giải mã mật khẩu

    }
}