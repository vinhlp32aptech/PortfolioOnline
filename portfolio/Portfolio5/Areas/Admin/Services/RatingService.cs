using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface RatingService
    {
        public List<Rating> FindAll();
        Rating Create(Rating rating);
        void Delete(string id);
        Rating Find(string id);
        Rating Update(Rating rating);
    }
}
