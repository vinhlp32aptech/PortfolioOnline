using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class UrlSessionPageServiceImpl : UrlSessionPageService
    {
        public DatabaseContext db;
        public UrlSessionPageServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public UrlSessionPage CreateUrlSessionPage(UrlSessionPage urlSessionPage)
        {
            db.UrlSessionPages.Add(urlSessionPage);
            db.SaveChanges();
            return urlSessionPage;
        }

        public void DeleteUrlSessionPage(string idurlSessionPage)
        {
            db.UrlSessionPages.Remove(db.UrlSessionPages.Find(idurlSessionPage));
            db.SaveChanges();
        }

        public List<UrlSessionPage> FindAllUrlSessionPage()
        {
             return db.UrlSessionPages.ToList();
        }

        public UrlSessionPage FindByIdUrlSessionPage(string idurlSessionPage)
        {
            return db.UrlSessionPages.SingleOrDefault(p => p.IdUrlSess == idurlSessionPage);
        }

        public UrlSessionPage UpdateUrlSessionPage(UrlSessionPage urlSessionPage)
        {
            db.Entry(urlSessionPage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return urlSessionPage;
        }
    }
}
