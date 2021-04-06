using System;
using System.Collections.Generic;
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
    }
}
