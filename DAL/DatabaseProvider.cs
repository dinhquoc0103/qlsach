using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseProvider
    {
        /// <summary>
        /// Các thuộc tính
        /// </summary>
        private string strConnect = @"Data Source=SM96\SORIMACHI2012;Initial Catalog=QLSach;Integrated Security=True;MultipleActiveResultSets=True";
        public SqlConnection connect = null;    // Đối tượng dùng để connect đến database
        public SqlCommand cmd = null;           // Đối tượng dùng để thao tác với database
        public SqlDataReader dr = null;         // Đối tượng hứng dữ liệu và giúp đọc từng dòng dữ liệu trả về
        
        /// <summary>
        /// Constructer
        /// </summary>
        public DatabaseProvider()
        {
            connect = new SqlConnection(strConnect);    // Khởi tạo kết nối
        }

        /// <summary>
        /// Mở kết nối đến database
        /// </summary>
        public void openConnect()
        {
            // Thử 
            try
            {   // Nếu kết nối chưa mở thì mở kết nối
                if(connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
            }
            catch(Exception error)
            {   
                // Không thử kết nối được thì vào đây quăng ra lỗi và dừng chương trình
                throw error;
            }
        }

        /// <summary>
        /// Đóng kết nối database
        /// </summary>
        public void closeConnect()
        {
            // Thử 
            try
            {   // Nếu kết nối đã mở thì đóng nó đi
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            catch (Exception error)
            {
                // Không close được thì vào đây quăng ra lỗi và dừng chương trình
                throw error;
            }
        }

        /// <summary>
        /// Lấy giá trị từ bảng bất kì và trả về kiểu đối tượng SqlDataReader (Bus sẽ sử dụng này để lấy dữ liệu và trung gian qua GUI)
        /// </summary>
        /// <param name="table">tên table truyền vào</param>
        /// <returns>trả về đối tượng SqlDataReader chứa dữ liệu và giúp đọc dữ liệu từng dòng trả về</returns>
        public SqlDataReader selectDataTable(string table, string where = "")
        {
            try
            {
                string sql = "SELECT * FROM " + table + where;
                cmd = new SqlCommand(sql);  // Tạo đối tượng SqlCommand và truyền vào câu sql
                cmd.Connection = connect;   // Gán connect cho đối tượng SqlCommand
                this.openConnect();         // Mở kết nối
                dr = cmd.ExecuteReader();   // Thực hiện truy vấn và trả về một đối tượng SqlDataReader
            }
            catch(Exception error)
            {
                throw error;
            }
            return dr;
        }

        /// <summary>
        /// Truy vấn cho insert hoặc update
        /// </summary>
        /// <param name="sql"></param>
        public void ExeCuteNonQuery(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql);
                cmd.Connection = connect;
                this.openConnect();
                cmd.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                throw error;
            }
            finally
            {
                this.closeConnect();
            }
        }

        public SqlDataReader ExeCuteReader(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql);
                cmd.Connection = connect;
                this.openConnect();
                dr = cmd.ExecuteReader();
            }
            catch (Exception error)
            {
                throw error;
            }
            return dr;
        }

    }
}
