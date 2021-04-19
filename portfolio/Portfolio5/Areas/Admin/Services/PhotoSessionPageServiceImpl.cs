using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class PhotoSessionPageServiceImpl : PhotoSessionPageService
    {
        public DatabaseContext db;
        public PhotoSessionPageServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public PhotoSessionPage CreatePhotoSessionPage(PhotoSessionPage photoSessionPage)
        {
            db.PhotoSessionPages.Add(photoSessionPage);
            db.SaveChanges();
            return photoSessionPage;
        }

        public void DeletePhotoSessionPage(string idphotoSessionPage)
        {
            db.PhotoSessionPages.Remove(db.PhotoSessionPages.Find(idphotoSessionPage));
            db.SaveChanges();
        }

        public List<PhotoSessionPage> FindAllPhotoSessionPage()
        {
            return db.PhotoSessionPages.ToList();
        }

        public PhotoSessionPage FindByIdPhotoSessionPage(string idphotoSessionPage)
        {
            return db.PhotoSessionPages.SingleOrDefault(p => p.IdPhotoSess == idphotoSessionPage);
        }

        public PhotoSessionPage UpdatePhotoSessionPage(PhotoSessionPage photoSessionPage)
        {
            db.Entry(photoSessionPage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return photoSessionPage;
        }
    }
}
