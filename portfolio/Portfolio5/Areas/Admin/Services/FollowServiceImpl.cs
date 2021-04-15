using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class FollowServiceImpl : FollowService
    {
        private DatabaseContext db;

        public FollowServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public List<Follow> FindAll()
        {
            return db.Follows.ToList();
        }
        public Follow Create(Follow follow)
        {
            db.Follows.Add(follow);
            db.SaveChanges();
            return follow;
        }

        public void Delete(string id)
        {
            db.Follows.Remove(db.Follows.Find(id));
            db.SaveChanges();
        }

        public Follow Find(string idFollow)
        {
            return db.Follows.SingleOrDefault(p => p.IdFollow == idFollow);
        }
        public Follow Update(Follow follow)
        {
            db.Entry(follow).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return follow;
        }
    }
}
