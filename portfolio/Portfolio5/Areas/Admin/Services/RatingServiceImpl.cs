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
    }
}
