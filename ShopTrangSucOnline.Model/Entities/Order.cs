using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopTrangSucOnline.Model.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        [Display(Name = "Tên khách hàng")]
        public string? CustomerName { get; set; }
        [Display(Name = "Địa chỉ")]
        public string? CustomerAddress { get; set; }
        [Display(Name = "Email")]
        public string? CustomerEmail { get; set; }
        [Display(Name = "Số điện thoại")]
        public string? CustomerMobile { get; set; }
        [Display(Name = "Lời nhắn của khách hàng")]
        public string? CustomerMessage { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Tạo bởi")]
        public string? CreatedBy { get; set; }
        [Display(Name = "Phương thức thanh toán")]
        public string? PaymentMethod { get; set; }
        [Display(Name = "Tình trạng thanh toán")]
        public string? PaymentStatus { get; set; }
        [Display(Name = "Trạng thái đơn hàng")]
        public bool? Status { get; set; }
    }
}
