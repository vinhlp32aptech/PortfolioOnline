using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class SessionPageServiceImpl : SessionPageService
    {
        public DatabaseContext db;
        public SessionPageServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public SessionPage CreateSessionPage(SessionPage sessionPage)
        {
            db.SessionPages.Add(sessionPage);
            db.SaveChanges();
            return sessionPage;
        }

        public void DeleteSessionPage(string idSessionPage)
        {
            db.SessionPages.Remove(db.SessionPages.Find(idSessionPage));
            db.SaveChanges();
        }

        public List<SessionPage> FindAllSessionPage()
        {
            return db.SessionPages.ToList();
        }

        public SessionPage FindByIdSessionPage(string idSessionPage)
        {
            return db.SessionPages.SingleOrDefault(p => p.IdSess == idSessionPage);
        }

        public SessionPage UpdateSessionPage(SessionPage sessionPage)
        {
            db.Entry(sessionPage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return sessionPage;
        }
    }
}
