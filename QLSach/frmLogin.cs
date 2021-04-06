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

namespace QLSach
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();

            // Gọi custom form dùng material skin
            Functions.customMaterialForm(this);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "ĐĂNG NHẬP";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();    // ẩn form đăng nhập
            frmManager manager = new frmManager();
            manager.FormClosed += new FormClosedEventHandler(manager_FormClosed);
            manager.Show();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;


            this.Hide();
            frmManager manager = new frmManager();
            manager.FormClosed += new FormClosedEventHandler(manager_FormClosed);
            manager.Show();
            
        }
        private void manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

     
    }
}
