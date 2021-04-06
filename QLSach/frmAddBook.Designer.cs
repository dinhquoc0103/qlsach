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
            this.lbl_bookCode = new System.Windows.Forms.Label();
            this.lbl_bookName = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_publishingBy = new System.Windows.Forms.Label();
            this.txt_bookCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_bookName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_price = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_author = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_publishingBy = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.btn_save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_clear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_bookCode
            // 
            this.lbl_bookCode.AutoSize = true;
            this.lbl_bookCode.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bookCode.Location = new System.Drawing.Point(34, 90);
            this.lbl_bookCode.Name = "lbl_bookCode";
            this.lbl_bookCode.Size = new System.Drawing.Size(83, 25);
            this.lbl_bookCode.TabIndex = 0;
            this.lbl_bookCode.Text = "Mã Sách";
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bookName.Location = new System.Drawing.Point(34, 146);
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(89, 25);
            this.lbl_bookName.TabIndex = 1;
            this.lbl_bookName.Text = "Tên Sách";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(34, 202);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(39, 25);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Giá";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(34, 255);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(83, 25);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "Thể Loại";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(34, 310);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(75, 25);
            this.lbl_author.TabIndex = 4;
            this.lbl_author.Text = "Tác Giả";
            // 
            // lbl_publishingBy
            // 
            this.lbl_publishingBy.AutoSize = true;
            this.lbl_publishingBy.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publishingBy.Location = new System.Drawing.Point(34, 369);
            this.lbl_publishingBy.Name = "lbl_publishingBy";
            this.lbl_publishingBy.Size = new System.Drawing.Size(125, 25);
            this.lbl_publishingBy.TabIndex = 5;
            this.lbl_publishingBy.Text = "Nhà Xuất Bản";
            // 
            // txt_bookCode
            // 
            this.txt_bookCode.Depth = 0;
            this.txt_bookCode.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookCode.Hint = "Nhập mã sách";
            this.txt_bookCode.Location = new System.Drawing.Point(178, 92);
            this.txt_bookCode.MaxLength = 32767;
            this.txt_bookCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_bookCode.Name = "txt_bookCode";
            this.txt_bookCode.PasswordChar = '\0';
            this.txt_bookCode.SelectedText = "";
            this.txt_bookCode.SelectionLength = 0;
            this.txt_bookCode.SelectionStart = 0;
            this.txt_bookCode.Size = new System.Drawing.Size(268, 23);
            this.txt_bookCode.TabIndex = 6;
            this.txt_bookCode.TabStop = false;
            this.txt_bookCode.UseSystemPasswordChar = false;
            // 
            // txt_bookName
            // 
            this.txt_bookName.Depth = 0;
            this.txt_bookName.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookName.Hint = "Nhập tên sách";
            this.txt_bookName.Location = new System.Drawing.Point(178, 147);
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
            this.txt_price.Location = new System.Drawing.Point(178, 202);
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
            this.txt_author.Location = new System.Drawing.Point(178, 312);
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
            this.txt_publishingBy.Location = new System.Drawing.Point(178, 371);
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
            "~ Chọn Thể Loại ~",
            "Bóng Đá",
            "Văn Học",
            "Kinh Tế",
            "Kinh Dị",
            "Hoạt Hình"});
            this.cbx_category.Location = new System.Drawing.Point(178, 254);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(268, 27);
            this.cbx_category.TabIndex = 12;
            this.cbx_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Depth = 0;
            this.btn_save.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(81, 433);
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
            this.btn_clear.Location = new System.Drawing.Point(195, 433);
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
            this.btn_cancel.Location = new System.Drawing.Point(346, 433);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = true;
            this.btn_cancel.Size = new System.Drawing.Size(48, 36);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "HỦY";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 511);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.txt_publishingBy);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.txt_bookCode);
            this.Controls.Add(this.lbl_publishingBy);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_bookName);
            this.Controls.Add(this.lbl_bookCode);
            this.Name = "frmAddBook";
            this.Text = "THÊM MỚI SÁCH";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bookCode;
        private System.Windows.Forms.Label lbl_bookName;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_publishingBy;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_bookCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_bookName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_price;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_author;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_publishingBy;
        private System.Windows.Forms.ComboBox cbx_category;
        private MaterialSkin.Controls.MaterialRaisedButton btn_save;
        private MaterialSkin.Controls.MaterialRaisedButton btn_clear;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cancel;
    }
}