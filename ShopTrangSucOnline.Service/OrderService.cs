using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTrangSucOnline.Service
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Order> _repository;
        public OrderService(IGenericRepository<Order> repository)
        {
            _repository = repository;
        }
        public void DeleteOrder(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Order> GetAllOrder()
        {
            return _repository.GetAll();
        }

        public Order GetOrder(int id)
        {
            return _repository.GetById(id);
        }

        public void InsertOrder(Order order)
        {
            _repository.Insert(order);
        }

        public void UpdateOrder(Order order)
        {
            _repository.Update(order);
        }
    }
}
