using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface PhotoSessionPageService
    {
        List<PhotoSessionPage> FindAllPhotoSessionPage();
        PhotoSessionPage CreatePhotoSessionPage(PhotoSessionPage photoSessionPage);
        void DeletePhotoSessionPage(string idphotoSessionPage);
        PhotoSessionPage FindByIdPhotoSessionPage(string idphotoSessionPage);
        PhotoSessionPage UpdatePhotoSessionPage(PhotoSessionPage photoSessionPage);
    }
}
