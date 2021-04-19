using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface RoleService
    {
        public List<Role> FindAll();
        public Role FindById(string idRole);
        public int CountId();
        public int CountIdById(string id);
        public Role Create(Role role);
        public void Delete(string idRole);
        public string GetNewestId(string keyword);
        public Role Update(Role role);
    }
}
