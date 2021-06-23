using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Services
{
    public class SigninServiceImpl : SigninService
    {
        private DatabaseContext db;

        public SigninServiceImpl(DatabaseContext db)
        {
            this.db = db;
        }

            public Account GetAccount(string email)
            {
                return db.Accounts.SingleOrDefault(p => p.Email == email);
            }

            public string GetRole(string idRole)
            {
                return (from roles in db.Roles
                       where
                         roles.IdRole == idRole
                       select 
                           roles.NameRole
                       ).Take(1).SingleOrDefault();
            }
    }
}
