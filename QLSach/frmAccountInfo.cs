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


namespace QLSach
{
    public partial class frmAccountInfo : MaterialForm
    {
        users user;
        public frmAccountInfo(users user)
        {
            InitializeComponent();

            Functions.customMaterialForm(this);

            this.user = user;
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            lbl_value_userCode.Text = user.UserCode;
            lbl_value_fullname.Text = user.FullName;
            lbl_value_email.Text = user.Email;
            lbl_value_status.Text = "Hoạt động";
            lbl_value_joinDate.Text = user.JoinDate.ToString();
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
