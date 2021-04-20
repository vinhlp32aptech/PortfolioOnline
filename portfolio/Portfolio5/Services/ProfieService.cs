using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio5.Models;

namespace Portfolio5.Services
{
    public interface ProfieService
    {


        User Update(User user);

        Account Update(Account account);

        User FindUser(string id); 

        Account FindAcc(string id);

    }
}
