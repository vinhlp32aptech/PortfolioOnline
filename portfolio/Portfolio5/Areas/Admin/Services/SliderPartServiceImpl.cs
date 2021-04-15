using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class SliderPartServiceImpl : SliderPartService
    {
        public DatabaseContext db;
        public SliderPartServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }


        public List<SliderPart> FindAllSliderPart()
        {

            return db.SliderParts.ToList();

        }
        public SliderPart CreateSliderPart(SliderPart sliderPart)
        {
            db.SliderParts.Add(sliderPart);
            db.SaveChanges();
            return sliderPart;
        }

        public void DeleteSliderPart(string idSliderPart)
        {
            db.SliderParts.Remove(db.SliderParts.Find(idSliderPart));
            db.SaveChanges();
        }

        public SliderPart FindByIdSliderPart(string idSliderPart)
        {
            return db.SliderParts.SingleOrDefault(p => p.IdSliderPart == idSliderPart);
        }

        public SliderPart UpdateSliderPart(SliderPart sliderPart)
        {
            db.Entry(sliderPart).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return sliderPart;
        }
    }
}
