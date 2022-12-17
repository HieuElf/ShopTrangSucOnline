using ShopTrangSucOnline.Model.Entities;

namespace ShopTrangSucOnline.Models
{
    public class CartItem
    {
        public Product ProductOrder { get; set; }//thông tin sản phẩm
        public int Quantity { get; set; }//số lượng sản phẩm
    }
}
