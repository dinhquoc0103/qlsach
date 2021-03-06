namespace QLSach
{
    partial class frmAddBook
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
            this.lbl_bookName = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_publishingBy = new System.Windows.Forms.Label();
            this.txt_bookName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_price = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_author = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_publishingBy = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.btn_save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_clear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_error_bookName = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_error_price = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_error_category = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_error_author = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_error_publishingBy = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bookName.Location = new System.Drawing.Point(34, 95);
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(89, 25);
            this.lbl_bookName.TabIndex = 1;
            this.lbl_bookName.Text = "Tên Sách";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(34, 162);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(39, 25);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Giá";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(34, 222);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(83, 25);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "Thể Loại";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(34, 283);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(75, 25);
            this.lbl_author.TabIndex = 4;
            this.lbl_author.Text = "Tác Giả";
            // 
            // lbl_publishingBy
            // 
            this.lbl_publishingBy.AutoSize = true;
            this.lbl_publishingBy.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publishingBy.Location = new System.Drawing.Point(34, 343);
            this.lbl_publishingBy.Name = "lbl_publishingBy";
            this.lbl_publishingBy.Size = new System.Drawing.Size(125, 25);
            this.lbl_publishingBy.TabIndex = 5;
            this.lbl_publishingBy.Text = "Nhà Xuất Bản";
            // 
            // txt_bookName
            // 
            this.txt_bookName.Depth = 0;
            this.txt_bookName.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookName.Hint = "Nhập tên sách";
            this.txt_bookName.Location = new System.Drawing.Point(178, 99);
            this.txt_bookName.MaxLength = 32767;
            this.txt_bookName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.PasswordChar = '\0';
            this.txt_bookName.SelectedText = "";
            this.txt_bookName.SelectionLength = 0;
            this.txt_bookName.SelectionStart = 0;
            this.txt_bookName.Size = new System.Drawing.Size(268, 23);
            this.txt_bookName.TabIndex = 7;
            this.txt_bookName.TabStop = false;
            this.txt_bookName.UseSystemPasswordChar = false;
            // 
            // txt_price
            // 
            this.txt_price.Depth = 0;
            this.txt_price.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Hint = "Nhập giá";
            this.txt_price.Location = new System.Drawing.Point(178, 162);
            this.txt_price.MaxLength = 32767;
            this.txt_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.SelectedText = "";
            this.txt_price.SelectionLength = 0;
            this.txt_price.SelectionStart = 0;
            this.txt_price.Size = new System.Drawing.Size(268, 23);
            this.txt_price.TabIndex = 8;
            this.txt_price.TabStop = false;
            this.txt_price.UseSystemPasswordChar = false;
            // 
            // txt_author
            // 
            this.txt_author.Depth = 0;
            this.txt_author.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.Hint = "Nhập tác giả";
            this.txt_author.Location = new System.Drawing.Point(178, 285);
            this.txt_author.MaxLength = 32767;
            this.txt_author.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_author.Name = "txt_author";
            this.txt_author.PasswordChar = '\0';
            this.txt_author.SelectedText = "";
            this.txt_author.SelectionLength = 0;
            this.txt_author.SelectionStart = 0;
            this.txt_author.Size = new System.Drawing.Size(268, 23);
            this.txt_author.TabIndex = 10;
            this.txt_author.TabStop = false;
            this.txt_author.UseSystemPasswordChar = false;
            // 
            // txt_publishingBy
            // 
            this.txt_publishingBy.Depth = 0;
            this.txt_publishingBy.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_publishingBy.Hint = "Nhập nhà xuất bản";
            this.txt_publishingBy.Location = new System.Drawing.Point(178, 345);
            this.txt_publishingBy.MaxLength = 32767;
            this.txt_publishingBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_publishingBy.Name = "txt_publishingBy";
            this.txt_publishingBy.PasswordChar = '\0';
            this.txt_publishingBy.SelectedText = "";
            this.txt_publishingBy.SelectionLength = 0;
            this.txt_publishingBy.SelectionStart = 0;
            this.txt_publishingBy.Size = new System.Drawing.Size(268, 23);
            this.txt_publishingBy.TabIndex = 11;
            this.txt_publishingBy.TabStop = false;
            this.txt_publishingBy.UseSystemPasswordChar = false;
            // 
            // cbx_category
            // 
            this.cbx_category.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Items.AddRange(new object[] {
            "Bóng Đá",
            "Văn Học",
            "Kinh Tế",
            "Kinh Dị",
            "Hoạt Hình"});
            this.cbx_category.Location = new System.Drawing.Point(178, 221);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(268, 27);
            this.cbx_category.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Depth = 0;
            this.btn_save.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(76, 418);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = true;
            this.btn_save.Size = new System.Drawing.Size(47, 36);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "LƯU";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSize = true;
            this.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Depth = 0;
            this.btn_clear.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Icon = null;
            this.btn_clear.Location = new System.Drawing.Point(190, 418);
            this.btn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Primary = true;
            this.btn_clear.Size = new System.Drawing.Size(78, 36);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "LÀM MỚI";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(341, 418);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = true;
            this.btn_cancel.Size = new System.Drawing.Size(48, 36);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "HỦY";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_error_bookName
            // 
            this.lbl_error_bookName.AutoSize = true;
            this.lbl_error_bookName.Depth = 0;
            this.lbl_error_bookName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_bookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_bookName.Location = new System.Drawing.Point(181, 129);
            this.lbl_error_bookName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_bookName.Name = "lbl_error_bookName";
            this.lbl_error_bookName.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_bookName.TabIndex = 17;
            // 
            // lbl_error_price
            // 
            this.lbl_error_price.AutoSize = true;
            this.lbl_error_price.Depth = 0;
            this.lbl_error_price.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_price.Location = new System.Drawing.Point(180, 192);
            this.lbl_error_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_price.Name = "lbl_error_price";
            this.lbl_error_price.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_price.TabIndex = 18;
            this.lbl_error_price.Click += new System.EventHandler(this.lbl_error_price_Click);
            // 
            // lbl_error_category
            // 
            this.lbl_error_category.AutoSize = true;
            this.lbl_error_category.Depth = 0;
            this.lbl_error_category.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_category.Location = new System.Drawing.Point(179, 256);
            this.lbl_error_category.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_category.Name = "lbl_error_category";
            this.lbl_error_category.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_category.TabIndex = 19;
            // 
            // lbl_error_author
            // 
            this.lbl_error_author.AutoSize = true;
            this.lbl_error_author.Depth = 0;
            this.lbl_error_author.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_author.Location = new System.Drawing.Point(179, 315);
            this.lbl_error_author.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_author.Name = "lbl_error_author";
            this.lbl_error_author.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_author.TabIndex = 20;
            // 
            // lbl_error_publishingBy
            // 
            this.lbl_error_publishingBy.AutoSize = true;
            this.lbl_error_publishingBy.Depth = 0;
            this.lbl_error_publishingBy.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error_publishingBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error_publishingBy.Location = new System.Drawing.Point(180, 376);
            this.lbl_error_publishingBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error_publishingBy.Name = "lbl_error_publishingBy";
            this.lbl_error_publishingBy.Size = new System.Drawing.Size(0, 18);
            this.lbl_error_publishingBy.TabIndex = 21;
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 496);
            this.Controls.Add(this.lbl_error_publishingBy);
            this.Controls.Add(this.lbl_error_author);
            this.Controls.Add(this.lbl_error_category);
            this.Controls.Add(this.lbl_error_price);
            this.Controls.Add(this.lbl_error_bookName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.txt_publishingBy);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.lbl_publishingBy);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_bookName);
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM MỚI SÁCH";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_bookName;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_publishingBy;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_bookName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_price;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_author;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_publishingBy;
        private System.Windows.Forms.ComboBox cbx_category;
        private MaterialSkin.Controls.MaterialRaisedButton btn_save;
        private MaterialSkin.Controls.MaterialRaisedButton btn_clear;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel lbl_error_bookName;
        private MaterialSkin.Controls.MaterialLabel lbl_error_price;
        private MaterialSkin.Controls.MaterialLabel lbl_error_category;
        private MaterialSkin.Controls.MaterialLabel lbl_error_author;
        private MaterialSkin.Controls.MaterialLabel lbl_error_publishingBy;
    }
}