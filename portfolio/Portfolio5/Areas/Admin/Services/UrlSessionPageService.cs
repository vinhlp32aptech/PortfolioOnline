using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface UrlSessionPageService
    {
        List<UrlSessionPage> FindAllUrlSessionPage();
        UrlSessionPage CreateUrlSessionPage(UrlSessionPage urlSessionPage);
        void DeleteUrlSessionPage(string idurlSessionPage);
        UrlSessionPage FindByIdUrlSessionPage(string idurlSessionPage);
        UrlSessionPage UpdateUrlSessionPage(UrlSessionPage urlSessionPage);
    }
}
