using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Services
{
    public class ProfieServiceImpl : ProfieService
    {
        private DatabaseContext db;

        public ProfieServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public Account FindAcc(string idAcc)
        {
            return db.Accounts.SingleOrDefault(p => p.IdAcc == idAcc);
        }

        public List<Account> FindAccount()
        {
            return db.Accounts.ToList();
        }

        public User FindUser(string idUser)
        {
            return db.Users.SingleOrDefault(p => p.IdUser == idUser);
        }

        public List<User> FindUser()
        {
            return db.Users.ToList();
        }

        public  AllUserAcc GetAllUserInfo(string id)
        {
            var acc =  db.Accounts.SingleOrDefault(p => p.IdAcc == id);
            var user = db.Users.SingleOrDefault(p => p.IdAcc == id);
            var rating = db.Ratings.SingleOrDefault(p => p.IdAcc == id);
            var soc = db.SocialUsers.SingleOrDefault(p => p.IdAcc == id);
            var follow = db.Follows.SingleOrDefault(p => p.IdAcc == id);
            return new AllUserAcc { Account = acc, User = user, Rating = rating, SocialUser = soc , Follow = follow};

        }

        public User Update(User user)
        {
            db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return user;
        }

        public Account Update(Account account)
        {
            db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return account;
        }
    }
}
