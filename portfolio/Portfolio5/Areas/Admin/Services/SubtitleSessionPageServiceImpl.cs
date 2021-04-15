using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class SubtitleSessionPageServiceImpl : SubtitleSessionPageService
    {
        public DatabaseContext db;
        public SubtitleSessionPageServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public SubtitleSessionPage CreateSubtitleSessionPage(SubtitleSessionPage subtitleSessionPage)
        {
            db.SubtitleSessionPages.Add(subtitleSessionPage);
            db.SaveChanges();
            return subtitleSessionPage;
        }

        public void DeleteSubtitleSessionPage(string idsubtitleSessionPage)
        {
            db.SubtitleSessionPages.Remove(db.SubtitleSessionPages.Find(idsubtitleSessionPage));
            db.SaveChanges();
        }

        public List<SubtitleSessionPage> FindAllSubtitleSessionPage()
        {
            return db.SubtitleSessionPages.ToList();
        }

        public SubtitleSessionPage FindByIdSubtitleSessionPage(string idsubtitleSessionPage)
        {
            return db.SubtitleSessionPages.SingleOrDefault(p => p.IdSubtitleSess == idsubtitleSessionPage);
        }

        public SubtitleSessionPage UpdateSubtitleSessionPage(SubtitleSessionPage subtitleSessionPage)
        {
            db.Entry(subtitleSessionPage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return subtitleSessionPage;
        }
    }
}
