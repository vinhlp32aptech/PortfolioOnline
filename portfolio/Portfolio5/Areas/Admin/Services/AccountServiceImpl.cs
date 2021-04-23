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

        public int CountIdById(string id)
        {
            return db.Accounts.Where(p => p.IdAcc.Contains(id)).Count();
        }

        public Account CreateAccount(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public User CreateUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

    

        public void Delete(string idacc)
        {
            db.Accounts.Remove(db.Accounts.Find(idacc));
            db.SaveChanges();
        }

        public List<Account> FindAll()
        {
            return db.Accounts.Where(p => p.Stat == true).ToList();
        }

        public List<Role> GetAllRole()
        {
            return db.Roles.ToList();
        }

        public string GetIdRoleByNameRol(string nameRole)
        {
            return db.Roles.Where(p => p.NameRole == nameRole).Select(x => x.IdRole).FirstOrDefault();
        }

        public string GetNewestId(string keyword)
        {
              return (from accounts in db.Accounts
                        where
                          accounts.IdAcc.Contains(keyword)
                        orderby
                          accounts.IdAcc descending
                        select accounts.IdAcc).Take(1).SingleOrDefault();
        }
    }
}
