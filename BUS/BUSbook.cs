using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data.SqlClient;

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
    }
}
