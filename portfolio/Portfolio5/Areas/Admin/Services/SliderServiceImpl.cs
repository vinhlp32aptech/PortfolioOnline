using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class SliderServiceImpl : SliderService
    {
        public DatabaseContext db;
        public SliderServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public List<Slider> FindAllSlider()
        {
        
            return db.Sliders.ToList();
        
        }
    }
}
