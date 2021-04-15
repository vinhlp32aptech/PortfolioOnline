using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class IconSessionPageServiceImpl : IconSessionPageService
    {
        public DatabaseContext db;
        public IconSessionPageServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public IconSessionPage CreateIconSessionPage(IconSessionPage iconSessionPage)
        {
            db.IconSessionPages.Add(iconSessionPage);
            db.SaveChanges();
            return iconSessionPage;
        }

        public void DeleteIconSessionPage(string idIconSessionPage)
        {
            db.IconSessionPages.Remove(db.IconSessionPages.Find(idIconSessionPage));
            db.SaveChanges();
        }

        public List<IconSessionPage> FindAllIconSessionPage()
        {
            return db.IconSessionPages.ToList();
        }

        public IconSessionPage FindByIdIconSessionPage(string idIconSessionPage)
        {
            return db.IconSessionPages.SingleOrDefault(p => p.IdIconSess == idIconSessionPage);
        }

        public IconSessionPage UpdateIconSessionPage(IconSessionPage iconSessionPage)
        {
            db.Entry(iconSessionPage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return iconSessionPage;
        }
    }
}
