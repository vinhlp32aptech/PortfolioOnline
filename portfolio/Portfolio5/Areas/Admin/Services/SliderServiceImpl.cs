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
        public Slider CreateSlider(Slider slider)
        {
            db.Sliders.Add(slider);
            db.SaveChanges();
            return slider;
        
        }

        public void DeleteSlider(string idSlider)
        {
            db.Sliders.Remove(db.Sliders.Find(idSlider));
            db.SaveChanges();
        }

            public Slider FindByIdSlider(string idSlider)
        {
            return db.Sliders.SingleOrDefault(p => p.IdSlider == idSlider);
        }

        public Slider UpdateSlider(Slider slider)
        {
            db.Entry(slider).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return slider;
        }

    }
}
