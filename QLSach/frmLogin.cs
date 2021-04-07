using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSach.Class;
using BUS;
using Model;
using System.ComponentModel.DataAnnotations;

namespace QLSach
{
    public partial class frmLogin : MaterialForm
    {
        BUSusers busUsers;
        public frmLogin()
        {
            InitializeComponent();

            // Gọi custom form dùng material skin
            Functions.customMaterialForm(this);

            busUsers = new BUSusers();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "ĐĂNG NHẬP";
        }

        //private void btn_login_Click(object sender, EventArgs e)
        //{
        //    this.Hide();    // ẩn form đăng nhập
        //    frmManager manager = new frmManager();
        //    manager.FormClosed += new FormClosedEventHandler(manager_FormClosed);
        //    manager.Show();
        //}

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            // Reset text error 
            lbl_error_email.Text = "";
            lbl_error_password.Text = "";

            // Tạo đối tượng lấy giá trị từ textbox lưu vào các thuộc tính
            users user = new users();
            user.Email = txt_email.Text.Trim();
            user.Password = txt_password.Text.Trim();

            // Bắt đầu validate
            ValidationContext context = new ValidationContext(user);
            var validationResult = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(user, context, validationResult, true);

            // Nếu có lỗi
            if(valid == false)
            {
                // Vòng lặp in lỗi lên lbl
                foreach (ValidationResult r in validationResult)
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
                // Check đăng nhập 
                if(busUsers.checkLogin(user) == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user = busUsers.getInfoUser(txt_email.Text.Trim(), txt_password.Text.Trim());

                    this.Hide();
                    frmManager manager = new frmManager(user);
                    manager.FormClosed += new FormClosedEventHandler(manager_FormClosed);
                    manager.Show();
                }
                else
                {
                    MessageBox.Show("Email hoặc Password không đúng", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
