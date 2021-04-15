using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface ViewService
    {
        public List<View> FindAll();
        View Create(View view);
        void Delete(string id);
        View Find(string id);
        View Update(View view);
    }
}
