using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Model
{
    public class users
    {
        public string UserCode { get; set; }
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email không được để trống"), EmailAddress(ErrorMessage = "Email sai định dạng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống"), RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*\W).{8,16}$", ErrorMessage = "Mật khẩu không thỏa mãn")]
        public string Password { get; set; }

        public int Status { get; set; }
        public DateTime JoinDate { get; set; }

    }
}
