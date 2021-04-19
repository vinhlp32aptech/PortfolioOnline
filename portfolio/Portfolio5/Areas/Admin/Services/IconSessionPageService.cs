using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface IconSessionPageService
    {
        List<IconSessionPage> FindAllIconSessionPage();
        IconSessionPage CreateIconSessionPage(IconSessionPage iconSessionPage);
        void DeleteIconSessionPage(string idiconSessionPage);
        IconSessionPage FindByIdIconSessionPage(string idiconSessionPage);
        IconSessionPage UpdateIconSessionPage(IconSessionPage iconSessionPage);
    }
}
