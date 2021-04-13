using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Services
{
    public interface AccountService
    {
        public List<Account> FindAll();
        List<Role> GetAllRole();
        string GetNewestId(string keyword);
        int CountIdById(string id);
        Account CreateAccount(Account account);
        User CreateUser(User user);
        void CreateUserRole(UserRole userRole);
        string GetIdRoleByNameRol(string nameRole);
        void Delete(string idacc);
    }
}
