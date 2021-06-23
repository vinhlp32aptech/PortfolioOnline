using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio5.Models;

namespace Portfolio5.Services
{
    public interface ProfieService
    {
        List<Account> FindAccount();
        List<User> FindUser();
        User Update(User user);

        Account Update(Account account);

        User FindUser(string id); 

        Account FindAcc(string id);
        public AllUserAcc GetAllUserInfo(string id);

        
    }
}
