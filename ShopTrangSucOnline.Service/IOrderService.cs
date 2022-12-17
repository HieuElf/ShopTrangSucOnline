using ShopTrangSucOnline.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTrangSucOnline.Service
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrder();
        Order GetOrder(int id);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
