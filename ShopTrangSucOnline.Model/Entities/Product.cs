using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopTrangSucOnline.Model.Entities
{
    public partial class Product
    {
        [Display(Name = "Mã sản phẩm")]
        public int Id { get; set; }
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; } = null!;
        [Display(Name = "Mã danh mục sản phẩm")]
        public int? CategoryId { get; set; }
        [Display(Name = "Ảnh")]
        public string? Image { get; set; }
        [Display(Name = "Ảnh...")]
        public string? MoreImage { get; set; }
        [Display(Name = "Giá")]
        public decimal? Price { get; set; }
        [Display(Name = "Giá khuyễn mại")]
        public decimal? Promotion { get; set; }
        [Display(Name = "Bảo hành")]
        public int? Warranty { get; set; }
        [Display(Name = "Mô tả")]
        public string? Description { get; set; }      
        public string? KeyWord { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Tạo bởi")]
        public string? CreatedBy { get; set; }
        [Display(Name = "Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }
        [Display(Name = "Cập nhật bởi")]
        public string? UpdatedBy { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }

        public virtual ProductCategory? Category { get; set; }
    }
}
