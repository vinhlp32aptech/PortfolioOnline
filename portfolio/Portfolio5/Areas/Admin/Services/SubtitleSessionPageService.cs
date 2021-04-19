using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface SubtitleSessionPageService
    {
        List<SubtitleSessionPage> FindAllSubtitleSessionPage();
        SubtitleSessionPage CreateSubtitleSessionPage(SubtitleSessionPage subtitleSessionPage);
        void DeleteSubtitleSessionPage(string idsubtitleSessionPage);
        SubtitleSessionPage FindByIdSubtitleSessionPage(string idsubtitleSessionPage);
        SubtitleSessionPage UpdateSubtitleSessionPage(SubtitleSessionPage subtitleSessionPage);
    }
}
