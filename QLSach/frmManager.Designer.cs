﻿namespace QLSach
{
    partial class frmManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.tctrl_manager = new MaterialSkin.Controls.MaterialTabControl();
            this.tp_book = new System.Windows.Forms.TabPage();
            this.btn_search = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.txt_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_manipulation = new System.Windows.Forms.Label();
            this.btn_cancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_edit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgv_listBooks = new System.Windows.Forms.DataGridView();
            this.tp_category = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_infoAccount = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tctrl_manager.SuspendLayout();
            this.tp_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listBooks)).BeginInit();
            this.tp_category.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrl_manager
            // 
            this.tctrl_manager.Controls.Add(this.tp_book);
            this.tctrl_manager.Controls.Add(this.tp_category);
            this.tctrl_manager.Controls.Add(this.tb_infoAccount);
            this.tctrl_manager.Depth = 0;
            this.tctrl_manager.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrl_manager.ImageList = this.imageList1;
            this.tctrl_manager.Location = new System.Drawing.Point(0, 63);
            this.tctrl_manager.MouseState = MaterialSkin.MouseState.HOVER;
            this.tctrl_manager.Name = "tctrl_manager";
            this.tctrl_manager.SelectedIndex = 0;
            this.tctrl_manager.Size = new System.Drawing.Size(956, 578);
            this.tctrl_manager.TabIndex = 0;
            // 
            // tp_book
            // 
            this.tp_book.BackColor = System.Drawing.Color.White;
            this.tp_book.Controls.Add(this.btn_search);
            this.tp_book.Controls.Add(this.lbl_filter);
            this.tp_book.Controls.Add(this.txt_search);
            this.tp_book.Controls.Add(this.lbl_manipulation);
            this.tp_book.Controls.Add(this.btn_cancel);
            this.tp_book.Controls.Add(this.btn_edit);
            this.tp_book.Controls.Add(this.btn_delete);
            this.tp_book.Controls.Add(this.btn_add);
            this.tp_book.Controls.Add(this.dgv_listBooks);
            this.tp_book.ImageKey = "icons8-books-emoji-24.png";
            this.tp_book.Location = new System.Drawing.Point(4, 32);
            this.tp_book.Name = "tp_book";
            this.tp_book.Padding = new System.Windows.Forms.Padding(3);
            this.tp_book.Size = new System.Drawing.Size(948, 542);
            this.tp_book.TabIndex = 0;
            this.tp_book.Text = "Sách";
            this.tp_book.Click += new System.EventHandler(this.tp_book_Click);
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Depth = 0;
            this.btn_search.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Icon = null;
            this.btn_search.Location = new System.Drawing.Point(437, 11);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.Primary = true;
            this.btn_search.Size = new System.Drawing.Size(81, 36);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter.Location = new System.Drawing.Point(29, 18);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(59, 29);
            this.lbl_filter.TabIndex = 8;
            this.lbl_filter.Text = "Lọc :";
            // 
            // txt_search
            // 
            this.txt_search.Depth = 0;
            this.txt_search.Hint = "Nhập tên sách để tìm kiếm";
            this.txt_search.Location = new System.Drawing.Point(111, 23);
            this.txt_search.MaxLength = 32767;
            this.txt_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.Size = new System.Drawing.Size(302, 23);
            this.txt_search.TabIndex = 7;
            this.txt_search.TabStop = false;
            this.txt_search.UseSystemPasswordChar = false;
            // 
            // lbl_manipulation
            // 
            this.lbl_manipulation.AutoSize = true;
            this.lbl_manipulation.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manipulation.Location = new System.Drawing.Point(29, 501);
            this.lbl_manipulation.Name = "lbl_manipulation";
            this.lbl_manipulation.Size = new System.Drawing.Size(110, 29);
            this.lbl_manipulation.TabIndex = 6;
            this.lbl_manipulation.Text = "Thao Tác :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(455, 496);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = true;
            this.btn_cancel.Size = new System.Drawing.Size(131, 36);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Đóng Ứng Dụng";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSize = true;
            this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Depth = 0;
            this.btn_edit.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Icon = null;
            this.btn_edit.Location = new System.Drawing.Point(365, 496);
            this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Primary = true;
            this.btn_edit.Size = new System.Drawing.Size(48, 36);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Depth = 0;
            this.btn_delete.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Icon = null;
            this.btn_delete.Location = new System.Drawing.Point(282, 496);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = true;
            this.btn_delete.Size = new System.Drawing.Size(48, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Depth = 0;
            this.btn_add.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(179, 496);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = true;
            this.btn_add.Size = new System.Drawing.Size(59, 36);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_listBooks
            // 
            this.dgv_listBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listBooks.Location = new System.Drawing.Point(25, 63);
            this.dgv_listBooks.Name = "dgv_listBooks";
            this.dgv_listBooks.RowTemplate.Height = 21;
            this.dgv_listBooks.Size = new System.Drawing.Size(896, 416);
            this.dgv_listBooks.TabIndex = 1;
            // 
            // tp_category
            // 
            this.tp_category.BackColor = System.Drawing.Color.White;
            this.tp_category.Controls.Add(this.materialLabel1);
            this.tp_category.ImageKey = "icons8-category-24.png";
            this.tp_category.Location = new System.Drawing.Point(4, 32);
            this.tp_category.Name = "tp_category";
            this.tp_category.Padding = new System.Windows.Forms.Padding(3);
            this.tp_category.Size = new System.Drawing.Size(948, 542);
            this.tp_category.TabIndex = 1;
            this.tp_category.Text = "Thể Loại";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(400, 168);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 18);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ahhahaaha";
            // 
            // tb_infoAccount
            // 
            this.tb_infoAccount.BackColor = System.Drawing.Color.White;
            this.tb_infoAccount.ImageKey = "icons8-information-24.png";
            this.tb_infoAccount.Location = new System.Drawing.Point(4, 32);
            this.tb_infoAccount.Name = "tb_infoAccount";
            this.tb_infoAccount.Size = new System.Drawing.Size(948, 542);
            this.tb_infoAccount.TabIndex = 2;
            this.tb_infoAccount.Text = "Thông Tin Tài Khoản";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-books-emoji-24.png");
            this.imageList1.Images.SetKeyName(1, "icons8-category-24.png");
            this.imageList1.Images.SetKeyName(2, "icons8-information-24.png");
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tctrl_manager;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 21);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(878, 45);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 633);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tctrl_manager);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.tctrl_manager.ResumeLayout(false);
            this.tp_book.ResumeLayout(false);
            this.tp_book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listBooks)).EndInit();
            this.tp_category.ResumeLayout(false);
            this.tp_category.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tctrl_manager;
        private System.Windows.Forms.TabPage tp_book;
        private System.Windows.Forms.TabPage tp_category;
        private System.Windows.Forms.TabPage tb_infoAccount;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgv_listBooks;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cancel;
        private MaterialSkin.Controls.MaterialRaisedButton btn_edit;
        private MaterialSkin.Controls.MaterialRaisedButton btn_delete;
        private MaterialSkin.Controls.MaterialRaisedButton btn_add;
        private System.Windows.Forms.Label lbl_manipulation;
        private System.Windows.Forms.Label lbl_filter;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search;
        private MaterialSkin.Controls.MaterialRaisedButton btn_search;
    }
}