namespace QLSach
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_close = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_error_email = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_error_password = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(23, 193);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(102, 29);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Mật Khẩu";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(23, 88);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(64, 29);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Hint = "Nhập tên email ...";
            this.txt_email.Location = new System.Drawing.Point(28, 131);
            this.txt_email.MaxLength = 32767;
            this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.Size = new System.Drawing.Size(330, 23);
            this.txt_email.TabIndex = 3;
            this.txt_email.TabStop = false;
            this.txt_email.UseSystemPasswordChar = false;
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Hint = "Nhập mật khẩu ...";
            this.txt_password.Location = new System.Drawing.Point(27, 236);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(331, 23);
            this.txt_password.TabIndex = 4;
            this.txt_password.TabStop = false;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Depth = 0;
            this.btn_login.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(28, 300);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(99, 36);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Depth = 0;
            this.btn_close.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Icon = null;
            this.btn_close.Location = new System.Drawing.Point(292, 301);
            this.btn_close.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_close.Name = "btn_close";
            this.btn_close.Primary = true;
            this.btn_close.Size = new System.Drawing.Size(66, 36);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_error_email
            // 
            this.lbl_error_email.AutoSize = true;
            this.lbl_error_email.Depth = 0;
            this.lbl_error_email.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_email.Location = new System.Drawing.Point(28, 161);
            this.lbl_error_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_email.Name = "lbl_error_email";
            this.lbl_error_email.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_email.TabIndex = 7;
            // 
            // lbl_error_password
            // 
            this.lbl_error_password.AutoSize = true;
            this.lbl_error_password.Depth = 0;
            this.lbl_error_password.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_password.Location = new System.Drawing.Point(28, 266);
            this.lbl_error_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_password.Name = "lbl_error_password";
            this.lbl_error_password.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_password.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 363);
            this.Controls.Add(this.lbl_error_password);
            this.Controls.Add(this.lbl_error_email);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
        private MaterialSkin.Controls.MaterialRaisedButton btn_close;
        private MaterialSkin.Controls.MaterialLabel lbl_error_email;
        private MaterialSkin.Controls.MaterialLabel lbl_error_password;
    }
}