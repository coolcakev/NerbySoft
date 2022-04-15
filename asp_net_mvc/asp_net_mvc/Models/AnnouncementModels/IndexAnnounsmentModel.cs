using asp_net_mvc.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_mvc.Models.AnnouncementModels
{
    public class IndexAnnounsmentModel
    {
        public IEnumerable<Announcement> Announcements { get; set; }
    }
}
