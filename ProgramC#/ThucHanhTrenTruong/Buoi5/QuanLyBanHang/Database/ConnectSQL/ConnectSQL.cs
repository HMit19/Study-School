using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Database.ConnectSQL
{
    internal class ConnectSQL
    {
        public static SqlConnection getConnection()
        {
            string connectString = "Data Source=HIEU-MAI\\SQLEXPRESS;Initial Catalog=banhang;Integrated Security=True";

            SqlConnection connect = new SqlConnection(connectString);

            return connect;
        }
    }
}
