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


        private void frmManager_Load(object sender, EventArgs e)
        {
            loadListBooks();
        }

        private void loadListBooks()
        {
            dgv_listBooks.DataSource = null;
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
            loadListBooks(); // load lại danh sách
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
            loadListBooks();    // load lại danh sách

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           
            string bookCode = dgv_listBooks.CurrentRow.Cells["bookCode"].Value.ToString();
            string bookName = dgv_listBooks.CurrentRow.Cells["bookName"].Value.ToString();

            // Thông báo messagebox trước hỏi có muốn xóa không
            var choose = MessageBox.Show("Bạn muốn xóa quyển " + bookName + "?", "XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(choose == DialogResult.Yes)
            {
                // Hàm xóa book trả về true có nghĩa là đã xóa thành công
                if (busBook.deleteBook(bookCode) == true)
                {
                    MessageBox.Show("Xóa thành công quyển " + bookName, "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadListBooks(); // load lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keywordSearch = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(keywordSearch))
            {
                MessageBox.Show("Bạn chưa nhập từ khóa để tìm kiếm", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(keywordSearch.Length < 2)
            {
                MessageBox.Show("Từ khóa tìm kiếm phải từ 2 kí tự trở lên", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgv_listBooks.DataSource = busBook.getListBookSearch(keywordSearch);
            }      
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            dgv_listBooks.DataSource = busBook.getListBooks();
        }
    }
}
