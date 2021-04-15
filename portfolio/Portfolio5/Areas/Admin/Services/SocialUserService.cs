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
        //SocialUser FindById(string IdSocialUser);
        //int CountId();
        //int CountIdById(string id);
        SocialUser Create(SocialUser socialUser);
        void Delete(string id);
        SocialUser Find(string id);
        SocialUser Update(SocialUser socialUser);
    }
}
