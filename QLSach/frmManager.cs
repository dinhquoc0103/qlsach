using MaterialSkin;
using MaterialSkin.Controls;
using QLSach.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Model;

namespace QLSach
{
    public partial class frmManager : MaterialForm
    {
        BUSbook busBook;
        public frmManager()
        {
            InitializeComponent();

            // Gọi custom form dùng material skin
            Functions.customMaterialForm(this);

            // Tạo đối tượng bus book
            busBook = new BUSbook();


        }

        //private void LoadListBook()
        //{
        //    // Câu query
        //    string sql = "SELECT * FROM book";

        //    // Nhận về dữ liệu table theo truy vấn từ câu query thông qua hàm getDataToTable
        //    tableBook = Functions.getDataToTable(sql, DatabaseConnection.connect);

        //    // đổi tên cột sang tiếng việt
        //    string[] arrColName = { "Mã Sách", "Tên Sách" , "Giá" , "Thể Loại" , "Tác Giả" , "Nhà Xuất Bản" };
        //    for (int i = 0; i < arrColName.Length; i++)
        //    {
        //        tableBook.Columns[i].ColumnName = arrColName[i];
        //    }
        //    //tableBook.Columns[0].ColumnName = "Mã Sách";   
        //    //tableBook.Columns[1].ColumnName = "Tên Sách";    
        //    //tableBook.Columns[2].ColumnName = "Giá";    
        //    //tableBook.Columns[3].ColumnName = "Thể Loại";   
        //    //tableBook.Columns[4].ColumnName = "Tác Giả";    
        //    //tableBook.Columns[5].ColumnName = "Nhà Xuất Bản";    

        //    // Hiển thị dữ liệu lên dataGridView
        //    dvg_listBooks.DataSource = tableBook;
        //}

        private void frmManager_Load(object sender, EventArgs e)
        {
            // Load list book lên dataGridView
            var listBooks = busBook.getListBooks();
            dgv_listBooks.DataSource = listBooks;

            // Đổi tên các cột khi hiển thị ra dataGridView
            string[] arrColName = { "Mã Sách", "Tên Sách", "Giá", "Thể Loại", "Tác Giả", "Nhà Xuất Bản" };
            for (int i = 0; i < arrColName.Length; i++)
            {
                dgv_listBooks.Columns[i].HeaderText = arrColName[i];
            }
           

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string bookCode = "";
            frmAddBook addBook = new frmAddBook(bookCode);
            addBook.ShowDialog();

        }

        private void tp_book_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn muốn thoát ứng dụng?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                busBook.closeApp();    // đóng kết nối 
                Application.Exit();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string bookCode = dgv_listBooks.CurrentRow.Cells["bookCode"].Value.ToString(); // Lấy ra giá trị bookCode từ vị trí của dòng khi click vào một ô của dòng đó
            frmAddBook addBook = new frmAddBook(bookCode);
            addBook.ShowDialog();
        }
    }
}
