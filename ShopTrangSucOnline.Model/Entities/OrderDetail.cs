using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopTrangSucOnline.Model.Entities
{
    public partial class OrderDetail
    {
        [Display(Name = "Mã đơn hàng")]
        public int? OrderId { get; set; }
        [Display(Name = "Mã sản phẩm")]
        public int? ProductId { get; set; }
        [Display(Name = "Số lượng")]
        public int? Quantity { get; set; }

        public virtual Order? Order { get; set; }
        public virtual ProductCategory? Product { get; set; }
    }
}
