using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class BUSbook
    {
        DALbook dalBook;
        DatabaseProvider db;

        public BUSbook()
        {
            dalBook = new DALbook();
            db = new DatabaseProvider();
        }

        // Nhận danh sách book trả về khi yêu cầu lớp DAL xử lí
        public List<book> getListBooks()
        {
            List<book> list =  dalBook.listBooks();
            db.closeConnect();    // Đóng kết nối
            return list;
        }

        /// <summary>
        /// đóng kết nối khi nhấn button thoát app
        /// </summary>
        public void closeApp()
        {
            db.closeConnect();
        }

        /// <summary>
        /// Yêu cầu DAL thêm row book vào table book. Nếu thành công trả về true và ngược lại là false
        /// </summary>
        /// <param name="b">một đối tượng book</param>
        /// <returns>True nếu thêm thành công và false nếu ngược lại</returns>
        public bool addBook(book b)
        {
            bool result = dalBook.insertRowBook(b);
            db.closeConnect();
            return result;
        }

        /// <summary>
        /// lấy thông tin 1 quyển sách và trả về datarow
        /// </summary>
        /// <param name="bookCode">mã sách</param>
        /// <returns>datarow tức là row book</returns>
        public DataRow getInfoBook(string bookCode)
        {
            DataRow info = dalBook.singleSelectRowBook(bookCode);
            return info;
        }

        /// <summary>
        /// Yêu cầu DAL cập nhật row book vào table book. Nếu thành công trả về true và ngược lại là false
        /// </summary>
        /// <param name="b">đối tượng book</param>
        /// <returns>true nếu cập nhật thành công và false nếu fail</returns>
        public bool updateBook(book b)
        {
            bool result = dalBook.updateRowBook(b);
            return result;
        }


        public bool deleteBook(string bookCode)
        {
            bool result = dalBook.deleteRowBook(bookCode);
            return result;
        }

        // lấy danh sách book theo kiểu dữ liệu trả về là dataTable
        public DataTable getListBooksDT()
        {
            DataTable dt = dalBook.listBooksDT();
            return dt;
        }

        public List<book> getListBookSearch(string keywordSearch)
        {
            List<book> list = dalBook.listBookSearch(keywordSearch);
            db.closeConnect();
            return list;
        }
    }
}
