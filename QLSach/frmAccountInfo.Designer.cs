namespace QLSach
{
    partial class frmAccountInfo
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
            this.lbl_userCode = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_joinDate = new System.Windows.Forms.Label();
            this.lbl_value_userCode = new System.Windows.Forms.Label();
            this.lbl_value_fullname = new System.Windows.Forms.Label();
            this.lbl_value_email = new System.Windows.Forms.Label();
            this.lbl_value_status = new System.Windows.Forms.Label();
            this.lbl_value_joinDate = new System.Windows.Forms.Label();
            this.btn_close = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_userCode
            // 
            this.lbl_userCode.AutoSize = true;
            this.lbl_userCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userCode.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userCode.Location = new System.Drawing.Point(34, 93);
            this.lbl_userCode.Name = "lbl_userCode";
            this.lbl_userCode.Size = new System.Drawing.Size(124, 24);
            this.lbl_userCode.TabIndex = 0;
            this.lbl_userCode.Text = "Mã tài khoản:";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fullname.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(34, 139);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(112, 24);
            this.lbl_fullname.TabIndex = 1;
            this.lbl_fullname.Text = "Tên đầy đủ: ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(34, 188);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(63, 24);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(34, 233);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(186, 24);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Trạng thái tài khoản: ";
            // 
            // lbl_joinDate
            // 
            this.lbl_joinDate.AutoSize = true;
            this.lbl_joinDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_joinDate.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_joinDate.Location = new System.Drawing.Point(34, 279);
            this.lbl_joinDate.Name = "lbl_joinDate";
            this.lbl_joinDate.Size = new System.Drawing.Size(143, 24);
            this.lbl_joinDate.TabIndex = 4;
            this.lbl_joinDate.Text = "Ngày tham gia: ";
            // 
            // lbl_value_userCode
            // 
            this.lbl_value_userCode.AutoSize = true;
            this.lbl_value_userCode.BackColor = System.Drawing.Color.White;
            this.lbl_value_userCode.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value_userCode.Location = new System.Drawing.Point(171, 98);
            this.lbl_value_userCode.Name = "lbl_value_userCode";
            this.lbl_value_userCode.Size = new System.Drawing.Size(49, 18);
            this.lbl_value_userCode.TabIndex = 5;
            this.lbl_value_userCode.Text = "label1";
            this.lbl_value_userCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_value_fullname
            // 
            this.lbl_value_fullname.AutoSize = true;
            this.lbl_value_fullname.BackColor = System.Drawing.Color.White;
            this.lbl_value_fullname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value_fullname.Location = new System.Drawing.Point(152, 144);
            this.lbl_value_fullname.Name = "lbl_value_fullname";
            this.lbl_value_fullname.Size = new System.Drawing.Size(49, 18);
            this.lbl_value_fullname.TabIndex = 6;
            this.lbl_value_fullname.Text = "label2";
            // 
            // lbl_value_email
            // 
            this.lbl_value_email.AutoSize = true;
            this.lbl_value_email.BackColor = System.Drawing.Color.White;
            this.lbl_value_email.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value_email.Location = new System.Drawing.Point(109, 192);
            this.lbl_value_email.Name = "lbl_value_email";
            this.lbl_value_email.Size = new System.Drawing.Size(49, 18);
            this.lbl_value_email.TabIndex = 7;
            this.lbl_value_email.Text = "label3";
            // 
            // lbl_value_status
            // 
            this.lbl_value_status.AutoSize = true;
            this.lbl_value_status.BackColor = System.Drawing.Color.White;
            this.lbl_value_status.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value_status.Location = new System.Drawing.Point(225, 238);
            this.lbl_value_status.Name = "lbl_value_status";
            this.lbl_value_status.Size = new System.Drawing.Size(49, 18);
            this.lbl_value_status.TabIndex = 8;
            this.lbl_value_status.Text = "label4";
            this.lbl_value_status.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_value_joinDate
            // 
            this.lbl_value_joinDate.AutoSize = true;
            this.lbl_value_joinDate.BackColor = System.Drawing.Color.White;
            this.lbl_value_joinDate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value_joinDate.Location = new System.Drawing.Point(183, 284);
            this.lbl_value_joinDate.Name = "lbl_value_joinDate";
            this.lbl_value_joinDate.Size = new System.Drawing.Size(49, 18);
            this.lbl_value_joinDate.TabIndex = 9;
            this.lbl_value_joinDate.Text = "label5";
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Depth = 0;
            this.btn_close.Icon = null;
            this.btn_close.Location = new System.Drawing.Point(38, 330);
            this.btn_close.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_close.Name = "btn_close";
            this.btn_close.Primary = true;
            this.btn_close.Size = new System.Drawing.Size(59, 36);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 394);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_value_joinDate);
            this.Controls.Add(this.lbl_value_status);
            this.Controls.Add(this.lbl_value_email);
            this.Controls.Add(this.lbl_value_fullname);
            this.Controls.Add(this.lbl_value_userCode);
            this.Controls.Add(this.lbl_joinDate);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.lbl_userCode);
            this.Name = "frmAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN TÀI KHOẢN";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userCode;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_joinDate;
        private System.Windows.Forms.Label lbl_value_userCode;
        private System.Windows.Forms.Label lbl_value_fullname;
        private System.Windows.Forms.Label lbl_value_email;
        private System.Windows.Forms.Label lbl_value_status;
        private System.Windows.Forms.Label lbl_value_joinDate;
        private MaterialSkin.Controls.MaterialRaisedButton btn_close;
    }
}