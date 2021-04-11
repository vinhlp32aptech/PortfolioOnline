using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface RoleService
    {
        List<Role> FindAll();
        Role FindById(string idRole);
         int CountId();
        int CountIdById(string id);
        Role Create(Role role);
        void Delete(string idRole);

    }
}
