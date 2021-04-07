namespace QLSach
{
    partial class frmChangePassword
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
            this.lbl_oldPassword = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.txt_oldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_newPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_changePassword = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_error_oldPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_error_newPassword = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbl_oldPassword
            // 
            this.lbl_oldPassword.AutoSize = true;
            this.lbl_oldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_oldPassword.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oldPassword.Location = new System.Drawing.Point(28, 94);
            this.lbl_oldPassword.Name = "lbl_oldPassword";
            this.lbl_oldPassword.Size = new System.Drawing.Size(101, 23);
            this.lbl_oldPassword.TabIndex = 0;
            this.lbl_oldPassword.Text = "Mật khẩu cũ";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_newPassword.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPassword.Location = new System.Drawing.Point(28, 178);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(111, 23);
            this.lbl_newPassword.TabIndex = 1;
            this.lbl_newPassword.Text = "Mật khẩu mới";
            // 
            // txt_oldPassword
            // 
            this.txt_oldPassword.Depth = 0;
            this.txt_oldPassword.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oldPassword.Hint = "";
            this.txt_oldPassword.Location = new System.Drawing.Point(34, 124);
            this.txt_oldPassword.MaxLength = 32767;
            this.txt_oldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_oldPassword.Name = "txt_oldPassword";
            this.txt_oldPassword.PasswordChar = '\0';
            this.txt_oldPassword.SelectedText = "";
            this.txt_oldPassword.SelectionLength = 0;
            this.txt_oldPassword.SelectionStart = 0;
            this.txt_oldPassword.Size = new System.Drawing.Size(259, 23);
            this.txt_oldPassword.TabIndex = 2;
            this.txt_oldPassword.TabStop = false;
            this.txt_oldPassword.UseSystemPasswordChar = false;
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Depth = 0;
            this.txt_newPassword.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPassword.Hint = "";
            this.txt_newPassword.Location = new System.Drawing.Point(34, 208);
            this.txt_newPassword.MaxLength = 32767;
            this.txt_newPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.PasswordChar = '\0';
            this.txt_newPassword.SelectedText = "";
            this.txt_newPassword.SelectionLength = 0;
            this.txt_newPassword.SelectionStart = 0;
            this.txt_newPassword.Size = new System.Drawing.Size(259, 23);
            this.txt_newPassword.TabIndex = 3;
            this.txt_newPassword.TabStop = false;
            this.txt_newPassword.UseSystemPasswordChar = false;
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.AutoSize = true;
            this.btn_changePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_changePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changePassword.Depth = 0;
            this.btn_changePassword.Icon = null;
            this.btn_changePassword.Location = new System.Drawing.Point(103, 273);
            this.btn_changePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Primary = true;
            this.btn_changePassword.Size = new System.Drawing.Size(116, 36);
            this.btn_changePassword.TabIndex = 4;
            this.btn_changePassword.Text = "ĐỔI MẬT KHẨU";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // lbl_error_oldPassword
            // 
            this.lbl_error_oldPassword.AutoSize = true;
            this.lbl_error_oldPassword.Depth = 0;
            this.lbl_error_oldPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_oldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_oldPassword.Location = new System.Drawing.Point(37, 153);
            this.lbl_error_oldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_oldPassword.Name = "lbl_error_oldPassword";
            this.lbl_error_oldPassword.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_oldPassword.TabIndex = 5;
            // 
            // lbl_error_newPassword
            // 
            this.lbl_error_newPassword.AutoSize = true;
            this.lbl_error_newPassword.Depth = 0;
            this.lbl_error_newPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_newPassword.Location = new System.Drawing.Point(37, 237);
            this.lbl_error_newPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_newPassword.Name = "lbl_error_newPassword";
            this.lbl_error_newPassword.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_newPassword.TabIndex = 6;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 328);
            this.Controls.Add(this.lbl_error_newPassword);
            this.Controls.Add(this.lbl_error_oldPassword);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.txt_newPassword);
            this.Controls.Add(this.txt_oldPassword);
            this.Controls.Add(this.lbl_newPassword);
            this.Controls.Add(this.lbl_oldPassword);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THAY ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_oldPassword;
        private System.Windows.Forms.Label lbl_newPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_oldPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_newPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btn_changePassword;
        private MaterialSkin.Controls.MaterialLabel lbl_error_oldPassword;
        private MaterialSkin.Controls.MaterialLabel lbl_error_newPassword;
    }
}