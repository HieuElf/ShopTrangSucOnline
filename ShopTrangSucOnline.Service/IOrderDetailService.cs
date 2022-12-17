using ShopTrangSucOnline.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTrangSucOnline.Service
{
    public interface IOrderDetailService
    {
        IEnumerable<OrderDetail> GetAllOrderDetail();
        OrderDetail GetOrderDetail(int id);
        void InsertOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int id);
    }
}
