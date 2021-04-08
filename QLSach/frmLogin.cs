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


        private void btn_login_Click_1(object sender, EventArgs e)
        {
            // Reset text error 
            lbl_error_email.Text = "";
            lbl_error_password.Text = "";

            // Tạo đối tượng lấy giá trị từ textbox lưu vào các thuộc tính
            users user = new users();
            user.Email = txt_email.Text.Trim().Replace("'", "''");
            user.Password = txt_password.Text.Trim().Replace("'", "''"); 

            bool checkEmptyEmail = string.IsNullOrEmpty(txt_email.Text.Trim());
            bool checkEmptyPass = string.IsNullOrEmpty(txt_password.Text.Trim());

            if (checkEmptyEmail == true)
            {
                lbl_error_email.Text = "Chưa nhập email";
                lbl_error_email.ForeColor = Color.Red;
            }
            if (checkEmptyPass == true)
            {
                lbl_error_password.Text = "Chưa nhập mật khẩu";
                lbl_error_password.ForeColor = Color.Red;
            }

            if(!checkEmptyEmail && !checkEmptyPass){
                if (busUsers.checkLogin(user) == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user = busUsers.getInfoUser(txt_email.Text.Trim(), txt_password.Text.Trim());

                    this.Hide();
                    frmManager manager = new frmManager(user);
                    manager.FormClosed += new FormClosedEventHandler(manager_FormClosed);   // khi form quản lí close hoặc đăng xuất thì sẽ quay về form login
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
            //this.Close();
              this.Show();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
