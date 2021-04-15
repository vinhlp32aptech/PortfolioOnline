using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface ContentPageService
    {
        List<ContentPage> FindAllContentPage();
        ContentPage CreateContentPage(ContentPage contentPage);
        void DeleteContentPage(string contentPage);
        ContentPage FindByIdContentPage(string contentPage);
        ContentPage UpdateContentPage(ContentPage contentPage);
    }
}
