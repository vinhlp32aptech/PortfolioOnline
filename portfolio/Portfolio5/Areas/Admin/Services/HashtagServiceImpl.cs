using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class HashtagServiceImpl : HashtagService
    {
        private DatabaseContext db;

        public HashtagServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public int CountId()
        {
            return db.Hashtags.Count();
        }

        public int CountIdById(string id)
        {
            return db.Hashtags.Where(p => p.IdHashtag == id).Count();
        }

        public Hashtag Create(Hashtag hashtag)
        {
            db.Hashtags.Add(hashtag);
            db.SaveChanges();
            return hashtag;
        }

        public void Delete(string idHashtag)
        {
            db.Hashtags.Remove(db.Hashtags.Find(idHashtag));
            db.SaveChanges();
        }

        public List<Hashtag> FindAll()
        {
            return db.Hashtags.ToList();
        }

        public Hashtag FindById(string idHashtag)
        {
            return db.Hashtags.SingleOrDefault(p => p.IdHashtag == idHashtag);
        }

        public string GetNewestId(string keyword)
        {
            return (from hashtag in db.Hashtags
                    where
                      hashtag.IdHashtag.Contains(keyword)
                    orderby
                      hashtag.IdHashtag descending
                    select hashtag.IdHashtag).Take(1).SingleOrDefault();
        }

        public Hashtag Update(Hashtag hashtag)
        {
            db.Entry(hashtag).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return hashtag;
        }
    }
}
