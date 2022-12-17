using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopTrangSucOnline.Model.Entities
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        [Display(Name = "Mã danh mục")]

        public int Id { get; set; }
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; } = null!;
        [Display(Name = "Mô tả")]
        public string? Description { get; set; }
        [Display(Name = "Ảnh")]
        public string? Image { get; set; }
        public string? KeyWord { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Tạo bởi")]
        public string? CreatedBy { get; set; }
        [Display(Name = "Ngày cập nhật")]
        public DateTime? UpdateDate { get; set; }
        [Display(Name = "Cập nhật bởi")]
        public string? UpdateBy { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
