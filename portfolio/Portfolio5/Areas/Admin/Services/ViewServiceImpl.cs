using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public class ViewServiceImpl : ViewService
    {
        private DatabaseContext db;

        public ViewServiceImpl(DatabaseContext _db)
        {
            this.db = _db;
        }

        public List<View> FindAll()
        {
            return db.Views.ToList();
        }

        public View Create(View view)
        {
            db.Views.Add(view);
            db.SaveChanges();
            return view;
        }
        public void Delete(string id)
        {
            db.Views.Remove(db.Views.Find(id));
            db.SaveChanges();
        }
    }
}
