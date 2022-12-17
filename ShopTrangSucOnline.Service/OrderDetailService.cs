using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTrangSucOnline.Service
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IGenericRepository<OrderDetail> _repository;
        public OrderDetailService(IGenericRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public void DeleteOrderDetail(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetail()
        {
            return _repository.GetAll();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return _repository.GetById(id);
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            _repository.Insert(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            _repository.Update(orderDetail);
        }
    }
}
