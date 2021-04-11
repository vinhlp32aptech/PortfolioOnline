using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface SocialUserService
    {
        public List<SocialUser> FindAll();
        SocialUser Create(SocialUser socialUser);
        void Delete(string id);
    }
}
