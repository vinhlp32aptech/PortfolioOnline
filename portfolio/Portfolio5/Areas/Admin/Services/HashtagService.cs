using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface HashtagService
    {
        public List<Hashtag> FindAll();
        public Hashtag Create(Hashtag hashtag);
        public Hashtag FindById(string idHashtag);
        public int CountId();
        public int CountIdById(string id);
        public void Delete(string idHashtag);
        public string GetNewestId(string keyword);
        public Hashtag Update(Hashtag hashtag);
    }
}
