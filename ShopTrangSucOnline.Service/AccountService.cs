using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTrangSucOnline.Service
{
    public class AccountService : IAccountService
    {
        private readonly IGenericRepository<Account> _repository;
        public AccountService(IGenericRepository<Account> repository)
        {
            _repository = repository;
        }
        public void DeleteAccount(int id)
        {
            _repository.Delete(id);
        }

        public Account GetAccount(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Account> GetAllAccount()
        {
            return _repository.GetAll();
        }

        public void InsertAccount(Account account)
        {
            _repository.Insert(account);
        }

        public void UpdateAccount(Account account)
        {
            _repository.Update(account);
        }
    }
}
