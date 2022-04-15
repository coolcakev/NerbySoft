using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_mvc.Models.AnnouncementModels
{
    public class GetAnnouncementAnnouncementItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public int Order { get; set; }
    }
}
