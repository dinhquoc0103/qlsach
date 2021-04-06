using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSach.Class
{
    

    class DatabaseConnection
    {
        public static SqlConnection connect;      // Tạo đối tượng Sqlconnection

        // Hàm connect đến database
        public static void connectDatabase()
        {
            // Tạo connect với chuỗi string connect truyền vào
            connect = new SqlConnection(@"Data Source=SM96\SORIMACHI2012;Initial Catalog=QLSach;Integrated Security=True");
            // Mở connect 
            connect.Open();
        }

        // Hàm disconnect và giải phóng tài nguyên máy
        public static void disconnectDatabase()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();            // Đóng kết nối
                connect.Dispose();          // Giải phóng tài nguyên
            }
        }
    }
}
