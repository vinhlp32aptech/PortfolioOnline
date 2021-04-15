using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class ContentPageServiceImpl : ContentPageService
    {
        public DatabaseContext db;
        public ContentPageServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public ContentPage CreateContentPage(ContentPage contentPage)
        {
            db.ContentPages.Add(contentPage);
            db.SaveChanges();
            return contentPage;
        }

        public void DeleteContentPage(string idContentPage)
        {
            db.ContentPages.Remove(db.ContentPages.Find(idContentPage));
            db.SaveChanges();
        }

        public List<ContentPage> FindAllContentPage()
        {
            return db.ContentPages.ToList();
        }

        public ContentPage FindByIdContentPage(string idContentPage)
        {
            return db.ContentPages.SingleOrDefault(p => p.IdContentPage == idContentPage);
        }

        public ContentPage UpdateContentPage(ContentPage contentPage)
        {
            db.Entry(contentPage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return contentPage;
        }
    }
}
