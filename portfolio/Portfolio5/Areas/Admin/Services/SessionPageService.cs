using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface SessionPageService
    {
        List<SessionPage> FindAllSessionPage();
        SessionPage CreateSessionPage(SessionPage sessionPage);
        void DeleteSessionPage(string idSessionPage);
        SessionPage FindByIdSessionPage(string idSessionPage);
        SessionPage UpdateSessionPage(SessionPage sessionPage);
    }
}
