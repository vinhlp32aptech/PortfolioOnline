using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Services
{
    public interface SigninService
    {
        public Account GetAccount(string email);
        public string GetRole(string idRole);
    }
}
