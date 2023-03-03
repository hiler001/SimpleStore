using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    class Connection
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-BPREQTBQ\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
    }
}
