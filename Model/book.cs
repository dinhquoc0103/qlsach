using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class book
    {
   
        public string BookCode { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống"), StringLength(64, MinimumLength = 2, ErrorMessage = "Tên sách phải dài 2 đến 64 ký tự")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Price không được để trống"), Range(5000, 100000000, ErrorMessage = "Giá không thỏa mãn")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Chưa chọn thể loại sách")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Tác giả không được để trống"), StringLength(64, MinimumLength = 2, ErrorMessage = "Tên tác giả phải dài 2 đến 64 ký tự")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Nhà xuất bản không được để trống"), StringLength(64, MinimumLength = 2, ErrorMessage = "Nhà xuất bản phải dài 2 đến 64 ký tự")]
        public string PublishingBy { get; set; }
    }
}
