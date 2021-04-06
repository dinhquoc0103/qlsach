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

namespace QLSach
{
    public partial class frmAddBook : MaterialForm
    {
        private string bookCode;        // Mã sách

        public frmAddBook(string bookCode)
        {
            InitializeComponent();

            Functions.customMaterialForm(this);

            this.bookCode = bookCode;
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            // thêm và chỉnh sửa dùng chung form nên phải phân biệt thông qua Mã Sách. Nếu khi chuyển form truyền
            // Mã sách qua mà nếu không null thì là chỉnh sửa và ngược lại null là thêm mới
            if(string.IsNullOrEmpty(this.bookCode))
            {
                this.Text = "THÊM MỚI SÁCH";
            }
            else
            {
                this.Text = "CHỈNH SỬA SÁCH";
                txt_bookCode.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bookCode.Clear();
            txt_bookName.Clear();
            txt_price.Clear();
            cbx_category.SelectedItem = "~ Chọn Thể Loại ~";
            txt_author.Clear();
            txt_publishingBy.Clear();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }
    }
}
