using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class RatingServiceImpl : RatingService
    {
        private DatabaseContext db;

        public RatingServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public List<Rating> FindAll()
        {
            return db.Ratings.ToList();
        }
        public Rating Create(Rating rating)
        {
            db.Ratings.Add(rating);
            db.SaveChanges();
            return rating;
        }

        public void Delete(string id)
        {
            db.Ratings.Remove(db.Ratings.Find(id));
            db.SaveChanges();
        }

        public Rating Find(string idRating)
        {
            return db.Ratings.SingleOrDefault(p => p.IdRating == idRating);
        }

        public Rating Update(Rating rating)
        {
            db.Entry(rating).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return rating;
        }
    }
}
