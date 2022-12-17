using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopTrangSucOnline.Model.Entities
{
    public partial class Account
    {
        public int Id { get; set; }
        [Display(Name = "Tên tài khoản")]
        public string Username { get; set; } = null!;
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; } = null!;
        [Display(Name = "Quyền hạn")]
        public string? Permission { get; set; }
    }
}
