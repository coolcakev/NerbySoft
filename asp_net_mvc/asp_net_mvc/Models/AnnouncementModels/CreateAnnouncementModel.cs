using asp_net_mvc.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_mvc.Models.AnnouncementModels
{
    public class CreateAnnouncementModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class ResponceCreateAnnouncementModel
    {
        public Announcement Announcement { get; set; }
    }

}
