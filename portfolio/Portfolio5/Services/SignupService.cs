using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Services
{
    public interface SignupService
    {
        public Account CreateAccount(Account account);
        public User CreateUser(User user);
        public void CreateUserRole(UserRole userrole);
        public Account GetAccount(string email);
        string GetIdRoleByNameRol(string nameRole);
        string GetNewestId(string keyword);
        int CountIdById(string id);

    }
}
