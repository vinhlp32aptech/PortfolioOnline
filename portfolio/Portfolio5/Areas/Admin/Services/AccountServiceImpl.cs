using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Services
{
    public class AccountServiceImpl : AccountService
    {
        private DatabaseContext db;

        public AccountServiceImpl(DatabaseContext _db)
        {
            this.db = _db;
        }

        public List<Account> FindAll()
        {
            return db.Accounts.ToList();
        }
    }
}
