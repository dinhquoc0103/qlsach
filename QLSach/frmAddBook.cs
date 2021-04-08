using MaterialSkin.Controls;
using QLSach.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BUS;

namespace QLSach
{
    public partial class frmAddBook : MaterialForm
    {
        private string bookCode;        // Mã sách
        BUSbook busBook;

        string[] arrLabelNameError = {
            "lbl_error_bookName" , "lbl_error_price" , "lbl_error_category", "lbl_error_author", "lbl_error_publishingBy"
        };

        public frmAddBook(string bookCode)
        {
            InitializeComponent();

            Functions.customMaterialForm(this);

            this.bookCode = bookCode;

            busBook = new BUSbook();
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
                
                // Chỉnh sửa thì in giá trị đã có lên form
                DataRow infoBook = busBook.getInfoBook(this.bookCode);
                txt_bookName.Text = infoBook[1].ToString();
                txt_price.Text = infoBook[2].ToString();
                cbx_category.SelectedItem = infoBook[3].ToString();
                txt_author.Text = infoBook[4].ToString();
                txt_publishingBy.Text = infoBook[5].ToString();

            }
        }

       

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bookName.Clear();
            txt_price.Clear();
            cbx_category.Text = "";
            txt_author.Clear();
            txt_publishingBy.Clear();
  
            foreach (string n in arrLabelNameError)
            {
                this.Controls.Find(n, true)[0].Text = "";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            // reset label error trước khi validate 
            foreach(string n in arrLabelNameError)
            {
                this.Controls.Find(n, true)[0].Text = "";
            }

            // Tạo đối tượng book
            book b = new book();
            b.BookCode = Functions.randomString(8); // Mã sách sẽ được tạo ngẫu nhiên bằng chuỗi với độ dài 8
            b.BookName = txt_bookName.Text.Replace("'", "''");
            b.Price = 0;
            if (!string.IsNullOrEmpty(txt_price.Text))
            {
                try
                {
                    b.Price = Math.Abs(Convert.ToInt32(txt_price.Text));
                }
                catch
                {
                    lbl_error_price.Text = "Giá sách phải là số nguyên dương";
                }
               
            }
            b.Category = cbx_category.Text.Replace("'", "''");
            b.Author = txt_author.Text.Replace("'", "''");
            b.PublishingBy = txt_publishingBy.Text.Replace("'", "''");

          

            // Để kiểm tra các dữ liệu phù hợp thiết lập bởi Attribute bên Model không, thì dùng lớp ValidationContext
            ValidationContext context = new ValidationContext(b);

            // results - lưu danh sách ValidationResult, kết quả kiểm tra
            var result = new List<ValidationResult>();

            // thực hiện kiểm tra dữ liệu
            bool valid = Validator.TryValidateObject(b, context, result, true);
            if (valid == false)
            {
                foreach (ValidationResult r in result)
                {   
                    // Tạo controlName bằng string
                    string controlName = "lbl_error_" + r.MemberNames.First();
                    // Tìm control thông qua key string và gán messError và thay đổi màu cho label error
                    this.Controls.Find(controlName, true)[0].Text = r.ErrorMessage;
                    this.Controls.Find(controlName, true)[0].ForeColor = Color.Red;
                }          
            }
            else
            {
                // Không tồn tại mã sách thì là thêm mới
                if (string.IsNullOrEmpty(this.bookCode))
                {
                    if(busBook.addBook(b) == true)
                    {
                        MessageBox.Show("Thêm mới sách thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới sách thất bại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    b.BookCode = this.bookCode;
                    if (busBook.updateBook(b) == true)
                    {
                        MessageBox.Show("Cập nhật sách thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sách thất bại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            
        }

      

        private void lbl_error_price_Click(object sender, EventArgs e)
        {

        }

     
    }
}
