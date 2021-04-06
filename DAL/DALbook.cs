using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class DALbook : DatabaseProvider
    {
        // DatabaseProvider db = null;   // Tạo đối tượng db để sử dụng các hàm của DatabaseProvider.cs

        /// <summary>
        /// Lấy danh sách book
        /// </summary>
        /// <returns>trả về một list danh sách book (list đối tượng book)</returns>
        public List<book> listBooks()
        {
            SqlDataReader dr = null;
            List<book> listBooks = new List<book>();

            try
            {
                dr = this.selectDataTable("book");
                while (dr.Read())
                {
                    book b = new book();

                    // Lấy giá trị từng cột từ SqlDataReader và chuyển thành kiểu dữ liệu tương ứng
                    b.BookCode = dr.GetString(0);
                    b.BookName = dr.GetString(1);
                    b.Price = dr.GetInt32(2);
                    b.Category = dr.GetString(3);
                    b.Author = dr.GetString(4);
                    b.PublishingBy = dr.GetString(5);

                    // Thêm đối tượng book vào danh sách book
                    listBooks.Add(b);

                    
                }
            }
            catch (Exception error)
            {
                throw error;
            }

            return listBooks;   // Trả về list books
        }

        /// <summary>
        /// Thêm row book vào csdl
        /// </summary>
        /// <param name="b">tham số truyền vào là đối tượng book</param>
        /// <returns>true nếu thành công hoặc false nếu fail</returns>
        public bool insertRowBook(book b)
        {
            bool flag = true;
            try
            {
                string sql = "INSERT INTO book VALUES('" + b.BookCode + "', N'" + b.BookName + "', '" + b.Price + "', N'" + b.Category + "', N'" + b.Author + "', N'" + b.PublishingBy + "')";
                this.ExeCuteNonQuery(sql);
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// select 1 dòng từ bảng book
        /// </summary>
        /// <param name="bookCode">mã sách</param>
        /// <returns>một dataRow đối tượng book</returns>
        public DataRow singleSelectRowBook(string bookCode)
        {
            DataTable table = new DataTable();
            table.Load(this.selectDataTable("book", " WHERE bookCode = '" + bookCode + "'"));

            return table.Rows[0];
        }

        /// <summary>
        /// Update một row của book
        /// </summary>
        /// <param name="b">đối tượng book</param>
        /// <returns>true or false</returns>
        public bool updateRowBook(book b)
        {
            bool flag = true;
            try
            {
                string sql = "UPDATE book SET BookName = N'" + b.BookName + "', Price = '" + b.Price + "', Category = N'" + b.Category + "', Author = N'" + b.Author + "', PublishingBy = N'" + b.PublishingBy + "' WHERE BookCode = '" + b.BookCode + "'";
                this.ExeCuteNonQuery(sql);
            }
            catch
            {
                flag = false;
            }
            return flag;
        }


        public bool deleteRowBook(string bookCode)
        {
            bool flag = true;
            try
            {
                string sql = "DELETE FROM book WHERE BookCode = '" + bookCode + "'";
                this.ExeCuteNonQuery(sql);
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public DataTable listBooksDT()
        {
            DataTable dt = new DataTable();
            try
            {
                dr = this.selectDataTable("book");
                dt.Load(dr);
            }
            catch (Exception error)
            {
                throw error;
            }

            return dt;
        }

        public List<book> listBookSearch(string keywordSearch)
        {
            SqlDataReader dr = null;
            List<book> listBooks = new List<book>();

            try
            {
                dr = this.selectDataTable("book", " WHERE BookName LIKE N'%" + keywordSearch + "%'");
                while (dr.Read())
                {
                    book b = new book();

                    // Lấy giá trị từng cột từ SqlDataReader và chuyển thành kiểu dữ liệu tương ứng
                    b.BookCode = dr.GetString(0);
                    b.BookName = dr.GetString(1);
                    b.Price = dr.GetInt32(2);
                    b.Category = dr.GetString(3);
                    b.Author = dr.GetString(4);
                    b.PublishingBy = dr.GetString(5);

                    // Thêm đối tượng book vào danh sách book
                    listBooks.Add(b);


                }
            }
            catch (Exception error)
            {
                throw error;
            }

            return listBooks;   // Trả về list books
        }
    }
}
