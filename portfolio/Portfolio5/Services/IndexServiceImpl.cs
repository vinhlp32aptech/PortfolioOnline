using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Services
{
    public class IndexServiceImpl : IndexService
    {
        private DatabaseContext db;

        public IndexServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public List<SliderPart> GetSliderHome()
        {
            return db.SliderParts.Where(p => p.IdSlider == "home").ToList();
        }
    }
}
