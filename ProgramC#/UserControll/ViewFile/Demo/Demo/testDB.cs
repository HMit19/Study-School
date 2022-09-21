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

namespace Demo
{
    public partial class testDB : Form
    {
        public testDB()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            // tạo kết nối với cơ sở dữ liệu
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2QJQJ3G\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True");
            // mở kết nối
            conn.Open();
            // tạo đối tượng command
            SqlCommand cmd = new SqlCommand("select * from users", conn);
            // tạo đối tượng dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // tạo đối tượng dataset
            DataSet ds = new DataSet();
            // đổ dữ liệu vào dataset
            da.Fill(ds);
            // đổ dữ liệu vào datagridview
            dataGridView1.DataSource = ds.Tables[0];
            // đóng kết nối
            conn.Close();
        }
    }
}
