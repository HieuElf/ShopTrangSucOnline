using ShopTrangSucOnline.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTrangSucOnline.Service
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccount();
        Account GetAccount(int id);
        void InsertAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(int id);
    }
}
