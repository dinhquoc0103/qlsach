namespace QLSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_edit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitem_changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_showAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_search = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_filter_category = new System.Windows.Forms.Label();
            this.txt_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgv_listBooks = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.cbx_filter_category = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_filter_publishingBy = new System.Windows.Forms.ComboBox();
            this.lbl_filter_publishingBy = new System.Windows.Forms.Label();
            this.tctrl_manager.SuspendLayout();
            this.tp_book.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listBooks)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrl_manager
            // 
            this.tctrl_manager.Controls.Add(this.tp_book);
            this.tctrl_manager.Depth = 0;
            this.tctrl_manager.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrl_manager.ImageList = this.imageList1;
            this.tctrl_manager.Location = new System.Drawing.Point(0, 63);
            this.tctrl_manager.MouseState = MaterialSkin.MouseState.HOVER;
            this.tctrl_manager.Name = "tctrl_manager";
            this.tctrl_manager.SelectedIndex = 0;
            this.tctrl_manager.Size = new System.Drawing.Size(956, 533);
            this.tctrl_manager.TabIndex = 0;
            // 
            // tp_book
            // 
            this.tp_book.BackColor = System.Drawing.Color.White;
            this.tp_book.Controls.Add(this.groupBox2);
            this.tp_book.Controls.Add(this.groupBox1);
            this.tp_book.Controls.Add(this.lbl_hello);
            this.tp_book.Controls.Add(this.menuStrip1);
            this.tp_book.Controls.Add(this.btn_showAll);
            this.tp_book.Controls.Add(this.btn_search);
            this.tp_book.Controls.Add(this.txt_search);
            this.tp_book.Controls.Add(this.dgv_listBooks);
            this.tp_book.ImageKey = "icons8-books-emoji-24.png";
            this.tp_book.Location = new System.Drawing.Point(4, 32);
            this.tp_book.Name = "tp_book";
            this.tp_book.Padding = new System.Windows.Forms.Padding(3);
            this.tp_book.Size = new System.Drawing.Size(948, 497);
            this.tp_book.TabIndex = 0;
            this.tp_book.Text = "Sách";
            this.tp_book.Click += new System.EventHandler(this.tp_book_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Location = new System.Drawing.Point(736, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 187);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Depth = 0;
            this.btn_add.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(26, 47);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = true;
            this.btn_add.Size = new System.Drawing.Size(59, 36);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Depth = 0;
            this.btn_delete.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Icon = null;
            this.btn_delete.Location = new System.Drawing.Point(122, 47);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = true;
            this.btn_delete.Size = new System.Drawing.Size(48, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSize = true;
            this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Depth = 0;
            this.btn_edit.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Icon = null;
            this.btn_edit.Location = new System.Drawing.Point(122, 112);
            this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Primary = true;
            this.btn_edit.Size = new System.Drawing.Size(48, 36);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(27, 112);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = true;
            this.btn_cancel.Size = new System.Drawing.Size(59, 36);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Đóng";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hello.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello.ForeColor = System.Drawing.Color.Black;
            this.lbl_hello.Location = new System.Drawing.Point(731, 24);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(89, 25);
            this.lbl_hello.TabIndex = 0;
            this.lbl_hello.Text = "Xin chào:";
            this.lbl_hello.Click += new System.EventHandler(this.lbl_hello_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(804, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.tsmitem_changePassword,
            this.đăngXuấtToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 23);
            this.toolStripMenuItem1.Text = "FullName";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // tsmitem_changePassword
            // 
            this.tsmitem_changePassword.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmitem_changePassword.Name = "tsmitem_changePassword";
            this.tsmitem_changePassword.Size = new System.Drawing.Size(211, 24);
            this.tsmitem_changePassword.Text = "Đổi Mật Khẩu";
            this.tsmitem_changePassword.Click += new System.EventHandler(this.tsmitem_changePassword_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // btn_showAll
            // 
            this.btn_showAll.AutoSize = true;
            this.btn_showAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_showAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showAll.Depth = 0;
            this.btn_showAll.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAll.Icon = null;
            this.btn_showAll.Location = new System.Drawing.Point(595, 17);
            this.btn_showAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Primary = true;
            this.btn_showAll.Size = new System.Drawing.Size(128, 36);
            this.btn_showAll.TabIndex = 10;
            this.btn_showAll.Text = "Hiển Thị Tất Cả";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Depth = 0;
            this.btn_search.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Icon = null;
            this.btn_search.Location = new System.Drawing.Point(496, 17);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.Primary = true;
            this.btn_search.Size = new System.Drawing.Size(81, 36);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_filter_category
            // 
            this.lbl_filter_category.AutoSize = true;
            this.lbl_filter_category.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter_category.Location = new System.Drawing.Point(13, 41);
            this.lbl_filter_category.Name = "lbl_filter_category";
            this.lbl_filter_category.Size = new System.Drawing.Size(73, 23);
            this.lbl_filter_category.TabIndex = 8;
            this.lbl_filter_category.Text = "Thể Loại";
            // 
            // txt_search
            // 
            this.txt_search.Depth = 0;
            this.txt_search.Hint = "Nhập tên sách để tìm kiếm";
            this.txt_search.Location = new System.Drawing.Point(21, 29);
            this.txt_search.MaxLength = 32767;
            this.txt_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.Size = new System.Drawing.Size(448, 23);
            this.txt_search.TabIndex = 7;
            this.txt_search.TabStop = false;
            this.txt_search.UseSystemPasswordChar = false;
            // 
            // dgv_listBooks
            // 
            this.dgv_listBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listBooks.Location = new System.Drawing.Point(21, 69);
            this.dgv_listBooks.Name = "dgv_listBooks";
            this.dgv_listBooks.RowTemplate.Height = 21;
            this.dgv_listBooks.Size = new System.Drawing.Size(702, 416);
            this.dgv_listBooks.TabIndex = 1;
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
            this.materialTabSelector1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.materialTabSelector1.BaseTabControl = this.tctrl_manager;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 29);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(964, 38);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // cbx_filter_category
            // 
            this.cbx_filter_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_filter_category.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_filter_category.FormattingEnabled = true;
            this.cbx_filter_category.Items.AddRange(new object[] {
            "~~ Chọn Thể Loại ~~",
            "Bóng Đá",
            "Văn Học",
            "Kinh Tế",
            "Kinh Dị",
            "Hoạt Hình"});
            this.cbx_filter_category.Location = new System.Drawing.Point(16, 70);
            this.cbx_filter_category.Name = "cbx_filter_category";
            this.cbx_filter_category.Size = new System.Drawing.Size(167, 27);
            this.cbx_filter_category.TabIndex = 6;
            this.cbx_filter_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_filter_publishingBy);
            this.groupBox2.Controls.Add(this.lbl_filter_publishingBy);
            this.groupBox2.Controls.Add(this.cbx_filter_category);
            this.groupBox2.Controls.Add(this.lbl_filter_category);
            this.groupBox2.Location = new System.Drawing.Point(736, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 213);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc Theo";
            // 
            // cbx_filter_publishingBy
            // 
            this.cbx_filter_publishingBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_filter_publishingBy.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_filter_publishingBy.FormattingEnabled = true;
            this.cbx_filter_publishingBy.Items.AddRange(new object[] {
            "~~ Chọn Nhà Xuất Bản ~~"});
            this.cbx_filter_publishingBy.Location = new System.Drawing.Point(18, 149);
            this.cbx_filter_publishingBy.Name = "cbx_filter_publishingBy";
            this.cbx_filter_publishingBy.Size = new System.Drawing.Size(167, 27);
            this.cbx_filter_publishingBy.TabIndex = 9;
            this.cbx_filter_publishingBy.SelectedIndexChanged += new System.EventHandler(this.cbx_filter_publishingBy_SelectedIndexChanged);
            // 
            // lbl_filter_publishingBy
            // 
            this.lbl_filter_publishingBy.AutoSize = true;
            this.lbl_filter_publishingBy.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter_publishingBy.Location = new System.Drawing.Point(15, 120);
            this.lbl_filter_publishingBy.Name = "lbl_filter_publishingBy";
            this.lbl_filter_publishingBy.Size = new System.Drawing.Size(110, 23);
            this.lbl_filter_publishingBy.TabIndex = 10;
            this.lbl_filter_publishingBy.Text = "Nhà Xuất Bản";
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 596);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tctrl_manager);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.tctrl_manager.ResumeLayout(false);
            this.tp_book.ResumeLayout(false);
            this.tp_book.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listBooks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tctrl_manager;
        private System.Windows.Forms.TabPage tp_book;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.DataGridView dgv_listBooks;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cancel;
        private MaterialSkin.Controls.MaterialRaisedButton btn_edit;
        private MaterialSkin.Controls.MaterialRaisedButton btn_delete;
        private MaterialSkin.Controls.MaterialRaisedButton btn_add;
        private System.Windows.Forms.Label lbl_filter_category;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search;
        private MaterialSkin.Controls.MaterialRaisedButton btn_search;
        private MaterialSkin.Controls.MaterialRaisedButton btn_showAll;
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmitem_changePassword;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_filter_category;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_filter_publishingBy;
        private System.Windows.Forms.Label lbl_filter_publishingBy;
    }
}