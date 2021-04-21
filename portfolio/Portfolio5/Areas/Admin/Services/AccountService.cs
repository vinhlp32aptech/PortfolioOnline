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
        public List<Role> GetAllRole();
        public string GetNewestId(string keyword);
        public int CountIdById(string id);
        public Account CreateAccount(Account account);
        public User CreateUser(User user);
        public void CreateUserRole(UserRole userRole);
        public string GetIdRoleByNameRol(string nameRole);
        public void Delete(string idacc);
    }
}
