using QuanLyBanHang.Database.ConnectSQL;
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

namespace QuanLyBanHang
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
                {
                    SqlConnection sql = ConnectSQL.getConnection();
                    sql.Open();
                    txtUsername.Text = sql != null ? "okee" : "fal";
                    //MessageBox.Show("Đăng nhập thành công!");
                    //this.Visible = false;
                    //MatHangForm frmMatHang = new MatHangForm(txtUsername.Text);
                    //frmMatHang.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắc muốn thoát", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
