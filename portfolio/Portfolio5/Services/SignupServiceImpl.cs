using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Services
{
    public class SignupServiceImpl : SignupService
    {
        private DatabaseContext db;

        public SignupServiceImpl(DatabaseContext db)
        {
            this.db = db;
        }

        public Account GetAccount(string email)
        {
            return db.Accounts.SingleOrDefault(p => p.Email == email);
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

        public void CreateUserRole(UserRole userrole)
        {
            db.UserRoles.Add(userrole);
            db.SaveChanges();
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
