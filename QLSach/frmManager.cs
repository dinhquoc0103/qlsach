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
        users user;
        public frmManager(users user)
        {
            InitializeComponent();

            // Gọi custom form dùng material skin
            Functions.customMaterialForm(this);

            // Tạo đối tượng bus book
            busBook = new BUSbook();

            // Gán đối tượng user
            this.user = user;


        }


        private void frmManager_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = this.user.FullName;
            cbx_filter_category.SelectedItem = "~~ Chọn Thể Loại ~~";
            cbx_filter_publishingBy.SelectedItem = "~~ Chọn Nhà Xuất Bản ~~";

            // Load list Nhà xuất bản vào combobox
            var listPublishingBy = busBook.getListPublishingBy();
            foreach (string publishingBy in listPublishingBy)
            {
                cbx_filter_publishingBy.Items.Add(publishingBy);
            }


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
            Dictionary<string, string> paramsFilter = new Dictionary<string, string>();
            paramsFilter.Add("filterSearch", txt_search.Text.Trim().Replace("'", "''"));
            paramsFilter.Add("filterCategory", cbx_filter_category.Text.Trim());
            paramsFilter.Add("filterPublishingBy", cbx_filter_publishingBy.Text.Trim());

            string keywordSearch = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(keywordSearch))
            {
                MessageBox.Show("Bạn chưa nhập từ khóa để tìm kiếm", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgv_listBooks.DataSource = busBook.getListBooksByFilter(paramsFilter);
            }
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            cbx_filter_category.SelectedItem = "~~ Chọn Thể Loại ~~";
            cbx_filter_publishingBy.SelectedItem = "~~ Chọn Nhà Xuất Bản ~~";
            dgv_listBooks.DataSource = busBook.getListBooks();
        }

        private void lbl_hello_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.Black;
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountInfo accountInfo = new frmAccountInfo(user);
            accountInfo.ShowDialog();
        }

     

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmLogin formLogin = new frmLogin();
            //formLogin.Show();
            this.Close();

        }

        private void tsmitem_changePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword changePass = new frmChangePassword(user);
            changePass.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> paramsFilter = new Dictionary<string, string>();
            paramsFilter.Add("filterSearch", txt_search.Text.Trim().Replace("'", "''"));
            paramsFilter.Add("filterCategory", cbx_filter_category.Text.Trim());
            paramsFilter.Add("filterPublishingBy", cbx_filter_publishingBy.Text.Trim());


            var listBooks = busBook.getListBooksByFilter(paramsFilter);
            dgv_listBooks.DataSource = listBooks;
        }

        private void cbx_filter_publishingBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> paramsFilter = new Dictionary<string, string>();
            paramsFilter.Add("filterSearch", txt_search.Text.Trim().Replace("'", "''"));
            paramsFilter.Add("filterCategory", cbx_filter_category.Text.Trim());
            paramsFilter.Add("filterPublishingBy", cbx_filter_publishingBy.Text.Trim());


            var listBooks = busBook.getListBooksByFilter(paramsFilter);
            dgv_listBooks.DataSource = listBooks;
        }
    }
}
