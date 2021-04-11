using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class SocialUserServiceImpl : SocialUserService
    {
        private DatabaseContext db;

        public SocialUserServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public List<SocialUser> FindAll()
        {
            return db.SocialUsers.ToList();
        }
        public SocialUser Create(SocialUser socialUser)
        {
            db.SocialUsers.Add(socialUser);
            db.SaveChanges();
            return socialUser;
        }

        public void Delete(string id)
        {
            db.SocialUsers.Remove(db.SocialUsers.Find(id));
            db.SaveChanges();
        }
    }
}
