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
using MaterialSkin;
using MaterialSkin.Controls;
using Model;
using BUS;
using System.Text.RegularExpressions;

namespace QLSach
{
    public partial class frmChangePassword : MaterialForm
    {
        users user;
        BUSusers busUsers;
        public frmChangePassword(users user)
        {
            InitializeComponent();

            Functions.customMaterialForm(this);

            this.user = user;

            busUsers = new BUSusers();
        }

 

       
        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            lbl_error_oldPassword.Text = "";
            lbl_error_newPassword.Text = "";

            

            if (string.IsNullOrEmpty(txt_oldPassword.Text.Trim()))
            {
                lbl_error_oldPassword.Text = "Chưa nhập mật khẩu cũ";
            }
            else if(txt_oldPassword.Text.Trim() != user.Password)
            {
                lbl_error_oldPassword.Text = "Mật khẩu cũ không đúng";
            }
            lbl_error_oldPassword.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(txt_newPassword.Text.Trim()))
            {
                lbl_error_newPassword.Text = "Chưa nhập mật khẩu mới";

            }
            else
            {
                string pattern = @"^(?=.*\d)(?=.*[A-Za-z_])(?=.*\W).{8,16}$";    // Biểu thức chính quy cho mật khẩu
                                                                             // Tạo đối tượng regex và truyền vào biểu thức chính quy + option bỏ qua hoa thường
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                // Tạo đối match dùng regex.Match so khớp password với biểu thức chính quy
                Match match = regex.Match(txt_newPassword.Text.Trim());

                // Nếu match trả về success tức là so khớp
                if (!match.Success)
                {
                    //MessageBox.Show("Mật khẩu mới không thỏa mãn ( mật khẩu mới phải có độ dài 8 kí tự, bao gồm chữ hoa, thường, kí tự đặc biệc)", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_error_newPassword.Text = "Mật khẩu mới không thỏa mãn";
                }
            }
            lbl_error_newPassword.ForeColor = Color.Red;

            // Nếu không có lỗi
            if(string.IsNullOrEmpty(lbl_error_oldPassword.Text.Trim()) && string.IsNullOrEmpty(lbl_error_newPassword.Text.Trim()))
            {
                if(busUsers.changePassword(user, txt_newPassword.Text.Trim()) == true)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }

        }
    }
}
