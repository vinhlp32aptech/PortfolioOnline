using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface FollowService
    {
        public List<Follow> FindAll();
        Follow Create(Follow follow);
        void Delete(string id);
    }
}
